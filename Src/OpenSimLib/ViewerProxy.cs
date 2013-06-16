﻿/*************************************************************************
Copyright (c) 2012 John McCaffery 

This file is part of Chimera.

Chimera is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Chimera is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Chimera.  If not, see <http://www.gnu.org/licenses/>.

**************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chimera;
using System.Windows.Forms;
using Chimera.OpenSim.GUI;
using System.Threading;
using OpenMetaverse;
using GridProxy;
using log4net;
using System.Diagnostics;
using System.Collections;
using OpenMetaverse.Packets;
using System.ComponentModel;
using System.Net;
using GridProxyConfig = GridProxy.ProxyConfig;
using Chimera.Util;
using System.IO;
using Nwc.XmlRpc;
using Chimera.Config;
using System.Drawing;
using Chimera.OpenSim.Packets;

namespace Chimera.OpenSim {
    public abstract class ViewerProxy : IOutput, ISystemPlugin {
        private static readonly string proxyAddress = "127.0.0.1";

        private Process mClient;
        private ILog mLogger;
        protected Proxy mProxy;
        private bool mClientLoggedIn;
        private bool mControlCamera;
        private bool mAutoRestart;
        private UUID mSecureSessionID = UUID.Zero;
        private UUID mSessionID = UUID.Zero;
        private UUID mAgentID = UUID.Zero;
        private string mFirstName = "NotLoggedIn";
        private string mLastName = "NotLoggedIn";
        private bool mFullscreen;
        private bool mEnabled;
        private bool mMaster = false;
        private float mDeltaScale = .25f;

        private object processLock = new object();

        private SetFollowCamProperties mFollowCamProperties;
        private Frame mFrame;
        private DeprecatedOutputPanel mOutputPanel;
        private InputPanel mInputPanel;
        private ViewerConfig mConfig;

        /// <summary>
        /// Whther to restart the viewer if the camera stops updating, or just clear the camera then set it again."
        /// </summary>
        private bool mRestartOnTimeout;
        /// <summary>
        /// The position the camera was at the last time an AgentUpdate packet was received.
        /// </summary>
        private Vector3 mLastViewerPosition;
        /// <summary>
        /// The position the camera was being set to the last time a CameraUpdated event was received.
        /// </summary>
        private Vector3 mLastCameraPosition;
        /// <summary>
        /// The last time the viewer was updated.
        /// </summary>
        private DateTime mLastCameraUpdate;
        /// <summary>
        /// The last time the viewer sent out an agent update.
        /// </summary>
        private DateTime mLastViewerUpdate;

        /// <summary>
        /// Selected whenever the client proxy starts up.
        /// </summary>
        public event EventHandler OnProxyStarted;
        /// <summary>
        /// Selected whenever a client logs in to the proxy.
        /// </summary>
        public event EventHandler OnClientLoggedIn;
        /// <summary>
        /// Selected whenever a viewer exits.
        /// </summary>
        public event EventHandler OnViewerExit;

        internal ViewerConfig ProxyConfig {
            get { return mConfig; }
        }

        internal bool Fullscreen {
            get { return mFullscreen; }
            set { 
                mFullscreen = value;
                if (mClientLoggedIn && mClient != null) {
                    ProcessWrangler.SetBorder(mClient, mFrame.Monitor, !value);
                    //ToggleHUD();
                }
            }
        }

        public bool ProxyRunning {
            get { return mProxy != null; }
        }

        public bool ClientLoggedIn {
            get { return mClientLoggedIn; }
        }

        public bool ControlCamera {
            get { return mControlCamera; }
            set {
                if (value != mControlCamera) {
                    mControlCamera = value;
                    if (value)
                        SetCamera();
                    else
                        ClearCamera();
                }
            }
        }

        /// <summary>
        /// The logger to use when writing to the logs.
        /// </summary>
        protected ILog Logger {
            get { return mLogger; }
            set { mLogger = value; }
        }

        public void Glow() {
            Chat("Glow");
        }

        public void NoGlow() {
            Chat("NoGlow");
        }

        public void Chat(string msg) {
            if (mProxy != null) {
                ChatFromViewerPacket p = new ChatFromViewerPacket();
                p.ChatData.Channel = -40;
                p.ChatData.Message = Utils.StringToBytes(msg);
                p.ChatData.Type = (byte)1;
                p.AgentData.AgentID = mAgentID;
                p.AgentData.SessionID = mSessionID;
                mProxy.InjectPacket(p, Direction.Outgoing);
            }
        }

        internal void ToggleHUD() {
            if (mClient != null)
                ProcessWrangler.PressKey(mClient, mConfig.ViewerToggleHUDKey);
        }

        internal bool StartProxy() {
            if (mConfig == null)
                throw new Exception("Unable to start proxy. No configuration specified.");
            if (mConfig.ProxyLoginURI == null)
                throw new Exception("Unable to start proxy. No login URI specified in the configuration.");
            if (mProxy != null)
                CloseProxy();
            string file = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

            string portArg = "--proxy-login-port=" + mConfig.ProxyPort;
            string listenIPArg = "--proxy-proxyAddress-facing-address=" + proxyAddress;
            string loginURIArg = "--proxy-remote-login-uri=" + mConfig.ProxyLoginURI;
            string proxyCaps = "--proxy-caps=false";
            string[] args = { portArg, listenIPArg, loginURIArg, proxyCaps };
            GridProxyConfig config = new GridProxyConfig("Routing God", "jm726@st-andrews.ac.uk", args);
            try {
                mProxy = new Proxy(config);
                mProxy.AddLoginResponseDelegate(mProxy_LoginResponse);
                mProxy.AddDelegate(PacketType.AgentUpdate, Direction.Outgoing, mProxy_AgentUpdatePacketReceived);
                //foreach (PacketType pt in Enum.GetValues(typeof(PacketType))) {
                    //mProxy.AddDelegate(pt, Direction.Incoming, ReceiveIncomingPacket);
                    //mProxy.AddDelegate(pt, Direction.Outgoing, ReceiveOutgoingPacket);
                //}

                mProxy.Start();
                if (mFollowCamProperties != null)
                    mFollowCamProperties.SetProxy(mProxy);
            } catch (NullReferenceException e) {
                Logger.Info("Unable to start proxy. " + e.Message);
                mProxy = null;
                return false;
            }

            if (OnProxyStarted != null)
                OnProxyStarted(mProxy, null);

            return true;
        }

        protected void InjectPacket(Packet p) {
            if (ProxyRunning)
                mProxy.InjectPacket(p, Direction.Incoming);
        }

        private bool mClosing;

        public void CloseViewer() {
            if (mClientLoggedIn) {
                mClosing = true;
                ProcessWrangler.PressKey(mClient, "q", true, false, false);

                Thread shutdownThread = new Thread(() => {
                    int i = 0;
                    while (mClientLoggedIn && i++ < 5) {
                        lock (processLock)
                            Monitor.Wait(processLock, 10000);
                        if (mClientLoggedIn) {
                            //ProcessWrangler.PressKey(mClient, "{ENTER}");
                            ProcessWrangler.PressKey(mClient, "q", true, false, false);
                        }
                    }
                });
                shutdownThread.Name = "Viewer Shutdown Thread.";
                shutdownThread.Start();
            }
        }

        /// <summary>
        /// Return control of the camera to the viewer.
        /// </summary>
        public abstract void ClearCamera();

        /// <summary>
        /// Take control of the camera and set it to the position specified by the input.
        /// </summary>
        public abstract void SetCamera();

        /// <summary>
        /// Take control of the window frustum and set it up as specified by the Window.
        /// </summary>
        public abstract void SetFrame();

        /// <summary>
        /// Called whenever the camera position is updated.
        /// </summary>
        /// <param name="input">The input which triggered the camera change.</param>
        /// <param name="args">The arguments about the change that was made.</param>
        protected abstract void ProcessCameraUpdate(Core coordinator, CameraUpdateEventArgs args);

        /// <summary>
        /// Called whenever a packet is received transition the client.
        /// </summary>
        /// <param name="p">The packet that was received.</param>
        /// <param name="ep">The end point the packet was received transition.</param>
        /// <returns>The packet which is to be forwarded on to the server.</returns>
        protected virtual Packet ReceiveOutgoingPacket(Packet p, IPEndPoint ep) { return p; }

        /// <summary>
        /// Called whenever a packet is received transition the server.
        /// </summary>
        /// <param name="p">The packet that was received.</param>
        /// <param name="ep">The end point the packet was received transition.</param>
        /// <returns>The packet which is to be forwarded on to the client.</returns>
        protected virtual Packet ReceiveIncomingPacket(Packet p, IPEndPoint ep) { return p; }

        private void CloseProxy() {
            if (mProxy != null) {
                mProxy.Stop();
                mProxy = null;
                if (mFollowCamProperties != null)
                    mFollowCamProperties.SetProxy(mProxy);
            }
        }

        #region IOutput Members

        public bool Active {
            get { return mClientLoggedIn; }
        }

        public Process Process {
            get { return mClient; }
        }

        public bool AutoRestart {
            get { return mAutoRestart; }
            set { mAutoRestart = value; }
        }

        public string Type {
            get { return "Virtual World Viewer"; }
        }

        public Frame Frame {
            get { return mFrame; }
        }

        UserControl IOutput.ControlPanel {
            get {
                if (mOutputPanel == null)
                    mOutputPanel = new DeprecatedOutputPanel(this);
                return mOutputPanel;
            }
        }

        public string State {
            get {
                string dump = "-Viewer Proxy-" + Environment.NewLine;
                if (mProxy != null) {
                    dump += "Running:" + Environment.NewLine;
                    dump += " Proxy: localhost:" + mConfig.ProxyPort + Environment.NewLine;
                    dump += " Endpoint: " + mConfig.ProxyLoginURI + Environment.NewLine;
                } else
                    dump += "Not running" + Environment.NewLine;

                if (mClientLoggedIn) {
                    dump += "Logged In:" + Environment.NewLine;
                    dump += " Login: " + mFirstName + " " + mLastName + Environment.NewLine;
                    dump += " Exe: " + mConfig.ViewerExecutable + Environment.NewLine;
                    dump += " Dir: " + mConfig.ViewerWorkingDirectory + Environment.NewLine;
                } else
                    dump += "Not logged in" + Environment.NewLine;

                return dump;
            }
        }

        public void Init(Frame frame) {
            mConfig = new ViewerConfig(frame.Name);
            mLogger = LogManager.GetLogger(mConfig.Section);
            mFrame = frame;
            mFrame.Core.CameraUpdated += Coordinator_CameraUpdated;
            mFrame.Core.EyeUpdated += Coordinator_EyeUpdated;
            mFrame.Core.Tick += new Action(Coordinator_Tick);
            mFrame.Core.CameraModeChanged += new Action<Core,ControlMode>(Coordinator_CameraModeChanged);
            mFrame.Core.DeltaUpdated += new Action<Chimera.Core,DeltaUpdateEventArgs>(Coordinator_DeltaUpdated);
            mFrame.MonitorChanged += new Action<Chimera.Frame,Screen>(mFrame_MonitorChanged);
            mFrame.Changed += new Action<Chimera.Frame,EventArgs>(mFrame_Changed);
            mFullscreen = mConfig.Fullscreen;

            if (mConfig.AutoStartViewer)
                Launch();
            else if (mConfig.AutoStartProxy)
                StartProxy();

            AutoRestart = mConfig.AutoRestartViewer;
            ControlCamera = mConfig.ControlCamera;
        }


        public bool Launch() {
            if (mConfig == null)
                throw new Exception("Unable to start client. No configuration specified.");
            if (mConfig.ViewerExecutable == null)
                throw new Exception("Unable to start client. No executable specified.");
            if (!ProxyRunning) 
                StartProxy();

            mClient = new Process();
            string args = mConfig.ViewerArguments + " ";
            if (mConfig.UseGrid)
                args += "--grid " + mConfig.LoginGrid;
            else
                args += "--loginuri http://localhost:" + mConfig.ProxyPort;
            if (mConfig.AutoLoginClient)
                args += " --login " + mConfig.LoginFirstName + " " + mConfig.LoginLastName + " " + mConfig.LoginPassword;
            mClient = ProcessWrangler.InitProcess(mConfig.ViewerExecutable, mConfig.ViewerWorkingDirectory, args);
            mClient.EnableRaisingEvents = true;
            try {
                Logger.Info("Starting client:\n\"" + mClient.StartInfo.FileName + "\" " + mClient.StartInfo.Arguments);
                if (!mClient.Start())
                    return false;

                mClient.Exited += new EventHandler(mClient_Exited);
                return mClientLoggedIn;

            } catch (Win32Exception e) {
                Logger.Info("Unable to start client " + mClient.StartInfo.FileName + ". " + e.Message);
                mClient = null;
                return false;
            }
        }

        public void Close() {
            mAutoRestart = false;
            if (mClientLoggedIn)
                CloseViewer();
            CloseProxy();
        }

        public void Restart(string reason) {
            Logger.Info("Restarting viewer " + reason);

            string dump = "Viewer crashed at " + DateTime.Now.ToString("u") + Environment.NewLine;
            dump += " Login: " + mFirstName + " " + mLastName + Environment.NewLine;
            dump += " Exe: " + mConfig.ViewerExecutable + Environment.NewLine;
            dump += " Dir: " + mConfig.ViewerWorkingDirectory + Environment.NewLine + Environment.NewLine;
            dump += "Log: " + Environment.NewLine;
            if (reason == "Crash") {
                Thread.Sleep(1000);
                string username = Environment.UserName;
                foreach (string line in File.ReadAllLines("C:\\Users\\" + username + "\\AppData\\Roaming\\Firestorm\\logs\\Firestorm.log"))
                    dump += line + Environment.NewLine;
            }
            dump += Environment.NewLine + Environment.NewLine + "---------------- End of Viewer Crash report -------------" + Environment.NewLine + Environment.NewLine;

            ProcessWrangler.Dump(dump, "-" + reason + "-FS.log");

            //if (mClientLoggedIn) {
                CloseViewer();
                Thread.Sleep(1000);
                CloseProxy();
                Thread.Sleep(1000);
                Launch();
            //}
        }

        #endregion

        #region IInput Members

        public event Action<IPlugin, bool> EnabledChanged;

        UserControl IPlugin.ControlPanel {
            get {
                if (mInputPanel == null) {
                    mMaster = true;
                    mFollowCamProperties = new SetFollowCamProperties(Frame.Core);
                    mInputPanel = new InputPanel(mFollowCamProperties);

                }
                return mInputPanel;
            }
        }

        public bool Enabled {
            get { return mEnabled; }
            set {
                if (mEnabled != value) {
                    mEnabled = value;
                    if (EnabledChanged != null)
                        EnabledChanged(this, value);
                }
            }
        }

        public string Name {
            get { return "MasterClient"; }
        }

        string IPlugin.State {
            get { throw new NotImplementedException(); }
        }

        public ConfigBase Config {
            get { return mConfig; }
        }

        public void Draw(Graphics graphics, Func<Vector3, Point> to2D, Action redraw, Perspective perspective) {
            //Do nothing
        }

        #endregion

        #region ISystemPlugin Members

        public void Init(Core coordinator) { }

        #endregion


        private void mFrame_MonitorChanged(Frame frame, Screen monitor) {
            if (mClientLoggedIn && mClient != null)
                ProcessWrangler.SetMonitor(mClient, monitor);
        }

        private void Coordinator_CameraUpdated(Core coordinator, CameraUpdateEventArgs args) {
            if (coordinator.ControlMode == ControlMode.Absolute || !mMaster) {
                double viewer = DateTime.Now.Subtract(mLastViewerUpdate).TotalSeconds;
                double camera = DateTime.Now.Subtract(mLastCameraUpdate).TotalSeconds;
                if (mClientLoggedIn && viewer > 2.0 && viewer > camera) {
                    //Console.WriteLine("Timeout since last viewer move. Last Viewer Update: {0}s, Last Camera Update: {1}s ", viewer, camera);
                    //Console.WriteLine("Control mode: " + coordinator.ControlMode);

                    if (mRestartOnTimeout)
                        Restart("Timeout");
                    else {
                        ClearCamera();
                        SetCamera();
                    }
                }
                if (mLastCameraPosition != args.position) {
                    mLastCameraUpdate = DateTime.Now;
                    mLastCameraPosition = args.position;
                }
                ProcessCameraUpdate(coordinator, args);
            }
        }

        /// <summary>
        /// Called whenever the eye position is updated.
        /// </summary>
        /// <param name="input">The input which triggered the eye change.</param>
        /// <param name="args">The arguments about the change that was made.</param>
        private void Coordinator_EyeUpdated(Core coordinator, EventArgs args) {
            if (ProxyRunning && ControlCamera && Frame.Core.ControlMode == ControlMode.Absolute) {
                SetCamera();
                SetFrame();
            }
        }
    
        private Packet mProxy_AgentUpdatePacketReceived(Packet p, IPEndPoint ep) {
            AgentUpdatePacket packet = p as AgentUpdatePacket;
            if (packet.AgentData.CameraAtAxis != mLastViewerPosition) {
                mLastViewerPosition = packet.AgentData.CameraAtAxis;
                mLastViewerUpdate =  DateTime.Now;
            }
            if (mMaster && mFrame.Core.ControlMode == ControlMode.Delta) {
                mFrame.Core.Update(packet.AgentData.CameraCenter, Vector3.Zero, new Rotation(packet.AgentData.CameraAtAxis), Rotation.Zero, ControlMode.Absolute);
            }
            return p;
        }

        private void Coordinator_CameraModeChanged(Core coordinator, ControlMode mode) {
            if (mMaster) {
                if (mode == ControlMode.Delta) {
                    ClearCamera();
                    if (mProxy != null && mFollowCamProperties.ControlCamera)
                        mProxy.InjectPacket(mFollowCamProperties.Packet, Direction.Incoming);
                } else {
                    SetCamera();
                    if (mProxy != null)
                        mProxy.InjectPacket(new ClearRemoteControlPacket(), Direction.Incoming);
                }
            }
        }

        private void Coordinator_DeltaUpdated(Core coordinator, DeltaUpdateEventArgs args) {
            if (mMaster && coordinator.ControlMode == ControlMode.Delta && mProxy != null) {
                RemoteControlPacket packet = new RemoteControlPacket();
                packet.Delta.Position = args.positionDelta * mDeltaScale;
                packet.Delta.Position.Z = 0f;
                packet.Delta.Pitch = (float) (args.rotationDelta.Pitch * (Math.PI / 45.0)) * mDeltaScale;
                packet.Delta.Yaw = (float) (args.rotationDelta.Yaw * (Math.PI / 45.0)) * mDeltaScale;
                mProxy.InjectPacket(packet, Direction.Incoming);
                
                //TODO - Would be nice if pitching the view 'stuck'.
            }
        }

        void StateManager_CustomTrigger(string trigger) {
            if (trigger == "Glow")
                Glow();
            else if (trigger == "NoGlow")
                NoGlow();
        }

        void mFrame_Changed(Frame f, EventArgs args) {
            if (f.Core.ControlMode == ControlMode.Absolute)
                SetFrame();
        }

        void Coordinator_Tick() {
            if (mClientLoggedIn && mClient != null && DateTime.Now.Minute % 5 == 0 && DateTime.Now.Second % 60 == 0)
                ProcessWrangler.PressKey(mClient, "{ENTER}");
        }

        private void mProxy_LoginResponse(XmlRpcResponse response) {
            mClientLoggedIn = true;
            Hashtable t = (Hashtable)response.Value;

            if (bool.Parse(t["login"].ToString())) {
                mSessionID = UUID.Parse(t["session_id"].ToString());
                mSecureSessionID = UUID.Parse(t["secure_session_id"].ToString());
                mAgentID = UUID.Parse(t["agent_id"].ToString());
                mFirstName = t["first_name"].ToString();
                mLastName = t["last_name"].ToString();

                lock (processLock)
                    Monitor.PulseAll(processLock);

                //TODO - get client process if not started through GUI
                if (mClient != null) {
                    ProcessWrangler.SetMonitor(mClient, mFrame.Monitor);
                    if (mFullscreen)
                        ProcessWrangler.SetBorder(mClient, mFrame.Monitor, !mFullscreen);
                }

                new Thread(() => {
                    if (mControlCamera && mFrame.Core.ControlMode == ControlMode.Absolute)
                        SetCamera();
                    SetFrame();
                    if (mMaster && mFollowCamProperties.ControlCamera)
                        mProxy.InjectPacket(mFollowCamProperties.Packet, Direction.Incoming);
                    if (OnClientLoggedIn != null)
                        OnClientLoggedIn(mProxy, null);

                    Thread.Sleep(30000);
                    //if (mFullscreen)
                        //ToggleHUD();
                    if (mClient != null)
                        ProcessWrangler.PressKey(mClient, "U", true, false, true);
                }).Start();
            } else {
            }
        }

        private void mClient_Exited(object sender, EventArgs e) {
            bool unexpected = !mClosing;
            mClosing = false;
            mClientLoggedIn = false;
            if (OnViewerExit != null)
                OnViewerExit(this, null);
            lock (processLock)
                Monitor.PulseAll(processLock);
            if (mAutoRestart && unexpected) {
                Restart("Crash");
            }
        }

        #region ISystemPlugin Members


        public void SetForm(Form form) {
        }

        #endregion
    }
}

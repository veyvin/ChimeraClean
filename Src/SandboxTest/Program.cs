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
using NuiLibDotNet;
using Chimera.Util;
using System.Windows.Forms;
using Chimera;
using OpenMetaverse;
using Chimera.Kinect;
using Nini.Config;
using System.Configuration;
using OpenMetaverse.Packets;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;
using SandboxTest;
using CefSharp.Example;
using CefSharp;
using System.Diagnostics;
using UtilLib;
using Chimera.OpenSim.Packets;

namespace Test {
    public class Program {
        static Vector mPointStart;
        static Vector mPointDir;
        static Vector mPlaneTopLeft;
        static Vector mPlaneNormal;
        static Scalar mW;
        static Scalar mH;
        static Vector mIntersection;
        static Vector mTop;
        static Vector mSide;
        static Scalar mX;
        static Scalar mY;
        private static Core mCoordinator;
        private static Vector3 sCentre = new Vector3(128f, 128f, 60f);



	/*
	Test for distributed Chimera
        [STAThread]
        public static void Main(string[] a) {
            InterProxyServer server = new InterProxyServer(5000);
            InterProxyClient client = new InterProxyClient("Client", 5000);

            client.OnPacketReceived += new BackChannelPacketDelegate(client_OnPacketReceived);

            SetCameraPacket p = new SetCameraPacket();
            p.Camera.LookAt = new Vector3(1f, 2f, 3f);
            p.Camera.LookAtDelta = new Vector3(0f, 0f, 0f);
            p.Camera.Position = new Vector3(3f, 2f, 1f);
            p.Camera.PositionDelta = new Vector3(0f, 0f, 0f);

            Console.WriteLine("Sending packet");
            server.BroadcastPacket(p);
            Console.ReadLine();

            Console.WriteLine("Sending packet");
            server.BroadcastPacket(p);
            Console.ReadLine();

            Console.WriteLine("Sending packet");
            server.BroadcastPacket(p);
            Console.ReadLine();

            Console.WriteLine("Exiting");

	    client.Stop();
            server.Stop();
        }

        static Packet client_OnPacketReceived(Packet packet, System.Net.IPEndPoint endPoint) {
            Console.WriteLine("Received");
            return packet;
        }

        private static Rotation GetRot(Vector3 pos) {
            return new Rotation(sCentre - pos);
        }
*/

        [STAThread]
        public static void Main(string[] a) {
	    /*
            CefExample.Init();

	    Application.SetCompatibleTextRenderingDefault(false);
            UDPTest form = new UDPTest();
            Application.Run(form);
	    */

            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sock.Connect(IPAddress.Loopback, 5001);

            IPAddress serverAddr = IPAddress.Parse("127.0.0.1");

            IPEndPoint endPoint = new IPEndPoint(serverAddr, 5000);

            string text = "Hello";
            byte[] send_buffer = Encoding.ASCII.GetBytes(text);

            sock.Send(send_buffer);

            Thread.Sleep(10000);

            /*
            string localAddress = "127.0.0.1";
            string portArg = "--proxy-login-port=8080";
            string listenIPArg = "--proxy-proxyAddress-facing-address=" + localAddress;
            string loginURIArg = "--proxy-remote-login-uri=http://localhost:9000";
            string proxyCaps = "--proxy-caps=false";
            string[] args = { portArg, listenIPArg, loginURIArg, proxyCaps };
            ProxyConfig config = new ProxyConfig("Routing God", "jm726@st-andrews.ac.uk", args);
            Proxy p = new Proxy(config);
            bool send = false;
            p.AddLoginResponseDelegate(response => {
                new Thread(() => {
                    Thread.Sleep(5000);
                    send = true;
                    Console.WriteLine("Starting to send packets.");
                }).Start();
            });
            p.Start();
            */

            /*
            mCoordinator = new Core(null);
            Vector3 start = new Vector3(100f, 100f, 60f);
            mCoordinator.Update(start, Vector3.Zero, GetRot(start), Rotation.Zero);
            Frame f = new Frame("MainWindow");
            mCoordinator.AddFrame(f);
            FullController proxy = new FullController(f);
            //BackwardCompatibleController proxy = new BackwardCompatibleController(w);
            proxy.OnClientLoggedIn += (source, args) => new Thread(SendPackets).Start(proxy);
            proxy.StartProxy(8080, "http://localhost:9000");
            ViewerController viewer = new ViewerController("%^{F1}", "MainWindow");

            string exe = Path.GetFullPath("../../Armadillo-Phoenix/Armadillo/Bin/firestorm-bin.exe");
            //string exe = "C:\\Program Files (x86)\\Firestorm-Release\\Firestorm-Release.exe";

            string viewerArgs = proxy.LoginURI;
            viewerArgs += " --login Master Client clientPassword";
            viewerArgs += " --channel \"Firestorm-Release\" --settings settings_firestorm_release_v4.xml --set InstallLanguage en";

            viewer.Start(exe, Path.GetDirectoryName(exe), viewerArgs);

            double firstDirect = CalcInterest(0, 300, .06);
            double bos = CalcInterest(2000, 50, .0169);
            Console.WriteLine("First Direct (300/m @ 6%) + Bank of Scotland (1.69%) = {0}", firstDirect + bos);
            CalcInterest(2000, 350, .03);

            Console.ReadLine();
            */
        }

        private static Rotation GetRot(Vector3 pos) {
            return new Rotation(sCentre - pos);
        }

        private static SetFollowCamPropertiesPacket MakePacket() {
                SetFollowCamPropertiesPacket packet = new SetFollowCamPropertiesPacket();
                packet.CameraProperty = new SetFollowCamPropertiesPacket.CameraPropertyBlock[22];
                for (int i = 0; i < 22; i++) {
                    packet.CameraProperty[i] = new SetFollowCamPropertiesPacket.CameraPropertyBlock();
                    packet.CameraProperty[i].Type = i + 1;
                }

                packet.CameraProperty[0].Value = 0f;
                packet.CameraProperty[1].Value = 0f;
                packet.CameraProperty[2].Value = 0f;
                packet.CameraProperty[3].Value = 0f;
                packet.CameraProperty[4].Value = 0f;
                packet.CameraProperty[5].Value = 0f;
                packet.CameraProperty[6].Value = 0f;
                packet.CameraProperty[7].Value = 0f;
                packet.CameraProperty[8].Value = 0f;
                packet.CameraProperty[9].Value = 0f;
                packet.CameraProperty[10].Value = 0f;
                packet.CameraProperty[11].Value = 1f;
                packet.CameraProperty[12].Value = 0f; //Position
                packet.CameraProperty[13].Value = 100f; //Position X
                packet.CameraProperty[14].Value = 100f; //Position Y
                packet.CameraProperty[15].Value = 60f; //Position Z
                packet.CameraProperty[16].Value = 0f; //Focus
                packet.CameraProperty[17].Value = 128f; //Focus X
                packet.CameraProperty[18].Value = 128f; //Focus Y
                packet.CameraProperty[19].Value = 60; //Focus Z
                packet.CameraProperty[20].Value = 1f; //Lock Positon
                packet.CameraProperty[21].Value = 1f; //Lock Focus

                return packet;
        }

        private static double CalcInterest(double start, double inc, double rate) {
            double total = start;
            double paid = 0;
            for (int i = 0; i < 12; i++) {
                total += (total * rate) / 12.0;
                total += inc;
                paid += inc;
            }

            Console.WriteLine("£{0} after 12 months starting at £{1}. £{2} paid in, £{3} interest @ {4}%.", total, start, paid, ((total - start) - paid), rate);

            return total;

        }

	/*
        private static void SendPackets(object param) {
            ProxyControllerBase controller = (ProxyControllerBase)param;
            SetFollowCamPropertiesPacket packet = MakePacket();
            Thread.Sleep(10000);
            Console.WriteLine("Sending packets");
            while (true) {
                for (int i = 0; i < 4; i++) {
                    float xInc = .2f;
                    float yInc = 0f;
                    float zInc = 0f;
                    switch (i) {
                        case 1: xInc = 0; yInc = .2f; zInc = .022f; break;
                        case 2: xInc = -.2f; yInc = 0f; break;
                        case 3: xInc = 0; yInc = -.2f; zInc = -.022f; break;
                    }
                    for (int x = 0; x < 320; x++) {
                        controller.InjectPacket(packet);
                        Vector3 pos = mCoordinator.Position;
                        pos.X += xInc;
                        pos.Y += yInc;
                        pos.Z += zInc;
                        mCoordinator.Update(pos, Vector3.Zero, GetRot(pos), Rotation.Zero);
                        controller.SetCamera();
                        Thread.Sleep(20);
                    }
                }
            }
        }
*/


            /*
            DotNetConfigSource dotnet = new DotNetConfigSource();
            ArgvConfigSource arg = new ArgvConfigSource(args);

            dotnet.Merge(arg);

            arg.AddSwitch("Test", "Test", "t");

            string test = arg.Configs["Test"].Get("Test");
            string test2 = dotnet.Configs["appSettings"].Get("Test");

            Console.WriteLine(test);

            mPointStart = Vector.Create("PointStart", 0f, 0f, 0f);
            mPointDir = Vector.Create("PointDir", 0f, 0f, 0f);

            //Init();
            Nui.Init();
            Nui.SetAutoPoll(true);

            GC.Collect();


            Window window = new Window("Test Window");
            window.Width = 2000;
            window.Height = 1500;
            window.TopLeft = new Vector3(0f, -1000f, 750f);

            IKinectCursor cursor = new PointCursor();
            //IKinectCursor cursor = new SimpleCursor();

            //Form = new TestForm(mPlaneTopLeft, mPlaneNormal, mTop, mSide, mPointStart, mPointDir, mIntersection, mW, mH, mX, mY);
            //Form form = new KinectMovementForm();
            //form.Begin();
            Form form = new KinectCursorForm(cursor, window);
            ProcessWrangler.BlockingRunForm(form, null);
            */

        private static void InitNui() {
            Nui.Init();
            Nui.SetAutoPoll(true);
            Vector pointEnd = Nui.joint(Nui.Hand_Right);
            mPointStart = Nui.joint(Nui.Shoulder_Right);
            mPointDir = mPointStart - pointEnd;

            mPlaneTopLeft = Vector.Create("PlanePoint", 1f, 1f, 0f);
            mPlaneNormal = Vector.Create("PlaneNormal", 0f, 0f, -1f);
            mW = Scalar.Create("W", 2f);
            mH = Scalar.Create("H", 2f);

            Vector vertical = Vector.Create(0f, 1f, 0f); // Vertical
            //Calculate the intersection of the plane defined by the point mPlaneTopLeft and the normal mPlaneNormal and the line defined by the point mPointStart and the direction mPointDir.
            mIntersection = Nui.intersect(mPlaneTopLeft, Nui.normalize(mPlaneNormal), mPointStart, Nui.normalize(mPointDir));
            //Calculate a vector that represents the orientation of the top of the input.
            mTop = Nui.scale(Nui.cross(vertical, mPlaneNormal), mW);
            //Calculate a vector that represents the orientation of the side of the input.
            mSide = Nui.scale(Nui.cross(mPlaneNormal, mTop), mH);

            //Calculate the vector (running along the plane) between the top left corner and the point of intersection.
            Vector diff = mIntersection - mPlaneTopLeft;

            //Project the diff line onto the top and side vectors to get x and y values.
            mX = Nui.project(diff, mTop);
            mY = Nui.project(diff, mSide);

            mX.OnChange += () => {
                if (mX.Value > 0 && mX.Value < mW.Value)
                    Console.WriteLine(mX.Value);
            };

            mPointStart.Set(1f, 0f, 0f);
        }

        internal class CefSharpSchemeHandlerFactory : ISchemeHandlerFactory {
            public const string SchemeName = "custom";

            public ISchemeHandler Create() {
                return new CefSharpSchemeHandler();
            }
        }

        public static void Init() {
            var settings = new CefSettings();
            settings.RemoteDebuggingPort = 8088;
            //settings.CefCommandLineArgs.Add("renderer-process-limit", "1");
            //settings.CefCommandLineArgs.Add("renderer-startup-dialog", "renderer-startup-dialog");
            settings.LogSeverity = LogSeverity.Verbose;

            if (Debugger.IsAttached) {
                var architecture = Environment.Is64BitProcess ? "x64" : "x86";
                settings.BrowserSubprocessPath = "BrowserSubprocess\\" + architecture + "\\Debug\\CefSharp.BrowserSubprocess.exe";
            }
	    

            settings.RegisterScheme(new CefCustomScheme {
                SchemeName = CefSharpSchemeHandlerFactory.SchemeName,
                SchemeHandlerFactory = new CefSharpSchemeHandlerFactory()
            });

            if (!Cef.Initialize(settings)) {
                if (Environment.GetCommandLineArgs().Contains("--type=renderer")) {
                    Environment.Exit(0);
                } else {
                    return;
                }
            }
        }
    }
}

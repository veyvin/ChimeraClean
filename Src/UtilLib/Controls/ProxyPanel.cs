﻿/*************************************************************************
Copyright (c) 2012 John McCaffery 

This file is part of Armadillo SlaveProxy.

Routing Project is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Routing Project is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Routing Project.  If not, see <http://www.gnu.org/licenses/>.

**************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GridProxy;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace UtilLib {
    public partial class ProxyPanel : UserControl {
        private ProxyManager proxy;
        private Process client;
        private bool loggedIn;

        public ProxyManager Proxy { 
            get { return proxy; }
            set { 
                proxy = value;
                if (proxy == null)
                    return;
                Action init = () => {
                    portBox.Text = proxy.ProxyPort.ToString();
                    loginURIBox.Text = proxy.ProxyLoginURI;
                    targetBox.Text = proxy.ClientExecutable;
                    firstNameBox.Text = proxy.FirstName;
                    lastNameBox.Text = proxy.LastName;
                    passwordBox.Text = proxy.Password;

                    if (proxy.ProxyRunning) {
                        proxyStartButton.Text = "Disconnect SlaveProxy";
                        proxyStatusLabel.Text = "Started";

                        portBox.Enabled = false;
                        loginURIBox.Enabled = false;
                    }

                    if (proxy.ClientLoggedIn) {
                        clientStatusLabel.Text = "Started";
                        clientStartButton.Text = "Disconnect Client";
                        firstNameBox.Enabled = false;
                        lastNameBox.Enabled = false;
                        passwordBox.Enabled = false;
                        targetBox.Enabled = false;
                    }
                };
                if (InvokeRequired)
                    Invoke(init);
                else
                    init();
            }
        }
        public bool HasStarted { get { return proxy != null; } }

        public string Port {
            get { return portBox.Text; }
            set { portBox.Text = value; }
        }
        public string LoginURI {
            get { return loginURIBox.Text; }
            set { loginURIBox.Text = value; }
        }

        public event EventHandler LoggedIn;
        public event EventHandler OnStarted;

        public ProxyPanel() {
            InitializeComponent();
        }

        public ProxyPanel(ProxyManager proxy)
            : this() {
                this.proxy = proxy;
        }

        private void connectButton_Click(object sender, EventArgs e) {
            if (proxy == null)
                return;
            if (proxyStartButton.Text.Equals("Bind SlaveProxy")) {
                if (proxy.ProxyRunning)
                    proxy.StopProxy();
                string file = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

                if (proxy.StartProxy(loginURIBox.Text, Int32.Parse(portBox.Text))) {
                    proxyStartButton.Text = "Disconnect SlaveProxy";
                    proxyStatusLabel.Text = "Started";

                    portBox.Enabled = false;
                    loginURIBox.Enabled = false;
                }
            } else if (proxy != null) {
                proxy.StopProxy();
                proxy = null;

                proxyStartButton.Text = "Bind SlaveProxy";
                proxyStatusLabel.Text = "Stopped";

                portBox.Enabled = true;
                loginURIBox.Enabled = true;
            }
        }

        private void updateTimer_Tick(object sender, EventArgs e) {
            if (loggedIn) {
                proxyStatusLabel.Text = "Started + Client Logged In";
            } 
        }

        private void clientStartButton_Click(object sender, EventArgs e) {
            if (clientStartButton.Text.Equals("Bind Client")) {
                if (!proxy.ProxyRunning)
                    proxyStartButton.PerformClick();

                if (gridCheck.Checked)
                    proxy.StartClient(targetBox.Text, firstNameBox.Text, lastNameBox.Text, passwordBox.Text, gridBox.Text);
                else
                    proxy.StartClient(targetBox.Text, firstNameBox.Text, lastNameBox.Text, passwordBox.Text);

                clientStatusLabel.Text = "Started";
                clientStartButton.Text = "Disconnect Client";
                firstNameBox.Enabled = false;
                lastNameBox.Enabled = false;
                passwordBox.Enabled = false;
                targetBox.Enabled = false;
            } else {
                clientStatusLabel.Text = "Stopped";
                clientStartButton.Text = "Bind Client";
                firstNameBox.Enabled = true;
                lastNameBox.Enabled = true;
                passwordBox.Enabled = true;
                targetBox.Enabled = true;
                //SendMEssage(proxyAddress.Id, 
            }
        }

        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMEssage(int hWnd, int Msg, int wParam, int lParam);

        public string FirstName {
            get { return firstNameBox.Text; }
            set { firstNameBox.Text = value; }
        }


        public string LastName {
            get { return lastNameBox.Text; }
            set { lastNameBox.Text = value; }
        }

        public string Password {
            get { return passwordBox.Text; }
            set { passwordBox.Text = value; }
        }

        private void portBox_TextChanged(object sender, EventArgs e) {
            gridBox.Text = portBox.Text;
        }

        private void gridCheck_CheckedChanged(object sender, EventArgs e) {
            gridBox.Enabled = gridCheck.Checked;
        }

    }
}

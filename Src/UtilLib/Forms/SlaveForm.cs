﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilLib;

namespace ConsoleTest {
    public partial class SlaveForm : Form {
        private CameraSlave slave;

        public SlaveForm() : this (new CameraSlave()) { }

        public SlaveForm(CameraSlave slave) {
            this.slave = slave;
            InitializeComponent();
            proxyPanel.Proxy = slave;
            Text = slave.Name;
            if (slave.ProxyRunning)
                Text += ": " + slave.ProxyConfig.ProxyPort;

            addressBox.Text = slave.ProxyConfig.MasterAddress;
            portBox.Text = slave.ProxyConfig.MasterPort.ToString();
            nameBox.Text = slave.Name;

            if (slave.ConnectedToMaster) {
                addressBox.Text = slave.ProxyConfig.MasterAddress;
                addressBox.Enabled = false;

                portBox.Text = slave.ProxyConfig.MasterPort.ToString();
                portBox.Enabled = false;

                nameBox.Text = slave.Name;
                nameBox.Enabled = false;

                connectButton.Text = "Disconnect from Master";
                statusLabel.Text = "Connected to " + slave.ProxyConfig.MasterAddress + ":" + slave.ProxyConfig.MasterPort + " as " + slave.Name;
            } else 
                statusLabel.Text = "Not Connected";

            slave.OnProxyStarted += (source, args) => {
                Invoke(new Action(() => Text = slave.Name + ": " + slave.ProxyConfig.ProxyPort));
            };
            slave.OnUpdateSentToClient += (position, lookAt) => {
                Invoke(new Action(() => {
                    masterPosition.Value = slave.MasterPosition;
                    masterRotation.LookAtVector = slave.MasterRotation.LookAtVector;
                    finalPosition.Value = position;
                    finalRotation.LookAtVector = lookAt;
                    receivedLabel.Text = slave.PacketsReceived.ToString();
                    injectedLabel.Text = slave.PacketsInjected.ToString();
                }));
            };
        }

        private void rotationOffsetPanel_OnChange(object sender, EventArgs e) {
            slave.OffsetRotation.Quaternion = rotationOffsetPanel.Rotation;
        }

        private void positionOffset_OnChange(object sender, EventArgs e) {
            slave.OffsetPosition = positionOffsetPanel.Value;
        }

        private void rawRotation_OnChange(object sender, EventArgs e) {
            slave.MasterRotation.Quaternion = masterRotation.Rotation;
        }

        private void rawPosition_OnChange(object sender, EventArgs e) {
            slave.MasterPosition = masterPosition.Value;
        }

        private void SlaveForm_FormClosing(object sender, FormClosingEventArgs e) {
            slave.Stop();
        }

        private void controlCamera_CheckedChanged(object sender, EventArgs e) {
            slave.ControlCamera = controlCamera.Checked;
        }

        private void masterBox_TextChanged(object sender, EventArgs e) {
            slave.ProxyConfig.MasterAddress = addressBox.Text;
        }

        private void portBox_TextChanged(object sender, EventArgs e) {
            slave.ProxyConfig.MasterPort = Int32.Parse(portBox.Text);
        }

        private void connectButton_Click(object sender, EventArgs e) {
            if (connectButton.Text.Equals("Connect To Master")) {
                slave.Name = nameBox.Text;
                if (slave.Connect()) {
                    addressBox.Enabled = false;
                    portBox.Enabled = false;
                    nameBox.Enabled = false;
                    connectButton.Text = "Disconnect from Master";
                    statusLabel.Text = "Connected to " + slave.ProxyConfig.MasterAddress + ":" + slave.ProxyConfig.MasterPort + " as " + slave.Name;
                } else
                    statusLabel.Text = "Unable to Connect";
            } else {
                slave.Disconnect();
                addressBox.Enabled = true;
                portBox.Enabled = true;
                nameBox.Enabled = true;
                connectButton.Text = "Connect To Master";
                statusLabel.Text = "Not Connected";
            }
        }
    }
}

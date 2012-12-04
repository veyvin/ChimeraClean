﻿namespace ConsoleTest {
    partial class SlaveForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlaveForm));
            ChimeraLib.Window window1 = new ChimeraLib.Window();
            UtilLib.Rotation rotation1 = new UtilLib.Rotation();
            this.rawTab = new System.Windows.Forms.TabPage();
            this.masterRotation = new ProxyTestGUI.RotationPanel();
            this.masterPosition = new ProxyTestGUI.VectorPanel();
            this.screenTab = new System.Windows.Forms.TabPage();
            this.screenWindowPanel = new ChimeraLib.Controls.WindowPanel();
            this.mainTabContainer = new System.Windows.Forms.TabControl();
            this.proxyTab = new System.Windows.Forms.TabPage();
            this.proxyPanel = new UtilLib.ProxyPanel();
            this.networkTab = new System.Windows.Forms.TabPage();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.MaskedTextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.controlCamera = new System.Windows.Forms.CheckBox();
            this.injectedLabel = new System.Windows.Forms.Label();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.debugPanel = new UtilLib.LogPanel();
            this.rawTab.SuspendLayout();
            this.screenTab.SuspendLayout();
            this.mainTabContainer.SuspendLayout();
            this.proxyTab.SuspendLayout();
            this.networkTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // rawTab
            // 
            this.rawTab.Controls.Add(this.masterRotation);
            this.rawTab.Controls.Add(this.masterPosition);
            this.rawTab.Location = new System.Drawing.Point(4, 22);
            this.rawTab.Name = "rawTab";
            this.rawTab.Padding = new System.Windows.Forms.Padding(3);
            this.rawTab.Size = new System.Drawing.Size(632, 289);
            this.rawTab.TabIndex = 1;
            this.rawTab.Text = "Virtual";
            this.rawTab.UseVisualStyleBackColor = true;
            // 
            // masterRotation
            // 
            this.masterRotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterRotation.DisplayName = "Master VirtualRotationOffset";
            this.masterRotation.Location = new System.Drawing.Point(0, 0);
            this.masterRotation.LookAtVector = ((OpenMetaverse.Vector3)(resources.GetObject("masterRotation.LookAtVector")));
            this.masterRotation.Name = "masterRotation";
            this.masterRotation.Pitch = 0F;
            this.masterRotation.Rotation = ((OpenMetaverse.Quaternion)(resources.GetObject("masterRotation.Rotation")));
            this.masterRotation.Size = new System.Drawing.Size(632, 147);
            this.masterRotation.TabIndex = 2;
            this.masterRotation.Yaw = 0F;
            this.masterRotation.OnChange += new System.EventHandler(this.rotation_OnChange);
            // 
            // masterPosition
            // 
            this.masterPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPosition.DisplayName = "Master VirtualPositionOffset";
            this.masterPosition.Location = new System.Drawing.Point(0, 153);
            this.masterPosition.Max = 2048D;
            this.masterPosition.Min = -2048D;
            this.masterPosition.Name = "masterPosition";
            this.masterPosition.Size = new System.Drawing.Size(632, 98);
            this.masterPosition.TabIndex = 3;
            this.masterPosition.Value = ((OpenMetaverse.Vector3)(resources.GetObject("masterPosition.Value")));
            this.masterPosition.X = 0F;
            this.masterPosition.Y = 0F;
            this.masterPosition.Z = 0F;
            this.masterPosition.OnChange += new System.EventHandler(this.position_OnChange);
            // 
            // screenTab
            // 
            this.screenTab.AutoScroll = true;
            this.screenTab.Controls.Add(this.screenWindowPanel);
            this.screenTab.Location = new System.Drawing.Point(4, 22);
            this.screenTab.Name = "screenTab";
            this.screenTab.Padding = new System.Windows.Forms.Padding(3);
            this.screenTab.Size = new System.Drawing.Size(632, 289);
            this.screenTab.TabIndex = 0;
            this.screenTab.Text = "Screen";
            this.screenTab.UseVisualStyleBackColor = true;
            // 
            // screenWindowPanel
            // 
            this.screenWindowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.screenWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.screenWindowPanel.Name = "screenWindowPanel";
            this.screenWindowPanel.Size = new System.Drawing.Size(632, 288);
            this.screenWindowPanel.TabIndex = 0;
            window1.AspectRatio = 0.5625D;
            window1.Diagonal = 482.59999999999997D;
            window1.EyeOffset = ((OpenMetaverse.Vector3)(resources.GetObject("window1.EyeOffset")));
            window1.FieldOfView = 0.5751065017725624D;
            window1.Height = 236.60007424667296D;
            window1.LockScreenPosition = true;
            rotation1.LookAtVector = ((OpenMetaverse.Vector3)(resources.GetObject("rotation1.LookAtVector")));
            rotation1.Pitch = 0F;
            rotation1.Quaternion = ((OpenMetaverse.Quaternion)(resources.GetObject("rotation1.Quaternion")));
            rotation1.Yaw = 0F;
            window1.RotationOffset = rotation1;
            window1.ScreenPosition = ((OpenMetaverse.Vector3)(resources.GetObject("window1.ScreenPosition")));
            window1.Width = 420.62235421630743D;
            this.screenWindowPanel.Window = window1;
            // 
            // mainTabContainer
            // 
            this.mainTabContainer.Controls.Add(this.proxyTab);
            this.mainTabContainer.Controls.Add(this.networkTab);
            this.mainTabContainer.Controls.Add(this.rawTab);
            this.mainTabContainer.Controls.Add(this.screenTab);
            this.mainTabContainer.Controls.Add(this.debugTab);
            this.mainTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabContainer.Location = new System.Drawing.Point(0, 0);
            this.mainTabContainer.Name = "mainTabContainer";
            this.mainTabContainer.SelectedIndex = 0;
            this.mainTabContainer.Size = new System.Drawing.Size(640, 315);
            this.mainTabContainer.TabIndex = 2;
            // 
            // proxyTab
            // 
            this.proxyTab.Controls.Add(this.proxyPanel);
            this.proxyTab.Location = new System.Drawing.Point(4, 22);
            this.proxyTab.Name = "proxyTab";
            this.proxyTab.Padding = new System.Windows.Forms.Padding(3);
            this.proxyTab.Size = new System.Drawing.Size(632, 289);
            this.proxyTab.TabIndex = 3;
            this.proxyTab.Text = "Proxy";
            this.proxyTab.UseVisualStyleBackColor = true;
            // 
            // proxyPanel
            // 
            this.proxyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proxyPanel.FirstName = "Routing";
            this.proxyPanel.LastName = "God";
            this.proxyPanel.Location = new System.Drawing.Point(3, 3);
            this.proxyPanel.LoginURI = "http://apollo.cs.st-andrews.ac.uk:8002";
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Password = "1245";
            this.proxyPanel.Port = "8080";
            this.proxyPanel.Proxy = null;
            this.proxyPanel.Size = new System.Drawing.Size(626, 283);
            this.proxyPanel.TabIndex = 0;
            // 
            // networkTab
            // 
            this.networkTab.Controls.Add(this.nameLabel);
            this.networkTab.Controls.Add(this.nameBox);
            this.networkTab.Controls.Add(this.label3);
            this.networkTab.Controls.Add(this.statusLabel);
            this.networkTab.Controls.Add(this.portBox);
            this.networkTab.Controls.Add(this.portLabel);
            this.networkTab.Controls.Add(this.addressBox);
            this.networkTab.Controls.Add(this.addressLabel);
            this.networkTab.Controls.Add(this.connectButton);
            this.networkTab.Controls.Add(this.controlCamera);
            this.networkTab.Controls.Add(this.injectedLabel);
            this.networkTab.Controls.Add(this.receivedLabel);
            this.networkTab.Controls.Add(this.label2);
            this.networkTab.Controls.Add(this.label1);
            this.networkTab.Location = new System.Drawing.Point(4, 22);
            this.networkTab.Name = "networkTab";
            this.networkTab.Padding = new System.Windows.Forms.Padding(3);
            this.networkTab.Size = new System.Drawing.Size(632, 289);
            this.networkTab.TabIndex = 4;
            this.networkTab.Text = "Network";
            this.networkTab.UseVisualStyleBackColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(8, 34);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(49, 31);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(113, 20);
            this.nameBox.TabIndex = 13;
            this.nameBox.Text = "Slave1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(116, 59);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(37, 13);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Status";
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.Location = new System.Drawing.Point(574, 3);
            this.portBox.Mask = "0000#";
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(50, 20);
            this.portBox.TabIndex = 10;
            this.portBox.Text = "8090";
            // 
            // portLabel
            // 
            this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(542, 6);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 8;
            this.portLabel.Text = "Port";
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.Location = new System.Drawing.Point(94, 3);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(442, 20);
            this.addressBox.TabIndex = 7;
            this.addressBox.Text = "127.0.0.1";
            this.addressBox.TextChanged += new System.EventHandler(this.masterBox_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(8, 6);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(80, 13);
            this.addressLabel.TabIndex = 6;
            this.addressLabel.Text = "Master Address";
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(168, 29);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(456, 23);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect To Master";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // controlCamera
            // 
            this.controlCamera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.controlCamera.AutoSize = true;
            this.controlCamera.Checked = true;
            this.controlCamera.CheckState = System.Windows.Forms.CheckState.Checked;
            this.controlCamera.Location = new System.Drawing.Point(526, 55);
            this.controlCamera.Name = "controlCamera";
            this.controlCamera.Size = new System.Drawing.Size(98, 17);
            this.controlCamera.TabIndex = 4;
            this.controlCamera.Text = "Control Camera";
            this.controlCamera.UseVisualStyleBackColor = true;
            this.controlCamera.CheckedChanged += new System.EventHandler(this.controlCamera_CheckedChanged);
            // 
            // injectedLabel
            // 
            this.injectedLabel.AutoSize = true;
            this.injectedLabel.Location = new System.Drawing.Point(116, 103);
            this.injectedLabel.Name = "injectedLabel";
            this.injectedLabel.Size = new System.Drawing.Size(13, 13);
            this.injectedLabel.TabIndex = 3;
            this.injectedLabel.Text = "0";
            // 
            // receivedLabel
            // 
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Location = new System.Drawing.Point(116, 81);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(13, 13);
            this.receivedLabel.TabIndex = 2;
            this.receivedLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Packets Injected: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Packets Recieved: ";
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugPanel);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Padding = new System.Windows.Forms.Padding(3);
            this.debugTab.Size = new System.Drawing.Size(632, 289);
            this.debugTab.TabIndex = 5;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // debugPanel
            // 
            this.debugPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPanel.Location = new System.Drawing.Point(3, 3);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(626, 283);
            this.debugPanel.Source = null;
            this.debugPanel.TabIndex = 1;
            // 
            // SlaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 315);
            this.Controls.Add(this.mainTabContainer);
            this.Name = "SlaveForm";
            this.Text = "SlaveForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SlaveForm_FormClosing);
            this.rawTab.ResumeLayout(false);
            this.screenTab.ResumeLayout(false);
            this.mainTabContainer.ResumeLayout(false);
            this.proxyTab.ResumeLayout(false);
            this.networkTab.ResumeLayout(false);
            this.networkTab.PerformLayout();
            this.debugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage rawTab;
        private System.Windows.Forms.TabPage screenTab;
        private System.Windows.Forms.TabControl mainTabContainer;
        private ProxyTestGUI.RotationPanel masterRotation;
        private ProxyTestGUI.VectorPanel masterPosition;
        private System.Windows.Forms.TabPage proxyTab;
        private UtilLib.ProxyPanel proxyPanel;
        private System.Windows.Forms.TabPage networkTab;
        private System.Windows.Forms.TabPage debugTab;
        private UtilLib.LogPanel debugPanel;
        private System.Windows.Forms.Label injectedLabel;
        private System.Windows.Forms.Label receivedLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox controlCamera;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.MaskedTextBox portBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private ChimeraLib.Controls.WindowPanel screenWindowPanel;



    }
}
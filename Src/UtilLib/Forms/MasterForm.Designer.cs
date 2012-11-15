﻿namespace ConsoleTest {
    partial class MasterForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.slavesTab = new System.Windows.Forms.TabControl();
            this.rawTab = new System.Windows.Forms.TabPage();
            this.visualSlavesSplit = new System.Windows.Forms.SplitContainer();
            this.displayTab = new System.Windows.Forms.TabControl();
            this.bothTab = new System.Windows.Forms.TabPage();
            this.hvSplit = new System.Windows.Forms.SplitContainer();
            this.hBox = new System.Windows.Forms.GroupBox();
            this.vBox = new System.Windows.Forms.GroupBox();
            this.proxyTab = new System.Windows.Forms.TabPage();
            this.networkTab = new System.Windows.Forms.TabPage();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.forwardedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.processedLabel = new System.Windows.Forms.Label();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.bindButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.MaskedTextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moveScaleSlider = new System.Windows.Forms.TrackBar();
            this.mouseScaleSlider = new System.Windows.Forms.TrackBar();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.topSplit = new System.Windows.Forms.SplitContainer();
            this.mousePanel = new System.Windows.Forms.Panel();
            this.mouseContainer = new System.Windows.Forms.GroupBox();
            this.proxyPanel = new UtilLib.ProxyPanel();
            this.debugPanel = new UtilLib.LogPanel();
            this.rawRotation = new ProxyTestGUI.RotationPanel();
            this.rawPosition = new ProxyTestGUI.VectorPanel();
            this.slavesTab.SuspendLayout();
            this.rawTab.SuspendLayout();
            this.visualSlavesSplit.Panel1.SuspendLayout();
            this.visualSlavesSplit.Panel2.SuspendLayout();
            this.visualSlavesSplit.SuspendLayout();
            this.displayTab.SuspendLayout();
            this.bothTab.SuspendLayout();
            this.hvSplit.Panel1.SuspendLayout();
            this.hvSplit.Panel2.SuspendLayout();
            this.hvSplit.SuspendLayout();
            this.proxyTab.SuspendLayout();
            this.networkTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseScaleSlider)).BeginInit();
            this.topSplit.Panel1.SuspendLayout();
            this.topSplit.Panel2.SuspendLayout();
            this.topSplit.SuspendLayout();
            this.mouseContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // slavesTab
            // 
            this.slavesTab.Controls.Add(this.rawTab);
            this.slavesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slavesTab.Location = new System.Drawing.Point(0, 0);
            this.slavesTab.Name = "slavesTab";
            this.slavesTab.SelectedIndex = 0;
            this.slavesTab.Size = new System.Drawing.Size(1038, 275);
            this.slavesTab.TabIndex = 0;
            this.slavesTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.slavesTab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // rawTab
            // 
            this.rawTab.AutoScroll = true;
            this.rawTab.Controls.Add(this.rawRotation);
            this.rawTab.Controls.Add(this.rawPosition);
            this.rawTab.Location = new System.Drawing.Point(4, 22);
            this.rawTab.Name = "rawTab";
            this.rawTab.Padding = new System.Windows.Forms.Padding(3);
            this.rawTab.Size = new System.Drawing.Size(1030, 249);
            this.rawTab.TabIndex = 0;
            this.rawTab.Text = "Input Values";
            this.rawTab.UseVisualStyleBackColor = true;
            // 
            // visualSlavesSplit
            // 
            this.visualSlavesSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualSlavesSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.visualSlavesSplit.Location = new System.Drawing.Point(0, 0);
            this.visualSlavesSplit.Name = "visualSlavesSplit";
            this.visualSlavesSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // visualSlavesSplit.Panel1
            // 
            this.visualSlavesSplit.Panel1.Controls.Add(this.topSplit);
            // 
            // visualSlavesSplit.Panel2
            // 
            this.visualSlavesSplit.Panel2.AutoScroll = true;
            this.visualSlavesSplit.Panel2.Controls.Add(this.slavesTab);
            this.visualSlavesSplit.Size = new System.Drawing.Size(1038, 648);
            this.visualSlavesSplit.SplitterDistance = 363;
            this.visualSlavesSplit.SplitterWidth = 10;
            this.visualSlavesSplit.TabIndex = 1;
            this.visualSlavesSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.visualSlavesSplit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // displayTab
            // 
            this.displayTab.Controls.Add(this.bothTab);
            this.displayTab.Controls.Add(this.proxyTab);
            this.displayTab.Controls.Add(this.networkTab);
            this.displayTab.Controls.Add(this.debugTab);
            this.displayTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTab.Location = new System.Drawing.Point(0, 0);
            this.displayTab.Name = "displayTab";
            this.displayTab.SelectedIndex = 0;
            this.displayTab.Size = new System.Drawing.Size(567, 363);
            this.displayTab.TabIndex = 0;
            this.displayTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.displayTab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // bothTab
            // 
            this.bothTab.Controls.Add(this.hvSplit);
            this.bothTab.Location = new System.Drawing.Point(4, 22);
            this.bothTab.Name = "bothTab";
            this.bothTab.Padding = new System.Windows.Forms.Padding(3);
            this.bothTab.Size = new System.Drawing.Size(559, 337);
            this.bothTab.TabIndex = 2;
            this.bothTab.Text = "Horizontal and Vertical";
            this.bothTab.UseVisualStyleBackColor = true;
            // 
            // hvSplit
            // 
            this.hvSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hvSplit.Location = new System.Drawing.Point(3, 3);
            this.hvSplit.Name = "hvSplit";
            // 
            // hvSplit.Panel1
            // 
            this.hvSplit.Panel1.Controls.Add(this.hBox);
            // 
            // hvSplit.Panel2
            // 
            this.hvSplit.Panel2.Controls.Add(this.vBox);
            this.hvSplit.Size = new System.Drawing.Size(553, 331);
            this.hvSplit.SplitterDistance = 267;
            this.hvSplit.TabIndex = 0;
            // 
            // hBox
            // 
            this.hBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hBox.Location = new System.Drawing.Point(0, 0);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(267, 331);
            this.hBox.TabIndex = 0;
            this.hBox.TabStop = false;
            this.hBox.Text = "Horizontal";
            this.hBox.Paint += new System.Windows.Forms.PaintEventHandler(this.hTab_Paint);
            // 
            // vBox
            // 
            this.vBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vBox.Location = new System.Drawing.Point(0, 0);
            this.vBox.Name = "vBox";
            this.vBox.Size = new System.Drawing.Size(282, 331);
            this.vBox.TabIndex = 0;
            this.vBox.TabStop = false;
            this.vBox.Text = "Vertical";
            this.vBox.Paint += new System.Windows.Forms.PaintEventHandler(this.vTab_Paint);
            // 
            // proxyTab
            // 
            this.proxyTab.Controls.Add(this.proxyPanel);
            this.proxyTab.Location = new System.Drawing.Point(4, 22);
            this.proxyTab.Name = "proxyTab";
            this.proxyTab.Padding = new System.Windows.Forms.Padding(3);
            this.proxyTab.Size = new System.Drawing.Size(559, 337);
            this.proxyTab.TabIndex = 3;
            this.proxyTab.Text = "Proxy";
            this.proxyTab.UseVisualStyleBackColor = true;
            // 
            // networkTab
            // 
            this.networkTab.Controls.Add(this.generatedLabel);
            this.networkTab.Controls.Add(this.forwardedLabel);
            this.networkTab.Controls.Add(this.label6);
            this.networkTab.Controls.Add(this.label7);
            this.networkTab.Controls.Add(this.processedLabel);
            this.networkTab.Controls.Add(this.receivedLabel);
            this.networkTab.Controls.Add(this.label4);
            this.networkTab.Controls.Add(this.label1);
            this.networkTab.Controls.Add(this.statusLabel);
            this.networkTab.Controls.Add(this.bindButton);
            this.networkTab.Controls.Add(this.portBox);
            this.networkTab.Controls.Add(this.portLabel);
            this.networkTab.Location = new System.Drawing.Point(4, 22);
            this.networkTab.Name = "networkTab";
            this.networkTab.Padding = new System.Windows.Forms.Padding(3);
            this.networkTab.Size = new System.Drawing.Size(559, 337);
            this.networkTab.TabIndex = 4;
            this.networkTab.Text = "Network";
            this.networkTab.UseVisualStyleBackColor = true;
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(111, 71);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(13, 13);
            this.generatedLabel.TabIndex = 26;
            this.generatedLabel.Text = "0";
            // 
            // forwardedLabel
            // 
            this.forwardedLabel.AutoSize = true;
            this.forwardedLabel.Location = new System.Drawing.Point(111, 58);
            this.forwardedLabel.Name = "forwardedLabel";
            this.forwardedLabel.Size = new System.Drawing.Size(13, 13);
            this.forwardedLabel.TabIndex = 25;
            this.forwardedLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Packets Generated: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Packets Forwarded: ";
            // 
            // processedLabel
            // 
            this.processedLabel.AutoSize = true;
            this.processedLabel.Location = new System.Drawing.Point(111, 45);
            this.processedLabel.Name = "processedLabel";
            this.processedLabel.Size = new System.Drawing.Size(13, 13);
            this.processedLabel.TabIndex = 22;
            this.processedLabel.Text = "0";
            // 
            // receivedLabel
            // 
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Location = new System.Drawing.Point(111, 32);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(13, 13);
            this.receivedLabel.TabIndex = 21;
            this.receivedLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Packets Processed: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Packets Recieved: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(158, 11);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Unbound";
            // 
            // bindButton
            // 
            this.bindButton.Location = new System.Drawing.Point(91, 6);
            this.bindButton.Name = "bindButton";
            this.bindButton.Size = new System.Drawing.Size(61, 23);
            this.bindButton.TabIndex = 13;
            this.bindButton.Text = "Bind";
            this.bindButton.UseVisualStyleBackColor = true;
            this.bindButton.Click += new System.EventHandler(this.bindButton_Click);
            // 
            // portBox
            // 
            this.portBox.Location = new System.Drawing.Point(35, 8);
            this.portBox.Mask = "0000#";
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(50, 20);
            this.portBox.TabIndex = 12;
            this.portBox.Text = "8090";
            // 
            // portLabel
            // 
            this.portLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(-268, 11);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 11;
            this.portLabel.Text = "Port";
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugPanel);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Padding = new System.Windows.Forms.Padding(3);
            this.debugTab.Size = new System.Drawing.Size(559, 337);
            this.debugTab.TabIndex = 5;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.mouseScaleSlider);
            this.controlPanel.Controls.Add(this.moveScaleSlider);
            this.controlPanel.Location = new System.Drawing.Point(3, 259);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(455, 100);
            this.controlPanel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Move Sensitivity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mouse Sensitivity";
            // 
            // moveScaleSlider
            // 
            this.moveScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveScaleSlider.Location = new System.Drawing.Point(3, 54);
            this.moveScaleSlider.Maximum = 40;
            this.moveScaleSlider.Minimum = 10;
            this.moveScaleSlider.Name = "moveScaleSlider";
            this.moveScaleSlider.Size = new System.Drawing.Size(449, 42);
            this.moveScaleSlider.TabIndex = 1;
            this.moveScaleSlider.Value = 20;
            // 
            // mouseScaleSlider
            // 
            this.mouseScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseScaleSlider.Location = new System.Drawing.Point(3, 6);
            this.mouseScaleSlider.Maximum = 40;
            this.mouseScaleSlider.Minimum = 10;
            this.mouseScaleSlider.Name = "mouseScaleSlider";
            this.mouseScaleSlider.Size = new System.Drawing.Size(449, 42);
            this.mouseScaleSlider.TabIndex = 2;
            this.mouseScaleSlider.Value = 20;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 50;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // topSplit
            // 
            this.topSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.topSplit.Location = new System.Drawing.Point(0, 0);
            this.topSplit.Name = "topSplit";
            // 
            // topSplit.Panel1
            // 
            this.topSplit.Panel1.Controls.Add(this.displayTab);
            // 
            // topSplit.Panel2
            // 
            this.topSplit.Panel2.Controls.Add(this.mouseContainer);
            this.topSplit.Panel2.Controls.Add(this.controlPanel);
            this.topSplit.Size = new System.Drawing.Size(1038, 363);
            this.topSplit.SplitterDistance = 567;
            this.topSplit.SplitterWidth = 10;
            this.topSplit.TabIndex = 1;
            this.topSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.topSplit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // mousePanel
            // 
            this.mousePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mousePanel.Location = new System.Drawing.Point(3, 13);
            this.mousePanel.Name = "mousePanel";
            this.mousePanel.Size = new System.Drawing.Size(448, 234);
            this.mousePanel.TabIndex = 7;
            this.mousePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mousePanel_Paint);
            this.mousePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseTab_MouseDown);
            this.mousePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTab_MouseMove);
            this.mousePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseTab_MouseUp);
            // 
            // mouseContainer
            // 
            this.mouseContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseContainer.Controls.Add(this.mousePanel);
            this.mouseContainer.Location = new System.Drawing.Point(3, 3);
            this.mouseContainer.Name = "mouseContainer";
            this.mouseContainer.Size = new System.Drawing.Size(454, 250);
            this.mouseContainer.TabIndex = 8;
            this.mouseContainer.TabStop = false;
            this.mouseContainer.Text = "Mouselook";
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
            this.proxyPanel.Size = new System.Drawing.Size(553, 331);
            this.proxyPanel.TabIndex = 0;
            // 
            // debugPanel
            // 
            this.debugPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPanel.Location = new System.Drawing.Point(3, 3);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(553, 331);
            this.debugPanel.TabIndex = 0;
            // 
            // rawRotation
            // 
            this.rawRotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawRotation.DisplayName = "Raw Rotation";
            this.rawRotation.Location = new System.Drawing.Point(3, 0);
            this.rawRotation.LookAtVector = ((OpenMetaverse.Vector3)(resources.GetObject("rawRotation.LookAtVector")));
            this.rawRotation.Name = "rawRotation";
            this.rawRotation.Pitch = 0F;
            this.rawRotation.Rotation = ((OpenMetaverse.Quaternion)(resources.GetObject("rawRotation.Rotation")));
            this.rawRotation.Size = new System.Drawing.Size(1008, 147);
            this.rawRotation.TabIndex = 2;
            this.rawRotation.Yaw = 0F;
            // 
            // rawPosition
            // 
            this.rawPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawPosition.DisplayName = "Raw Position";
            this.rawPosition.Location = new System.Drawing.Point(6, 153);
            this.rawPosition.Max = 2048D;
            this.rawPosition.Min = -2048D;
            this.rawPosition.Name = "rawPosition";
            this.rawPosition.Size = new System.Drawing.Size(1005, 98);
            this.rawPosition.TabIndex = 1;
            this.rawPosition.Value = ((OpenMetaverse.Vector3)(resources.GetObject("rawPosition.Value")));
            this.rawPosition.X = 128F;
            this.rawPosition.Y = 128F;
            this.rawPosition.Z = 128F;
            this.rawPosition.OnChange += new System.EventHandler(this.rawPosition_OnChange);
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 648);
            this.Controls.Add(this.visualSlavesSplit);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.slavesTab.ResumeLayout(false);
            this.rawTab.ResumeLayout(false);
            this.visualSlavesSplit.Panel1.ResumeLayout(false);
            this.visualSlavesSplit.Panel2.ResumeLayout(false);
            this.visualSlavesSplit.ResumeLayout(false);
            this.displayTab.ResumeLayout(false);
            this.bothTab.ResumeLayout(false);
            this.hvSplit.Panel1.ResumeLayout(false);
            this.hvSplit.Panel2.ResumeLayout(false);
            this.hvSplit.ResumeLayout(false);
            this.proxyTab.ResumeLayout(false);
            this.networkTab.ResumeLayout(false);
            this.networkTab.PerformLayout();
            this.debugTab.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveScaleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mouseScaleSlider)).EndInit();
            this.topSplit.Panel1.ResumeLayout(false);
            this.topSplit.Panel2.ResumeLayout(false);
            this.topSplit.ResumeLayout(false);
            this.mouseContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl slavesTab;
        private System.Windows.Forms.TabPage rawTab;
        private ProxyTestGUI.VectorPanel rawPosition;
        private System.Windows.Forms.SplitContainer visualSlavesSplit;
        private System.Windows.Forms.TabControl displayTab;
        private System.Windows.Forms.TabPage bothTab;
        private System.Windows.Forms.SplitContainer hvSplit;
        private System.Windows.Forms.GroupBox hBox;
        private System.Windows.Forms.GroupBox vBox;
        private System.Windows.Forms.TabPage proxyTab;
        private UtilLib.ProxyPanel proxyPanel;
        private System.Windows.Forms.TabPage networkTab;
        private System.Windows.Forms.TabPage debugTab;
        private UtilLib.LogPanel debugPanel;
        private System.Windows.Forms.MaskedTextBox portBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button bindButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.Label forwardedLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label processedLabel;
        private System.Windows.Forms.Label receivedLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar mouseScaleSlider;
        private System.Windows.Forms.TrackBar moveScaleSlider;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Timer moveTimer;
        private ProxyTestGUI.RotationPanel rawRotation;
        private System.Windows.Forms.SplitContainer topSplit;
        private System.Windows.Forms.GroupBox mouseContainer;
        private System.Windows.Forms.Panel mousePanel;
    }
}
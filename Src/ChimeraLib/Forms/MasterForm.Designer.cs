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
            ChimeraLib.Window window1 = new ChimeraLib.Window();
            UtilLib.Rotation rotation1 = new UtilLib.Rotation();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            this.slaveColourPicker = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.visualSlavesSplit = new System.Windows.Forms.SplitContainer();
            this.topSplit = new System.Windows.Forms.SplitContainer();
            this.displayTab = new System.Windows.Forms.TabControl();
            this.bothTab = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.scaleBar = new System.Windows.Forms.TrackBar();
            this.hvSplit = new System.Windows.Forms.SplitContainer();
            this.hBox = new System.Windows.Forms.GroupBox();
            this.vBox = new System.Windows.Forms.GroupBox();
            this.lockMasterCheck = new System.Windows.Forms.CheckBox();
            this.proxyTab = new System.Windows.Forms.TabPage();
            this.masterCameraCheck = new System.Windows.Forms.CheckBox();
            this.proxyPanel = new UtilLib.ProxyPanel();
            this.networkTab = new System.Windows.Forms.TabPage();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.inputTabContainer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kinectValuePanel = new ProxyTestGUI.VectorPanel();
            this.kinectPositionPanel = new ProxyTestGUI.VectorPanel();
            this.kinectRotationPanel = new ProxyTestGUI.RotationPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mouseScaleSlider = new System.Windows.Forms.TrackBar();
            this.moveScaleSlider = new System.Windows.Forms.TrackBar();
            this.mouseContainer = new System.Windows.Forms.GroupBox();
            this.mousePanel = new System.Windows.Forms.Panel();
            this.ignorePitchCheck = new System.Windows.Forms.CheckBox();
            this.kinectFrameTab = new System.Windows.Forms.TabPage();
            this.kinectFramePanel = new System.Windows.Forms.PictureBox();
            this.slavesTabContainer = new System.Windows.Forms.TabControl();
            this.virtualTab = new System.Windows.Forms.TabPage();
            this.viewerControlCheck = new System.Windows.Forms.CheckBox();
            this.cameraOffsetPanel = new ProxyTestGUI.VectorPanel();
            this.rawRotation = new ProxyTestGUI.RotationPanel();
            this.rawPosition = new ProxyTestGUI.VectorPanel();
            this.masterTab = new System.Windows.Forms.TabPage();
            this.frustumNearCheck = new System.Windows.Forms.CheckBox();
            this.rotationCheck = new System.Windows.Forms.CheckBox();
            this.eyeOffsetCheck = new System.Windows.Forms.CheckBox();
            this.aspectRatioCheck = new System.Windows.Forms.CheckBox();
            this.fovCheck = new System.Windows.Forms.CheckBox();
            this.frustumVCheck = new System.Windows.Forms.CheckBox();
            this.frustumHCheck = new System.Windows.Forms.CheckBox();
            this.debugTab = new System.Windows.Forms.TabPage();
            this.debugPanel = new UtilLib.LogPanel();
            this.masterWindowPanel = new ChimeraLib.Controls.WindowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.visualSlavesSplit)).BeginInit();
            this.visualSlavesSplit.Panel1.SuspendLayout();
            this.visualSlavesSplit.Panel2.SuspendLayout();
            this.visualSlavesSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSplit)).BeginInit();
            this.topSplit.Panel1.SuspendLayout();
            this.topSplit.Panel2.SuspendLayout();
            this.topSplit.SuspendLayout();
            this.displayTab.SuspendLayout();
            this.bothTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hvSplit)).BeginInit();
            this.hvSplit.Panel1.SuspendLayout();
            this.hvSplit.Panel2.SuspendLayout();
            this.hvSplit.SuspendLayout();
            this.vBox.SuspendLayout();
            this.proxyTab.SuspendLayout();
            this.networkTab.SuspendLayout();
            this.inputTabContainer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseScaleSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveScaleSlider)).BeginInit();
            this.mouseContainer.SuspendLayout();
            this.mousePanel.SuspendLayout();
            this.kinectFrameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kinectFramePanel)).BeginInit();
            this.slavesTabContainer.SuspendLayout();
            this.virtualTab.SuspendLayout();
            this.masterTab.SuspendLayout();
            this.debugTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 50;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
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
            this.visualSlavesSplit.Panel2.Controls.Add(this.slavesTabContainer);
            this.visualSlavesSplit.Size = new System.Drawing.Size(845, 559);
            this.visualSlavesSplit.SplitterDistance = 199;
            this.visualSlavesSplit.SplitterWidth = 10;
            this.visualSlavesSplit.TabIndex = 1;
            this.visualSlavesSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.visualSlavesSplit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
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
            this.topSplit.Panel2.Controls.Add(this.inputTabContainer);
            this.topSplit.Size = new System.Drawing.Size(845, 199);
            this.topSplit.SplitterDistance = 148;
            this.topSplit.SplitterWidth = 10;
            this.topSplit.TabIndex = 1;
            this.topSplit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.topSplit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // displayTab
            // 
            this.displayTab.Controls.Add(this.bothTab);
            this.displayTab.Controls.Add(this.proxyTab);
            this.displayTab.Controls.Add(this.networkTab);
            this.displayTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayTab.Location = new System.Drawing.Point(0, 0);
            this.displayTab.Name = "displayTab";
            this.displayTab.SelectedIndex = 0;
            this.displayTab.Size = new System.Drawing.Size(148, 199);
            this.displayTab.TabIndex = 0;
            this.displayTab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.displayTab.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // bothTab
            // 
            this.bothTab.Controls.Add(this.label11);
            this.bothTab.Controls.Add(this.scaleBar);
            this.bothTab.Controls.Add(this.hvSplit);
            this.bothTab.Location = new System.Drawing.Point(4, 22);
            this.bothTab.Name = "bothTab";
            this.bothTab.Padding = new System.Windows.Forms.Padding(3);
            this.bothTab.Size = new System.Drawing.Size(140, 173);
            this.bothTab.TabIndex = 2;
            this.bothTab.Text = "Horizontal and Vertical";
            this.bothTab.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Scale";
            // 
            // scaleBar
            // 
            this.scaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleBar.Location = new System.Drawing.Point(28, 144);
            this.scaleBar.Maximum = 4000;
            this.scaleBar.Name = "scaleBar";
            this.scaleBar.Size = new System.Drawing.Size(112, 42);
            this.scaleBar.TabIndex = 1;
            this.scaleBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scaleBar.Value = 500;
            this.scaleBar.Scroll += new System.EventHandler(this.scaleBar_Scroll);
            // 
            // hvSplit
            // 
            this.hvSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.hvSplit.Size = new System.Drawing.Size(140, 135);
            this.hvSplit.SplitterDistance = 46;
            this.hvSplit.TabIndex = 0;
            // 
            // hBox
            // 
            this.hBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hBox.Location = new System.Drawing.Point(0, 0);
            this.hBox.Name = "hBox";
            this.hBox.Size = new System.Drawing.Size(46, 135);
            this.hBox.TabIndex = 0;
            this.hBox.TabStop = false;
            this.hBox.Text = "Horizontal";
            this.hBox.Paint += new System.Windows.Forms.PaintEventHandler(this.hTab_Paint);
            // 
            // vBox
            // 
            this.vBox.Controls.Add(this.lockMasterCheck);
            this.vBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vBox.Location = new System.Drawing.Point(0, 0);
            this.vBox.Name = "vBox";
            this.vBox.Size = new System.Drawing.Size(90, 135);
            this.vBox.TabIndex = 0;
            this.vBox.TabStop = false;
            this.vBox.Text = "Vertical";
            this.vBox.Paint += new System.Windows.Forms.PaintEventHandler(this.vTab_Paint);
            // 
            // lockMasterCheck
            // 
            this.lockMasterCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lockMasterCheck.AutoSize = true;
            this.lockMasterCheck.Checked = true;
            this.lockMasterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lockMasterCheck.Location = new System.Drawing.Point(3, 3);
            this.lockMasterCheck.Name = "lockMasterCheck";
            this.lockMasterCheck.Size = new System.Drawing.Size(85, 17);
            this.lockMasterCheck.TabIndex = 0;
            this.lockMasterCheck.Text = "Lock Master";
            this.lockMasterCheck.UseVisualStyleBackColor = true;
            this.lockMasterCheck.CheckedChanged += new System.EventHandler(this.lockMasterCheck_CheckedChanged);
            // 
            // proxyTab
            // 
            this.proxyTab.Controls.Add(this.masterCameraCheck);
            this.proxyTab.Controls.Add(this.proxyPanel);
            this.proxyTab.Location = new System.Drawing.Point(4, 22);
            this.proxyTab.Name = "proxyTab";
            this.proxyTab.Padding = new System.Windows.Forms.Padding(3);
            this.proxyTab.Size = new System.Drawing.Size(146, 179);
            this.proxyTab.TabIndex = 3;
            this.proxyTab.Text = "Proxy";
            this.proxyTab.UseVisualStyleBackColor = true;
            // 
            // masterCameraCheck
            // 
            this.masterCameraCheck.AutoSize = true;
            this.masterCameraCheck.Location = new System.Drawing.Point(8, 166);
            this.masterCameraCheck.Name = "masterCameraCheck";
            this.masterCameraCheck.Size = new System.Drawing.Size(133, 17);
            this.masterCameraCheck.TabIndex = 1;
            this.masterCameraCheck.Text = "Control Master Camera";
            this.masterCameraCheck.UseVisualStyleBackColor = true;
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
            this.proxyPanel.Size = new System.Drawing.Size(140, 173);
            this.proxyPanel.TabIndex = 0;
            // 
            // networkTab
            // 
            this.networkTab.Controls.Add(this.addressBox);
            this.networkTab.Controls.Add(this.label9);
            this.networkTab.Controls.Add(this.label8);
            this.networkTab.Controls.Add(this.label3);
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
            this.networkTab.Size = new System.Drawing.Size(146, 179);
            this.networkTab.TabIndex = 4;
            this.networkTab.Text = "Network";
            this.networkTab.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBox.Location = new System.Drawing.Point(54, 8);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(221, 20);
            this.addressBox.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Status:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(111, 83);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(13, 13);
            this.generatedLabel.TabIndex = 26;
            this.generatedLabel.Text = "0";
            // 
            // forwardedLabel
            // 
            this.forwardedLabel.AutoSize = true;
            this.forwardedLabel.Location = new System.Drawing.Point(111, 70);
            this.forwardedLabel.Name = "forwardedLabel";
            this.forwardedLabel.Size = new System.Drawing.Size(13, 13);
            this.forwardedLabel.TabIndex = 25;
            this.forwardedLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Packets Generated: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Packets Forwarded: ";
            // 
            // processedLabel
            // 
            this.processedLabel.AutoSize = true;
            this.processedLabel.Location = new System.Drawing.Point(111, 57);
            this.processedLabel.Name = "processedLabel";
            this.processedLabel.Size = new System.Drawing.Size(13, 13);
            this.processedLabel.TabIndex = 22;
            this.processedLabel.Text = "0";
            // 
            // receivedLabel
            // 
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Location = new System.Drawing.Point(111, 44);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(13, 13);
            this.receivedLabel.TabIndex = 21;
            this.receivedLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Packets Processed: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Packets Recieved: ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(49, 31);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(51, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "Unbound";
            // 
            // bindButton
            // 
            this.bindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bindButton.Location = new System.Drawing.Point(369, 6);
            this.bindButton.Name = "bindButton";
            this.bindButton.Size = new System.Drawing.Size(59, 23);
            this.bindButton.TabIndex = 13;
            this.bindButton.Text = "Bind";
            this.bindButton.UseVisualStyleBackColor = true;
            this.bindButton.Click += new System.EventHandler(this.bindButton_Click);
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.Location = new System.Drawing.Point(313, 8);
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
            this.portLabel.Location = new System.Drawing.Point(-346, 11);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 11;
            this.portLabel.Text = "Port";
            // 
            // inputTabContainer
            // 
            this.inputTabContainer.Controls.Add(this.tabPage1);
            this.inputTabContainer.Controls.Add(this.tabPage2);
            this.inputTabContainer.Controls.Add(this.kinectFrameTab);
            this.inputTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTabContainer.Location = new System.Drawing.Point(0, 0);
            this.inputTabContainer.Name = "inputTabContainer";
            this.inputTabContainer.SelectedIndex = 0;
            this.inputTabContainer.Size = new System.Drawing.Size(687, 199);
            this.inputTabContainer.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.kinectValuePanel);
            this.tabPage1.Controls.Add(this.kinectPositionPanel);
            this.tabPage1.Controls.Add(this.kinectRotationPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kinect";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // kinectValuePanel
            // 
            this.kinectValuePanel.DisplayName = "Kinect Head Value (m)";
            this.kinectValuePanel.Location = new System.Drawing.Point(0, 241);
            this.kinectValuePanel.Max = 30D;
            this.kinectValuePanel.Min = -30D;
            this.kinectValuePanel.Name = "kinectValuePanel";
            this.kinectValuePanel.Size = new System.Drawing.Size(649, 98);
            this.kinectValuePanel.TabIndex = 3;
            this.kinectValuePanel.Value = ((OpenMetaverse.Vector3)(resources.GetObject("kinectValuePanel.Value")));
            this.kinectValuePanel.X = 10F;
            this.kinectValuePanel.Y = 0F;
            this.kinectValuePanel.Z = 0F;
            this.kinectValuePanel.OnChange += new System.EventHandler(this.kinectValuePanel_OnChange);
            // 
            // kinectPositionPanel
            // 
            this.kinectPositionPanel.DisplayName = "Kinect Position (cm)";
            this.kinectPositionPanel.Location = new System.Drawing.Point(3, 147);
            this.kinectPositionPanel.Max = 1000D;
            this.kinectPositionPanel.Min = -1000D;
            this.kinectPositionPanel.Name = "kinectPositionPanel";
            this.kinectPositionPanel.Size = new System.Drawing.Size(646, 98);
            this.kinectPositionPanel.TabIndex = 2;
            this.kinectPositionPanel.Value = ((OpenMetaverse.Vector3)(resources.GetObject("kinectPositionPanel.Value")));
            this.kinectPositionPanel.X = 400F;
            this.kinectPositionPanel.Y = 0F;
            this.kinectPositionPanel.Z = 0F;
            this.kinectPositionPanel.OnChange += new System.EventHandler(this.kinectOffsetPanel_OnChange);
            // 
            // kinectRotationPanel
            // 
            this.kinectRotationPanel.DisplayName = "Kinect Orientation";
            this.kinectRotationPanel.Location = new System.Drawing.Point(3, 3);
            this.kinectRotationPanel.LookAtVector = ((OpenMetaverse.Vector3)(resources.GetObject("kinectRotationPanel.LookAtVector")));
            this.kinectRotationPanel.Name = "kinectRotationPanel";
            this.kinectRotationPanel.Pitch = 0F;
            this.kinectRotationPanel.Rotation = ((OpenMetaverse.Quaternion)(resources.GetObject("kinectRotationPanel.Rotation")));
            this.kinectRotationPanel.Size = new System.Drawing.Size(646, 147);
            this.kinectRotationPanel.TabIndex = 1;
            this.kinectRotationPanel.Yaw = 180F;
            this.kinectRotationPanel.OnChange += new System.EventHandler(this.kinectRotationPanel_OnChange);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.controlPanel);
            this.tabPage2.Controls.Add(this.mouseContainer);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mouselook";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.Controls.Add(this.label5);
            this.controlPanel.Controls.Add(this.label2);
            this.controlPanel.Controls.Add(this.mouseScaleSlider);
            this.controlPanel.Controls.Add(this.moveScaleSlider);
            this.controlPanel.Location = new System.Drawing.Point(0, 79);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(373, 100);
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
            // mouseScaleSlider
            // 
            this.mouseScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseScaleSlider.Location = new System.Drawing.Point(3, 6);
            this.mouseScaleSlider.Maximum = 40;
            this.mouseScaleSlider.Minimum = 10;
            this.mouseScaleSlider.Name = "mouseScaleSlider";
            this.mouseScaleSlider.Size = new System.Drawing.Size(367, 42);
            this.mouseScaleSlider.TabIndex = 2;
            this.mouseScaleSlider.Value = 20;
            // 
            // moveScaleSlider
            // 
            this.moveScaleSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moveScaleSlider.Location = new System.Drawing.Point(3, 54);
            this.moveScaleSlider.Maximum = 40;
            this.moveScaleSlider.Minimum = 10;
            this.moveScaleSlider.Name = "moveScaleSlider";
            this.moveScaleSlider.Size = new System.Drawing.Size(367, 42);
            this.moveScaleSlider.TabIndex = 1;
            this.moveScaleSlider.Value = 20;
            // 
            // mouseContainer
            // 
            this.mouseContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mouseContainer.Controls.Add(this.mousePanel);
            this.mouseContainer.Location = new System.Drawing.Point(0, 3);
            this.mouseContainer.Name = "mouseContainer";
            this.mouseContainer.Size = new System.Drawing.Size(373, 76);
            this.mouseContainer.TabIndex = 8;
            this.mouseContainer.TabStop = false;
            this.mouseContainer.Text = "Mouselook";
            // 
            // mousePanel
            // 
            this.mousePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mousePanel.Controls.Add(this.ignorePitchCheck);
            this.mousePanel.Location = new System.Drawing.Point(3, 13);
            this.mousePanel.Name = "mousePanel";
            this.mousePanel.Size = new System.Drawing.Size(367, 60);
            this.mousePanel.TabIndex = 7;
            this.mousePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mousePanel_Paint);
            this.mousePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseTab_MouseDown);
            this.mousePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTab_MouseMove);
            this.mousePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseTab_MouseUp);
            // 
            // ignorePitchCheck
            // 
            this.ignorePitchCheck.AutoSize = true;
            this.ignorePitchCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ignorePitchCheck.Location = new System.Drawing.Point(425, 0);
            this.ignorePitchCheck.Name = "ignorePitchCheck";
            this.ignorePitchCheck.Size = new System.Drawing.Size(83, 17);
            this.ignorePitchCheck.TabIndex = 0;
            this.ignorePitchCheck.Text = "Ignore Pitch";
            this.ignorePitchCheck.UseVisualStyleBackColor = true;
            this.ignorePitchCheck.CheckedChanged += new System.EventHandler(this.ignorePitchCheck_CheckedChanged);
            // 
            // kinectFrameTab
            // 
            this.kinectFrameTab.Controls.Add(this.kinectFramePanel);
            this.kinectFrameTab.Location = new System.Drawing.Point(4, 22);
            this.kinectFrameTab.Name = "kinectFrameTab";
            this.kinectFrameTab.Padding = new System.Windows.Forms.Padding(3);
            this.kinectFrameTab.Size = new System.Drawing.Size(673, 179);
            this.kinectFrameTab.TabIndex = 2;
            this.kinectFrameTab.Text = "Kinect Image";
            this.kinectFrameTab.UseVisualStyleBackColor = true;
            // 
            // kinectFramePanel
            // 
            this.kinectFramePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kinectFramePanel.Location = new System.Drawing.Point(3, 3);
            this.kinectFramePanel.Name = "kinectFramePanel";
            this.kinectFramePanel.Size = new System.Drawing.Size(667, 173);
            this.kinectFramePanel.TabIndex = 1;
            this.kinectFramePanel.TabStop = false;
            // 
            // slavesTabContainer
            // 
            this.slavesTabContainer.Controls.Add(this.virtualTab);
            this.slavesTabContainer.Controls.Add(this.masterTab);
            this.slavesTabContainer.Controls.Add(this.debugTab);
            this.slavesTabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slavesTabContainer.Location = new System.Drawing.Point(0, 0);
            this.slavesTabContainer.Name = "slavesTabContainer";
            this.slavesTabContainer.SelectedIndex = 0;
            this.slavesTabContainer.Size = new System.Drawing.Size(845, 350);
            this.slavesTabContainer.TabIndex = 0;
            this.slavesTabContainer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.slavesTabContainer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            // 
            // virtualTab
            // 
            this.virtualTab.AutoScroll = true;
            this.virtualTab.Controls.Add(this.viewerControlCheck);
            this.virtualTab.Controls.Add(this.cameraOffsetPanel);
            this.virtualTab.Controls.Add(this.rawRotation);
            this.virtualTab.Controls.Add(this.rawPosition);
            this.virtualTab.Location = new System.Drawing.Point(4, 22);
            this.virtualTab.Name = "virtualTab";
            this.virtualTab.Padding = new System.Windows.Forms.Padding(3);
            this.virtualTab.Size = new System.Drawing.Size(837, 324);
            this.virtualTab.TabIndex = 0;
            this.virtualTab.Text = "Virtual Space";
            this.virtualTab.UseVisualStyleBackColor = true;
            // 
            // viewerControlCheck
            // 
            this.viewerControlCheck.AutoSize = true;
            this.viewerControlCheck.Location = new System.Drawing.Point(101, 7);
            this.viewerControlCheck.Name = "viewerControlCheck";
            this.viewerControlCheck.Size = new System.Drawing.Size(94, 17);
            this.viewerControlCheck.TabIndex = 4;
            this.viewerControlCheck.Text = "Viewer Control";
            this.viewerControlCheck.UseVisualStyleBackColor = true;
            this.viewerControlCheck.CheckedChanged += new System.EventHandler(this.viewerControlCheck_CheckedChanged);
            // 
            // cameraOffsetPanel
            // 
            this.cameraOffsetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cameraOffsetPanel.DisplayName = "CameraOffset";
            this.cameraOffsetPanel.Location = new System.Drawing.Point(8, 260);
            this.cameraOffsetPanel.Max = 10D;
            this.cameraOffsetPanel.Min = -10D;
            this.cameraOffsetPanel.Name = "cameraOffsetPanel";
            this.cameraOffsetPanel.Size = new System.Drawing.Size(682, 98);
            this.cameraOffsetPanel.TabIndex = 3;
            this.cameraOffsetPanel.Value = ((OpenMetaverse.Vector3)(resources.GetObject("cameraOffsetPanel.Value")));
            this.cameraOffsetPanel.X = -4F;
            this.cameraOffsetPanel.Y = 0F;
            this.cameraOffsetPanel.Z = 2F;
            this.cameraOffsetPanel.OnChange += new System.EventHandler(this.cameraOffsetPanel_OnChange);
            // 
            // rawRotation
            // 
            this.rawRotation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawRotation.DisplayName = "In World Rotation";
            this.rawRotation.Location = new System.Drawing.Point(0, 0);
            this.rawRotation.LookAtVector = ((OpenMetaverse.Vector3)(resources.GetObject("rawRotation.LookAtVector")));
            this.rawRotation.Name = "rawRotation";
            this.rawRotation.Pitch = 0F;
            this.rawRotation.Rotation = ((OpenMetaverse.Quaternion)(resources.GetObject("rawRotation.Rotation")));
            this.rawRotation.Size = new System.Drawing.Size(693, 147);
            this.rawRotation.TabIndex = 2;
            this.rawRotation.Yaw = 0F;
            // 
            // rawPosition
            // 
            this.rawPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawPosition.DisplayName = "In World Position";
            this.rawPosition.Location = new System.Drawing.Point(6, 156);
            this.rawPosition.Max = 2048D;
            this.rawPosition.Min = -2048D;
            this.rawPosition.Name = "rawPosition";
            this.rawPosition.Size = new System.Drawing.Size(687, 98);
            this.rawPosition.TabIndex = 1;
            this.rawPosition.Value = ((OpenMetaverse.Vector3)(resources.GetObject("rawPosition.Value")));
            this.rawPosition.X = 128F;
            this.rawPosition.Y = 128F;
            this.rawPosition.Z = 128F;
            this.rawPosition.OnChange += new System.EventHandler(this.rawPosition_OnChange);
            // 
            // masterTab
            // 
            this.masterTab.AutoScroll = true;
            this.masterTab.Controls.Add(this.frustumNearCheck);
            this.masterTab.Controls.Add(this.rotationCheck);
            this.masterTab.Controls.Add(this.eyeOffsetCheck);
            this.masterTab.Controls.Add(this.aspectRatioCheck);
            this.masterTab.Controls.Add(this.fovCheck);
            this.masterTab.Controls.Add(this.frustumVCheck);
            this.masterTab.Controls.Add(this.frustumHCheck);
            this.masterTab.Controls.Add(this.masterWindowPanel);
            this.masterTab.Location = new System.Drawing.Point(4, 22);
            this.masterTab.Name = "masterTab";
            this.masterTab.Padding = new System.Windows.Forms.Padding(3);
            this.masterTab.Size = new System.Drawing.Size(837, 324);
            this.masterTab.TabIndex = 1;
            this.masterTab.Text = "Master";
            this.masterTab.UseVisualStyleBackColor = true;
            // 
            // frustumNearCheck
            // 
            this.frustumNearCheck.AutoSize = true;
            this.frustumNearCheck.Location = new System.Drawing.Point(175, 285);
            this.frustumNearCheck.Name = "frustumNearCheck";
            this.frustumNearCheck.Size = new System.Drawing.Size(94, 17);
            this.frustumNearCheck.TabIndex = 7;
            this.frustumNearCheck.Text = "FrumstumNear";
            this.frustumNearCheck.UseVisualStyleBackColor = true;
            this.frustumNearCheck.CheckedChanged += new System.EventHandler(this.frustumNearCheck_CheckedChanged);
            // 
            // rotationCheck
            // 
            this.rotationCheck.AutoSize = true;
            this.rotationCheck.Location = new System.Drawing.Point(497, 285);
            this.rotationCheck.Name = "rotationCheck";
            this.rotationCheck.Size = new System.Drawing.Size(66, 17);
            this.rotationCheck.TabIndex = 6;
            this.rotationCheck.Text = "Rotation";
            this.rotationCheck.UseVisualStyleBackColor = true;
            this.rotationCheck.CheckedChanged += new System.EventHandler(this.rotationCheck_CheckedChanged);
            // 
            // eyeOffsetCheck
            // 
            this.eyeOffsetCheck.AutoSize = true;
            this.eyeOffsetCheck.Location = new System.Drawing.Point(416, 285);
            this.eyeOffsetCheck.Name = "eyeOffsetCheck";
            this.eyeOffsetCheck.Size = new System.Drawing.Size(75, 17);
            this.eyeOffsetCheck.TabIndex = 5;
            this.eyeOffsetCheck.Text = "Eye Offset";
            this.eyeOffsetCheck.UseVisualStyleBackColor = true;
            this.eyeOffsetCheck.CheckedChanged += new System.EventHandler(this.eyeOffsetCheck_CheckedChanged);
            // 
            // aspectRatioCheck
            // 
            this.aspectRatioCheck.AutoSize = true;
            this.aspectRatioCheck.Location = new System.Drawing.Point(326, 285);
            this.aspectRatioCheck.Name = "aspectRatioCheck";
            this.aspectRatioCheck.Size = new System.Drawing.Size(84, 17);
            this.aspectRatioCheck.TabIndex = 4;
            this.aspectRatioCheck.Text = "AspectRatio";
            this.aspectRatioCheck.UseVisualStyleBackColor = true;
            this.aspectRatioCheck.CheckedChanged += new System.EventHandler(this.aspectRatioCheck_CheckedChanged);
            // 
            // fovCheck
            // 
            this.fovCheck.AutoSize = true;
            this.fovCheck.Location = new System.Drawing.Point(275, 285);
            this.fovCheck.Name = "fovCheck";
            this.fovCheck.Size = new System.Drawing.Size(45, 17);
            this.fovCheck.TabIndex = 3;
            this.fovCheck.Text = "FoV";
            this.fovCheck.UseVisualStyleBackColor = true;
            this.fovCheck.CheckedChanged += new System.EventHandler(this.fovCheck_CheckedChanged);
            // 
            // frustumVCheck
            // 
            this.frustumVCheck.AutoSize = true;
            this.frustumVCheck.Location = new System.Drawing.Point(91, 285);
            this.frustumVCheck.Name = "frustumVCheck";
            this.frustumVCheck.Size = new System.Drawing.Size(78, 17);
            this.frustumVCheck.TabIndex = 2;
            this.frustumVCheck.Text = "FrumstumV";
            this.frustumVCheck.UseVisualStyleBackColor = true;
            this.frustumVCheck.CheckedChanged += new System.EventHandler(this.frustumVCheck_CheckedChanged);
            // 
            // frustumHCheck
            // 
            this.frustumHCheck.AutoSize = true;
            this.frustumHCheck.Location = new System.Drawing.Point(6, 285);
            this.frustumHCheck.Name = "frustumHCheck";
            this.frustumHCheck.Size = new System.Drawing.Size(79, 17);
            this.frustumHCheck.TabIndex = 1;
            this.frustumHCheck.Text = "FrumstumH";
            this.frustumHCheck.UseVisualStyleBackColor = true;
            this.frustumHCheck.CheckedChanged += new System.EventHandler(this.frustumHCheck_CheckedChanged);
            // 
            // debugTab
            // 
            this.debugTab.Controls.Add(this.debugPanel);
            this.debugTab.Location = new System.Drawing.Point(4, 22);
            this.debugTab.Name = "debugTab";
            this.debugTab.Padding = new System.Windows.Forms.Padding(3);
            this.debugTab.Size = new System.Drawing.Size(837, 318);
            this.debugTab.TabIndex = 5;
            this.debugTab.Text = "Debug";
            this.debugTab.UseVisualStyleBackColor = true;
            // 
            // debugPanel
            // 
            this.debugPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugPanel.Location = new System.Drawing.Point(3, 3);
            this.debugPanel.Name = "debugPanel";
            this.debugPanel.Size = new System.Drawing.Size(831, 370);
            this.debugPanel.Source = null;
            this.debugPanel.TabIndex = 0;
            // 
            // masterWindowPanel
            // 
            this.masterWindowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterWindowPanel.Location = new System.Drawing.Point(0, 0);
            this.masterWindowPanel.MinimumSize = new System.Drawing.Size(637, 295);
            this.masterWindowPanel.Name = "masterWindowPanel";
            this.masterWindowPanel.Size = new System.Drawing.Size(837, 295);
            this.masterWindowPanel.TabIndex = 8;
            window1.AspectRatio = 0.48051948051948051D;
            window1.Diagonal = 427.14166268347088D;
            window1.EyePosition = ((OpenMetaverse.Vector3)(resources.GetObject("window1.EyePosition")));
            window1.FieldOfView = 0.18447523605652025D;
            window1.Height = 185.00000000000003D;
            window1.LockScreenPosition = true;
            rotation1.LookAtVector = ((OpenMetaverse.Vector3)(resources.GetObject("rotation1.LookAtVector")));
            rotation1.Pitch = 0F;
            rotation1.Quaternion = ((OpenMetaverse.Quaternion)(resources.GetObject("rotation1.Quaternion")));
            rotation1.Yaw = 0F;
            window1.RotationOffset = rotation1;
            window1.ScreenPosition = ((OpenMetaverse.Vector3)(resources.GetObject("window1.ScreenPosition")));
            window1.Width = 385.00000000000006D;
            this.masterWindowPanel.Window = window1;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 559);
            this.Controls.Add(this.visualSlavesSplit);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            this.visualSlavesSplit.Panel1.ResumeLayout(false);
            this.visualSlavesSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visualSlavesSplit)).EndInit();
            this.visualSlavesSplit.ResumeLayout(false);
            this.topSplit.Panel1.ResumeLayout(false);
            this.topSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topSplit)).EndInit();
            this.topSplit.ResumeLayout(false);
            this.displayTab.ResumeLayout(false);
            this.bothTab.ResumeLayout(false);
            this.bothTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBar)).EndInit();
            this.hvSplit.Panel1.ResumeLayout(false);
            this.hvSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hvSplit)).EndInit();
            this.hvSplit.ResumeLayout(false);
            this.vBox.ResumeLayout(false);
            this.vBox.PerformLayout();
            this.proxyTab.ResumeLayout(false);
            this.proxyTab.PerformLayout();
            this.networkTab.ResumeLayout(false);
            this.networkTab.PerformLayout();
            this.inputTabContainer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseScaleSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveScaleSlider)).EndInit();
            this.mouseContainer.ResumeLayout(false);
            this.mousePanel.ResumeLayout(false);
            this.mousePanel.PerformLayout();
            this.kinectFrameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kinectFramePanel)).EndInit();
            this.slavesTabContainer.ResumeLayout(false);
            this.virtualTab.ResumeLayout(false);
            this.virtualTab.PerformLayout();
            this.masterTab.ResumeLayout(false);
            this.masterTab.PerformLayout();
            this.debugTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl slavesTabContainer;
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
        private System.Windows.Forms.SplitContainer topSplit;
        private System.Windows.Forms.GroupBox mouseContainer;
        private System.Windows.Forms.Panel mousePanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog slaveColourPicker;
        private System.Windows.Forms.CheckBox ignorePitchCheck;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage virtualTab;
        private System.Windows.Forms.TabPage masterTab;
        private System.Windows.Forms.TrackBar scaleBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox lockMasterCheck;
        private System.Windows.Forms.TabControl inputTabContainer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ProxyTestGUI.RotationPanel rawRotation;
        //private ChimeraLib.Controls.WindowPanel masterWindowPanel;
        private System.Windows.Forms.CheckBox masterCameraCheck;
        private System.Windows.Forms.CheckBox rotationCheck;
        private System.Windows.Forms.CheckBox eyeOffsetCheck;
        private System.Windows.Forms.CheckBox aspectRatioCheck;
        private System.Windows.Forms.CheckBox fovCheck;
        private System.Windows.Forms.CheckBox frustumVCheck;
        private System.Windows.Forms.CheckBox frustumHCheck;
        private ProxyTestGUI.VectorPanel cameraOffsetPanel;
        private System.Windows.Forms.CheckBox frustumNearCheck;
        private System.Windows.Forms.CheckBox viewerControlCheck;
        private ProxyTestGUI.VectorPanel kinectPositionPanel;
        private ProxyTestGUI.RotationPanel kinectRotationPanel;
        private System.Windows.Forms.TabPage kinectFrameTab;
        private System.Windows.Forms.PictureBox kinectFramePanel;
        private ProxyTestGUI.VectorPanel kinectValuePanel;
        private ChimeraLib.Controls.WindowPanel masterWindowPanel;
    }
}
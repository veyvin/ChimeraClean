﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Chimera.Experimental.Plugins;
using OpenMetaverse;
using System.IO;

namespace Chimera.Experimental.GUI {
    public partial class AvatarMovementControl : UserControl {
        private AvatarMovementPlugin mPlugin;
        private ExperimentalConfig mConfig;

        public AvatarMovementControl() {
            InitializeComponent();
        }

        public AvatarMovementControl(AvatarMovementPlugin plugin) : this() {
            mPlugin = plugin;
            mConfig = mPlugin.Config as ExperimentalConfig;
            mPlugin.TargetChanged += new Action<string, Vector3>(mPlugin_TargetChanged);

            turnRatePanel.Value = (float) (mPlugin.Config as ExperimentalConfig).TurnRate;
            moveRatePanel.Value = (mPlugin.Config as ExperimentalConfig).MoveRate;
            distanceThresholdPanel.Value = (mPlugin.Config as ExperimentalConfig).DistanceThreshold;
            heightOffsetPanel.Value = (mPlugin.Config as ExperimentalConfig).HeightOffset;
        }

        private void mPlugin_TargetChanged(string name, Vector3 position) {
            Action a = () => statusLabel.Text = "Aiming for '" + name + "' at " + position + ".";
            if (InvokeRequired)
                Invoke(a);
            else
                a();
        }

        private void startButton_Click(object sender, EventArgs e) {
            mPlugin.Start();
        }

        private void turnRatePanel_ValueChanged(float obj) {
            (mPlugin.Config as ExperimentalConfig).TurnRate = turnRatePanel.Value;
        }

        private void movePanel_ValueChanged(float obj) {
            (mPlugin.Config as ExperimentalConfig).MoveRate = moveRatePanel.Value;
        }

        private void targetThresholdPanel_ValueChanged(float obj) {
            (mPlugin.Config as ExperimentalConfig).DistanceThreshold = distanceThresholdPanel.Value;
        }

        private void heightOffsetPanel_ValueChanged(float obj) {
            (mPlugin.Config as ExperimentalConfig).HeightOffset = heightOffsetPanel.Value;
        }

        private void pauseButton_Click(object sender, EventArgs e) {
            mPlugin.Pause();
        }

        private void drawMapButton_Click(object sender, EventArgs e) {
            if (mConfig.MapFile != null)
                mapFileDialog.FileName = Path.GetFullPath(mConfig.MapFile);

            if (mapFileDialog.ShowDialog() == DialogResult.OK) {
                mConfig.MapFile = mapFileDialog.FileName;
                mPlugin.DrawMap();
            }
        }

        private void reloadTargetsButton_Click(object sender, EventArgs e) {
            mPlugin.LoadTargets();
        }

        private void restartButton_Click(object sender, EventArgs e) {
            mPlugin.Restart();
        }

        private void nextButton_Click(object sender, EventArgs e) {
            mPlugin.Next();
        }

        private void prevButton_Click(object sender, EventArgs e) {
            mPlugin.Prev();
        }
    }
}

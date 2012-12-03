﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilLib;

namespace ChimeraLib.Controls {
    public partial class WindowPanel : UserControl {
        private static readonly decimal ASPECT_RATIO_TOLERANCE = new decimal(0.0001);
        private static double INCH2MM = 25.4;
        private Window window;

        public WindowPanel() {
            InitializeComponent();
            aspectRatioValue.Value = aspectRatioHValue.Value / aspectRatioWValue.Value;
        }
        public WindowPanel(Window window) : this() {
            Window = window;
        }

        public Window Window {
            get { return window;  }
            set {
                if (value == null)
                    return;
                if (window != null)
                    window.OnChange -= WindowChanged;
                window = value;
                window.OnChange += WindowChanged;
                WindowChanged(value, null);
            }
        }
        private bool init;
        private void WindowChanged(object source, EventArgs args) {
            if (window == null)
                return;
            Action a = () => {
                double max = Math.Max(window.Height, window.Width);
                if (max > heightSlider.Maximum) {
                    return;
                    //heightSlider.Maximum = (int) max;
                    //heightValue.Maximum = new decimal(max / 10.0);
                    //widthSlider.Maximum = (int) max;
                    //widthValue.Maximum = new decimal(max / 10.0);
                }

                double diagonalInch = Window.Diagonal / INCH2MM;
                if (diagonalInch * 10.0 > diagonalSlider.Maximum) {
                    return;
                    //diagonalSlider.Maximum = (int) (diagonalInch * 10.0);
                    //diagonalValue.Maximum = new decimal(diagonalInch);
                }

                init = true;
                decimal aspectRatio = aspectRatioValue.Value;
                widthSlider.Value = (int) (window.Width);
                widthValue.Value = new decimal(window.Width / 10.0);
                heightSlider.Value = (int) (window.Height);
                heightValue.Value = new decimal(window.Height / 10.0);
                diagonalSlider.Value = (int) (diagonalInch * 10);
                diagonalValue.Value = new decimal(diagonalInch);
                fovSlider.Value = (int)(window.FieldOfView * Rotation.RAD2DEG * 100);
                fovValue.Value = new decimal(window.FieldOfView * Rotation.RAD2DEG);
                aspectRatioValue.Value = new decimal(window.AspectRatio);
                if (Math.Abs(aspectRatio - aspectRatioValue.Value) > ASPECT_RATIO_TOLERANCE) {
                    aspectRatioWValue.Value = new decimal(window.Width);
                    aspectRatioHValue.Value = new decimal(window.Height);
                }
                screenPositionPanel.Value = window.ScreenPosition / 100f;
                eyeOffsetPanel.Value = window.EyeOffset;
                rotationOffsetPanel.Rotation = window.RotationOffset.Quaternion;
                fovLabel.Text = "Field of View (radians): " + Math.Round(window.FieldOfView, 3);
                init = false;
            };

            if (InvokeRequired)
                Invoke(a);
            else
                a();

        }
        private void widthSlider_Scroll(object sender, EventArgs e) {
            if (window != null && !init)
                window.Width = widthSlider.Value;
        }

        private void widthValue_ValueChanged(object sender, EventArgs e) {
            if (window != null && !init)
                window.Width = decimal.ToDouble(widthValue.Value) * 10.0;
        }

        private void heightSlider_Scroll(object sender, EventArgs e) {
            if (window != null && !init)
                window.Height = heightSlider.Value;
        }

        private void heightValue_ValueChanged(object sender, EventArgs e) {
            if (window != null && !init)
                window.Height = decimal.ToDouble(heightValue.Value) * 10.0;
        }

        private void diagonalSlider_Scroll(object sender, EventArgs e) {
            if (window != null && !init)
                window.Diagonal = (diagonalSlider.Value / 10) * INCH2MM;
        }

        private void diagonalValue_ValueChanged(object sender, EventArgs e) {
            if (window != null && !init)
                window.Diagonal = decimal.ToDouble(diagonalValue.Value) * INCH2MM;
        }

        private void fovSlider_Scroll(object sender, EventArgs e) {
            if (window != null && !init)
                window.FieldOfView = (fovSlider.Value / 100) * Rotation.DEG2RAD;
        }

        private void fovValue_ValueChanged(object sender, EventArgs e) {
            if (window != null && !init)
                window.FieldOfView = decimal.ToDouble(fovValue.Value) * Rotation.DEG2RAD;
        }

        private void aspectComponent_ValueChanged(object sender, EventArgs e) {
            if (window != null && aspectRatioHValue != null && aspectRatioWValue != null && !init)
                aspectRatioValue.Value = aspectRatioHValue.Value / aspectRatioWValue.Value;
        }

        private void aspectRatioValue_ValueChanged(object sender, EventArgs e) {
            if (window != null && aspectRatioHValue != null && aspectRatioWValue != null && !init)
                window.AspectRatio = decimal.ToDouble(aspectRatioValue.Value);
        }

        private void screenPositionPanel_OnChange(object sender, EventArgs e) {
            if (window != null && !init)
                window.ScreenPosition = screenPositionPanel.Value * 100f;
        }

        private void eyeOffsetPanel_OnChange(object sender, EventArgs e) {
            if (window != null && !init)
                window.EyeOffset = eyeOffsetPanel.Value;
        }

        private void rotationOffsetPanel_OnChange(object sender, EventArgs e) {
            if (window != null && !init)
                window.RotationOffset.Quaternion = rotationOffsetPanel.Rotation;
        }
    }
}

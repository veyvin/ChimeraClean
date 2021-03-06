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
namespace Chimera.GUI {
    partial class ScalarPanel {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.spinner = new System.Windows.Forms.NumericUpDown();
            this.valueSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // value
            // 
            this.spinner.DecimalPlaces = 2;
            this.spinner.Location = new System.Drawing.Point(0, 0);
            this.spinner.Name = "value";
            this.spinner.Size = new System.Drawing.Size(63, 20);
            this.spinner.TabIndex = 0;
            this.spinner.ValueChanged += new System.EventHandler(this.value_ValueChanged);
            // 
            // valueSlider
            // 
            this.valueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.valueSlider.LargeChange = 100;
            this.valueSlider.Location = new System.Drawing.Point(60, 0);
            this.valueSlider.Maximum = 1000;
            this.valueSlider.Minimum = -1000;
            this.valueSlider.Name = "valueSlider";
            this.valueSlider.Size = new System.Drawing.Size(296, 45);
            this.valueSlider.SmallChange = 10;
            this.valueSlider.TabIndex = 1;
            this.valueSlider.TickFrequency = 100;
            this.valueSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valueSlider.Scroll += new System.EventHandler(this.valueSlider_Scroll);
            // 
            // ScalarPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spinner);
            this.Controls.Add(this.valueSlider);
            this.MinimumSize = new System.Drawing.Size(95, 20);
            this.Name = "ScalarPanel";
            this.Size = new System.Drawing.Size(356, 20);
            ((System.ComponentModel.ISupportInitialize)(this.spinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown spinner;
        private System.Windows.Forms.TrackBar valueSlider;
    }
}

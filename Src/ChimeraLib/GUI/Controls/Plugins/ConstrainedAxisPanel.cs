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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Chimera.Plugins;

namespace Chimera.GUI.Controls.Plugins {
    public partial class ConstrainedAxisPanel : UserControl {
        private ConstrainedAxis mConstrainedAxis;

        public ConstrainedAxisPanel() {
            InitializeComponent();
        }

        public ConstrainedAxisPanel(Chimera.Plugins.ConstrainedAxis constrainedAxis)
            : this() {

            Axis = constrainedAxis;
        }

        public ConstrainedAxis Axis {
            get { return mConstrainedAxis; }
            set {
                if (value == null)
                    return;

                mConstrainedAxis = value;

                deadzonePanel.Max = mConstrainedAxis.Deadzone.Value * 3;
                scalePanel.Max = mConstrainedAxis.Scale.Value * 3;
                scalePanel.Min = mConstrainedAxis.Scale.Value * -3;

                deadzonePanel.Scalar = mConstrainedAxis.Deadzone;
                scalePanel.Scalar = mConstrainedAxis.Scale;
                rawPanel.Scalar = mConstrainedAxis.Raw;
                outputPanel.Scalar = mConstrainedAxis.Output;
            }
        }
    }
}

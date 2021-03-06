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
using Chimera.Interfaces;

namespace Chimera.GUI {
    public partial class UpdatedScalarPanel : ScalarPanel {
        private IUpdater<float> mScalar;
        private Action<float> mChangeListener;
        private bool mGuiChanged;
        private bool mExternalChanged;

        public UpdatedScalarPanel()
            : base() {

            Disposed += new EventHandler(UpdatedScalarPanel_Disposed);
            mChangeListener = new Action<float>(mScalar_OnChange);
        }

        void UpdatedScalarPanel_Disposed(object sender, EventArgs e) {
            if (mScalar != null)
                mScalar.Changed -= mScalar_OnChange;
        }

        public IUpdater<float> Scalar {
            get { return mScalar; }
            set {
                if ( mScalar != null)
                    mScalar.Changed -= mChangeListener;
                mScalar = value;
                if (mScalar != null) {
                    mExternalChanged = true;
                    Value = value.Value;
                    mScalar.Changed += mChangeListener;
                    mExternalChanged = false;
                }
            }
        }

        private void UpdatedScalarPanel_ValueChanged(float obj) {
            if (!mExternalChanged && (object) mScalar != null) {
                mGuiChanged = true;
                mScalar.Value = Value;
                mGuiChanged = false;
            }
        }

        void mScalar_OnChange(float val) {
            if (!mGuiChanged) {
                mExternalChanged = true;
                Value = val;
                mExternalChanged = false;
            }
        }

        /*
        private void UpdatedScalarPanel_VisibleChanged(object sender, EventArgs e) {
            if (Visible)
                mScalar.Changed += mChangeListener;
            else
                mScalar.Changed -= mChangeListener;
        }

        private void UpdatedScalarPanel_Load(object sender, EventArgs e) {
            UpdatedScalarPanel_VisibleChanged(sender, e);
        }
        */
    }
}

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
using System.Linq;
using System.Text;
using Chimera.Interfaces.Overlay;
using System.Drawing;
using OpenMetaverse;
using Chimera.Util;
using Chimera.Overlay.Drawables;

namespace Chimera.Overlay.States {
    public class SeeThroughMenuState : State {
        private readonly List<SeeThroughMenuWindow> mWindows = new List<SeeThroughMenuWindow>();
        private Vector3 mPosition;
        private Rotation mOrientation;

        public SeeThroughMenuState(string name, StateManager manager, Vector3 position, Rotation orientation)
            : base(name, manager) {

            mPosition = position;
            mOrientation = orientation;
        }

        public override IWindowState CreateWindowState(Window window) {
            SeeThroughMenuWindow stateWindow = new SeeThroughMenuWindow(window);
            mWindows.Add(stateWindow);
            return stateWindow;
        }

        public override void TransitionToStart() {
            Manager.Coordinator.EnableUpdates = true;
            Manager.Coordinator.ControlMode = ControlMode.Absolute;
            Manager.Coordinator.Update(mPosition, Vector3.Zero, mOrientation, Rotation.Zero);
            Manager.Coordinator.EnableUpdates = false;

            foreach (var window in mWindows)
                window.ResetToTransparent();
        }

        protected override void TransitionToFinish() {
            TransitionToStart();
        }

        protected override void TransitionFromStart() {
            foreach (var window in mWindows)
                window.TransitionFromState();
        }

        public override void TransitionFromFinish() {
            foreach (var window in mWindows)
                window.ResetToTransparent();
        }

        private class SeeThroughMenuWindow : WindowState {
            private Bitmap mFadeBG;

            public SeeThroughMenuWindow(Window window)
                : base(window.OverlayManager) {
            }

            internal void TransitionFromState() {
                mFadeBG = new Bitmap(Manager.Window.Monitor.Bounds.Width, Manager.Window.Monitor.Bounds.Height);
                using (Graphics g = Graphics.FromImage(mFadeBG)) {
                    g.CopyFromScreen(Manager.Window.Monitor.Bounds.Location, Point.Empty, Manager.Window.Monitor.Bounds.Size);
                }
            }

            internal void ResetToTransparent() {
                mFadeBG = null;
            }

            protected override void OnActivated() { }

            public override void DrawStatic(Graphics graphics) {
                if (mFadeBG != null)
                    graphics.DrawImage(mFadeBG, Point.Empty);
                else {
                    using (Pen p = new Pen(Color.FromArgb(200, Color.White)))
                        graphics.DrawRectangle(p, Clip);
                    base.DrawStatic(graphics);
                }
            }
        }
    }
}

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
using Chimera.Util;
using System.IO;
using OpenMetaverse;

namespace Chimera {
    public class WindowConfig : ConfigBase {
        public string Monitor;
        public bool LaunchOverlay;
        public bool Fullscreen;
        public bool ControlPointer;
        public double Width;
        public double Height;
        public Vector3 TopLeft;
        public double Pitch;
        public double Yaw;
        public bool AlwaysOnTop;


        public WindowConfig(params string[] args) : base(args) { }

        public WindowConfig(string name, string file, string[] args)
            : base(name, file, args) {
        }

        public override string Group {
            get { return "Window"; }
        }

        protected override void InitConfig() {
            AddCommandLineKey(false, "Monitor", "m");
            AddCommandLineKey(false, "LaunchOverlay", "l");
            AddCommandLineKey(false, "Fullscreen", "f");
            AddCommandLineKey(false, "MouseControl", "mc");
           

            Monitor = Get(false, "Monitor", "CrashLog.log", "The monitor on which this window should render.");
            LaunchOverlay = Get(false, "LaunchOverlay", false, "Whether to launch an overlay for this window at startup.");
            Fullscreen = Get(false, "Fullscreen", false, "Whether to launch the overlay fullscreen.");
            ControlPointer = Get(false, "ControlPointer", false, "Whether the overlay should take control of the pointer and move it when the pointer is over the window.");
            AlwaysOnTop = Get(false, "AlwaysOnTop", true, "Whether the overlay window should force itself to stay on top at all times or let it's order in the Z buffer be freely decided.");

            TopLeft = GetV(false, "TopLeft", new Vector3(1000f, 0f, 0f), "The position of the top left corner of the window in real world coordinates (mm).");
            Yaw = Get(false, "Yaw", 0.0, "The yaw for the direction the monitor faces in the real world.");
            Pitch = Get(false, "Pitch", 0.0, "The pitch for the direction the monitor faces in the real world.");
            Width = Get(false, "Width", 0.0, "The width of the window in the real world (mm).");
            Height = Get(false, "Height", 0.0, "The height of the window in the real world (mm).");
        }
    }
}

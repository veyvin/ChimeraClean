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
using System.Drawing;
using System.Xml;
using Chimera.Interfaces.Overlay;

namespace Chimera.Overlay.Drawables {
    public class DynamicTextFactory : IFeatureFactory {
        #region IFactory<IFeature> Members

        public IFeature Create(OverlayPlugin manager, XmlNode node) {
            return new DynamicText(manager, node);
        }

        public IFeature Create(OverlayPlugin manager, XmlNode node, Rectangle clip) {
            return new DynamicText(manager, node, clip);
        }

        #endregion

        #region IFactory Members

        public string Name {
            get { return "DynamicText"; }
        }

        #endregion
    }
    public class DynamicText : Text {
        private WindowOverlayManager mManager;
        private bool mNeedsRedrawn;

        public DynamicText(string text, WindowOverlayManager manager, Font font, Color colour, PointF location)
            : base(text, manager.Frame.Name, font, colour, location) {
            mManager = manager;
        }

        public DynamicText(OverlayPlugin manager, XmlNode node)
            : base(manager, node) {
            mManager = GetManager(manager, node, "text");
        }

        public DynamicText(OverlayPlugin manager, XmlNode node, Rectangle clip)
            : base(manager, node, clip) {
            mManager = GetManager(manager, node, "text");
        }

        public override bool NeedsRedrawn {
            get { return mNeedsRedrawn; }
        }

        public override string TextString {
            get { return base.TextString; }
            set {
                base.TextString = value;
                mNeedsRedrawn = true;
            }
        }

        public override void DrawStatic(Graphics graphics) { }

        public override void DrawDynamic(Graphics graphics) {
            Draw(graphics);
        }
    }
}

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
using Chimera.Interfaces.Overlay;

namespace Chimera.Overlay {
    public class DrawableRoot : OverlayXmlLoader, IFeature {
        /// <summary>
        /// The features which will be drawn on this window state.
        /// </summary>
        private readonly List<IFeature> mFeatures = new List<IFeature>();
        /// <summary>
        /// True if the state needs to be redrawn.
        /// </summary>
        private bool mNeedsRedrawn;
        /// <summary>
        /// The name of the window this drawable is to be drawn on.
        /// </summary>
        private string mWindowName;
        /// <summary>
        /// The clip rectangle bounding the area this item will be drawn to.
        /// </summary>
        private Rectangle mClip;
        /// <summary>
        /// Whether this drawable is active and should therefore be drawn.
        /// </summary>
        private bool mActive = true;

        public DrawableRoot(string window) {
            mWindowName = window;
        }

        public virtual Rectangle Clip {
            get { return mClip; }
            set { 
                mClip = value;
                foreach (var feature in mFeatures)
                    feature.Clip = value;
            }
        }

        public virtual string Frame {
            get { return mWindowName; }
        }

        public virtual bool Active {
            get { return mActive; }
            set { 
                mActive = value;
                foreach (var feature in mFeatures)
                    feature.Active = value;
            }
        }

        /// <summary>
        /// Whether the dynmic part of the drawable needs to be redrawn.
        /// </summary>
        public virtual bool NeedsRedrawn {
            get { return mNeedsRedrawn || mFeatures.Aggregate(false, (s, d) => s || d.NeedsRedrawn); }
        }

        /// <summary>
        /// Features which need to be drawn in the window.
        /// </summary>
        public IFeature[] Features {
            get { return mFeatures.ToArray(); }
        }

        /// <summary>
        /// Set whether or not this window state needs redrawn.
        /// </summary>
        /// <param name="value"></param>
        protected void SetNeedsRedrawn(bool value) {
            mNeedsRedrawn = value;
        }

        /// <summary>
        /// Notify the drawable that the area on which it is to draw has changed. Should draw any elements which only change when the area is resized to the supplied graphics object.
        /// Call this transition a sub class to draw all features for this window state.
        /// </summary>
        /// <param name="clip">The area in which this drawable will be drawn.</param>
        /// <param name="graphics">The object with which to to draw any elements which only change when the area is resized.</param>
        public virtual void DrawStatic(Graphics graphics) {
            foreach (var feature in mFeatures.Where(feat => feat.Active))
                feature.DrawStatic(graphics);
        }

        /// <summary>
        /// Draw the elements of the drawable that change more frequently than when the drawing area is resized.
        /// Call this transition a sub class to draw all features for this window state.
        /// </summary>
        /// <param name="graphics">The object with which to draw the elements.</param>
        public virtual void DrawDynamic(Graphics graphics) {
            foreach (var feature in mFeatures)
                if (feature.Active)
                    feature.DrawDynamic(graphics);
        }
        /// <summary>
        /// Add a drawable feature to the state. Any features added will be drawn on top of content drawn as part of the state itself.
        /// </summary>
        /// <param name="feature">The feature to add.</param>
        public virtual void AddFeature(IFeature feature) {
            mFeatures.Add(feature);
        }
    }
}

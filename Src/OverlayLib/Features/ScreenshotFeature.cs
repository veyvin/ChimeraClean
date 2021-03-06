﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chimera.Interfaces.Overlay;
using System.Drawing;
using System.Xml;

namespace Chimera.Overlay.Features {
    public class ScreenshotFeatureFactory : IFeatureFactory {
        #region IFactory<IFeature> Members

        public IFeature Create(OverlayPlugin manager, XmlNode node) {
            return new ScreenshotFeature(manager, node);
        }

        public IFeature Create(OverlayPlugin manager, XmlNode node, Rectangle clip) {
            return Create(manager, node);
        }

        #endregion

        #region IFactory Members

        public string Name {
            get { return "Screenshot"; }
        }

        #endregion
    }

    public class ScreenshotFeature : OverlayXmlLoader, IFeature {
        private FrameOverlayManager mManager;
        private Bitmap mScreenshot;
        private Rectangle mClip;
        private bool mActive;
        private bool mIncludeOverlay;

        #region IFeature Members

        public System.Drawing.Rectangle Clip {
            get { return mClip; }
            set { mClip = value; }
        }

        public bool Active {
            get { return mActive; }
            set {
                mActive = value;
                if (value) {
                    if (mScreenshot != null)
                        mScreenshot.Dispose();
                    mScreenshot = new Bitmap(mManager.Frame.Monitor.Bounds.Width, mManager.Frame.Monitor.Bounds.Height);
                    using (Graphics g = Graphics.FromImage(mScreenshot)) {
                        g.CopyFromScreen(mManager.Frame.Monitor.Bounds.Location, Point.Empty, mManager.Frame.Monitor.Bounds.Size);
                        if (mIncludeOverlay && mManager != null && mManager.CurrentDisplay != null) {
                            mManager.CurrentDisplay.DrawStatic(g);
                        }
                    }
                }
            }
        }

        public bool NeedsRedrawn {
            get { return false; }
        }

        public string Frame {
            get { return mManager.Frame.Name; }
        }

        public void DrawStatic(System.Drawing.Graphics graphics) {
            graphics.DrawImage(mScreenshot, mClip.Location);
        }

        public void DrawDynamic(System.Drawing.Graphics graphics) { }

        #endregion

        public ScreenshotFeature(OverlayPlugin plugin, XmlNode node) {
            mManager = GetManager(plugin, node, "Screenshot Feature");
            mIncludeOverlay = GetBool(node, false, "IncludeOverlay");
        }
    }
}

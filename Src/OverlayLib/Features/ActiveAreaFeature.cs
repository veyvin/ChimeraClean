﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chimera.Interfaces.Overlay;
using System.Xml;
using System.Drawing;
using Chimera.Overlay.Triggers;

namespace Chimera.Overlay.Features {
    public class ActiveAreaFeatureFactory : IFeatureFactory {
        #region IFactory<IFeature> Members

        public IFeature Create(OverlayPlugin manager, XmlNode node) {
            return new ActiveAreaFeature(manager, node);
        }

        public IFeature Create(OverlayPlugin manager, XmlNode node, Rectangle clip) {
            return Create(manager, node);
        }

        #endregion

        #region IFactory Members

        public string Name {
            get { return "ActiveArea"; }
        }

        #endregion
    }

    public class ActiveAreaFeature : OverlayXmlLoader, IFeature {
        private OverlayPlugin mPlugin;
        private IFeature mFeature;
        private ActiveAreaTrigger mTrigger;

        public ActiveAreaFeature(OverlayPlugin plugin, XmlNode node) {
            mPlugin = plugin;
            XmlNode triggerNode = node.SelectSingleNode("child::Trigger");
            XmlNode featureNode = node.SelectSingleNode("child::Feature");
            if (triggerNode == null)
                throw new ArgumentException("Unable to load Active Area. No 'Trigger' attribute specified.");
            if (featureNode == null)
                throw new ArgumentException("Unable to load Active Area. No 'Feature' attribute specified.");

            mTrigger = new ActiveAreaTrigger(plugin, triggerNode);
            mFeature = mPlugin.GetFeature(featureNode, "conditional feature", null);

            if (mFeature == null)
                throw new ArgumentException("Unable to load Active Area. Unable to parse feature.");

            mTrigger.Triggered += new Action<ITrigger>(mActiveTrigger_Triggered);
        }

        void mActiveTrigger_Triggered(ITrigger source) {
            mFeature.Active = mTrigger.Inside;
            mPlugin[Frame].ForceRedrawStatic();
        }


        #region IFeature Members

        public Rectangle Clip {
            get { return mFeature.Clip; }
            set { mFeature.Clip = value; }
        }

        public bool Active {
            get { return mTrigger.Active && mTrigger.Inside; }
            set {
                mTrigger.Active = value;
                if (!value)
                    mFeature.Active = false;
                else
                    mFeature.Active = mTrigger.Condition;
            }
        }

        public bool NeedsRedrawn {
            get { return mFeature.NeedsRedrawn; }
        }

        public string Frame {
            get { return mFeature.Frame; }
        }

        public void DrawStatic(Graphics graphics) {
            mFeature.DrawStatic(graphics);
        }

        public void DrawDynamic(Graphics graphics) {
            mFeature.DrawDynamic(graphics);
        }

        #endregion
    }
}

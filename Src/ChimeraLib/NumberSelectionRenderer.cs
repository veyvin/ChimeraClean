﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Chimera {
    public class NumberSelectionRenderer : ISelectionRenderer {
        private ISelectable mSelectable;

        public ISelectable Selectable {
            get { return mSelectable; }
        }

        public void DrawHover(Graphics graphics, Rectangle clipRectangle, DateTime mHoverStart, double mSelectTime) {
            double tickLength = mSelectTime / 3;
            double hoverTime = DateTime.Now.Subtract(mHoverStart).TotalMilliseconds;
            int tick = (int)(hoverTime / tickLength) + 1;
            double progress = hoverTime % tickLength;
            int fontSize = (int)((progress / tickLength) * (mSelectable.Bounds.Height / 2.0));
            using (Font font = new Font(FontFamily.GenericMonospace, fontSize, FontStyle.Bold)) {
                string str = tick.ToString();
                SizeF size = graphics.MeasureString(str, font);
                //SizeF size = TextRenderer.MeasureText(str, font);

                float x = mSelectable.Bounds.X + ((mSelectable.Bounds.Width / 2) - (size.Width / 2));
                float y = mSelectable.Bounds.Y + ((mSelectable.Bounds.Height / 2) - (size.Height / 2));

                graphics.DrawString(str, font, Brushes.Red, x, y);
            }
        }

        public void DrawSelected(Graphics graphics, Rectangle clipRectangle) {
            throw new NotImplementedException();
        }

        public void Init(ISelectable selectable) {
            mSelectable = selectable;
        }
    }
}

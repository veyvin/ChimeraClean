﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chimera.Interfaces.Overlay {
    public interface IWindowState : IDrawable {

        /// <summary>
        /// All features which are to be drawn onto the window state.
        /// </summary>
        Chimera.Interfaces.Overlay.IDrawable[] Features {
            get;
            set;
        }

        /// <summary>
        /// Whether or not the window state is currently enabled.
        /// </summary>
        bool Enabled {
            get;
            set;
        }

        /// <summary>
        /// Add a drawable feature to the state. Any features added will be drawn on top of content drawn as part of the state itself.
        /// </summary>
        /// <param name="feature">The feature to add.</param>
        void AddFeature(IDrawable feature);
    }
}

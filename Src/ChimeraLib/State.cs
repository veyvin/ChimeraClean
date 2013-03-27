﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chimera {
    public abstract class State : IState {
        /// <summary>
        /// Factory used to create new WindowState objects for each window in the system.
        /// </summary>
        private IWindowStateFactory mWindowStateFactory;
    
        public IWindowState[] WindowStates {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public StateTransition[] Transitions {
            get {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }
    }
}

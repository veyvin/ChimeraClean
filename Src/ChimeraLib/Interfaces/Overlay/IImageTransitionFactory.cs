﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chimera.Interfaces.Overlay {
    public interface IImageTransitionFactory {
        IImageTransition Create(double length);
    }
}

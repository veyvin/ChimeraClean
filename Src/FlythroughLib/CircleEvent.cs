﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UtilLib;

namespace FlythroughLib {
    public class CircleEvent : FlythroughEvent {
        /// <summary>
        /// The vector which describes the 0 point. This defines where the arc will start and the plane on which it will rotate.
        /// </summary>
        private Rotation mPlane;
        /// <summary>
        /// The length of the arc in degrees.
        /// </summary>
        private float mLength;
        /// <summary>
        /// The rotation on the horizontal plane.
        /// </summary>
        private Rotation mCurrentRotation;
        /// <summary>
        /// The radius of the circle to describe.
        /// </summary>
        private float mRadius;

        public CircleEvent() : base (null, 0) {
            throw new System.NotImplementedException();
        }
        /// <summary>
        /// The vector which describes the 0 point. This defines where the arc will start and the plane on which it will rotate.
        /// </summary>
        public Rotation Plane {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// The radius of the circle to describe.
        /// </summary>
        public float Radius {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// The coordinates where the camera will start.
        /// </summary>
        public Vector3 StartPosition {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// The coordinates where the camera will end up.
        /// </summary>
        public Vector3 EndPosition {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }

        /// <summary>
        /// The length of the arc to describe, in degrees.
        /// </summary>
        public float ArcLength {
            get {
                throw new System.NotImplementedException();
            }
            set {
            }
        }
    
        public override bool Step() {
            throw new NotImplementedException();
        }

        /// <param name="container">The container which this event is part of.</param>
        /// <param name="length">The length of time the event will last (ms).</param>
        protected override void LengthChanged(FlythroughManager container, int length) {
            throw new NotImplementedException();
        }
    }
}

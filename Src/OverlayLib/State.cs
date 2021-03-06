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
using Chimera.Interfaces.Overlay;
using Chimera.Util;
using System.Drawing;
using OpenMetaverse;
using Chimera.Interfaces;
using System.Xml;

namespace Chimera.Overlay {
    public abstract class State : OverlayXmlLoader {
        /// <summary>
        /// The window states, mapped to the names of the windows.
        /// </summary>
        private readonly Dictionary<string, IFrameState> mWindowStates = new Dictionary<string,IFrameState>();
        /// <summary>
        /// Transitions transition this state to other states, mapped to the name of the other state.
        /// </summary>
        private readonly Dictionary<string, StateTransition> mTransitions = new Dictionary<string, StateTransition>();
        /// <summary>
        /// The form which will coordinate the state.
        /// </summary>
        private readonly OverlayPlugin mManager;
        /// <summary>
        /// The name for the state.
        /// </summary>
        private string mName;
        /// <summary>
        /// Whether this state is currently active.
        /// </summary>
        private bool mActive;
        /// <summary>
        /// How opaque the overlays should be for this state. Set when the state is transitioned to.
        /// </summary>
        private double mOpacity = 1.0;
        /// <summary>
        /// Whether to allow control of the pointer when this state is enabled.
        /// </summary>
        private bool mEnableCursor;

        /// <summary>
        /// Statistics object for tracking how this state is used.
        /// </summary>
        private TickStatistics mStatistics = new TickStatistics();

        /// <summary>
        /// State the state, specifying the name, form and the window factory for creating window states.
        /// </summary>
        /// <param name="name">The name of the state. All state names should be unique.</param>
        /// <param name="form">The form which will control this state.</param>
        private State(string name, OverlayPlugin manager) {
            mName = name;
            mManager = manager;

            mManager.Core.FrameAdded += new Action<Frame,EventArgs>(Coordinator_FrameAdded);
        }

        /// <summary>
        /// State the state, specifying the name, overlay and node to load values from.
        /// </summary>
        /// <param name="name">The name of the state. All state names should be unique.</param>
        /// <param name="form">The form which will control this state.</param>
        public State(string name, OverlayPlugin manager, XmlNode node)
            : this(name, manager) {

            mOpacity = GetDouble(node, mOpacity, "Opacity");
            mEnableCursor = GetBool(node, mEnableCursor, "EnableCursor");
        }

        /// <summary>
        /// State the state, specifying the name, overlay, node to load values from and whether to control the cursor.
        /// </summary>
        /// <param name="name">The name of the state. All state names should be unique.</param>
        /// <param name="form">The form which will control this state.</param>
        public State(string name, OverlayPlugin manager, XmlNode node, bool enableCursor)
            : this(name, manager, node) {
            mEnableCursor = enableCursor;
            mEnableCursor = GetBool(node, mEnableCursor, "EnableCursor");
        }



        /// <summary>
        /// //TODO - is this right? 
        /// Relies on state being added to coordinator to add windows, i.e. quite late on during startup.
        /// </summary>
        public void Init() {
            foreach (var window in mManager.Core.Frames)
                Coordinator_FrameAdded(window, null);
        }

        protected virtual void Coordinator_FrameAdded(Frame frame, EventArgs args) {
            if (!mWindowStates.ContainsKey(frame.Name))
                mWindowStates.Add(frame.Name, CreateFrameState(mManager[frame.Name]));
        }

        public IFrameState this[string window] {
            get {
                if (!mWindowStates.ContainsKey(window))
                    Coordinator_FrameAdded(mManager.Core[window], null);
                return mWindowStates[window];
            }
        }
    
        public IFrameState[] WindowStates {
            get { return mWindowStates.Values.ToArray(); }
        }

        /// <summary>
        /// All the transitions for the state.
        /// </summary>
        public StateTransition[] Transitions {
            get { return mTransitions.Values.ToArray(); }
        }

        /// <summary>
        /// The unique name for the state.
        /// </summary>
        public string Name {
            get { return mName; }
        }

        public TickStatistics Statistics {
            get { return mStatistics; }
        }

        public string StatisticsRow {
            get {
                string row = "";

                double total = Math.Round(mStatistics.WorkTotal / 60000.0);
                double min = mStatistics.ShortestWork == double.MaxValue ? 0.0 : Math.Round(mStatistics.ShortestWork / 60000.0, 1);
                double max = mStatistics.LongestWork == double.MinValue ? -1.0 : Math.Round(mStatistics.LongestWork / 60000.0);
                double mean = Math.Round(mStatistics.MeanWorkLength / 60000.0, 1);

                row += "    <TR>" + Environment.NewLine;
                row += "        <TD>" + Name + "</TD>" + Environment.NewLine;
                row += "        <TD ALIGN=\"center\">" + mStatistics.TickCount + "</TD>" + Environment.NewLine;
                row += "        <TD ALIGN=\"center\">" + total.ToString("0.") + "</TD>" + Environment.NewLine;
                row += "        <TD ALIGN=\"center\">" + max.ToString("0.") + "</TD>" + Environment.NewLine;
                row += "        <TD ALIGN=\"center\">" + min.ToString("0.#") + "</TD>" + Environment.NewLine;
                row += "        <TD ALIGN=\"center\">" + mean.ToString("0.#") + "</TD>" + Environment.NewLine;
                row += "    </TR>" + Environment.NewLine;

                return row;
            }
        }

        /// <summary>
        /// Whether the state is currently active.
        /// </summary>
        public bool Active {
            get { return mActive; }
            set { 
                mActive = value;
                foreach (var transition in mTransitions.Values)
                    transition.Active = value;
                if (Manager.CurrentTransition == null)
                    foreach (var window in mWindowStates.Values)
                        window.Active = value;
                if (value) {
                    if (Manager.CurrentTransition == null)
                        TransitionToStart();
                    foreach (var man in Manager.OverlayManagers)
                        man.Opacity = mOpacity;
                    TransitionToFinish();
                    mManager.ControlPointers = mEnableCursor;
                    mStatistics.Begin();
                } else {
                    TransitionFromStart();
                    if (Manager.CurrentTransition == null)
                        FinishTransitionFrom();
                    mStatistics.End();
                }
            }
        }

        /// <summary>
        /// The manager which will coordiante the state.
        /// </summary>
        public OverlayPlugin Manager {
            get { return mManager; }
        }

        /// <summary>
        /// Add a new transition to another state.
        /// </summary>
        /// <param name="stateTransition">The new transition to add.</param>
        public void AddTransition(StateTransition stateTransition) {
            if (stateTransition.From != this)
                throw new ArgumentException("Error. " + stateTransition.Name + " does not start at " + Name + " so cannot be added as a transition from it.");
            //TODO - this is a hack and will break things. Need to decide on how to handle multiple triggers.
            //What happens if new transition needs to be drawn?
            if (mTransitions.ContainsKey(stateTransition.To.Name)) {
                mTransitions[stateTransition.To.Name].AddTriggers(stateTransition.Triggers);
            } else {
                mTransitions.Add(stateTransition.To.Name, stateTransition);
                if (stateTransition is IFeature)
                    AddFeature(stateTransition as IFeature);
            }
        }
        
        /// <summary>
        /// Add a feature to the be drawn on one of the windows for the state.
        /// </summary>
        /// <param name="window">The window to draw the feature on.</param>
        /// <param name="feature">The feature to draw.</param>
        public void AddFeature(IFeature feature) {
            this[feature.Frame].AddFeature(feature);
        }

        public virtual void Draw(Graphics graphics, Func<Vector3, Point> to2D, Action redraw, Perspective perspective) {
            foreach (var activeArea in WindowStates.
                Aggregate(new List<IDiagramDrawable>(), (l, w) => {
                    l.AddRange(w.Features.Where(f => f is IDiagramDrawable).Select(f => f as IDiagramDrawable));
                    return l;
                }))
                activeArea.Draw(graphics, to2D, redraw, perspective);
        }

        /// <summary>
        /// Create a window state for drawing this state to the specified window.
        /// </summary>
        /// <param name="window">The window the new window state is to draw on.</param>
        public virtual IFrameState CreateFrameState(FrameOverlayManager manager) {
            return new FrameState(manager);
        }

        public void StartTransitionTo() {
            foreach (var window in mWindowStates.Values)
                window.Active = true;
            TransitionToStart();
            if (!mEnableCursor)
                mManager.ControlPointers = false;
        }

        public void FinishTransitionFrom() {
            foreach (var window in mWindowStates.Values)
                window.Active = false;
            TransitionFromFinish();
        }

        /// <summary>
        /// Called before a transition to this state begins, set up any graphics that need to be in place before the transition begins.
        /// Will only be called if a tranisition was used to get to the state.
        /// </summary>
        protected abstract void TransitionToStart();

        /// <summary>
        /// Do any actions that need to be set as soon as the state is activated.
        /// Use this to make sure the overlay is set up as expected, e.g. set whether the camera should be controlled.
        /// </summary>
        protected abstract void TransitionToFinish();

        /// <summary>
        /// Do any actions that need to be when the state is de-activated.
        /// Use this to make sure the overlay is set up as expected, e.g. set whether the camera should be controlled.
        /// </summary>
        protected abstract void TransitionFromStart();

        /// <summary>
        /// Called after the transition away from this state has been finished. Finalize any graphics that needed to stay in place whilst the transition was going.
        /// Will only be called if a tranisition was used to get from the state.
        /// </summary>
        protected abstract void TransitionFromFinish();

        public override string ToString() {
            return mName;
        }
    }
}
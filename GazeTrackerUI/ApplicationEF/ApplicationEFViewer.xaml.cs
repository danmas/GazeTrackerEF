// <copyright file="VideoViewer.xaml.cs" company="ITU">
// ******************************************************
// GazeTrackingLibrary for ITU GazeTracker
// Copyright (C) 2010 Martin Tall  
// ------------------------------------------------------------------------
// This program is free software; you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the 
// Free Software Foundation; either version 3 of the License, 
// or (at your option) any later version.
// This program is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU 
// General Public License for more details.
// You should have received a copy of the GNU General Public License 
// along with this program; if not, see http://www.gnu.org/licenses/.
// **************************************************************
// </copyright>
// <author>Martin Tall</author>
// <email>info@martintall.com</email>

using System;
using System.Windows;
using System.Windows.Input;
using GazeTrackerUI.SettingsUI;
using GazeTrackerUI.Tools;
using GazeTrackingLibrary;
using GTCommons.Enum;
using GTSettings;

namespace GazeTrackerUI.ApplicationEF
{ 
    public partial class ApplicationEFViewer :  Window
    {
        #region Variables
        
        private static ApplicationEFViewer instance;

        #endregion

        #region Constructor

        private ApplicationEFViewer()
        {
            ComboBoxBackgroundColorFix.Initialize();
            InitializeComponent();
            menuBarIcons.IsDetachVideoVisible = false;
            RegisterForEvents();
        }


        private void RegisterForEvents()
        {
            Activated += WindowActivated;
            Deactivated += WindowDeactivated;
            SizeChanged += WindowSizeChanged;
        }

        #endregion //CONSTRUCTION

        #region Get/Set

        public static ApplicationEFViewer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ApplicationEFViewer();
                }

                return instance;
            }
        }

        public VideoModeEnum VideoMode
        {
            get { return Settings.Instance.Visualization.VideoMode; }
            set { Settings.Instance.Visualization.VideoMode = value; }
        }

        public bool HasBeenResized { get; set; }

        #endregion //PROPERTIES

        #region Public methods


        public void ShowWindow(int width, int height)
        {
            try
            {
                this.Show();    
            }
            catch (Exception)
            {

            }
        }

        #endregion //PUBLICMETHODS


        #region Private methods

        #region Window-events

        private void WindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Size prevSize = e.PreviousSize;
            Size newSize = e.NewSize;

            if (prevSize != newSize)
            {
//                videoImageControl.VideoImageWidth = Convert.ToInt32(newSize.Width - videoImageControl.Margin.Left - videoImageControl.Margin.Right);
//                videoImageControl.VideoImageHeight = Convert.ToInt32(newSize.Height - videoImageControl.Margin.Top - videoImageControl.Margin.Bottom);
//                videoImageControl.UpdateLayout();
            }
        }

        private void WindowActivated(object sender, EventArgs e)
        {
            // Rendering video when active/visible
//            if (WindowState.Equals(WindowState.Normal))
//                videoImageControl.Start();
        }

        private void WindowDeactivated(object sender, EventArgs e)
        {
            Console.WriteLine(" !!!!!!!!!!!!! ApplicationEFViewer WindowDeactivated");
        }

        private void WindowHide(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine(" !!!!!!!!!!!!! ApplicationEFViewer WindowHide");
            this.Hide();
        }

        #endregion

        #region DragWindow

        /// <summary>
        /// Enters the move window.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void EnterMoveWindow(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Exits the move window.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        private void ExitMoveWindow(object sender, RoutedEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// Drags the window.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The <see cref="System.Windows.Input.MouseButtonEventArgs"/> instance containing the event data.</param>
        private void DragWindow(object sender, MouseButtonEventArgs args)
        {
            DragMove();
        }

        #endregion

        #endregion //PRIVATEMETHODS
    }
}
﻿#pragma checksum "C:\Users\Zach\documents\visual studio 2010\Projects\RedditProfilerForWindowsPhone\RedditProfilerForWindowsPhone\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4830571A65066198FACC65474502EDCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RedditProfilerForWindowsPhone {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.VisualStateGroup StalkState;
        
        internal System.Windows.VisualState Outside;
        
        internal System.Windows.VisualState Inside;
        
        internal System.Windows.VisualStateGroup DataFetchState;
        
        internal System.Windows.VisualState Downloaded;
        
        internal System.Windows.VisualState Downloading;
        
        internal System.Windows.Controls.ProgressBar ProgressBar;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel StalkTarget;
        
        internal System.Windows.Controls.Border subredditListBorder;
        
        internal System.Windows.Controls.ListBox SubredditList;
        
        internal System.Windows.Controls.ListBox DetailedList;
        
        internal System.Windows.Controls.StackPanel InsideStackPanel;
        
        internal System.Windows.Controls.Button ResetButton;
        
        internal System.Windows.Controls.Button GoDeeperButton;
        
        internal System.Windows.Controls.StackPanel OutsideStackPanel;
        
        internal System.Windows.Controls.TextBox userName;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RedditProfilerForWindowsPhone;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.StalkState = ((System.Windows.VisualStateGroup)(this.FindName("StalkState")));
            this.Outside = ((System.Windows.VisualState)(this.FindName("Outside")));
            this.Inside = ((System.Windows.VisualState)(this.FindName("Inside")));
            this.DataFetchState = ((System.Windows.VisualStateGroup)(this.FindName("DataFetchState")));
            this.Downloaded = ((System.Windows.VisualState)(this.FindName("Downloaded")));
            this.Downloading = ((System.Windows.VisualState)(this.FindName("Downloading")));
            this.ProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("ProgressBar")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.StalkTarget = ((System.Windows.Controls.StackPanel)(this.FindName("StalkTarget")));
            this.subredditListBorder = ((System.Windows.Controls.Border)(this.FindName("subredditListBorder")));
            this.SubredditList = ((System.Windows.Controls.ListBox)(this.FindName("SubredditList")));
            this.DetailedList = ((System.Windows.Controls.ListBox)(this.FindName("DetailedList")));
            this.InsideStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("InsideStackPanel")));
            this.ResetButton = ((System.Windows.Controls.Button)(this.FindName("ResetButton")));
            this.GoDeeperButton = ((System.Windows.Controls.Button)(this.FindName("GoDeeperButton")));
            this.OutsideStackPanel = ((System.Windows.Controls.StackPanel)(this.FindName("OutsideStackPanel")));
            this.userName = ((System.Windows.Controls.TextBox)(this.FindName("userName")));
        }
    }
}


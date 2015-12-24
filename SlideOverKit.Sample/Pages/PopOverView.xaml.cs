﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SlideOverKit.Sample
{
    public partial class PopOverView : SlideMenuView
    {
        public const int iOSTopMargin = 100;
        public const int AndroidTopMargin = 30;
        public const int WinPHoneTopMargin = 100;

        public PopOverView ()
        {
            InitializeComponent ();
            this.BackgroundColor = Color.White;

            // In this case, you must set both LeftMargin and TopMarin
            this.LeftMargin = 10;

            // In some small screen Android devices, the menu cannot be layout with full size.
            // In this case, we just set LeftMargin and TopMargin,
            // you do not need to set the HeightRequest or WidthRequest, as they are no effect in Pop up View.
            // If the view is too small for Android devices, we can reduce the TopMargin.
            this.TopMargin = Device.OnPlatform<int> (iOSTopMargin, AndroidTopMargin, WinPHoneTopMargin);

            // We can set the PopUpView coming directions.
            this.MenuOrientations = MenuOrientation.PopUpViewFromBottom;

            // The menu will hide without animation, 
            // If you want to have the animation, you can call the MenuContainerPage.HideMenu(), 
            // But you cannot call it from this View, cause of cycle references, you can sent a message to ContainerPage
            DoneButton.Clicked += (object sender, EventArgs e) => {
                this.HideWithoutAnimations ();
            };
        }
    }
}


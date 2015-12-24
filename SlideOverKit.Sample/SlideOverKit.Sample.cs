﻿using System;

using Xamarin.Forms;

namespace SlideOverKit.Sample
{
    public class App : Application
    {
        public App ()
        {
            MainPage = new NavigationPage (new SlideOverKit.Sample.MainPage ()){ Title = "Main Page" };
            MessagingCenter.Subscribe<SlideOverKit.Sample.QuickInnerMenuPage> (this, "GoBackToMainPage", (m) => {
                Device.BeginInvokeOnMainThread (() => {                    
                    MainPage = new NavigationPage (new SlideOverKit.Sample.MainPage ()){ Title = "Main Page" };
                });
            });
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}


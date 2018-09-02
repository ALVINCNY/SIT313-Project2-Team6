﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamCnblogs.Portable.Interfaces;

namespace XamCnblogs.UI.Controls
{
    public class XamNavigationPage : NavigationPage
    {
        // Press the back key timestamp for the first time
        private DateTime firstBackPressedTime = DateTime.MinValue;
        public XamNavigationPage(Page root) : base(root)
        {
            Init();
            Title = root.Title;
            Icon = root.Icon;
        }

        public XamNavigationPage()
        {
            Init();
        }

        void Init()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                BarBackgroundColor = (Color)Application.Current.Resources["NavigationText"];
            }
        }

        protected override bool OnBackButtonPressed()
        {
            if (Device.RuntimePlatform == Device.Android && this.RootPage == this.CurrentPage)
            {
                var rootpage = this.RootPage as Pages.Android.RootPage;
                if (rootpage != null && rootpage.SelectedSearch)
                {
                    rootpage.SelectedSearch = false;
                    return true;
                }
                if (firstBackPressedTime == DateTime.MinValue || firstBackPressedTime.AddSeconds(3) < DateTime.Now)
                {
                    DependencyService.Get<IToast>().SendToast("Press again to exit the program");
                    firstBackPressedTime = DateTime.Now;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return base.OnBackButtonPressed();
        }
    }
}

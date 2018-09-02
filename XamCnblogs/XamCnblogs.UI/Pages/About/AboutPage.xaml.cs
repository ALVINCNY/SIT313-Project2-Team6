﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamCnblogs.Portable.Interfaces;
using XamCnblogs.Portable.ViewModel;

namespace XamCnblogs.UI.Pages.About
{
    public partial class AboutPage : ContentPage
    {
        AboutViewModel vm;
        public AboutPage()
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.iOSSpecific.Page.SetUseSafeArea(this, true);
            BindingContext = vm = new AboutViewModel();

            if (Device.Android == Device.RuntimePlatform)
            {
                var cancel = new ToolbarItem
                {
                    Text = "Share",
                    Command = new Command(() =>
                    {
                        DependencyService.Get<IShares>().Shares("https://github.com/JoesWeek/XamCnblogs", "Group Six make for CnBlogs");
                    }),
                    Icon = "toolbar_share.png"
                };
                ToolbarItems.Add(cancel);
            }

            this.VersionName.Text = VersionTracking.CurrentVersion;
        }
    }
}
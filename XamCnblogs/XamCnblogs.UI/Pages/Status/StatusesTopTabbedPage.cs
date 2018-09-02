using Naxam.Controls.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamCnblogs.UI.Pages.Status
{
    public class StatusesTopTabbedPage : TopTabbedPage
    {
        public StatusesTopTabbedPage()
        {
            if (Device.iOS == Device.RuntimePlatform)
            {
                BarTextColor = (Color)Application.Current.Resources["PrimaryText"];
                BarIndicatorColor = (Color)Application.Current.Resources["SecondaryText"];
                BarBackgroundColor = (Color)Application.Current.Resources["NavigationText"];
            }
            else
            {
                BarTextColor = (Color)Application.Current.Resources["NavigationText"];
                BarIndicatorColor = (Color)Application.Current.Resources["Divider"];
                BarBackgroundColor = (Color)Application.Current.Resources["Primary"];
            }
            Title = "Quick Mark";
            Icon = "menu_statuses.png";
            
            this.Children.Add(new StatusesPage() { Title = "Full Site" });
            this.Children.Add(new StatusesPage(1) { Title = "Attention" });
            this.Children.Add(new StatusesPage(2) { Title = "Mine" });
            this.Children.Add(new StatusesPage(3) { Title = "My respond" });
            this.Children.Add(new StatusesPage(6) { Title = "Apply me" });
        }
    }
}

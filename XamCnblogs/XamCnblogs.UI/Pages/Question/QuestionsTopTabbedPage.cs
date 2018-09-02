using Naxam.Controls.Forms;
using System;
using Xamarin.Forms;
using XamCnblogs.Portable.Helpers;
using XamCnblogs.Portable.Model;
using XamCnblogs.UI.Pages.Account;

namespace XamCnblogs.UI.Pages.Question
{
    public class QuestionsTopTabbedPage : TopTabbedPage
    {
        public QuestionsTopTabbedPage()
        {
            Title = "Questions";
            Icon = "menu_question.png";
            
            this.Children.Add(new QuestionsPage() { Title = "need solved" });
            this.Children.Add(new QuestionsPage(1) { Title = "High score" });
            this.Children.Add(new QuestionsPage(2) { Title = "No answer" });
            this.Children.Add(new QuestionsPage(3) { Title = "solved" });
            this.Children.Add(new QuestionsPage(4) { Title = "My question" });

            if (Device.iOS == Device.RuntimePlatform)
            {
                BarTextColor = (Color)Application.Current.Resources["PrimaryText"];
                BarIndicatorColor = (Color)Application.Current.Resources["SecondaryText"];
                BarBackgroundColor = (Color)Application.Current.Resources["NavigationText"];

                var cancel = new ToolbarItem
                {
                    Text = "Search",
                    Command = new Command(async () =>
                    {
                        await NavigationService.PushAsync(Navigation, new QuestionsSearchPage());
                    }),
                    Icon = "toolbar_search.png"
                };
                ToolbarItems.Add(cancel);
            }
            else {
                BarTextColor = (Color)Application.Current.Resources["NavigationText"];
                BarIndicatorColor = (Color)Application.Current.Resources["Divider"];
                BarBackgroundColor = (Color)Application.Current.Resources["Primary"];
            }
        }
    }
}

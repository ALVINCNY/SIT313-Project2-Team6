using FFImageLoading.Transformations;
using FormsToolkit;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamCnblogs.Portable.Helpers;
using XamCnblogs.Portable.Interfaces;
using XamCnblogs.UI.Pages.About;

namespace XamCnblogs.UI.Pages.Account
{
    public partial class AccountPage : ContentPage
    {
        public AccountPage()
        {
            InitializeComponent();
            Title = "Me";
            Icon = "menu_avatar.png";

            ffimageloading.Transformations.Add(new CircleTransformation());
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            UpdateUser();
        }
        void UpdateUser()
        {
            if (UserTokenSettings.Current.HasExpiresIn())
            {
                this.UserName.IsVisible = false;
                this.UserSeniority.IsVisible = false;
                this.LogoutLayout.IsVisible = false;
                this.Login.IsVisible = true;

                this.ffimageloading.Source = "avatar_placeholder.png";
                this.UserName.Text = "";
                this.UserSeniority.Text = "";
            }
            else
            {
                this.UserName.IsVisible = true;
                this.UserSeniority.IsVisible = true;
                this.LogoutLayout.IsVisible = true;
                this.Login.IsVisible = false;

                this.ffimageloading.Source = UserSettings.Current.Avatar;
                this.UserName.Text = UserSettings.Current.DisplayName;
                this.UserSeniority.Text = "Registration time：" + UserSettings.Current.Seniority;
            }
        }
        void OnLogin(object sender, EventArgs args)
        {
            if (UserTokenSettings.Current.HasExpiresIn())
            {
                MessagingService.Current.SendMessage(MessageKeys.NavigateLogin);
            }
        }
        void OnLogout(object sender, EventArgs args)
        {
            //LogOut
            if (!UserTokenSettings.Current.HasExpiresIn())
            {
                UserSettings.Current.UpdateUser(new Portable.Model.User());
                UserTokenSettings.Current.UpdateUserToken(new Portable.Model.Token() { ExpiresIn = 0 });

                UpdateUser();
            }
        }
        void OnBlog(object sender, EventArgs args)
        {
            if (UserTokenSettings.Current.HasExpiresIn())
            {
                MessagingService.Current.SendMessage(MessageKeys.NavigateLogin);
            }
            else
            {
                Navigation.PushAsync(new ArticlesPage(UserSettings.Current.BlogApp));
            }
        }

        //Setting  BookMarks
        void OnBookmarks(object sender, EventArgs args)
        {
            if (UserTokenSettings.Current.HasExpiresIn())
            {
                MessagingService.Current.SendMessage(MessageKeys.NavigateLogin);
            }
            else
            {
                Navigation.PushAsync(new BookmarksPage());
            }
        }
        void OnSetting(object sender, EventArgs args)
        {
            Navigation.PushAsync(new SettingPage());
        }
        void OnAbout(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AboutPage());
        }
        async void OnEmail(object sender, EventArgs args)
        {
            try
            {
                var message = new EmailMessage
                {
                    Subject =$"From XamCnblogs's Client  -{ VersionTracking.CurrentVersion} ",
                    Body = "",
                    To = new System.Collections.Generic.List<string>() { "614047512@qq.com" }
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException)
            {
                DependencyService.Get<IToast>().SendToast("No email client in your phone");
            }
            catch (Exception)
            {
                DependencyService.Get<IToast>().SendToast("No email client in your phone");
            }
        }
    }
}
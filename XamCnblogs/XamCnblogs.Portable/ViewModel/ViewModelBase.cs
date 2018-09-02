﻿using MvvmHelpers;
using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using XamCnblogs.Portable.Helpers;
using XamCnblogs.Portable.Interfaces;
using XamCnblogs.Portable.Services;

namespace XamCnblogs.Portable.ViewModel
{
    public class ViewModelBase : BaseViewModel
    {
        protected INavigation Navigation { get; }

        public ViewModelBase(INavigation navigation = null)
        {
            Navigation = navigation;
        }

        public static void Init()
        {
            DependencyService.Register<IStoreManager, StoreManager>();
            DependencyService.Register<IArticlesService, ArticlesService>();
            DependencyService.Register<IArticlesDetailsService, ArticlesDetailsService>();
            DependencyService.Register<INewsService, NewsService>();
            DependencyService.Register<INewsDetailsService, NewsDetailsService>();
            DependencyService.Register<IKbArticlesService, KbArticlesService>();
            DependencyService.Register<IKbArticlesDetailsService, KbArticlesDetailsService>();
            DependencyService.Register<IStatusesService, StatusesService>();
            DependencyService.Register<IStatusesCommentService, StatusesCommentService>();
            DependencyService.Register<IQuestionsService, QuestionsService>();
            DependencyService.Register<IQuestionsDetailsService, QuestionsDetailsService>();
            DependencyService.Register<IAnswersDetailsService, AnswersDetailsService>();
            DependencyService.Register<IBlogsService, BlogsService>();
            DependencyService.Register<IBookmarksService, BookmarksService>();
            DependencyService.Register<ISearchService, SearchService>();
        }

        public AccessTokenSettings Settings
        {
            get { return AccessTokenSettings.Current; }
        }

        protected IStoreManager StoreManager { get; } = DependencyService.Get<IStoreManager>();
        protected IToast Toast { get; } = DependencyService.Get<IToast>();
        protected IShares Shares { get; } = DependencyService.Get<IShares>();
        public IHtmlTemplate HtmlTemplate { get; } = DependencyService.Get<IHtmlTemplate>();

        ICommand launchBrowserCommand;
        public ICommand LaunchBrowserCommand =>
        launchBrowserCommand ?? (launchBrowserCommand = new Command<string>(async (t) =>
        {
            if (IsBusy)
                return;
            await ExecuteLaunchBrowserAsync(t);
        }));

        public async static Task ExecuteLaunchBrowserAsync(string uri)
        {
            if (!uri.StartsWith("http://", StringComparison.OrdinalIgnoreCase) && !uri.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
                uri = "http://" + uri;

            var lower = uri.ToLowerInvariant();

            try
            {
                await Browser.OpenAsync(uri, BrowserLaunchType.SystemPreferred);
            }
            catch
            {
            }
        }
    }
}

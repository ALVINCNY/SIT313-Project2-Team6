﻿using Naxam.Controls.Forms;
using System;
using Xamarin.Forms;

namespace XamCnblogs.UI.Pages.Search
{
    public class SearchPage : TopTabbedPage
    {
        string searchValue = "";
        public SearchPage()
        {
            BarTextColor = (Color)Application.Current.Resources["NavigationText"];
            BarIndicatorColor = (Color)Application.Current.Resources["Divider"];
            BarBackgroundColor = (Color)Application.Current.Resources["Primary"];

            var articles = new ArticlesSearchPage() { Title = "Blog" };
            var news = new NewsSearchPage() { Title = "News" };
            var kbArticles = new KbArticlesSearchPage() { Title = "Knowledge base" };
            var questions = new QuestionsSearchPage() { Title = "Questions" };
            this.Children.Add(articles);
            this.Children.Add(news);
            this.Children.Add(kbArticles);
            this.Children.Add(questions);

            this.SearchChanged += delegate (object sender, SearchChangedEventArgs e)
            {
                searchValue = e.Value;
                Search(searchValue);
            };
            this.CurrentPageChanged += delegate (object sender, EventArgs e)
            {
                Search(searchValue);
            };
        }
        void Search(string value)
        {
            (this.CurrentPage as BaseSearchPage).Search(value);
        }
        public void OnSearchChanged(SearchChangedEventArgs e)
        {
            SearchChanged?.Invoke(this, e);
        }

        public event OnSearchChangedEventHandler SearchChanged;
    }
    public class SearchChangedEventArgs : EventArgs
    {
        public string Value { get; set; }
    }
    public delegate void OnSearchChangedEventHandler(object sender, SearchChangedEventArgs e);

}

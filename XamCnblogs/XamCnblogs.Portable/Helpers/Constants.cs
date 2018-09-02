namespace XamCnblogs.Portable.Helpers
{
    public static class MessageKeys
    {
        public const string NavigateLogin = "navigate_login";
        public const string NavigateToken = "navigate_token";
        public const string NavigateAccount = "navigate_account";
        public const string NavigateNotification = "navigate_notification";
    }
    public static class HtmlTemplate
    {
        public static string GetScoreName(int score)
        {
            if (score > 100000)
            {
                return "Level 9";
            }
            if (score > 50000)
            {
                return "Level 8";
            }
            if (score > 20000)
            {
                return "Level 7";
            }
            if (score > 10000)
            {
                return "Level 6";
            }
            if (score > 5000)
            {
                return "Level 5";
            }
            if (score > 2000)
            {
                return "Level 4";
            }
            if (score > 500)
            {
                return "Level 3";
            }
            if (score > 200)
            {
                return "Level 2";
            }
            return "Level 1";
        }
    }

    public enum LoadMoreStatus
    {
        StausDefault = 0,
        StausLoading = 1,
        StausNodata = 2,
        StausEnd = 3,
        StausFail = 4,
        StausError = 5,
        StausNologin = 6
    }
}

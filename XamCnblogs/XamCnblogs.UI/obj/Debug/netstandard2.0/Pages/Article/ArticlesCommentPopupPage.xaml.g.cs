//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("XamCnblogs.UI.Pages.Article.ArticlesCommentPopupPage.xaml", "Pages/Article/ArticlesCommentPopupPage.xaml", typeof(global::XamCnblogs.UI.Pages.Article.ArticlesCommentPopupPage))]

namespace XamCnblogs.UI.Pages.Article {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\Article\\ArticlesCommentPopupPage.xaml")]
    public partial class ArticlesCommentPopupPage : global::Rg.Plugins.Popup.Pages.PopupPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamCnblogs.UI.Controls.CommentEditor Comment;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamCnblogs.UI.Controls.ActivityIndicatorButton SendButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(ArticlesCommentPopupPage));
            Comment = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamCnblogs.UI.Controls.CommentEditor>(this, "Comment");
            SendButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamCnblogs.UI.Controls.ActivityIndicatorButton>(this, "SendButton");
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("XamCnblogs.UI.Pages.Status.StatusesCommentPopupPage.xaml", "Pages/Status/StatusesCommentPopupPage.xaml", typeof(global::XamCnblogs.UI.Pages.New.StatusesCommentPopupPage))]

namespace XamCnblogs.UI.Pages.New {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("Pages\\Status\\StatusesCommentPopupPage.xaml")]
    public partial class StatusesCommentPopupPage : global::Rg.Plugins.Popup.Pages.PopupPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamCnblogs.UI.Controls.CommentEditor Comment;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::XamCnblogs.UI.Controls.ActivityIndicatorButton SendButton;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(StatusesCommentPopupPage));
            Comment = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamCnblogs.UI.Controls.CommentEditor>(this, "Comment");
            SendButton = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::XamCnblogs.UI.Controls.ActivityIndicatorButton>(this, "SendButton");
        }
    }
}

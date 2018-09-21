using XamCnblogs.Portable.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCnblogs.Portable.Interfaces
{

    public interface IAnswersDetailsService
    {
        Task<ResponseMessage> GetCommentAsync(int id);
        Task<ResponseMessage> PostCommentAsync(int questionId, int answerId, string content);
        Task<ResponseMessage> EditCommentAsync(int questionId, int answerId, int commentId, int userId, string content);
        Task<ResponseMessage> DeleteCommentAsync(int questionId, int answerId, int commentId); 
    }
    public interface IArticlesDetailsService
    {
        Task<ResponseMessage> GetArticlesAsync(int id);
        Task<ResponseMessage> GetCommentAsync(string blogApp, int id, int pageIndex = 1, int pageSize = 20);
        Task<ResponseMessage> PostCommentAsync(string blogApp, int id, string content);
    }
    public interface IArticlesService
    {
        Task<ResponseMessage> GetArticlesAsync(int position, int pageIndex = 1, int pageSize = 20);
    }
    public interface IBlogsService
    {
        Task<ResponseMessage> GetArticlesAsync(string blogApp, int pageIndex = 1, int pageSize = 20);
    }
    public interface IBookmarksService
    {
        Task<ResponseMessage> GetBookmarksAsync(int pageIndex = 1, int pageSize = 20);
        Task<ResponseMessage> EditBookmarkAsync(Bookmarks bookmarks);
        Task<ResponseMessage> DeleteBookmarkAsync(int id);
    }
    public interface IHtmlTemplate
    {
        string GetArticlesTemplate();
        string GetKbArticlesTemplate();
        string GetNewsTemplate();
        string GetQuestionsTemplate();
        string GetAnswersTemplate();
        string GetStatusesTemplate();
    }
}

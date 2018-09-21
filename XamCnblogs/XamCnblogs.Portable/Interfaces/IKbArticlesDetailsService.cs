using XamCnblogs.Portable.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCnblogs.Portable.Interfaces
{
    public interface IKbArticlesDetailsService
    {
        Task<ResponseMessage> GetKbArticlesAsync(int id);
    }
    public interface IKbArticlesService
    {
        Task<ResponseMessage> GetKbArticlesAsync(int pageIndex = 1, int pageSize = 20);
    }
    public interface INewsDetailsService
    {
        Task<ResponseMessage> GetNewsAsync(int id);
        Task<ResponseMessage> GetCommentAsync(int id, int pageIndex, int pageSize);
        Task<ResponseMessage> PostCommentAsync(int id, string content, bool hasEdit = false);
        Task<ResponseMessage> DeleteCommentAsync(int id);
    }
    public interface INewsService
    {
        Task<ResponseMessage> GetNewsAsync(int position, int pageIndex = 1, int pageSize = 20);
    }
    public interface IShares
    {
        void Shares(string url, string title);
        void SharesIcon(string url, string title, object icon);
    }

    public interface IStatusesCommentService
    {
        Task<ResponseMessage> GetCommentsAsync(int id);
        Task<ResponseMessage> PostCommentAsync(int id, string content);
        Task<ResponseMessage> DeleteCommentAsync(int statusId, int id);
    }
    
}

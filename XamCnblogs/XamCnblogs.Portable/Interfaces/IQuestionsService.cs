using XamCnblogs.Portable.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace XamCnblogs.Portable.Interfaces
{
    public interface IQuestionsDetailsService
    {
        Task<ResponseMessage> GetQuestionsAsync(int id);
        Task<ResponseMessage> GetAnswersAsync(int id, int pageIndex, int pageSize);
        Task<ResponseMessage> PostAnswerAsync(int id, string content);
        Task<ResponseMessage> EditAnswerAsync(int questionId, int answerId, int userId, string content);
        Task<ResponseMessage> DeleteAnswerAsync(int questionId, int answerId);
    }
    public interface IQuestionsService
    {
        Task<ResponseMessage> GetQuestionsAsync(int position, int pageIndex = 1, int pageSize = 20);
        Task<ResponseMessage> EditQuestionsAsync(Questions questions);
    }
    public interface ISearchService
    {
        Task<ResponseMessage> GetSearchAsync(int position, string keyWords, int pageIndex = 1, int pageSize = 20);
    }
}

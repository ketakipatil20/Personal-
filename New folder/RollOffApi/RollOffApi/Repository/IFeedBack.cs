using System.Threading.Tasks;

namespace RollOffApi.Repository
{
    public interface IFeedBack
    {
        Task<FeedbackForm> AddFeedbackAsync(FeedbackForm feedback);
    }
}

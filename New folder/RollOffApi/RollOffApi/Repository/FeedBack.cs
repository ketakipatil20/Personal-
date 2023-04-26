using System.Threading.Tasks;

namespace RollOffApi.Repository
{
    public class FeedBack:IFeedBack
    {
        private readonly casestudyContext context;
        public FeedBack(casestudyContext context)
        {
            this.context = context;
        }
        #region AddFeedbackAsync
        public async Task<FeedbackForm> AddFeedbackAsync(FeedbackForm feedback)
        {
            await context.AddAsync(feedback);
            await context.SaveChangesAsync();
            return feedback;
        }
        #endregion
    }
}


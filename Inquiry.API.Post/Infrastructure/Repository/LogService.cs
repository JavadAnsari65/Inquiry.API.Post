using Inquiry.API.Post.Infrastructure.Configuration;
using Inquiry.API.Post.Infrastructure.Entities;

namespace Inquiry.API.Post.Infrastructure.Repository
{
    public class LogService
    {
        private readonly InquiryPostContext _dbContext;

        public LogService(InquiryPostContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void LogAction(string actionName, string requestData, string responseData, string errorMessage = null)
        {
            var logEntry = new ActionLog
            {
                ActionName = actionName,
                RequestData = requestData,
                ResponseData = responseData,
                ErrorMessage = errorMessage
            };

            _dbContext.ActionLogs.Add(logEntry);
            _dbContext.SaveChanges();
        }
    }

}

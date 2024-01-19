namespace Inquiry.API.Post.Infrastructure.Entities
{
    public class ActionLog
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
        public string ActionName { get; set; }
        public string RequestData { get; set; }
        public string ResponseData { get; set; }
        public string ErrorMessage { get; set; }
    }
}

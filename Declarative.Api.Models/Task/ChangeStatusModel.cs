namespace Declarative.Api.Models.Task
{
    public class ChangeStatusModel
    {
        public string Id { get; set; }
        public string Status { get; set; }
        public string UserId { get; set; }
        public DateTime Updated { get; set; }
    }
}

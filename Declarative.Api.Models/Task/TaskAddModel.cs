namespace Declarative.Api.Models.Task
{
    public class TaskAddModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }
        public DateTime DeadLine { get; set; }
    }
}

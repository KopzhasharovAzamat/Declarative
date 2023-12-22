namespace Declarative.Api.Models.Task
{
    public class TaskAddModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public int Status { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Priority { get; set; }
    }
}

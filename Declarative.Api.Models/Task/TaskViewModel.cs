namespace Declarative.Api.Models.Task
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Priority {  get; set; }

    }
}

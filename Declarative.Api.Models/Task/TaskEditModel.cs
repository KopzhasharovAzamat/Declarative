namespace Declarative.Api.Models.Task
{
    public class TaskEditModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public int Priority { get; set; }
    }
}

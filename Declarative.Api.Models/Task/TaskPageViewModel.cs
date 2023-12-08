namespace Declarative.Api.Models.Task
{
    public class TaskPageViewModel
    {
        public IEnumerable<TaskViewModel> Tasks { get; set; }
        public int TotalTasks {  get; set; }
    }
}

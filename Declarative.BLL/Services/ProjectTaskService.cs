using Declarative.Api.Models.Task;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;

namespace Declarative.BLL.Services
{
    public class ProjectTaskService : IProjectTaskService
    {
        private readonly IProjectTaskRepository<ProjectTask> _projectTaskRepository;
        public ProjectTaskService(IProjectTaskRepository<ProjectTask> projectTaskRepository)
        {
            _projectTaskRepository = projectTaskRepository;
        }
        public IEnumerable<TaskViewModel> GetAll()
        {
            return _projectTaskRepository.GetAll();
        }
        public TaskViewModel GetById(int id)
        {
            return _projectTaskRepository.GetById(id);
        }
        public void Create(TaskAddModel projectTask)
        {
            var taskEntity = new ProjectTask { Name = projectTask.Name};
            _projectTaskRepository.Create(taskEntity);
        }
        public void Update(TaskEditModel projectTask)
        {
            var taskEntity = new ProjectTask { Name = projectTask.Name };
            _projectTaskRepository.Update(taskEntity);
        }
        public void Delete(int id)
        {
            _projectTaskRepository.Delete(id);
        }
    }
}

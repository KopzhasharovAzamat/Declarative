using AutoMapper;
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
        private readonly IMapper _mapper;
        public ProjectTaskService(IProjectTaskRepository<ProjectTask> projectTaskRepository, IMapper mapper)
        {
            _projectTaskRepository = projectTaskRepository;
            _mapper = mapper;
        }
        public IEnumerable<TaskViewModel> GetAll()
        {
            var projectTasks = _projectTaskRepository.GetAll();
            return _mapper.Map<IEnumerable<TaskViewModel>>(projectTasks);
        }
        public TaskViewModel GetById(int id)
        {
            var projectTaskEntity = _projectTaskRepository.GetById(id);
            return _mapper.Map<TaskViewModel>(projectTaskEntity);
        }
        public void Create(TaskAddModel projectTask)
        {
            var taskEntity = _mapper.Map<ProjectTask>(projectTask);
            _projectTaskRepository.Create(taskEntity);
        }
        public void Update(TaskEditModel projectTask)
        {
            var taskEntity = _mapper.Map<ProjectTask>(projectTask);
            _projectTaskRepository.Update(taskEntity);
        }
        public void Delete(int id)
        {
            _projectTaskRepository.Delete(id);
        }
    }
}

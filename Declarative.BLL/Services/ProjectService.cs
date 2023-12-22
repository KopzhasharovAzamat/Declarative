using AutoMapper;
using Declarative.Api.Models.Project;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;

namespace Declarative.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository<Project> _projectRepository;
        private readonly IMapper _mapper;
        public ProjectService(IProjectRepository<Project> projectRepository, IMapper mapper)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProjectViewModel> GetAll()
        {
            var projects = _projectRepository.GetAll();
            return _mapper.Map<IEnumerable<ProjectViewModel>>(projects);
        }
        public ProjectViewModel GetById(int id)
        {
            var projectEntity = _projectRepository.GetById(id);
            return _mapper.Map<ProjectViewModel>(projectEntity);
        }
        public void Create(ProjectAddModel project)
        {
            var projectEntity = _mapper.Map<Project>(project);
            _projectRepository.Create(projectEntity);
        }
        public void Update(ProjectEditModel project)
        {
            var projectEntity = _mapper.Map<Project>(project);
            _projectRepository.Update(projectEntity);
        }
        public void Delete(int id)
        {
            _projectRepository.Delete(id);
        }
    }
}

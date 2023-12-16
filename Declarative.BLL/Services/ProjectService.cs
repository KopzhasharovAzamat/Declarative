using Declarative.Api.Models.Project;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;

namespace Declarative.BLL.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository<Project> _projectRepository;
        public ProjectService(IProjectRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }
        public IEnumerable<ProjectViewModel> GetAll()
        {
            return _projectRepository.GetAll();
        }
        public ProjectViewModel GetById(int id)
        {
            return _projectRepository.GetById(id);
        }
        public void Create(ProjectAddModel project)
        {
            var projectEntity = new Project { Name = project.Name };
            _projectRepository.Create(projectEntity);
        }
        public void Update(ProjectEditModel project)
        {
            var projectEntity = new Project { Name = project.Name };
            _projectRepository.Update(projectEntity);
        }
        public void Delete(int id)
        {
            _projectRepository.Delete(id);
        }
    }
}

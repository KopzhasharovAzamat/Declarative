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
    }
}

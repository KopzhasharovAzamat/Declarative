using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;

namespace Declarative.BLL.Services
{
    public class ProjectLeaderService : IProjectLeaderService
    {
        private readonly IProjectLeaderRepository<ProjectLeader> _ProjectLeaderRepository;
        public ProjectLeaderService(IProjectLeaderRepository<ProjectLeader> ProjectLeaderRepository)
        {
            _ProjectLeaderRepository = ProjectLeaderRepository;
        }
    }
}

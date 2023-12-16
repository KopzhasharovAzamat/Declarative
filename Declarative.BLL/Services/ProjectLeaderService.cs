using Declarative.Api.Models.ProjectLeader;
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
        public IEnumerable<ProjectLeaderViewModel> GetAll()
        {
            return _ProjectLeaderRepository.GetAll();
        }
        public ProjectLeaderViewModel GetById(int id)
        {
            return _ProjectLeaderRepository.GetById(id);
        }
        public void Create(ProjectLeaderAddModel projectLeader)
        {
            var projectLeaderEntity = new ProjectLeader { FirstName = projectLeader.Name, LastName = projectLeader.Name };
            _ProjectLeaderRepository.Create(projectLeaderEntity);
        }
        public void Update(ProjectLeaderEditModel projectLeader)
        {
            var projectLeaderEntity = new ProjectLeader { FirstName = projectLeader.Name, LastName= projectLeader.Name };
            _ProjectLeaderRepository.Update(projectLeaderEntity);
        }
        public void Delete(int id)
        {
            _ProjectLeaderRepository.Delete(id);
        }
    }
}

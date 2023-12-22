using AutoMapper;
using Declarative.Api.Models.ProjectLeader;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;

namespace Declarative.BLL.Services
{
    public class ProjectLeaderService : IProjectLeaderService
    {
        private readonly IProjectLeaderRepository<ProjectLeader> _ProjectLeaderRepository;
        private readonly IMapper _mapper;
        public ProjectLeaderService(IProjectLeaderRepository<ProjectLeader> ProjectLeaderRepository, IMapper mapper)
        {
            _ProjectLeaderRepository = ProjectLeaderRepository;
            _mapper = mapper;
        }
        public IEnumerable<ProjectLeaderViewModel> GetAll()
        {
            var projectLeaders = _ProjectLeaderRepository.GetAll();
            return _mapper.Map<IEnumerable<ProjectLeaderViewModel>>(projectLeaders);
        }
        public ProjectLeaderViewModel GetById(int id)
        {
            var projectLeaderEntity = _ProjectLeaderRepository.GetById(id);
            return _mapper.Map<ProjectLeaderViewModel>(projectLeaderEntity);
        }
        public void Create(ProjectLeaderAddModel projectLeader)
        {
            var projectLeaderEntity = _mapper.Map<ProjectLeader>(projectLeader);
            _ProjectLeaderRepository.Create(projectLeaderEntity);
        }
        public void Update(ProjectLeaderEditModel projectLeader)
        {
            var projectLeaderEntity = _mapper.Map<ProjectLeader>(projectLeader);
            _ProjectLeaderRepository.Update(projectLeaderEntity);
        }
        public void Delete(int id)
        {
            _ProjectLeaderRepository.Delete(id);
        }
    }
}

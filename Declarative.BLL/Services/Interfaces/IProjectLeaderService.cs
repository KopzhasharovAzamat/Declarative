using Declarative.Api.Models.ProjectLeader;
using Declarative.DAL.Entities;

namespace Declarative.BLL.Services.Interfaces
{
    public interface IProjectLeaderService
    {
        IEnumerable<ProjectLeaderViewModel> GetAll();
        ProjectLeaderViewModel GetById(int id);
        void Create(ProjectLeaderAddModel item);
        void Update(ProjectLeaderEditModel item);
        void Delete(int id);
    }
}
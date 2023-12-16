using Declarative.Api.Models.Project;
using Declarative.DAL.Entities;

namespace Declarative.BLL.Services.Interfaces
{
    public interface IProjectService
    {
        IEnumerable<ProjectViewModel> GetAll();
        ProjectViewModel GetById(int id);
        void Create(ProjectAddModel item);
        void Update(ProjectEditModel item);
        void Delete(int id);
    }
}

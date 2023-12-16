using Declarative.Api.Models.Task;
using Declarative.DAL.Entities;

namespace Declarative.BLL.Services.Interfaces
{
    public interface IProjectTaskService
    {
        IEnumerable<TaskViewModel> GetAll();
        TaskViewModel GetById(int id);
        void Create(TaskAddModel item);
        void Update(TaskEditModel item);
        void Delete(int id);
    }
}
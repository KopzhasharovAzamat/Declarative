using Declarative.Api.Models.Employee;
using Declarative.DAL.Entities;

namespace Declarative.BLL.Services.Interfaces
{
    public interface IEmployeeService
    {
        IEnumerable<EmployeeViewModel> GetAll();
        EmployeeViewModel GetById(int id);
        void Create(EmployeeAddModel item);
        void Update(EmployeeEditModel item);
        void Delete(int id);
    }
}
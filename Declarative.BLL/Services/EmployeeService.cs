using Declarative.Api.Models.Employee;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;

namespace Declarative.BLL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository<Employee> _employeeRepository;
        public EmployeeService(IEmployeeRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IEnumerable<EmployeeViewModel> GetAll()
        {
            var model = _employeeRepository.GetAll();

            var result = new List<EmployeeViewModel>();

            foreach (var item in model)
            {
                result.Add(new EmployeeViewModel
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Position = item.Position,
                });
            }

            return result;
        }
        public EmployeeViewModel GetById(int id)
        {
            var item = _employeeRepository.GetById(id);
            var employee = new EmployeeViewModel
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                Position = item.Position,
            };
            return employee;
        }
        public void Create(EmployeeAddModel employee)
        {
            var employeeEntity = new Employee { FirstName = employee.FirstName, LastName = employee.LastName };
            _employeeRepository.Create(employeeEntity);
        }
        public void Update(EmployeeEditModel employee)
        {
            var employeeEntity = new Employee { FirstName = employee.FirstName, LastName = employee.LastName };
            _employeeRepository.Update(employeeEntity);
        }
        public void Delete(int id)
        {
            _employeeRepository.Delete(id);
        }
    }
}

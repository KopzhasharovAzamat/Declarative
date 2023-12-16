using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;

namespace Declarative.DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        private readonly AppDbContext context;
        public EmployeeRepository(AppDbContext context) 
        {
            this.context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return context.Employees.ToList();
        }
        public Employee GetById(int id)
        {
            return context.Employees.Find(id);
        }
        public void Create(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }
        public void Update(Employee employee)
        {
            context.Employees.Update(employee);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }
        }
    }
}

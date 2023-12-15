using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

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
            return context.Employees;
        }

        public Employee Get(int id)
        {
            return context.Employees.Find(id);
        }

        public void Create(Employee book)
        {
            context.Employees.Add(book);
        }

        public void Update(Employee book)
        {
            //context.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Employee> Find(Func<Employee, Boolean> predicate)
        {
            return context.Employees.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Employee book = context.Employees.Find(id);
            if (book != null)
                context.Employees.Remove(book);
        }

        public Employee GetValue(int id)
        {
            throw new NotImplementedException(); // error
        }

        public void Delete(Employee item)
        {
            throw new NotImplementedException(); // error
        }
    }
}

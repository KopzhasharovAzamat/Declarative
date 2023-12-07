using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private readonly AppDbContext db;
        public EmployeeRepository(AppDbContext context) 
        {
            this.db = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            return db.Employees;
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public void Create(Employee book)
        {
            db.Employees.Add(book);
        }

        public void Update(Employee book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Employee> Find(Func<Employee, Boolean> predicate)
        {
            return db.Employees.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Employee book = db.Employees.Find(id);
            if (book != null)
                db.Employees.Remove(book);
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

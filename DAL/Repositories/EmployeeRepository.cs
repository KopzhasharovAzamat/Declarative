using DAL.Entities;
using DAL.EntityFramework;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EmployeeRepository : IRepository<Employee>
    {
        private context db;
        public EmployeeRepository(context context) 
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

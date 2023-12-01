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
    public class CompanyRepository : IRepository<Company>
    {
        private context db;
        public CompanyRepository(context context) 
        {
            this.db = context;
        }
        public IEnumerable<Company> GetAll()
        {
            return db.Companies;
        }

        public Company Get(int id)
        {
            return db.Companies.Find(id);
        }

        public void Create(Company book)
        {
            db.Companies.Add(book);
        }

        public void Update(Company book)
        {
            db.Entry(book).State = EntityState.Modified;
        }

        public IEnumerable<Company> Find(Func<Company, Boolean> predicate)
        {
            return db.Companies.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Company book = db.Companies.Find(id);
            if (book != null)
                db.Companies.Remove(book);
        }

        public Company GetValue(int id)
        {
            throw new NotImplementedException(); // error
        }

        public void Delete(Company item)
        {
            throw new NotImplementedException(); // error
        }
    }
}

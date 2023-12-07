using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly AppDbContext db;
        public CompanyRepository(AppDbContext context) 
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
            db.Entry(book).State = System.Data.Entity.EntityState.Modified;
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

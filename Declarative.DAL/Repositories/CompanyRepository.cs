using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Declarative.DAL.Repositories
{
    public class CompanyRepository : ICompanyRepository<Company>
    {
        private readonly AppDbContext context;
        public CompanyRepository(AppDbContext context) 
        {
            this.context = context;
        }
        public IEnumerable<Company> GetAll()
        {
            return context.Companies;
        }

        public Company Get(int id)
        {
            return context.Companies.Find(id);
        }

        public void Create(Company book)
        {
            context.Companies.Add(book);
        }

        public void Update(Company book)
        {
            context.Entry(book).State = System.Data.Entity.EntityState.Modified;
        }

        public IEnumerable<Company> Find(Func<Company, Boolean> predicate)
        {
            return context.Companies.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Company book = context.Companies.Find(id);
            if (book != null)
                context.Companies.Remove(book);
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

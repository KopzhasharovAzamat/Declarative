using Declarative.DAL.Entities;
using Declarative.DAL.EntityFramework;
using Declarative.DAL.Interfaces;

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
            return context.Companies.ToList();
        }
        public Company GetById(int id)
        {
            return context.Companies.Find(id);
        }
        public void Create(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
        }
        public void Update(Company company)
        {
            context.Companies.Update(company);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            Company company = context.Companies.Find(id);
            if (company != null)
            {
                context.Companies.Remove(company);
                context.SaveChanges();
            }
        }

    }
}

using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;

namespace Declarative.BLL.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository<Company> _companyRepository;
        public CompanyService(ICompanyRepository<Company> CompanyRepository)
        {
            _companyRepository = CompanyRepository;
        }
    }
}

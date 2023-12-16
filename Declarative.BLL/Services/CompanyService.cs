using Declarative.Api.Models.Company;
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
        public IEnumerable<CompanyViewModel> GetAll()
        {
            return _companyRepository.GetAll();
        }

        public CompanyViewModel GetById(int id)
        {
            var companyEntity = _companyRepository.GetById(id);
            return companyEntity;
        }
        public void Create(CompanyAddModel company)
        {
            var companyEntity = new Company { Description = company.Description, Name = company.Name };
            _companyRepository.Create(companyEntity);
        }

        public void Update(CompanyEditModel company)
        {
            var companyEntity = new Company { Description = company.Description, Name = company.Name, EmployeeId = company.EmployeeId, ProjectId = company.ProjectId };
            _companyRepository.Update(companyEntity);
        }
        public void Delete(int id)
        {
            _companyRepository.Delete(id);
        }
    }
}

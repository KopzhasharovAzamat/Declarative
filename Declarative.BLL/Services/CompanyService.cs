using AutoMapper;
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
        private readonly IMapper _mapper;
        public CompanyService(ICompanyRepository<Company> CompanyRepository, IMapper mapper)
        {
            _companyRepository = CompanyRepository;
            _mapper = mapper;
        }
        public IEnumerable<CompanyViewModel> GetAll()
        {
            var companies = _companyRepository.GetAll();
            return _mapper.Map<IEnumerable<CompanyViewModel>>(companies);
        }

        public CompanyViewModel GetById(int id)
        {
            var companyEntity = _companyRepository.GetById(id);
            return _mapper.Map<CompanyViewModel>(companyEntity);
        }

        public void Create(CompanyAddModel company)
        {
            var companyEntity = _mapper.Map<Company>(company);
            _companyRepository.Create(companyEntity);
        }

        public void Update(CompanyEditModel company)
        {
            var companyEntity = _mapper.Map<Company>(company);
            _companyRepository.Update(companyEntity);
        }
        public void Delete(int id)
        {
            _companyRepository.Delete(id);
        }
    }
}

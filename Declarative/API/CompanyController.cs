using Declarative.Api.Models.Company;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Declarative.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public IEnumerable<CompanyViewModel> Get()
        {
            var companies = _companyService.GetAll();
            return companies;
        }
        
    }
}

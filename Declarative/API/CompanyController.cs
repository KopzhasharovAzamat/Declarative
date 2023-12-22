using Declarative.Api.Models.Company;
using Declarative.BLL.Services.Interfaces;
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
        public ActionResult<IEnumerable<CompanyViewModel>> GetAll()
        {
            var companies = _companyService.GetAll();
            return Ok(companies);
        }
        [HttpGet("{id}")]
        public ActionResult<CompanyViewModel> GetById(int id)
        {
            var company = _companyService.GetById(id);

            if (company == null)
            {
                return NotFound();
            }

            return Ok(company);
        }

        [HttpPost]
        public ActionResult Create([FromBody] CompanyAddModel company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _companyService.Create(company);

            return CreatedAtAction(nameof(GetById), new { id = company.Id }, company);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] CompanyEditModel company)
        {
            if (!ModelState.IsValid || id != company.Id)
            {
                return BadRequest(ModelState);
            }

            var existingCompany = _companyService.GetById(id);
            if (existingCompany == null)
            {
                return NotFound();
            }

            _companyService.Update(company);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var existingCompany = _companyService.GetById(id);
            if (existingCompany == null)
            {
                return NotFound();
            }

            _companyService.Delete(id);

            return NoContent();
        }
    }
}

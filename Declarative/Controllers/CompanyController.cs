using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Declarative.BLL.Services;
using Declarative.BLL.Configurations;
using Declarative.BLL.Services.Interfaces;
using Declarative.Api.Models.Company;
using Declarative.DAL.Entities;

namespace Declarative.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public IActionResult Index()
        {
            var companies = _companyService.GetAll();
            return View(companies);
        }

        public IActionResult Details(int id)
        {
            var company = _companyService.GetById(id);
            if(company == null)
            {
                return NotFound();
            }
            return View(company);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CompanyAddModel company)
        {
            if (ModelState.IsValid)
            {
                _companyService.Create(company);
                return RedirectToAction("Index");
            }
            return View(company);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var company = _companyService.GetById(id);
            if(company == null)
            {
                return NotFound();
            }
            return View(company);
        }
    }
}

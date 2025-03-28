using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.PresentationLayer.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public IActionResult Update(int id)
        {
            var company = _companyRepository.GetCompanyById(id);
            return View(company);
        }

        [HttpPost]
        public IActionResult Update(Company company)
        {
            _companyRepository.Update(company);
            return RedirectToAction("Company");
        }
        public IActionResult Company()
        {
            var companyList = _companyRepository.ListAllCompanies();
            return View(companyList);
        }

        public IActionResult CompanyView(int id)
        {
            var company = _companyRepository.GetCompanyById(id);
            return View(company);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            _companyRepository.Delete(id);
            return RedirectToAction("Company");
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            _companyRepository.Create(company);
            return RedirectToAction("Company");
        }
    }
}

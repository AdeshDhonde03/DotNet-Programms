using ItBoostUp.BuisnessLayer.Interface;
using ItBoostUp.BuisnessLayer.Models;
using ItBoostUp.PresentationLayer.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ItBoostUp.PresentationLayer.Controllers
{
    // Controller level filter registration
    [ServiceFilter(typeof(CustomActionFilter))]
    public class CompanyController : Controller
    {
        ICompanyRepository companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public IActionResult Company()
        {
            var list = companyRepository.List();
            return View(list);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Company company)
        {
            companyRepository.Create(company);

            return RedirectToAction("Company");
        }

        public IActionResult Delete(int id)
        {
            companyRepository.Delete(id);

            return RedirectToAction("Company");
        }

        public IActionResult CompanyDetail(int id)
        {
            var company = companyRepository.GetById(id);

            return View(company);
        }

        public IActionResult EditCompany(int id)
        {
            var company = companyRepository.GetById(id);

            return View(company);
        }
        public IActionResult Update(Company company)
        {
            companyRepository.Update(company);

            return RedirectToAction("Company");
        }

    }
}

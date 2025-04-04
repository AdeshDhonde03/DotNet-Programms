using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.BussinessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateManager.PresentationLayer.Controllers
{
    public class CountryController : Controller
    {
        ICountryRepository countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        [HttpGet]
        public IActionResult Country(int id = 1)
        {
            var list = countryRepository.List();

            if (id == 1)
            {
                //list = list.Where(x => x.IsActive == true);
                list = list.Where(x => x.IsActive).ToList();
                return View(list);
            }
            else if (id == 2)
            {
                list = list.Where(x => !x.IsActive).ToList();
                return View(list);
            }
            return View(list);
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            countryRepository.Create(country);
            return RedirectToAction("Country");
        }

        [HttpGet]
        public IActionResult ShowCountry(int id)
        {
            var country = countryRepository.GetById(id);

            return View(country);
        }

        public IActionResult Delete(int id)
        {
            countryRepository.Delete(id);
            
            return RedirectToAction("Country");
        }

        public IActionResult ActivateCountry(int id, bool flag)
        {
            countryRepository.ActivateCountry(id, flag);
            return RedirectToAction("Country");
        }

        public IActionResult EditCountry(int id)
        {
            var company = countryRepository.GetById(id);

            return View(company);
        }
        [HttpPost]
        public IActionResult Update(Country country)
        {
            countryRepository.Update(country);
            return RedirectToAction("Country");
        }
    }
}

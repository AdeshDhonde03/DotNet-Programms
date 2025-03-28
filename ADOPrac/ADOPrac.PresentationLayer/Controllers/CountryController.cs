using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.PresentationLayer.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public IActionResult Update(int id)
        {
            var country = _countryRepository.GetCountryById(id);
            return View(country);
        }

        [HttpPost]
        public IActionResult Update(Country country)
        {
            _countryRepository.Update(country);
            return RedirectToAction("Country");
        }

        
        public IActionResult Country(int id=0)
        {
            
            var countryList = _countryRepository.GetCountriesList();
            if(id == 1)
            {
                countryList = countryList.Where(x => x.isActive == 1).ToList();
            }else if(id == 2)
            {
                countryList = countryList.Where(x => x.isActive == 0).ToList();
            }
            return View(countryList);
        }

        public IActionResult ActiveChange(int id, int flag)
        {
            _countryRepository.ChangeIsActive(id , flag);
            return RedirectToAction("Country");
        }

        public IActionResult Delete(int id)
        {
            _countryRepository.Delete(id);
            return RedirectToAction("Country");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country country)
        {
            _countryRepository.Create(country);
            return RedirectToAction("Country");
        }
    }
}

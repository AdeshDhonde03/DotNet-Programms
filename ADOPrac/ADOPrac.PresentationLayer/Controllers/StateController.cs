using ADOPrac.BusinessLogicLayer.IRepository;
using ADOPrac.BusinessLogicLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADOPrac.PresentationLayer.Controllers
{
    public class StateController : Controller
    {
        private readonly IStateRepository _stateRepository;
        private readonly ICountryRepository _countryRepository;

        public StateController(IStateRepository stateRepository , ICountryRepository countryRepository)
        {
            _stateRepository = stateRepository;
            _countryRepository = countryRepository;
        }
        public IActionResult State()
        {
            var stateList = _stateRepository.GetStatesList();
            ViewData["Countries"] = _countryRepository.GetCountriesList();
            return View(stateList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(State state)
        {
            _stateRepository.Create(state);
            return RedirectToAction("State");
        }

        public IActionResult CountryOptions()
        {
            
            return View();
        }
    }
}

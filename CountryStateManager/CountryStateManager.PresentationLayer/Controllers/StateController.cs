using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.BussinessLayer.Models;
using CountryStateManager.BussinessLayer.Models.ViewModels;
using CountryStateManager.DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace CountryStateManager.PresentationLayer.Controllers
{
    public class StateController : Controller
    {
        IStateRepository _stateRepository;
        ICountryRepository _countryRepository;

        public StateController(IStateRepository stateRepository, ICountryRepository countryRepository)
        {
            _stateRepository = stateRepository;
            _countryRepository = countryRepository;
        }

        public IActionResult State(int id = 1)
        {
            var countryList = _countryRepository.List();
            ViewBag.CountryList = countryList.Select(c => new SelectListItem
            {
                Value = c.CountryId.ToString(),
                Text = c.Name
            }).ToList();

            var stateList = _stateRepository.List();

            if (id == 1)
            {
                //list = list.Where(x => x.IsActive == true);
                stateList = stateList.Where(x => x.IsActive).ToList();
                return View(stateList);
            }
            else if (id == 2)
            {
                stateList = stateList.Where(x => !x.IsActive).ToList();
                return View(stateList);
            }

            return View(stateList);
        }

        public IActionResult Create(State state)
        {
            _stateRepository.Create(state);
            
            return RedirectToAction("State");
        }

        public IActionResult ShowState(int id)
        {
            var state = _stateRepository.GetById(id);

            return View(state);
        }

        public IActionResult Delete(int id)
        {
            _stateRepository.Delete(id);

            return RedirectToAction("State");
        }

        public IActionResult EditState(int id)
        {
            var state = _stateRepository.GetById(id);

            var countryList = _countryRepository.List();
            ViewBag.CountryList = countryList.Select(c => new SelectListItem
            {
                Value = c.CountryId.ToString(),
                Text = c.Name
            }).ToList();

            return View(state);
        }

        [HttpPost]
        public IActionResult Update(StateViewModel state)
        {
            _stateRepository.Update(state);

            return RedirectToAction("State");
        }

        public IActionResult ActivateState(int id, bool flag)
        {
            _stateRepository.ActivatState(id, flag);
            return RedirectToAction("State");
        }
    }
}

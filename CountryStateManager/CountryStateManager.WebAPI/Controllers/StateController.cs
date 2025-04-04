using AutoMapper;
using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.BussinessLayer.Models;
using CountryStateManager.BussinessLayer.Models.ViewModels;
using CountryStateManager.BussinessLayer.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        IStateRepository _stateRepository;
        ICountryRepository _countryRepository;
        private readonly IMapper _mapper;

        public StateController(IStateRepository stateRepository, ICountryRepository countryRepository, IMapper mapper)
        {
            _stateRepository = stateRepository;
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        [HttpGet("list")]
        public IActionResult StateList()
        {
            var list = _stateRepository.List();

            if (list == null)
            {
                return Ok("No records available");
            }

            return Ok(list);
        }

        [HttpPost("add")]
        public IActionResult Create([FromBody] State state)
        {
            _stateRepository.Create(state);

            return Ok("Record created successfully");
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var state = _stateRepository.GetById(id);

            if (state == null)
            {
                return NotFound();
            }
            return Ok(state);
        }

        [HttpDelete("remove/{id}")]
        public IActionResult Delete(int id)
        {
            if (_stateRepository.GetById(id) == null)
            {
                return NotFound();
            }

            _stateRepository.Delete(id);

            return Ok("Record deleted successfully");
        }

        [HttpPut("edit")]
        public IActionResult Update(StateViewModel state)
        {
            if (_stateRepository.GetById(state.StateId) == null)
            {
                return BadRequest($"Record with id: {state.StateId} not found.");
            }
            _stateRepository.Update(state);
            return Ok();
        }

        [HttpPut("editActiveStatus/{id}")]
        public IActionResult ActiveStatus([FromRoute] int id, [FromQuery] bool status)
        {
            if (_stateRepository.GetById(id) == null)
            {
                return BadRequest($"Record with id: {id} not found.");
            }
            _stateRepository.ActivatState(id, status);
            return Ok();
        }

        [HttpGet("countrylist")]
        public IActionResult GetCountries()
        {

            var list = _countryRepository.List();

            if(list == null)
            {
                return Ok("No countries available");
            }

            //var countryList = new List<CountryListForStates>();

            //foreach(var item in list)
            //{
            //    CountryListForStates country = _mapper.Map<CountryListForStates>(item);
            //    countryList.Add(country);
            //}

            var countryList = list
                .Select(item => _mapper.Map<CountryListForStates>(item))
                .ToList();

            return Ok(countryList);
        }
    }
}

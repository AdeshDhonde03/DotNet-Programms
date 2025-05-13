using CountryStateManager.BussinessLayer.Interface;
using CountryStateManager.BussinessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryStateManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet("list")]
        public IActionResult CountryList()
        {
            var list = _countryRepository.List();

            if (list == null)
            {
                return Ok("No records available");
            }

            return Ok(list);
        }

        [HttpPost("add")]
        public IActionResult Create([FromBody] Country country)
        {
            _countryRepository.Create(country);

            return Ok("Record created successfully");
        }

        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var country = _countryRepository.GetById(id);

            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpDelete("remove/{id}")]
        public IActionResult Delete(int id)
        {
            if(_countryRepository.GetById(id) == null)
            {
                return NotFound();
            }

            _countryRepository.Delete(id);

            return Ok("Record deleted successfully");
        }

        [HttpPut("edit")]
        public IActionResult Update(Country country)
        {
            if(_countryRepository.GetById(country.CountryId) == null)
            {
                return BadRequest($"Country with id: {country.CountryId} not found.");
            }
            _countryRepository.Update(country);
            return Ok();
        }

        [HttpPut("editActiveStatus/{id}")]
        public IActionResult ActiveStatus([FromRoute] int id, [FromQuery]bool status)
        {
            if (_countryRepository.GetById(id) == null)
            {
                return BadRequest($"Country with id: {id} not found.");
            }
            _countryRepository.ActivateCountry(id, status);
            return Ok();
        }
    }
}

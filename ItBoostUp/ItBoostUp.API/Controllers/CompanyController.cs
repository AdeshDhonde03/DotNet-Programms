using ItBoostUp.BuisnessLayer.DTOs;
using ItBoostUp.BuisnessLayer.Interface;
using ItBoostUp.BuisnessLayer.Mappings;
using ItBoostUp.BuisnessLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItBoostUp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        [HttpGet("list")]
        public IActionResult CompanyList()
        {
            var companyData = _companyRepository.List();

            if(companyData == null)
            {
                return Ok("No records available");
            }

            return Ok(companyData);
        }

        [HttpPost("addCompany")]
        public IActionResult Create([FromBody] Company company)
        {
            var result = _companyRepository.Create(company);

            return Ok("Record created successfully");
        }

        [HttpDelete("remove/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            if(_companyRepository.GetById(id) == null)
            {
                return BadRequest($"Record with Id: {id} not found");
            }
            var result = _companyRepository.Delete(id);

            return Ok("Record deleted successfully");
        }

        [HttpPut("edit/{id}")]
        public IActionResult Update([FromBody] UpdateCompanyDto updateCompanyDto,[FromRoute] int id)
        {
            var company = _companyRepository.GetById(id);

            if (company == null)
            {
                return BadRequest($"Record with id {id} not found.");
            }

            company.MapUpdateCompanyDtoWithCompany(updateCompanyDto);
            
            var result = _companyRepository.Update(company);
            
            return Ok();
        }

        [HttpGet("getcompany/{id}")]
        public IActionResult GetCompanyById([FromRoute] int id)
        {
            var company = _companyRepository.GetById(id);

            if (company == null)

            {
                return NotFound();
            }

            return Ok(company);
        }
    }
}

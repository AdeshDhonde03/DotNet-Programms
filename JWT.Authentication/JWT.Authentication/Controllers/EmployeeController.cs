using JWT.Authentication.Interfaces;
using JWT.Authentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _services;

        public EmployeeController(IEmployeeService services)
        {
            _services = services;
        }

       
        [HttpGet("getAllEmployee")]
        
        public List<Employee>GetAllEmployees()
        {
            return _services.GetAllEmployees();
        }

        [HttpPost("addEmployee")]
        
        public Employee Create([FromBody]Employee employee)
        {
            var employee1 = _services.Create(employee);
            return employee1;
        }

        
    }
}

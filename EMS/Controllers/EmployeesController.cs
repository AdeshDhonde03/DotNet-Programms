using EMS.DTOs.EmployeeDtos;
using EMS.Entities;
using EMS.Mappings;
using EMS.Params;
using EMS.Responses.EmployeeResponses;
using EMS.Services.EmployeeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : BaseApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
              _employeeService = employeeService;
        }

       
  //CRUD Operations

        [HttpGet]

        public async Task<ActionResult<IEnumerable<EmployeeResponse>>>GetEmployee([FromQuery]EmployeeParams param)
        {
            var employees = await _employeeService.GetEmployees();

            int skipElements=(param.PageNumber-1)*param.PageSize;
            int takeElements=Math.Min(employees.Count() - skipElements,param.PageSize);

            if(param.SearchText != string.Empty)
            {
                employees = employees.Where(employee =>
                    employee.Name
                    .Contains(param.SearchText, StringComparison.OrdinalIgnoreCase)

           );


            }
            int totalCount = employees.Count();

            int totalPages = totalCount / param.PageSize;



            if (totalCount % param.PageSize != 0)
            {
                totalPages++;
            }

            employees = employees.Skip(skipElements)
                        .Take(takeElements)
                        .ToList();

            Response.Headers.Add("X-Page-Number", param.PageNumber.ToString());
            Response.Headers.Add("X-Page-Size", param.PageSize.ToString());
            Response.Headers.Add("X-Total-Pages", totalPages.ToString());
            Response.Headers.Add("X-Total-Count", totalCount.ToString());

            return Ok(new PaginatedEmployeeResponse()
            {
                TotalPages = totalPages,
                PageSize = param.PageSize,
                PageNumber = param.PageNumber,
                TotalCount = totalCount,
                Employees = employees
            });
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeDto createEmployeeDto)
        {
            Employee SavedEmployee = _employeeService.CreateEmployee(createEmployeeDto);
            if (await _employeeService.SaveChangesToDbAsync())
            {
                return Ok(new EmployeeResponse(SavedEmployee));
            }
            return BadRequest("Failed to create employee");

        }


        [HttpGet("{employeeId}")]

        public async Task<ActionResult<EmployeeResponse>>GetEmployeeById([FromRoute]int employeeId)
        {
            var employee=await _employeeService.GetEmployeeById(employeeId);
            if(employee == null)
            {
                return NotFound();

            }
            return Ok(new EmployeeResponse(employee));
        }
        [HttpDelete("{employeeId}")]
        public async Task<ActionResult> DeleteEmployee([FromRoute] int employeeId)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);
            if(employee==null)
            {
                return BadRequest($"Employee by id{employeeId} do not exist");
            }
             _employeeService.DeleteEmployee(employee);
            if(await _employeeService.SaveChangesToDbAsync())
            {
                return Ok();
            }
            return BadRequest("Failed to delete employee");
        }
        [HttpPut("{employeeId}")]
        public async Task<ActionResult>UpdateEmployee([FromRoute]int employeeId ,[FromBody] UpdateEmployeeDto updateEmployeeDto)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);
            if (employee == null)
            {
                return BadRequest($"Employee by id{employeeId} do not exist");
            }

            employee.MapUpdateEmployeeDtowithEmployee(updateEmployeeDto);
            _employeeService.UpdateEmployee(employee);
            if (await _employeeService.SaveChangesToDbAsync())
            {
                return Ok("Employee Updated");
            }
            return BadRequest("Failed to update employee");


        }


    }
}

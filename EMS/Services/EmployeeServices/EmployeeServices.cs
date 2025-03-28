using EMS.DTOs.EmployeeDtos;
using EMS.Entities;
using EMS.Repository.EmployeeRepositories;
using EMS.Responses.EmployeeResponses;

namespace EMS.Services.EmployeeServices
{
    public class EmployeeServices : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeServices(IEmployeeRepository employeeRepository) 
        { 
            _employeeRepository = employeeRepository;
        }
        public Employee CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            Employee employee = new Employee(createEmployeeDto);
            return _employeeRepository.CreateEmployee(employee);
        }
        public async Task<IEnumerable<EmployeeResponse>>GetEmployees()
        {
            var employees = await _employeeRepository.GetEmployees();
            return employees.Select(employee => new EmployeeResponse(employee)).ToList();
        }

        public void DeleteEmployee(Employee employee)
        {
             _employeeRepository.DeleteEmployee(employee);
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var employee= await _employeeRepository.GetEmployeeById(employeeId);
            return employee; 
        }

        

        public async Task<bool> SaveChangesToDbAsync()
        {
            return await _employeeRepository.SaveChangesToDbAsync();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        
    }
}

using EMS.DTOs.EmployeeDtos;
using EMS.Entities;
using EMS.Responses.EmployeeResponses;

namespace EMS.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Employee CreateEmployee(CreateEmployeeDto createEmployeeDto);
        Task<IEnumerable<EmployeeResponse>> GetEmployees();
        Task<Employee> GetEmployeeById(int employeeId);

        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        public Task<bool> SaveChangesToDbAsync();
    }
}


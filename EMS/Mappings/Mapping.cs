    using EMS.DTOs.EmployeeDtos;
using EMS.Entities;

namespace EMS.Mappings
{
    public static class Mapping
    {
        public static void MapUpdateEmployeeDtowithEmployee(this Employee employee, UpdateEmployeeDto updateEmployeeDto)
        {
            employee.Name = updateEmployeeDto.Name;
            employee.Email = updateEmployeeDto.Email;
            employee.Salary = updateEmployeeDto.Salary;
        }
    }
}

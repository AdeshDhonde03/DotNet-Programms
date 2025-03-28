using EMS.DTOs.EmployeeDtos;
using System.ComponentModel.DataAnnotations;

namespace EMS.Entities
{
    public class Employee
    {
        public Employee(int employeeId, string name, string email, double salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Email = email;
            Salary = salary;
        }
        public Employee(CreateEmployeeDto createEmployeeDto)
        {
            Name=createEmployeeDto.Name;
            Email=createEmployeeDto.Email;
            Salary=createEmployeeDto.Salary;
            }
        public Employee()
        {
           
        }

        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}

using EMS.Entities;

namespace EMS.Responses.EmployeeResponses
{
    public class EmployeeResponse
    {
        public EmployeeResponse(int employeeId, string name, string email, double salary)
        {
            EmployeeId = employeeId;
            Name = name;
            Email = email;
            Salary = salary;
        }
        public EmployeeResponse(Employee employee)
        {
            EmployeeId = employee.EmployeeId;
            Name = employee.Name;
            Email = employee.Email;
            Salary= employee.Salary;

        }
        public EmployeeResponse()
        {
            
        }

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }
    }
}

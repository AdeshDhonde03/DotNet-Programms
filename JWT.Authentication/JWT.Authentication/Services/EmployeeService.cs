using JWT.Authentication.Data;
using JWT.Authentication.Interfaces;
using JWT.Authentication.Models;

namespace JWT.Authentication.Services
{
    public class EmployeeService : IEmployeeService
    {
        private JwtContext _context;

        public EmployeeService(JwtContext context)
        {
            _context = context;
        }

        public Employee Create(Employee employee)
        {
            var emp = _context.Employees.Add(employee);
            _context.SaveChanges();
            return emp.Entity;
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
    }
}

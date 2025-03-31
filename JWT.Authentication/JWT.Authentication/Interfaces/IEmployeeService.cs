using JWT.Authentication.Models;

namespace JWT.Authentication.Interfaces
{
    public interface IEmployeeService
    {
       public Employee Create(Employee employee);
        public List<Employee> GetAllEmployees();

    }
}

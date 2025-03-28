using EMS.Entities;

namespace EMS.Repository.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Employee CreateEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int employeeId);

        void UpdateEmployee(Employee employee);
        void DeleteEmployee(Employee employee);

        public Task<bool> SaveChangesToDbAsync();
 
    }
}

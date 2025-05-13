using EMS.Repository.EmployeeRepositories;
using EMS.Services.EmployeeServices;

namespace EMS.Extensions
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeServices>();
        }
    }
}

using EMS.Entities;
using Microsoft.EntityFrameworkCore;

namespace EMS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee>Employees{ get; set; }
    }
}

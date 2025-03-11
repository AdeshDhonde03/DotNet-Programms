using Microsoft.EntityFrameworkCore;
using poultry_management_system.web.Models.Domain;

namespace poultry_management_system.web.Data
{
    public class PoultryDbContext : DbContext
    {
        public PoultryDbContext(DbContextOptions options) : base(options)
        {

        }
     public DbSet<DialyFlockEntry> DailyEntry {  get; set; }
     public DbSet<User>Users{ get; set; }
    }
}

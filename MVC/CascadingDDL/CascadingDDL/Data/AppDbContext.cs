using CascadingDDL.Models.DBEntities;
using Microsoft.EntityFrameworkCore;

namespace CascadingDDL.Data
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Country> Country { get; set; }
        public DbSet<State> State { get; set; }

        public DbSet<City> City { get; set; }


    }
}

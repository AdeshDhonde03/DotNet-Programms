using DynamicDropDown.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicDropDown.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

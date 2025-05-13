using Microsoft.EntityFrameworkCore;
using Vendor.Models;

namespace Vendor.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<City> Cities { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Prevent multiple cascade paths
        //    modelBuilder.Entity<Vendors>()
        //        .HasOne(v => v.State)
        //        .WithMany()
        //        .HasForeignKey(v => v.StateId)
        //        .OnDelete(DeleteBehavior.Restrict); // No cascade delete

        //    modelBuilder.Entity<Vendors>()
        //        .HasOne(v => v.City)
        //        .WithMany()
        //        .HasForeignKey(v => v.CityId)
        //        .OnDelete(DeleteBehavior.Restrict); // No cascade delete

        //    modelBuilder.Entity<City>()
        //        .HasOne(c => c.State)
        //        .WithMany(s => s.Cities)
        //        .HasForeignKey(c => c.StateId)
        //        .OnDelete(DeleteBehavior.Restrict); // No cascade delete
        //}


    }
}

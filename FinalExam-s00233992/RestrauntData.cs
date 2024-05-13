using System.Data.Entity;
using YourProjectName.Models;

namespace FinalExam_s00233992
{
    public class RestaurantData : DbContext
    {
        // Define DbSet for each entity
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        // Constructor
        public RestaurantData() : base("OODExam_VLADKHOKHA")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
        }
    }
}

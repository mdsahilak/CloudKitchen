using Microsoft.EntityFrameworkCore;

namespace CloudKitchen.Models
{
public class CloudKitchenContext : DbContext
    {
        public CloudKitchenContext(DbContextOptions<CloudKitchenContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<Driver> Drivers { get; set; }
	}
}
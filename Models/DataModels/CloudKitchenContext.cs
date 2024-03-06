using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CloudKitchen.Models
{
public class CloudKitchenContext : IdentityDbContext<IdentityUser>
    {
        public CloudKitchenContext(DbContextOptions<CloudKitchenContext> options) : base(options)
        {
        }
        
        public DbSet<FoodItem> FoodItems { get; set; }

        public DbSet<FoodReview> FoodReviews { get; set; }

        public DbSet<Kitchen> Kitchens { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<Order> Orders { get; set; }
	}
}
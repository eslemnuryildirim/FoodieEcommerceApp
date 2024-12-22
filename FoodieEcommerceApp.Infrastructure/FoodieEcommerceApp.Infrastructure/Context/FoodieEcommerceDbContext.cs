using Microsoft.EntityFrameworkCore;
using FoodieEcommerceApp.Domain.Entities;

namespace FoodieEcommerceApp.Infrastructure.Context
{
    public class FoodieEcommerceDbContext : DbContext
    {
        public FoodieEcommerceDbContext(DbContextOptions<FoodieEcommerceDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}

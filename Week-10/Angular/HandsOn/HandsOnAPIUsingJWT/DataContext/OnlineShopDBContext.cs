using Microsoft.EntityFrameworkCore;
using HandsOnAPIUsingJWT.Entities;
namespace HandsOnAPIUsingJWT.DataContext
{
    public class OnlineShopDBContext : DbContext
    {
        public OnlineShopDBContext(DbContextOptions<OnlineShopDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //seed data to Products table
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", Price = 1000},
                new Product { ProductId = 2, ProductName = "Smartphone", Price = 500},
                new Product { ProductId = 3, ProductName = "Tablet", Price = 300},
                new Product { ProductId = 4, ProductName = "Smartwatch", Price = 200}
            );
            //seed data to Users table
            modelBuilder.Entity<User>().HasData(
                new User { UserId = "U0001", UserName = "admin", Password = "admin123", Email="admin@gmail.com",Mobile="9098909890",Role = "Admin" },
                new User { UserId = "U0002", UserName = "user", Password = "user123", Email = "user@gmail.com", Mobile = "8098909890", Role = "User" }
            );
        }
    }
}
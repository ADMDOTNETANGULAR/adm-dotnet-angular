using Microsoft.EntityFrameworkCore;
using OnlineShopping.ProductService.Entities;
namespace OnlineShopping.ProductService.DBContext
{
    public class ProductDBDBContext : DbContext
    {
        public ProductDBDBContext(DbContextOptions<ProductDBDBContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed data to Products table
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", Price = 1000 },
                new Product { ProductId = 2, ProductName = "Smartphone", Price = 500 },
                new Product { ProductId = 3, ProductName = "Tablet", Price = 300 },
                new Product { ProductId = 4, ProductName = "Smartwatch", Price = 200 }
            );

        }
    }
}
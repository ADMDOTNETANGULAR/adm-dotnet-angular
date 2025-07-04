using Microsoft.EntityFrameworkCore;
using HandsOnMVCUsingEF.Entities;
namespace HandsOnMVCUsingEF.DBContext
{
    public class OnlineShopContext:DbContext
    {
        //Define the DbSet for Product
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string to connect to the database
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-4O1D65I\SQLEXPRESS;Initial Catalog=OnlineShopDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding initial data into the Products table
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "Laptop", Price = 50000, Quantity = 10 },
                new Product { ProductId = 2, ProductName = "Mobile", Price = 20000, Quantity = 20 },
                new Product { ProductId = 3, ProductName = "Tablet", Price = 15000, Quantity = 15 }
            );
        }

    }
}

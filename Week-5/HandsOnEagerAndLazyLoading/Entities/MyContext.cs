using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HandsOnEagerAndLazyLoading.Entities
{
    internal class MyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public MyContext()
        {
            // Enable lazy loading
            this.ChangeTracker.LazyLoadingEnabled = true;
           
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(); // Enable lazy loading proxies

            optionsBuilder.UseSqlServer("server=DESKTOP-4O1D65I\\SQLEXPRESS;database=EComm1;trusted_connection=true;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding data to the database
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "C001", CategoryName = "Electronics" },
                new Category { CategoryId = "C002", CategoryName = "Books" }
            );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Laptop", Price = 50000, CategoryId = "C001" },
                new Product { ProductId = 2, Name = "Smartphone", Price = 20000, CategoryId = "C001" },
                new Product { ProductId = 3, Name = "Fiction Book", Price = 300, CategoryId = "C002" }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = Guid.NewGuid(), ProductId = 1, OrderDate = DateTime.Now },
                new Order { OrderId = Guid.NewGuid(), ProductId = 2, OrderDate = DateTime.Now },
                new Order { OrderId = Guid.NewGuid(), ProductId = 3, OrderDate = DateTime.Now }
            );
        }
    }
}

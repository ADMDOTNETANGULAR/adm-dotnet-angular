using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HandsOnEFUsingCodeFirst.Entities;// Import necessary namespaces including Entity Framework Core and the Product entity
namespace HandsOnEFUsingCodeFirst.DBContext
{
    internal class AppDbContext:DbContext // Define the AppDbContext class that inherits from DbContext
    {
        //Manage Connection String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set the connectionstring for the database
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=AppDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        //Define the DbSet for Product entity to represent the Products table in the database
        //Entity Sets are used to query and save instances of entities
        public DbSet<Product> Products { get; set; }
    }

}

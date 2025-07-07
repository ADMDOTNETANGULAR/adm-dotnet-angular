using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JobPortal.Domain;
namespace JobPortal.Infrastructure.DBContext
{
    internal class JobPortalDbContext : DbContext
    {
        //define the DbSet properties for your entities
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //configure the database connection string
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-4O1D65I\\SQLEXPRESS;Initial Catalog=JobPortalDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed Employee data
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = "E001",
                    EmployeeName = "John Doe",
                    Email = "John@abc.com",
                    PhoneNumber = "1234567890",
                    Organization = "Tech"

                },
                new Employee
                {
                    EmployeeId = "E002",
                    EmployeeName = "Jane Smith",
                    Email = "Jane@ab.com",
                    PhoneNumber = "0987654321",
                    Organization = "Finance"
                }

    );
        }
    }
}

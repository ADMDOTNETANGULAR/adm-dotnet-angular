using Microsoft.EntityFrameworkCore;
using OnlineShopping.UserService.Entities;
namespace OnlineShopping.UserService.DataContext
{
    public class UserDBContext : DbContext
    {
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seed data to Users table
            modelBuilder.Entity<User>().HasData(
                new User { UserId = "U0001", UserName = "admin", Password = "admin123", Email = "admin@gmail.com", Mobile = "9098909890", Role = "Admin" },
                new User { UserId = "U0002", UserName = "user", Password = "user123", Email = "user@gmail.com", Mobile = "8098909890", Role = "User" }
            );
        }
    }
}
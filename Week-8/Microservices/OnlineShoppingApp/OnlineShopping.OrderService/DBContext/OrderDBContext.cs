using Microsoft.EntityFrameworkCore;
namespace OnlineShopping.OrderService.DBContext
{
    public class OrderDBContext:DbContext
    {
        public OrderDBContext(DbContextOptions<OrderDBContext> options) : base(options)
        {
        }
        public DbSet<Entities.Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data to Orders table
            modelBuilder.Entity<Entities.Order>().HasData(
                new Entities.Order { OrderId = 1, ProductId = 1, OrderDate = DateTime.Parse("12.2.2023"), Quantity = 2, TotalPrice = 2000 },
                new Entities.Order { OrderId = 2, ProductId = 2, OrderDate = DateTime.Parse("12.2.2023"), Quantity = 1, TotalPrice = 500 },
                new Entities.Order { OrderId = 3, ProductId = 3, OrderDate = DateTime.Parse("12.2.2023"), Quantity = 3, TotalPrice = 900 }
            );
        }
    }
}

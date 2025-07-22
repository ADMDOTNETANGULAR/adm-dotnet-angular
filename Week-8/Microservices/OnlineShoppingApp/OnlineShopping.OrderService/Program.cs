
using Microsoft.EntityFrameworkCore;
using OnlineShopping.OrderService.DBContext;

namespace OnlineShopping.OrderService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("OrderDBConnection");
            // Register DbContext with SQL Server provider
            builder.Services.AddDbContext<OrderDBContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddScoped<Repositories.IOrderRepository, Repositories.OrderRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}


using Microsoft.EntityFrameworkCore;
using OnlineShopping.ProductService.DBContext;

namespace OnlineShopping.ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Get connection string from appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("ProductDBConnection");
            // Register DbContext with SQL Server provider
            builder.Services.AddDbContext<ProductDBDBContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddScoped<Repositories.IProductRepository, Repositories.ProductRepository>();
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

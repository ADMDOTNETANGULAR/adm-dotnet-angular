using Microsoft.EntityFrameworkCore;
using HandsOnAPIUsingEFCore.Repositories;
namespace HandsOnAPIUsingEFCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //Remove Json Serialization and Add XML Serialization

            // Add services to the container.
            // Configure Entity Framework Core with SQL Server
            var connectionString = builder.Configuration.GetConnectionString("FlightDBConnection");
            // Ensure the connection string is set in appsettings.json
            builder.Services.AddDbContext<DataContext.FlightDBContext>(options =>
                options.UseSqlServer(connectionString));
            // Register the FlightRepository as a service
            // This allows it to be injected into controllers or other services
            // Registering the repository interface and its implementation
            // This allows for dependency injection
            //AddScoped means a new instance is created for each request
            builder.Services.AddScoped<IFlightContract, FlightRepository>();
            // AddTransient means a new instance is created each time it is requested
            //builder.Services.AddTransient<IFlightContract, FlightRepository>();
            builder.Services.AddControllers();
            //add cors policy
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAllOrigins",
                    builder => builder.AllowAnyOrigin() //accept all the client servers
                                      .AllowAnyMethod() // accept GET,PUT,POST,DELETE
                                      .AllowAnyHeader()); // all request and response headers allowd
            });
            //Ensure that the XML serialization is used instead of JSON serialization
            //builder.Services.AddControllers(
            //    options => options.OutputFormatters.RemoveType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter>()
            //    ).AddXmlSerializerFormatters(); // This adds XML serialization support

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
            else if (app.Environment.IsProduction())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }
            // Use CORS policy
            app.UseCors("AllowAllOrigins");
            app.UseAuthorization();


            app.MapControllers(); // This maps the controller routes to the application

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Flight}/{action=GetAllFlights}/{id?}"
            //);
            app.Run();
        }
    }
}

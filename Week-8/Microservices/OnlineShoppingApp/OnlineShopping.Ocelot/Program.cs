using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Text;
namespace OnlineShopping.Ocelot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //configure Ocelot
            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: false);
            // Add services to the container.
            

            builder.Services.AddOcelot(); // Register Ocelot services
            var app = builder.Build();
          
            app.UseOcelot(); // Use Ocelot middleware
            app.MapGet("/", () => "Hello World!");
            app.Run();
        }
    }
}

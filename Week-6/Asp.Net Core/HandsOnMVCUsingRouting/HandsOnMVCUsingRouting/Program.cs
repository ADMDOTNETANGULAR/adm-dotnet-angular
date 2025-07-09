using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace HandsOnMVCUsingRouting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting(); // Enable attribute routing middleware

            app.UseAuthorization();
            // Map routes for controllers
            // This is where we define the conventional routing for our application.
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
               // pattern: "{controller}/{action}/{id?}");
            // Map the default route for the Home controller


            app.Run();
        }
    }
}

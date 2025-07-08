using HandsOnMVCUsingEF.DBContext;
using HandsOnMVCUsingEF.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HandsOnMVCUsingEF
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            var connectionString = builder.Configuration.GetConnectionString("OnlineShopDBConnection");
            builder.Services.AddDbContext<OnlineShopContext>(options=>options.UseSqlServer(connectionString));
            builder.Services.AddScoped<IProductContract, ProductRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
           app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

           app.Run();
        }
    }
}

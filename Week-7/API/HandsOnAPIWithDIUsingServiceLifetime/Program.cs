
using HandsOnAPIWithDIUsingServiceLifetime.Services;

namespace HandsOnAPIWithDIUsingServiceLifetime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Choose ONE at a time:
            builder.Services.AddSingleton<IGuidService, GuidService>();
            //builder.Services.AddScoped<IGuidService, GuidService>();
            //builder.Services.AddTransient<IGuidService, GuidService>();
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

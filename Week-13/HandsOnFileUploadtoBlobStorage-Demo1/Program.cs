
using HandsOnFileUploadtoBlobStorage_Demo1.Services;

namespace HandsOnFileUploadtoBlobStorage_Demo1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IAzureStorage, AzureStorage>();
            builder.Services.AddControllers();
            //enable cors
            builder.Services.AddCors(policy =>
            policy.AddPolicy("AllowOriginPolicy", options =>
            {
                options.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyOrigin();
            }));
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
            app.UseCors("AllowOriginPolicy");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

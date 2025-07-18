using HandsOnAPIUsingExceptionHandling.Exceptions;
using HandsOnAPIUsingExceptionHandling.Middleware;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Diagnostics;
using HandsOnAPIUsingExceptionHandling.Models;

namespace HandsOnAPIUsingExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Register the custom exception filter globally
            builder.Services.AddControllers(options =>
              options.Filters.Add(new GlobalExceptionFilter()));
            // ✅ Register ExceptionHandler with custom logic
            //builder.Services.AddExceptionHandler(options =>
            //{
            //    options.ExceptionHandler = async context =>
            //    {
            //        var exception = context.Features.Get<IExceptionHandlerFeature>()?.Error; // ✅ Works if using Microsoft.AspNetCore.Diagnostics
            //        var response = context.Response;

            //        response.StatusCode = exception is NotFoundException ? 404 : 500;
            //        response.ContentType = "application/json";

            //        var error = new ErrorDetails
            //        {
            //            StatusCode = response.StatusCode,
            //            Message = exception?.Message ?? "Internal Server Error"
            //        };

            //        await response.WriteAsync(JsonSerializer.Serialize(error));
            //    };
            //});
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
               // app.UseDeveloperExceptionPage(); // Use the built-in developer exception page in development
                //app.UseExceptionHandler("/error"); // Use the built-in exception handler in development
                // 🔥 Register your custom exception middleware first
                //inline with the built-in exception handler
                //app.UseExceptionHandler(errorApp =>
                //{
                //    errorApp.Run(async context =>
                //    {
                //        context.Response.StatusCode = 500;
                //        context.Response.ContentType = "application/json";

                //        await context.Response.WriteAsync("{\"message\": \"Something went wrong.\"}");
                //    });
                //});
            }
            else if (app.Environment.IsProduction())
            {
                // app.UseExceptionHandler("/error"); // Use the built-in exception handler in development
                // 🔥 Register your custom exception middleware first
                //inline with the built-in exception handler
                app.UseExceptionHandler(errorApp =>
                {
                    errorApp.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        context.Response.ContentType = "application/json";

                        await context.Response.WriteAsync("{\"message\": \"Something went wrong.\"}");
                    });
                });
            }
                //// 🔥 Register your custom exception middleware first
                app.UseMiddleware<ExceptionMiddleware>(); // Custom exception handling middleware
                app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

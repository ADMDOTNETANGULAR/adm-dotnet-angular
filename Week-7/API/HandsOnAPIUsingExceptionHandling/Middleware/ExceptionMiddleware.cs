using HandsOnAPIUsingExceptionHandling.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Text.Json;

namespace HandsOnAPIUsingExceptionHandling.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context); // Proceed to next middleware or endpoint
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unhandled exception occurred");
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";

        var statusCode = exception switch
        {
            Exceptions.NotFoundException => HttpStatusCode.NotFound,
            _ => HttpStatusCode.InternalServerError

        };

        var errorDetails = new ErrorDetails
        {
            StatusCode = (int)statusCode,
            Message = exception.Message
        };

        context.Response.StatusCode = (int)statusCode;
        var result = JsonSerializer.Serialize(errorDetails);

        return context.Response.WriteAsync(result);
    }
}

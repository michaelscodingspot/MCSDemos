using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AspNetCoreMVC_Core31.Middlewares
{
public class ErrorLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            // Use your logging framework here to log the exception 
            throw;
        }
    }
}
}
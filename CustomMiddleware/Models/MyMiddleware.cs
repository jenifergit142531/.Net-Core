using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
public class MyMiddleware : IMiddleWare
{
    public async Task InvokeAsync(HttpContext context,RequestDelegate next)
    {
        await context.Response.WriteAsync("Custom middleware Request");
        await next(context);
        await context.Response.WriteAsync("Custom middleware Response");

    }
}
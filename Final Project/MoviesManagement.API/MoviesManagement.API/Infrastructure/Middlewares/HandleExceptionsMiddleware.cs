using Microsoft.AspNetCore.Http;
using MoviesManagement.API.Global_Exceptions;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace MoviesManagement.API.Infrastructure.Middlewares
{
    public class HandleExceptionsMiddleware
    {
        private readonly RequestDelegate _next;

        public HandleExceptionsMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ApiExceptionHandling(context, ex);
            var result = JsonConvert.SerializeObject(error);

            context.Response.Clear(); //გავასუფთაოთ output
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = error.Status.Value;

            await context.Response.WriteAsync(result);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Practice_1.Exceptions;
using System;
using System.Threading.Tasks;

namespace Practice_1.Infrastructure.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private const int serverErrors = 500;
        private const int clientErrors = 400;
        private const int succeed = 200;

        public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);

                if (context.Response.StatusCode >= serverErrors && context.Response.StatusCode < 600)
                    _logger.LogError($"{context.Response.StatusCode} server error occured");

                if (context.Response.StatusCode >= clientErrors && context.Response.StatusCode < 500)
                    _logger.LogWarning($"{context.Response.StatusCode} client error occured");

                if (context.Response.StatusCode >= succeed && context.Response.StatusCode < 300)
                    _logger.LogInformation($"{context.Response.StatusCode} Succeed!");
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new PossibleExceptions(context, ex);
            var errorResult = JsonConvert.SerializeObject(error);

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = error.Status.Value;

            await context.Response.WriteAsync(errorResult);
        }
    }
}

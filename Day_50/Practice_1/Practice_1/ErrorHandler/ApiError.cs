using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.Services.Exceptions;
using System;
using System.Net;

namespace Practice_1.ErrorHandler
{
    public class ApiError : ProblemDetails
    {
        public const string unhandledException = "unhandled";
        private HttpContext _context;
        private Exception _exception;

        public LogLevel logLevel { get; set; }
        public string Code { get; set; }

        public string TraceId
        {
            get
            {
                if (Extensions.TryGetValue("traceId", out var traceId))
                {
                    return (string)traceId;
                }
                return null;
            }
            set => Extensions["TraceId"] = value;
        }

        public ApiError(HttpContext context, Exception exception)
        {
            _context = context;
            _exception = exception;

            TraceId = context.TraceIdentifier;
            Code = "UnhandledErrorCode";
            Title = exception.Message;
            logLevel = LogLevel.Error;
            Instance = context.Request.Path;
            Status = (int)HttpStatusCode.InternalServerError;

            HandleException((dynamic)exception);
        }

        private void HandleException(RealEstateAlreadyExistsException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.Conflict;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8";
            Title = exception.Message;
            logLevel = LogLevel.Information;
        }

        private void HandleException(RealEstateNotFoundException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.NotFound;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = exception.Message;
            logLevel = LogLevel.Trace;
        }


    }
}

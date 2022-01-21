using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentService.Exceptions;
using System;
using System.Net;

namespace Practice_1
{
    public class ApiError : ProblemDetails
    {
        public const string unhandledError = "UnhandledException";
        private HttpContext _context;
        private Exception _exception;

        public LogLevel LogLevel { get; set; }
        public string Code { get; set; }
        public string TraceId
        {
            get
            {
                if (Extensions.TryGetValue("TraceId", out object traceId))
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

            LogLevel = LogLevel.Error;
            Title = exception.Message;
            Code = "Unhandled Error Code";
            TraceId = context.TraceIdentifier;
            Instance = context.Request.Path;

            HandleException((dynamic)exception);
        }

        private void HandleException(StudentAlreadyExistException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.Conflict;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8";
            Title = exception.Message;
            LogLevel = LogLevel.Information;
        }

        private void HandleException(StudentNotFoundException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.NotFound;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.4";
            Title = exception.Message;
            LogLevel = LogLevel.Trace;
        }

        private void HandleException(StudentCouldNotBeAddedException exception)
        {
            Code = exception.Code;
            Status = (int)HttpStatusCode.BadRequest;
            Type = "https://datatracker.ietf.org/doc/html/rfc7231#section-6.5.8";
            Title = exception.Message;
            LogLevel = LogLevel.Information;
        }

        private void HandleException(Exception exception) { }
    }
}

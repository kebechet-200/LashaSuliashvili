using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonService.Exceptions;
using System;
using System.Net;

namespace Practice_1.Exceptions
{
    public class PossibleExceptions : ProblemDetails
    {
        private HttpContext _context;
        private Exception _exception;

        public string Code { get; set; }

        public PossibleExceptions(HttpContext context, Exception exception)
        {
            _context = context;
            _exception = exception;

            Title = exception.Message;
            Code = "";

            HandleException((dynamic)exception);
        }

        private void HandleException(PersonCouldNotFoundException exception)
        {
            Status = (int)HttpStatusCode.NotFound;
            Title = exception.Message;
            Code = exception.Code;
        }

        private void HandleException(EmptyDataException exception)
        {
            Status = (int)HttpStatusCode.InternalServerError;
            Title = exception.Message;
            Code = exception.Code;
        }
    }
}

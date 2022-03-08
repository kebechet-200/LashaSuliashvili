using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.Services.Exceptions
{
    public class AuthenticationError : Exception
    {
        public AuthenticationError(string message) : base(message) { }
    }
}

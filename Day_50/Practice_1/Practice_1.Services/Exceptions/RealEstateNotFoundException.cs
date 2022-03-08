using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.Services.Exceptions
{
    public class RealEstateNotFoundException : Exception
    {
        public readonly string Code = "Real Estate Not Found";
        public RealEstateNotFoundException(string message) : base(message) { }
    }
}

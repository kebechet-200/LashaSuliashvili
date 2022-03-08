using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1.Services.Exceptions
{
    public class RealEstateAlreadyExistsException : Exception
    {
        public readonly string Code = "Real Estate Already Exists";
        public RealEstateAlreadyExistsException(string message) : base(message) { }
    }
}

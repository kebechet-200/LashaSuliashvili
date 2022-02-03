using System;
using System.Collections.Generic;
using System.Text;

namespace PersonService.Exceptions
{
    public class EmptyDataException : Exception
    {
        public EmptyDataException(string message) : base(message) { }
    }
}

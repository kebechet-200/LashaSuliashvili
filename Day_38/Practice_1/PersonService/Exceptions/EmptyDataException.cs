using System;
using System.Collections.Generic;
using System.Text;

namespace PersonService.Exceptions
{
    public class EmptyDataException : Exception
    {
        public string Code = "Data is empty";
        public EmptyDataException(string message) : base(message) { }
    }
}

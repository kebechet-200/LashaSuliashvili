using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Practice_1.ExceptionClass
{
    internal class IndexCantBeNegativeNumberException : Exception
    {
        public IndexCantBeNegativeNumberException()
        {
        }

        public IndexCantBeNegativeNumberException(string message) : base(message)
        {
        }

        public IndexCantBeNegativeNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IndexCantBeNegativeNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

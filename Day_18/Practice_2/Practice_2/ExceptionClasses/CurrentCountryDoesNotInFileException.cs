using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Practice_2.ExceptionClasses
{
    public class CurrentCountryDoesNotInFileException : Exception
    {
        public CurrentCountryDoesNotInFileException()
        {
        }

        public CurrentCountryDoesNotInFileException(string message) : base(message)
        {
        }

        public CurrentCountryDoesNotInFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CurrentCountryDoesNotInFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

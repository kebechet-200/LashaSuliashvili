using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Practice_2.ExceptionClasses
{
    public class CurrentCityDoesNotInFileException : Exception
    {
        public CurrentCityDoesNotInFileException()
        {
        }

        public CurrentCityDoesNotInFileException(string message) : base(message)
        {
        }

        public CurrentCityDoesNotInFileException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CurrentCityDoesNotInFileException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

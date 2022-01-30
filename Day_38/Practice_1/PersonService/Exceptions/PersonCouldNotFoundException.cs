using System;
using System.Runtime.Serialization;

namespace PersonService.Exceptions
{
    [Serializable]
    public class PersonCouldNotFoundException : Exception
    {
        public string Code = "Could Not Found";
        public PersonCouldNotFoundException()
        {
        }

        public PersonCouldNotFoundException(string message) : base(message)
        {
        }

        public PersonCouldNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PersonCouldNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
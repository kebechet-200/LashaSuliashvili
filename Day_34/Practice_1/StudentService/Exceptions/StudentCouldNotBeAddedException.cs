using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService.Exceptions
{
    public class StudentCouldNotBeAddedException : Exception
    {
        public string Code = "Student could not be added";

        public StudentCouldNotBeAddedException(string message) : base(message) { }
    }
}

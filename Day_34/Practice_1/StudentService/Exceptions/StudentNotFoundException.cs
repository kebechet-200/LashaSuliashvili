using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService.Exceptions
{
    public class StudentNotFoundException : Exception
    {
        public string Code = "Student Not Found";
        public StudentNotFoundException(string message) : base(message) { }
    }
}

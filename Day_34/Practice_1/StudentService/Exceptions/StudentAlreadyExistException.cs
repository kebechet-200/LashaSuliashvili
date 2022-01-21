using System;
using System.Collections.Generic;
using System.Text;

namespace StudentService.Exceptions
{
    public class StudentAlreadyExistException : Exception
    {
        public string Code = "Student Already Exist";

        public StudentAlreadyExistException(string message) : base(message) { }
    }
}

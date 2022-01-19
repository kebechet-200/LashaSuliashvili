using System;

namespace StudentService
{
    public class Student
    {
        public Student(int id, string firstName, string lastName, string nationId, string faculty, int score)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            NationId = nationId;
            Faculty = faculty;
            Score = score;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationId { get; set; }
        public string Faculty { get; set; }
        public int Score { get; set; }

    }
}

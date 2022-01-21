using StudentService.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService
{
    public class StudentsService
    {
        private static List<Student> _students;

        static StudentsService()
        {
            _students = new List<Student>()
            {
                new Student(1,"Lasha","Suliashvili","210392182","Computer Science", 50),
                new Student(2,"John","Doe","210422182","Laws", 75),
                new Student(3,"Giorgi","Suliashvili","7358277","International Communications",98),
                new Student(4,"Nika","Gvari #1","210392182","Some Faculty #1", 84),
                new Student(5,"Beqa","Gvari #2","20123312","Some Faculty #2", 37),
                new Student(6,"Davit","Gvari #3","1238521","Some Faculty #3", 94),
                new Student(7,"Mariam","Gvari #4","983285","Some Faculty #4", 32),
                new Student(8,"Maya","Gvari #5","15725732","Some Faculty #5", 19),
            };
        }

        public async Task AddStudentAsync(Student student)
        {
            var result = from s in _students
                         where s.NationId == student.NationId
                         select s;

            if(result.Any())
                throw new StudentAlreadyExistException("Student Already Exist");
            if (student.Score < 18)
                throw new StudentCouldNotBeAddedException("This student could not be added");

            _students.Add(student);

            await Task.CompletedTask;
        }

        public async Task<Student> GetStudentAsync(int id)
        {
            var result = (from s in _students
                         where s.Id == id
                         select s).FirstOrDefault();

            if (result == null)
                throw new StudentNotFoundException("Student not found");

            return await Task.FromResult(result);
        }

        public  async Task<List<Student>> GetStudentsAsync()
        {
            return await Task.FromResult(_students);
        }

        public async Task DeleteStudentAsync(int id)
        {
            var result = (from s in _students
                          where s.Id == id
                          select s).FirstOrDefault();

            if (result == null)
                throw new StudentNotFoundException("Student not found");

            _students.Remove(result);

            await Task.CompletedTask;
        }

        public async Task UpdateStudentAsync(Student std)
        {
            var student = (from s in _students
                          where s.Id == std.Id
                          select s).FirstOrDefault();

            if (student == null)
                throw new StudentNotFoundException("Student not found");

            student.Id = std.Id;
            student.FirstName = std.FirstName;
            student.LastName = std.LastName;
            student.Faculty = std.Faculty;
            student.Score = std.Score;

            await Task.CompletedTask;
        }
    }
}

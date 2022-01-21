using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_1.Models.DTOs;
using StudentService;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Practice_1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentsService _StudentsService;

        public StudentController(StudentsService studentsService)
        {
            _StudentsService = studentsService;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(Student student)
        {
            await _StudentsService.AddStudentAsync(student);

            return Ok();
        }

        [HttpGet("Get")]
        public async Task<ActionResult<StudentDTO>> Get(int id)
        {
            var student = await _StudentsService.GetStudentAsync(id);

            var studentDTO = new StudentDTO
            {
                Id = student.Id,
                Score = student.Score,
                Faculty = student.Faculty,
                FirstName = student.FirstName,
                LastName = student.LastName,
                NationId = student.NationId
            };

            return Ok(studentDTO);
        }

        [HttpGet]

        public async Task<ActionResult<StudentDTO>> Get()
        {
            var student = await _StudentsService.GetStudentsAsync();

            return Ok(student);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _StudentsService.DeleteStudentAsync(id);

            return Ok();
        }
        
        [HttpPut("Update")]

        public async Task<IActionResult> Update(Student std)
        {
            await _StudentsService.UpdateStudentAsync(std);

            return Ok();
        }
    }
}

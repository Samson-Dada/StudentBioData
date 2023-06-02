using API.Models.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {

            _studentService = studentService;

        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Student>>> GetAll()
        {
            var students = await _studentService.GetAllStudent();
            if(students is null)
            {
                return NotFound("No Student Found");
            }
            return Ok(students);
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<Student>> GetById(int studentId)
        {
            var studentById = await _studentService.GetStudentById(studentId);
            if(studentById is null)
            {
                return NotFound($"Cannot found {studentById} of Student");
            }
            return Ok(studentById);
        }


        [HttpPost]
        public async Task<ActionResult<Student>> Create()
        {
            return Ok(); 
        }
    }
}

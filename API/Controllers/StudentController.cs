using API.Models.DTO;
using API.Entities;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ResponseCache(CacheProfileName = "240SecondsCacheProfile")]
    [Route("api/students")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(IStudentService studentService, IMapper mapper)
        {

            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Student>>> GetAll()
        {
            var students = await _studentService.GetAllStudent();
            if (students is null)
            {
                return NotFound("No Student Found");
            }
            return Ok(students);
        }

        [HttpGet("{studentId}")]
        public async Task<ActionResult<StudentDetailDto>> GetById(int studentId)
        {
            var studentById = await _studentService.GetStudentById(studentId);
            if (studentById is null)
            {
                return NotFound($"Cannot found {studentById} of Student");
            }
            var mapStudentId = _mapper.Map<StudentDetailDto>(studentById);
            return Ok(mapStudentId);
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Create()
        {
            return Ok();
        }
    }
}

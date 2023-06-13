using API.Data.Repositories;
using API.Entities;

namespace API.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<ICollection<Student>> GetAllStudent()
        {
            var students = await _studentRepository.GetAll();
            return students;
        }

        public async Task<Student> GetStudentById(int studentId)
        {
            var studentById = await _studentRepository.GetById(studentId);
            return studentById;
        }
    }
}

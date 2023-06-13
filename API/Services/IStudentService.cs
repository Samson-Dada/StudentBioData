using API.Entities;

namespace API.Services
{
    public  interface IStudentService
    {
        Task<ICollection<Student>> GetAllStudent();
        Task<Student> GetStudentById(int studentId);
    }
}

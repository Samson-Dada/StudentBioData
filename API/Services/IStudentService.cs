using API.Models.Entites;
public interface IStudentService
{
    Task<ICollection<Student>> GetAllStudent();
    Task<Student> GetStudentById(int studentId);
}
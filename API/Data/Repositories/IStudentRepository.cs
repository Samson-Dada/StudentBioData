using API.Models.Entites;

namespace API.Data.Repositories
{
    public interface IStudentRepository
    {
        Task<ICollection<Student>> GetAll();
        Task<Student> GetById(int id);
        //Task<Student> GetStudentByName(string firstName, string lastName);
        Task Add(Student newStudent);
    }
}

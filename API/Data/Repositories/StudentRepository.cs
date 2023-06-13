using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repositories
{

    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAppContext _context;

        public StudentRepository(StudentAppContext context)
        {
            _context = context;
        }
        public async Task<ICollection<Student>> GetAll()
        {
            var students = await _context.Students.ToListAsync();
            if (!students.Any())
            {
                return null;
            }
            return students;

        }

        public async Task<Student> GetById(int id)
        {
            var student = await _context.Students.SingleOrDefaultAsync(s => s.StudentId == id);
            if (student is null)
            {
                return null;
            }
            return student;
        }

        public async Task Add(Student newStudent)
        {
            await _context.AddAsync(newStudent);
            await _context.SaveChangesAsync();
        }
    }
}

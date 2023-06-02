using API.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public static class StudentSeedData
    {

        public static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new List<Student>
            {
                new Student
                {

                StudentId = 1,
                FirstName = "John",
                LastName = "Deo",
                Gender = "Male",
                DateOfBirth = DateTime.UtcNow,
                StudentClass = "Senior secondar school",
                Subject = "Math"
                },
                 new Student
                {
                StudentId = 2,
                FirstName = "Carlos",
                LastName = "Temi",
                Gender = "Female",
                DateOfBirth = DateTime.UtcNow,
                StudentClass = "Senior secondar school",
                Subject = "Math"
                 },
                  new Student
                 {
                StudentId = 3,
                FirstName = "Dayo",
                LastName = "Benson",
                Gender = "Male",
                DateOfBirth = DateTime.UtcNow,
                StudentClass = "Senior secondar school",
                Subject = "Math"
                }
            });

            modelBuilder.Entity<Subject>().HasData(
             new List<Subject>
            {
                new Subject
                {
                    SubjectId = 1,
                    SubjectName = "Mathematic",
                    SubjectDescription = "Duo aliquyam at blandit ea enim et clita amet sanctus amet sanctus amet sanctus"
                },
                new Subject
                {
                    SubjectId = 2,
                    SubjectName = "Computer Science",
                    SubjectDescription = "Duo aliquyam at blandit ea enim et clita amet sanctus amet sanctus amet sanctus"
                },
                new Subject
                {
                    SubjectId = 3,
                    SubjectName = "English Language",
                    SubjectDescription = "Duo aliquyam at blandit ea enim et clita amet sanctus amet sanctus amet sanctus"
                },
            }
                );
        }

    }
}

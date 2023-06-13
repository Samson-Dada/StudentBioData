using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StudentAppContext : DbContext
    {

        public StudentAppContext(DbContextOptions<StudentAppContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            StudentSeedData.SeedData(modelBuilder);
        }


        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}
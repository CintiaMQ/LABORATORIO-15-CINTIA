using Microsoft.EntityFrameworkCore;

namespace Semana13.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-90J21RF\\SQLEXPRESS; " +
                "Initial Catalog=SCHOOL2; Integrated Security=True;trustservercertificate=True");
        }
    }
}

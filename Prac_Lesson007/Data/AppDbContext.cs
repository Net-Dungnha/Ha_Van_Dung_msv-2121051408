using Microsoft.EntityFrameworkCore;
using Prac_Lesson007.Models;

namespace Prac_Lesson007.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
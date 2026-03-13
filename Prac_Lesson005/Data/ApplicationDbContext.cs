using Microsoft.EntityFrameworkCore;
using Prac_Lesson005.Models;

namespace Prac_Lesson005.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
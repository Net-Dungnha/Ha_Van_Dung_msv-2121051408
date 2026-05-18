using Microsoft.EntityFrameworkCore;
using Prac_Lesson009.Models;

namespace Prac_Lesson009.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        
    }
}
using DemoMVC.Models.Entity;  // ← Import các model (Book, Author, User, Categories)
using Microsoft.EntityFrameworkCore;  // ← Import EF Core

namespace Library.Data  // ← Namespace của project
{
    // Class kế thừa DbContext - lớp quản lý kết nối và truy vấn database
    public class ApplicationDbContext : DbContext
    {
        // Constructor nhận DbContextOptions để cấu hình connection
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)  // ← Chuyển options cho DbContext cha
        {
        }

        // DbSet<T> đại diện cho một bảng trong database
        // Khi migrate, EF Core sẽ tạo bảng Authors từ class Author
        public DbSet<Author> Authors { get; set; }

        // Bảng Books tương ứng với model Book
        public DbSet<Book> Books { get; set; }

        // Bảng Categories tương ứng với model Categories
        public DbSet<Categories> Categories { get; set; }

        // Bảng Users tương ứng với model User
        public DbSet<User> Users { get; set; }
    }
}
using Prac_Lesson008.Models;

namespace Prac_Lesson008.Data
{
    public static class DbSeeder
    {
        /// <summary>
        /// Tự động thêm dữ liệu mẫu vào bảng Courses nếu bảng đang rỗng.
        /// Được gọi 1 lần khi ứng dụng khởi động.
        /// </summary>
        public static void SeedCourses(AppDbContext context)
        {
            // Nếu bảng Courses đã có dữ liệu → không làm gì cả
            if (context.Courses.Any())
                return;

            // Thêm 3 khóa học mẫu
            var courses = new List<Course>
            {
                new Course
                {
                    Name = "Lập trình C#",
                    Description = "Học lập trình hướng đối tượng với ngôn ngữ C#"
                },
                new Course
                {
                    Name = "ASP.NET Core MVC",
                    Description = "Xây dựng ứng dụng web với ASP.NET Core MVC"
                },
                new Course
                {
                    Name = "Cơ sở dữ liệu",
                    Description = "Học SQL Server, SQLite và Entity Framework Core"
                }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges(); // Lưu vào database
        }
    }
}

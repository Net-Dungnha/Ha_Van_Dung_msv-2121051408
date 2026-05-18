namespace Prac_Lesson008.ViewModels
{
    /// <summary>
    /// ViewModel dùng để hiển thị dữ liệu kết hợp giữa bảng Student và Course.
    /// Thay vì truyền trực tiếp Model (Student) vào View,
    /// ta dùng ViewModel để chỉ lấy những trường cần thiết từ nhiều bảng.
    /// </summary>
    public class StudentCourseViewModel
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int Age { get; set; }
        public string? ClassName { get; set; }

        // Dữ liệu từ bảng Course
        public int CourseId { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }
    }
}

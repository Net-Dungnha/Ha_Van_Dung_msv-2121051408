using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prac_Lesson008.Models
{
    public class Student
    {
        // Khóa chính
        [Key]
        public int Id { get; set; }

        [Required]
        // Tên sinh viên, bắt buộc phải có
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Class { get; set; }

        // Foreign key
        public int CourseId { get; set; }
        
        // Navigation property
        [ForeignKey("CourseId")]
        // Liên kết với khóa chính của Course, cho phép truy cập thông tin khóa học của Student
        public Course? Course { get; set; }
    }
}
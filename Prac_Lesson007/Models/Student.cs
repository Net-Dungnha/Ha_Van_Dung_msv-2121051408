using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prac_Lesson007.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Class { get; set; }

        // Foreign key
        public int CourseId { get; set; }

        // Navigation property
        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
    }
}
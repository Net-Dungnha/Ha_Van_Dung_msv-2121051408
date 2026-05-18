using System.ComponentModel.DataAnnotations;

namespace Prac_Lesson009.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public string? Class { get; set; }
    }
}
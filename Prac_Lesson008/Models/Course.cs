using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prac_Lesson008.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        // Navigation property
        public ICollection<Student>? Students { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;
namespace Prac_Lesson006.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }

    }
}
using Prac_Lesson007.Models;

namespace Prac_Lesson007.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Class { get; set; }
        public string? CourseName { get; set; }
        public string? CourseDescription { get; set; }
    }
}
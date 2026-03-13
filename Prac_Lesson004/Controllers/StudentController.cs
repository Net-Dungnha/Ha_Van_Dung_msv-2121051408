using Microsoft.AspNetCore.Mvc;

namespace Prac_Lesson004.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string name, int age)
        {
            ViewBag.Message = "Xin Chao " + name + ", Ban " + age + " tuoi";
            return View();
        }
    }
}
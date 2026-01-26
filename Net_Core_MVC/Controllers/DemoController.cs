using Microsoft.AspNetCore.Mvc;

namespace Net_Core_MVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
        
            ViewBag.Message = "Hello Hà Văn Dũng - MSV: 12345678";
            return View();
        }
    }
}
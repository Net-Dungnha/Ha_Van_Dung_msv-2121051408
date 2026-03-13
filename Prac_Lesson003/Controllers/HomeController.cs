using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Mvc;
using Prac_Lesson003.Models;

namespace Prac_Lesson003.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
   public IActionResult Index2()
    {
        return Content("Hello, World! I am Ha Van Dung - 2121051408");
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

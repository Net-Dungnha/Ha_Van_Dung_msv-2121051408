using System;
using Microsoft.AspNetCore.Mvc;
using Stu_MVC_P.NET_Core_MVC001.Models;
namespace Stu_MVC_P.NET_Core_MVC001.Controllers
{
    public class BIMController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new BMI());
        }

        [HttpPost]
        public ActionResult Index(BMI Models)
        {
           if (Models != null && Models.Height > 0 && Models.Weight > 0)
           {
                Models.BMI = Models.Weight / (Models.Height * Models.Height);
                if (Models.BMI < 18.5){
                    Models.Result = "Underweight";
                }
                else if (Models.BMI >= 18.5 && Models.BMI < 24.9){
                    Models.Result = "Normal weight";
                }
                else if (Models.BMI >= 25 && Models.BMI < 29.9){
                    Models.Result = "Overweight";
                }
                else{
                    Models.Result = "Obesity";
                }
            }

            return View(Models);
        }
    }
}
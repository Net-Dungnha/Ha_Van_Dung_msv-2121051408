using System;
using Microsoft.AspNetCore.Mvc;

namespace Stu_MVC_P.NET_Core_MVC001.Controllers
{
    public class BMI
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Value { get; set; }
        public string Result { get; set; }
    }

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
                Models.Value = Models.Weight / (Models.Height * Models.Height);
                if (Models.Value < 18.5){
                    Models.Result = "Underweight";
                }
                else if (Models.Value >= 18.5 && Models.Value < 24.9){
                    Models.Result = "Normal weight";
                }
                else if (Models.Value >= 25 && Models.Value < 29.9){
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
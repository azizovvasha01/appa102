using Microsoft.AspNetCore.Mvc;
namespace Portfolio32_MVCIntro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Welcome to MVC Intro Project!";
            ViewData["Info"] = "This project was created for the 32-MVC Intro task.";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Title"] = "About MVC Project";
            return View();
        }
    }
}

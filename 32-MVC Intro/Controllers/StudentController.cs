using Microsoft.AspNetCore.Mvc;
using Portfolio32_MVCIntro.Models;
using System.Collections.Generic;
using System.Linq;
namespace Portfolio32_MVCIntro.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> students = new()
        {
            new Student { Id = 1, Name = "Said", Age = 22 },
            new Student { Id = 2, Name = "Aylin", Age = 20 },
            new Student { Id = 3, Name = "Murad", Age = 25 }
        };
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                ViewBag.Error = "Student not found.";
                return View();
            }
            return View(student);
        }
    }
}

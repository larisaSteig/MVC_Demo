using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Data")]
        public IActionResult DisplayData()
        {
            return View();
        }

        [Route("/Students")]
        public IActionResult Students()
        {
            var students = StudentManager.GetAll();
            return Json(students);
        }

        public IActionResult Create(Student student)
        {
            StudentManager.Add(student);
            return RedirectToAction("/Students");
        }
    }
}
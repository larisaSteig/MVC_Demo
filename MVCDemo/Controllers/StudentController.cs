using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {

        public IActionResult Data(int id)
        {
            var students = StudentManager.GetAll();
            var student = students.SingleOrDefault(m => m.Id == id);
            var content = "<table class='table col-6'><tr><th>Full Name</th><th>Phone</th></tr>";
            content += $"<tr><td>{student.FirstName}</td><td>{student.Phone}</td></tr>";
            return Content(content);
        }
        public IActionResult Details()
        {
            // get students
            var students = StudentManager.GetAll();
            var list = new SelectList(students,"Id","FullName");
            ViewBag.Students = list;
            //add list to the view
            return View();
        }
        public IActionResult Index()
        {
            var students = StudentManager.GetAll();
            return View(students);
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {   
            if(ModelState.IsValid)
            {
                //if (false)
                //{  
                //    ModelState.AddModelError("", "There was a server validation error");
                //    return View();

                //}
                try
                {
                    StudentManager.Add(student);
                    return RedirectToAction("Index");
                }
                catch
                {
                    // log the exception
                    return View();
                }

            }

            else
            {
                return View();
            }

            
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            try
            {
                StudentManager.Add(student);
                return RedirectToAction("Index");
            }
            catch
            {
                // log the exception
                return View();
            }
        }
        public IActionResult Edit(int id)
        {
            var students = StudentManager.GetAll();
            var student = students.SingleOrDefault(s => s.Id == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            var students = StudentManager.GetAll();
            var s = students.SingleOrDefault(s => s.Id == student.Id);            
            s.FirstName = student.FirstName;
            s.LastName = student.LastName;
            s.Phone = student.Phone;          
            return RedirectToAction("Index");
        }
    }
}
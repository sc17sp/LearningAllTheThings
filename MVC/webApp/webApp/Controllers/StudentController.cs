using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webApp.Models;

namespace webApp.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> studentList = new List<Student>()
        {

                new Student() { StudentID = 1, StudentName ="John", Age = 18},
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                new Student() { StudentID = 4, StudentName = "Chris" , Age = 17 } ,
                new Student() { StudentID = 4, StudentName = "Rob" , Age = 19 }
        };
    
        // GET: Student
        public ActionResult Index()
        {

            return View(studentList);
        }

        public ActionResult Edit(int id) 
        {
            var std = studentList.Where(s => s.StudentID == id).FirstOrDefault();

            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std) 
        {
            if (ModelState.IsValid)
            { 
            
            return RedirectToAction("Index");
            }

            return View(std);
        }
    }
}
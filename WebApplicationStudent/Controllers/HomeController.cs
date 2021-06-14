using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationStudent.Models.Database;
using WebApplicationStudent.Models;


namespace WebApplicationStudent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Dashboard()
        {//checking
            TempData["ErrMsg"] = "You need to login to view dashboard";
            Database db = new Database();
            var students=db.Students.GetAll();
            //  return RedirectToAction("Index");
            return View(students);
        }

        public ActionResult AddStudent()
        {
            ViewBag.Message = "Add new Student";
            Student s = new Student();
            return View(s);
        }
        [HttpPost]
        public ActionResult AddStudent(Student s)
        {
            Database db = new Database();
            db.Students.Insert(s);

            return RedirectToAction("Dashboard");
        }

        public ActionResult Edit(int id)
        {
            Database db = new Database();
            var p=db.Students.Get(id);

             
            return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            Database db = new Database();
             db.Students.Update(s);


            return RedirectToAction("Dashboard");
        }

        public ActionResult Delete()
        {

            return RedirectToAction("Dashboard");
        }

    }
}
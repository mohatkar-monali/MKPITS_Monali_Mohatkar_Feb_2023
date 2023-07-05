using Studentdbconmvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Studentdbconmvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            StudentDbHandler handler = new StudentDbHandler();
            ModelState.Clear();
            return View(handler.GetStudent());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentList st)
        {
            if(ModelState.IsValid)
            {
                StudentDbHandler handler = new StudentDbHandler();
                if(handler.InsertStudent(st))
                {
                    ViewBag.Messgae = "Record Inserted";
                    ModelState.Clear();
                }
               
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int stdid)
        {
            StudentDbHandler std=new StudentDbHandler();
            return View(std.GetStudent().Find(m=>m.StdId==stdid));
        }

        [HttpPost]
        public ActionResult Edit(StudentList st,int stdid)
        {
            try
            {
                StudentDbHandler handler = new StudentDbHandler();
                handler.UpdateStudent(st);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
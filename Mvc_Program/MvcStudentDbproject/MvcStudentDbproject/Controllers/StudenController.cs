using MvcStudentDbproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcStudentDbproject.Controllers
{
    public class StudenController : Controller
    {
        // GET: Studen
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
        public ActionResult Create(StudentModel st)
        {
            if (ModelState.IsValid)
            {
                StudentDbHandler handler = new StudentDbHandler();
                if (handler.InsertStudent(st))
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
            StudentDbHandler std = new StudentDbHandler();
            return View(std.GetStudent().Find(m => m.StdId == stdid));
        }

        [HttpPost]
        public ActionResult Edit(int stdid, StudentModel st)
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

        [HttpGet]
        public ActionResult Delete(int StdId)
        {
            StudentDbHandler Handler = new StudentDbHandler();
            return View(Handler.GetStudent().Find(m => m.StdId == StdId));
        }
        [HttpPost]
        public ActionResult Delete(int StdId, StudentModel st)
        {
            try
            {
                StudentDbHandler db = new StudentDbHandler();
                db.DeleteStudent(st);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Details(int Stdid)
        {
            StudentDbHandler itemDbHandler = new StudentDbHandler();
            return View(itemDbHandler.GetStudent().Find(m => m.StdId == Stdid));
        }
    }
}
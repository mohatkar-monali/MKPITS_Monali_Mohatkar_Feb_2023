using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formcollection_Type.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form1(FormCollection fc)
        {
            ViewBag.id = fc["Id"];
            ViewBag.name = fc["Name"];
            bool chk = Convert.ToBoolean(fc["Addon"].Split(',')[0]);
            ViewBag.addon = chk;
            return View("Index");
        }
    }
}
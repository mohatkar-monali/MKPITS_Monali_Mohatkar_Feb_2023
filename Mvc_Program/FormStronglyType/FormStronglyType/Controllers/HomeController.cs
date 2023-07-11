using FormStronglyType.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormStronglyType.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form1(UserModel um)
        {
            ViewBag.id = um.Id;
            ViewBag.name = um.Name;
            if (um.Addon == true)
            {
                ViewBag.addon = "Selected";
            }
            else
            {
                ViewBag.addon = "Not Selected";
            }
           return View("Index");
        }
    }
}
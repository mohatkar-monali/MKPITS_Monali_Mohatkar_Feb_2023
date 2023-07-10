using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormWeakType.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Form1( int txtId,string txtName,string chkAddon)
        {
            ViewBag.Id = txtId;
            ViewBag.Name=txtName;
            if (chkAddon != null)
            {
                ViewBag.Addon = "Selected";
            }
            else
            {
                ViewBag.Addon = "Not Selected";
            }
            return View("Index");
        }
    }
}
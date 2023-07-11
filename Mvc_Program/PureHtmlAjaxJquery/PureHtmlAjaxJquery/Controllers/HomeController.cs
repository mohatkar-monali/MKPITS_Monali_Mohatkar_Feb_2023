using PureHtmlAjaxJquery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PureHtmlAjaxJquery.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult From1(UserModel um) 
        {
            string Value = "ID:" + Convert.ToString(um.Id)
                         + "Name:" + Convert.ToString(um.Name)
                         + "Addon:" + Convert.ToString(um.Addon);
            string s = "$('#Output').html('" + Value + "')";
            return JavaScript(s);
        }

    }
}
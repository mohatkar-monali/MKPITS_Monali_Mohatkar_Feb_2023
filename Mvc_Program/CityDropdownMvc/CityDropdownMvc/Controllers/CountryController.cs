using CityDropdownMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CityDropdownMvc.Models;

namespace CityDropdownMvc.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Details()
        {
            bindState();
            return View();
        }

        public void bindState()
        {
            DateModel1 modelDemo = new DateModel1();
            var state = modelDemo.tblStates.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select State--", Value = "0" });

            foreach (var m in state)
            {


                li.Add(new SelectListItem { Text = m.statename, Value = m.stateid.ToString() });
                ViewBag.state = li;

            }
        }

        public JsonResult getCity(int id)
        {
            DateModel1 modelDemo = new DateModel1();
            var ddlCity = modelDemo.tblCities.Where(x => x.stateid == id).ToList();
            List<SelectListItem> licities = new List<SelectListItem>();

            licities.Add(new SelectListItem { Text = "--Select State--", Value = "0" });
            if (ddlCity != null)
            {
                foreach (var x in ddlCity)
                {
                    licities.Add(new SelectListItem { Text = x.CityName, Value = x.Cityid.ToString() });
                }
            }
            return Json(new SelectList(licities, "Value", "Text", JsonRequestBehavior.AllowGet));
        }

    }

}

using CountyCityAjax.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CountyCityAjax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CascadingModel cascading = new CascadingModel();
            cascading.Countries = PopulateDropDown("select CountryId ,CountryName from Countris", "CountryId", "CountryName");
            return View(cascading);
      
        }

        //populatedropdown is user defined function created to fill country dropdown
        public List<SelectListItem> PopulateDropDown(string query, string textColumn, string valueColumn)
        {
            List<SelectListItem> ilist = new List<SelectListItem>();
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ilist.Add(new SelectListItem
                            {
                                Text = reader[textColumn].ToString(),
                                Value = reader[valueColumn].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }
            return ilist;

        }


        [HttpPost]
        public ActionResult Index(int countryId, int stateId, int cityId)
        {
            CascadingModel model = new CascadingModel();
            model.Countries = PopulateDropDown("SELECT CountryId, CountryName FROM Countries", "CountryName", "CountryId");
            model.States = PopulateDropDown("SELECT StateId, StateName FROM States WHERE CountryId = " + countryId, "StateName", "StateId");
            model.Cities = PopulateDropDown("SELECT CityId, CityName FROM Cities WHERE StateId = " + stateId, "CityName", "CityID");
            return View(model);
        }

        [HttpPost]
        public JsonResult AjaxMethod(string type, int value)
        {
            CascadingModel model = new CascadingModel();
            switch (type)
            {
                case "CountryId":
                    model.States = PopulateDropDown("SELECT StateId, StateName FROM States WHERE CountryId = " + value, "StateName", "StateId");
                    break;
                case "StateId":
                    model.Cities = PopulateDropDown("SELECT CityId, CityName FROM Cities  WHERE StateId = " + value, "CityName", "CityId");
                    break;
            }
            return Json(model);
        }




    }

}

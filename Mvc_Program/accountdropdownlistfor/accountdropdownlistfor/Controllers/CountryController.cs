using accountdropdownlistfor.Models;
using Microsoft.AspNetCore.Mvc;

namespace accountdropdownlistfor.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CountryModel cm)
        {
            var cmt = cm.selectcountry;
            ViewBag.cmt=cmt.ToString();
            return View();
        }
    }
}

using checkboxmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace checkboxmvc.Controllers
{
    public class TeaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Tea t)
        {
            if (t.tea == true)
            {
                ViewBag.tea = "You Selected Tea";
            }
            if (t.Loundary == true)
            {
                ViewBag.Loundary ="you selected loundary";
            }
            if(t.Breakfast == true)
            {
                ViewBag.Breakfast = "you selected breakfast";
            }
            return View();

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using validdataannotation.Models;

namespace validdataannotation.Controllers
{
    public class StudentDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(StudentModel sm)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Name=sm.Name;
                ViewBag.Age=sm.Age;
                ViewBag.Email=sm.Email;
                ViewBag.conemail = sm.ConfirmEmail;
                return View("Index");
            }
            else
            {
                ViewBag.Name = "No Data";
                ViewBag.Age="No Data";
                ViewBag.Email = "No Data";
                ViewBag.conemail = "No Data";
                return View("Index");
            }
        }
    }
}

using FormValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FormValidation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(StudentModel st)
        {
            if (string.IsNullOrEmpty(st.Name))
            {
                ModelState.AddModelError("Name", "Name Required");
               
            }
          
            if(st.Age==0 || st.Age > 120)
            {
                ModelState.AddModelError("Age", "Please enter valid age between 1-120");
            }
            if (ModelState.IsValid)
            {
                ViewBag.Name = st.Name;
                ViewBag.Age = st.Age;
                return View("Index");
            }
            else
            {
                ViewBag.Name = "No Data";
                    ViewBag.Age = "No Data";
                    return View("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
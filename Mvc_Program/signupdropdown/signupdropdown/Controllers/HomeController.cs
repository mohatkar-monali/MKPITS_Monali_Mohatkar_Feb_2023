using Microsoft.AspNetCore.Mvc;
using signupdropdown.Models;
using System.Diagnostics;

namespace signupdropdown.Controllers
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
        
        public IActionResult Index(Signup sp)
        {
            ViewBag.uname = sp.username;
            ViewBag.gen = sp.gender;
           
            var ct=sp.getcity;
            ViewBag.city=ct.ToString();
            ViewBag.sub1 = null;
            ViewBag.sub2 = null;
            if (sp.sub1 == true)
            {
                ViewBag.sub1 = "dotnet";
            }
           else if (sp.sub2 == true)
            {
                ViewBag.sub2 = "java";
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
using evenodd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace evenodd.Controllers
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

        public IActionResult Index(Even e)
        {
            int num = e.n1;
            string res = "";
            if (num % 2 == 0)
            {
                res = "even";
            }
            else
            {
                res = "odd";
            }
            ViewBag.result = res;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using sgowgreaterno.Models;
using System.Diagnostics;

namespace sgowgreaterno.Controllers
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

        [HttpPost]
        public ActionResult Index(GreaterModel gm   )
        {
            if (gm.num1 > gm.num2)
            {
                ViewBag.res = "Number 1 is greater";
            }
            else
            {
                ViewBag.res = "number 2 is greater";
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
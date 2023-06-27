using checkoperation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace checkoperation.Controllers
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
        public ActionResult Index(Operation o)
        {
            ViewBag.num1 = o.number1;
            ViewBag.num2 = o.number2;
            if (o.addition == true)
            {
                ViewBag.result1 = o.number1+o.number2;
                ViewBag.result = o.result1;
            }
            if(o.substraction == true)
            {
                ViewBag.result2=o.number1 -o.number2;
                ViewBag.result = o.result2;
            }
            if(o.multiplication == true)
            {
                ViewBag.result3=o.number1 *o.number2;
                ViewBag.result = o.result3;
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
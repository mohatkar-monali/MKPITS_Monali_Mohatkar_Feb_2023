using Microsoft.AspNetCore.Mvc;
using radiobuttonfor.Models;
using System.Diagnostics;

namespace radiobuttonfor.Controllers
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
        public ActionResult Index(UserModel m)
        {
            ViewBag.num1 = m.number1;
            ViewBag.num2 = m.number2;
            string b = m.caltype;
            int result = 0;
            if (b == "add")
            {
                result = m.number1 + m.number2;

            }
            if (b == "sub")
            {
                result = m.number1 - m.number2;

            }
            if (b == "mul")
            {
                result = m.number1 * m.number2;
            }
            ViewBag.res=result;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
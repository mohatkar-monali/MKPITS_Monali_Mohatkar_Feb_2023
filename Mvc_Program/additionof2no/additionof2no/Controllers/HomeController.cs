using additionof2no.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace additionof2no.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
      //  [HttpPost]
        public IActionResult Index(CalculateModel c)

        {
            int num1 = c.num1;
            int num2 = c.num2;
            int result=num1 + num2;
            ViewBag.res=result;
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
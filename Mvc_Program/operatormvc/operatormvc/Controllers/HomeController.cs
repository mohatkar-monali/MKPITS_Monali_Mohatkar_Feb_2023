using Microsoft.AspNetCore.Mvc;
using operatormvc.Models;
using System.Diagnostics;

namespace operatormvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public IActionResult Index(Operator k)
        {
            ViewBag.result = k.result;

            ViewBag.num1 = k.num1;
            ViewBag.num2 = k.num2;
            //char op;
            ViewBag.op=k.op;
            if (k.op == '+')
            {
                ViewBag.result = k.num1 + k.num2;
            }

            else if (k.op == '-')
            {
                ViewBag.result = k.num1 - k.num2;
            }

            else if (k.op == '*')
            {
                ViewBag.result = k.num1 * k.num2;
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
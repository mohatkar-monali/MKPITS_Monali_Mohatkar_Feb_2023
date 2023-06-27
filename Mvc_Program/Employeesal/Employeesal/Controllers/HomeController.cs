using Employeesal.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Employeesal.Controllers
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
        public IActionResult Index(Employee e)
        {
            ViewBag.name = e.EmpName;
            ViewBag.bsal = e.BasicSalary;
            if (e.hra == true)
            {
                e.result1 =e.BasicSalary * 0.25 ;
                ViewBag.result1 = e.result1;
            }
            if (e.da == true)
            {
                e.result2 = e.BasicSalary * 0.45;
                ViewBag.result2 = e.result2;
            }
            if(e.ta == true)
            {
                e.result3 = e.BasicSalary * 0.15;
                ViewBag.result3 = e.result3;
            }
            ViewBag.totalsal=e.result1 + e.result2+e.result3;
            ViewBag.total =e.totalsal;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
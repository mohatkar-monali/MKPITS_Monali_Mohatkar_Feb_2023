using accountdropdownlistfor.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace accountdropdownlistfor.Controllers
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
        public IActionResult Index(Account ac)
        {
            int balance = 1000;
            int accounno = ac.accountno;
            int amount = ac.amount;
            var transtype = ac.GetTranstype;
            string transt=transtype.ToString();
            
            switch(transt)
            {
                case "deposite":
                    balance = balance + amount;
                    break;
                case "withdrwa":
                    balance = balance - amount;
                    break;

            }
            ViewBag.accno =accounno ;
            ViewBag.Bal= balance;
            ViewBag.typ=transtype.ToString() ;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
using dropdownproduct.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace dropdownproduct.Controllers
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
        public IActionResult Index(Product p)
        {
            ViewBag.ono = p.orderno;
            ViewBag.cname = p.custname;
            ViewBag.price=p.price;
            ViewBag.qty = p.quantity;
            ViewBag.ptype = p.producttype;
            int tprice = p.price * p.quantity;
            ViewBag.totalprice=tprice;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
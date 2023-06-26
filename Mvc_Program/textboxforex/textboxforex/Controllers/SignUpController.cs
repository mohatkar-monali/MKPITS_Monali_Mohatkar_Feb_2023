using Microsoft.AspNetCore.Mvc;
using textboxforex.Models;

namespace textboxforex.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index(SignUpModel s)
        {
            ViewBag.name=s.Name;
            ViewBag.password=s.Password;
            return View();
        }
    }
}

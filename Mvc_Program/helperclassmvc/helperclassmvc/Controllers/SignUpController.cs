using helperclassmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace helperclassmvc.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult signup(SignUp s)
        {
            ViewBag.name = s.Name;
            ViewBag.password = s.password;
            return View();
        }
    }
}

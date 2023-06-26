using Microsoft.AspNetCore.Mvc;

namespace mvccontroller1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Student()
        {
            return View();
        }

    }
}

using Microsoft.AspNetCore.Mvc;

namespace mvccontroller1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

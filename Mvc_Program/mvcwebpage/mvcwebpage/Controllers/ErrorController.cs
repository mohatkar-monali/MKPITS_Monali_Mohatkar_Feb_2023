using Microsoft.AspNetCore.Mvc;

namespace mvcwebpage.Controllers
{
    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

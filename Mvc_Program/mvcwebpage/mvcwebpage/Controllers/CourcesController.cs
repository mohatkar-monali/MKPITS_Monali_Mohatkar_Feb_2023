using Microsoft.AspNetCore.Mvc;

namespace mvcwebpage.Controllers
{
    public class CourcesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace mvcwebpage.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

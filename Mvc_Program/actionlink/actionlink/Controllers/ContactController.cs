using Microsoft.AspNetCore.Mvc;

namespace actionlink.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

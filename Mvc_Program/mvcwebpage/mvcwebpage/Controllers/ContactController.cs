using Microsoft.AspNetCore.Mvc;

namespace mvcwebpage.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

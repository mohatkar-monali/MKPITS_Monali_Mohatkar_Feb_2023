using Microsoft.AspNetCore.Mvc;
using ItemDbConncetion.Models;
namespace ItemDbConncetion.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //----Add new item----
        public IActionResult create()
        {
            return View();
        }

        [HttpPost]  
        public IActionResult create(ItemModel itm)
        {
            if(ModelState.IsValid)
            {
                ItemDbHandler idb = new ItemDbHandler();
                if(idb.InsertItem(itm))
                {
                    ViewBag.message = "record inserted successfully";
                    ModelState.Clear(); 
                }
            }
            return View();
        }
    }
}

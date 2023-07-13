using DbConItemListClass.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DbConItemListClass.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ItemDbHandler db = new ItemDbHandler();
            ModelState.Clear();
            return View(db.GetItems());
        }

        [HttpGet] 
        public ActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ItemModel im)
        {  
            if(ModelState.IsValid)
            {
                ItemDbHandler db = new ItemDbHandler();
                if(db.InsertItem(im))
                {
                    ViewBag.Message = "Record Saved Successfully";
                    ModelState.Clear();
                }

            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {                                                    
            ItemDbHandler Handler = new ItemDbHandler();
            return View(Handler.GetItems().Find(m=>m.Id==id));
        }
        [HttpPost]
        public ActionResult Edit(int id,ItemModel im)
        {
            try
            {
                ItemDbHandler db = new ItemDbHandler();
                db.UpdateItem(im);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ItemDbHandler Handler = new ItemDbHandler();
            return View(Handler.GetItems().Find(m => m.Id == id));
        }
        [HttpPost]
        public ActionResult Delete(int id, ItemModel imt)
        {
            try
            {
                ItemDbHandler db = new ItemDbHandler();
                db.DeleteItem(imt);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }
       
        //another way
        
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        ItemDbHandler ItemHandler = new ItemDbHandler();
        //        if (ItemHandler.DeleteItem(id))
        //        {
        //            ViewBag.AlertMsg = "Item Deleted Successfully";
        //        }
        //        return RedirectToAction("Index");
        //    }
        //    catch { return View(); }
        //}
        public ActionResult Details(int id)
        {
            ItemDbHandler itemDbHandler = new ItemDbHandler();
            return View(itemDbHandler.GetItems().Find(m=>m.Id==id));
        }
    }
}
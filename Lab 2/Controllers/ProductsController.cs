using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        //GET : Products/World
        public ActionResult World(string WorldName)
        {
            ViewBag.WorldName = WorldName;
            return View();
        }
    }
}
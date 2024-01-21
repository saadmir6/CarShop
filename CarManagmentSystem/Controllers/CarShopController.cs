using CarManagmentSystem.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManagmentSystem.Controllers
{
    public class CarShopController : Controller
    {
        private readonly DataContext _context = new DataContext();

        // GET: CarShop
        public ActionResult Careers()
        {
            return View();
        }
        
        public ActionResult Sell()
        {
            return View();
        }
        
        public ActionResult Service()
        {
            return View();
        }
        
        public ActionResult Shop()
        {
            var products = _context.Cars.ToList();

            return View(products);
        }
        
        public ActionResult Stores()
        {
            var stores = _context.storesData.ToList();

            return View(stores);

        }
    }
}
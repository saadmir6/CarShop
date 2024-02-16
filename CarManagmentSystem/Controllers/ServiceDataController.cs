using CarManagmentSystem.Models;
using CarManagmentSystem.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CarManagmentSystem.Controllers
{
    public class ServiceDataController : Controller
    {

        private readonly DataContext _context = new DataContext();
        // GET: ServiceData
        public ActionResult ServiceTable()
        {
            var serviceTable = _context.seriveData.ToList();
            return View(serviceTable);
        }

        // POST: ServiceData/AddService
        public ActionResult AddService([FromBody] ServiceData serviceData)
        {
            if (serviceData == null)
            {
                return Content("Invalid data");
            }

            _context.seriveData.Add(serviceData);
            _context.SaveChanges();
            return Json(serviceData);
        }
    }
}
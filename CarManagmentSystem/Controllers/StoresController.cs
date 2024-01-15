using CarManagmentSystem.Models;
using CarManagmentSystem.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CarManagmentSystem.Controllers
{
    public class StoresController : Controller
    {
        private readonly DataContext _context = new DataContext();


        // GET: Stores
        public ActionResult Index()
        {
            return View();
        }


        // POST: Stores/AddStore
        public async Task<ActionResult> AddStore([System.Web.Http.FromBody] StoresData data)
        {
            //if (data == null) { return Content("Invalid Data Entered"); }

            //_context.storesData.Add(data);
            //await _context.SaveChangesAsync();
            //return Json(data);

            //var _data = (data == null) ? Content("Invalid data entered") : _context.storesData.Add(data);

        }

        // DELETE: Stores/DeleteData/{id}
        public async Task<ActionResult> DeleteData(int id)
        {

        }

        //PUT: Stores/PutData/{id}
        public async Task<ActionResult> PutData(int id)
        {

        }
    }
}
using CarManagmentSystem.Models;
using CarManagmentSystem.MyDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace CarManagmentSystem.Controllers
{
    public class StoresController : Controller
    {
        private readonly DataContext _context = new DataContext();


       public ActionResult Stores()
        {
            var stores = _context.storesData.ToList();
            return View(stores);
        }


        // POST: Stores/AddStore
        public ActionResult AddStore([System.Web.Http.FromBody] StoresData data)
        {

            // if (data == null) { return Content("Invalid Data Entered"); 
            //_context.storesData.Add(data);
            //_context.SaveChangesAsync();
            //return Json(data);


            _context.storesData.Add(data ?? null);
            _context.SaveChanges();
            return Json(data)
        }

        // DELETE: Stores/DeleteData/{id}
        public async Task<ActionResult> DeleteData(int id)
        {
            var data = await _context.storesData.FindAsync(id) ?? throw new Exception();
            _context.storesData.Remove(data);
            _context.SaveChanges();
            return Json(data);
        }
        
            

        //PUT: Stores/PutData/{id}
        public async Task<ActionResult> PutData(int id, [FromBody] StoresData data)
        {
            if (id != data.Id)
            {
                throw new Exception();
            }

            var existingData = await _context.storesData.FindAsync(data.Id);

            _context.Entry(existingData).CurrentValues.SetValues(data);

            _context.Entry(existingData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Json(data);
        }
    }
}
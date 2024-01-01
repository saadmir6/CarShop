using CarManagmentSystem.Models;
using CarManagmentSystem.MyDatabase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;


namespace CarManagmentSystem.Controllers
{
    public class DataController : Controller
    {
        private readonly DataContext _context = new DataContext();


        //public ActionResult Index()
        //{

        //    var product = _context.Cars.ToList();

        //    return View(product);
        //}


        // POST: CarShop/CreateProduct
        public async Task<ActionResult> CreateProduct([System.Web.Http.FromBody] Cars data)
        {
            if (data == null)
            {
                return Content("Invalid data");
            }

            _context.Cars.Add(data);
            await _context.SaveChangesAsync();

            return Json(data);
        }


        // DELETE: CarShop/DeleteProduct/{id}
        [HttpDelete]
        public async Task<ActionResult> DeleteProduct(int id)
        {

            var data = await _context.Cars.FindAsync(id) ?? throw new Exception(); // Using null-coalescing operator
            _context.Cars.Remove(data);
            await _context.SaveChangesAsync();

            return Json(data);

        }


        // PUT: CarShop/UpdateProduct/{id}
        [HttpPut]
        public async Task<ActionResult> UpdateProduct(int Id, [System.Web.Http.FromBody] Cars data)
        {

            if (Id != data.Id)
            {
                throw new Exception();
            }
            var existingData = await _context.Cars.FindAsync(Id);

            _context.Entry(existingData).CurrentValues.SetValues(data);

            _context.Entry(existingData).State = EntityState.Modified;

            try
            {

                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw new DbUpdateConcurrencyException();
            }

            return Json(data);
        }  
    }
}
        


    






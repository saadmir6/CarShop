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
    public class CarShopController : Controller
    {
        private readonly DataContext _context = new DataContext();

        // POST: CarShop/Create
        
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

            var data = await _context.Cars.FindAsync(id);

            if (data == null)
            {
                throw new Exception();
            }

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

            //existingData.Image = data.Image;
            //existingData.Name = data.Name;
            //existingData.Year = data.Year;
            //existingData.Miles = data.Miles;
            //existingData.Company = data.Company;
            //existingData.Type = data.Type;

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

        //[HttpGet]
        //public  ActionResult ViewProduct()
        //{
        //    //var products = await _context.Products.ToListAsync();

        //    var dataList = _context.Cars.ToList();
        //    return HttpRequestWrapper(dataList);
        //}

        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _context.Cars.ToListAsync();

            if (products == null || products.Count == 0)
            {
                return Content("No products found");
            }

            return Json(products, JsonRequestBehavior.AllowGet);
        }


    }
}
        


    






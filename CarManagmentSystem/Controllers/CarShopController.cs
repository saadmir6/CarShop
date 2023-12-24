using CarManagmentSystem.Models;
using CarManagmentSystem.MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Results;

//using System.Web.Http;
using System.Web.Mvc;


namespace CarManagmentSystem.Controllers
{
    public class CarShopController : Controller
    {
        private readonly DataContext _context = new DataContext();

        // POST: Product/Create
        [HttpPost]
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

        public DeleteProduct(int id)
        {
            return;
        }

        public UpdateProduct()
        {
            return;
        }

        public ViewProduct(int id)
        {
            return;
        }
    }
}
        


    






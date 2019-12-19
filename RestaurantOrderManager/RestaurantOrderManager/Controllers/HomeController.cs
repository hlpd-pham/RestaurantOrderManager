using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestaurantOrderManager.Models;

namespace RestaurantOrderManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        public ActionResult OrderDetail()
        {
            var chosenOrder = new Order(){orderId = 3, orderName = "Long", status = "DONE"};
            
            Console.WriteLine(chosenOrder.orderName);
            Console.WriteLine(chosenOrder.status);
            Console.WriteLine(chosenOrder.orderId);
            return View(chosenOrder);
        }
    }
}
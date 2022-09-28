using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Collections.Generic;
using mvc_assignment_dorien.Models;


namespace MvcMovie.Controllers
{
    public class CustomerController : Controller
    {
        // 
        // GET: /Customer/
        public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /Customer/Orders/ 
        public IActionResult Orders()
        {
            return View(new CustomerViewModel
            {
                CustomerNumber = 111111,
                FirstName = "John",
                LastName = "Smith",
                Orders = new List<CustomerOrder> {
                new CustomerOrder
                {
                    Id = 1,
                    OrderDate = new System.DateTime(),
                    Description = "Part 1",
                    Total = 10.00m
                },
                new CustomerOrder
                {
                    Id = 2,
                    OrderDate = new System.DateTime(),
                    Description = "Part 2",
                    Total = 20.00m
                },
                new CustomerOrder
                {
                    Id = 3,
                    OrderDate = new System.DateTime(),
                    Description = "Part 3",
                    Total = 30.00m
                }
        }
            });
        }
    }
}
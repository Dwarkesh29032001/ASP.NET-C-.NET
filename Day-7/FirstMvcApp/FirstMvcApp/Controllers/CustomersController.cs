using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMvcApp.Models;

namespace FirstMvcApp.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers;
        List<Order> orders;
        public CustomersController()
        {
            customers= new List<Customer>()
            {
                new Customer() {CustomerId=1001,ContactName="Alicia K.",City="Berlin"},
                new Customer() {CustomerId=1002,ContactName="John Mark",City="London"},
                new Customer() {CustomerId=1003,ContactName="Maria Andrus",City="Berlin"},
            };
            orders = new List<Order>()
            {
                new Order(){OrderId=1,OrderDate=DateTime.Now,Quantity=100,CustomerId=1001},
                new Order(){OrderId=2,OrderDate=DateTime.Now,Quantity=100,CustomerId=1003},
            };
        }
        // GET: Customers
        public ActionResult Index()
        {
            //if (DateTime.Now.Month<6)
            //{
            //    return View("List");
            //}
            //else
            //{
            //    return View();
            //}
            return View();
        }
        //Customers/List
        public ActionResult List()
        {
            
            //ViewBag.PageTitle = "Welcome To Customers List!";
            //ViewBag.PageSubTitle = "Customers Of Synechron Pvt. Ltd. From Globe!";
            //ViewBag.Orders=orders;
            ViewData["PageTitle"] = "Welcome To Customers List!";
            ViewData["PageSubTitle"] = "Customers Of Synechron Pvt. Ltd. From Globe!";
            ViewData["Orders"] = orders;
            return View(customers);
        }
        public ActionResult One()
        {
            ViewBag.PageTitle = "Page - 1 From ViewBag";
            ViewData["PageTitle"] = "Page - 1 From ViewData";
            TempData["PageTitle"] = "Page - 1 From TempData";
            return RedirectToAction("Two");
        }
        public ActionResult Two()
        {
            return View();
        }
    }
}
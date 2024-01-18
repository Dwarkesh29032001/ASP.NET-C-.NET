using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using SecondMVCApp.Models;


namespace SecondMVCApp.Controllers
{
    public class ProductsController : Controller
    {

        List<Employee> employees;
        List<Product> products;

        public ProductsController()
        {
            employees = new List<Employee>() { 
            
            new Employee() {EmployeeID = 1001 , EmployeeName="Dwarkesh.V" , EmployeeAddress = "Pune"},
            new Employee() {EmployeeID = 1002 , EmployeeName="Amey.D" , EmployeeAddress = "Warud"},
            new Employee() {EmployeeID = 1003 , EmployeeName="Abhishek.G" , EmployeeAddress = "Wakad"},
            
            };

            products = new List<Product>() { 
            
            new Product() {ProductID=5001 , ProductName="MI" , ProductPrice=30000} ,
            new Product() {ProductID=5002 , ProductName="Realme" , ProductPrice=40000} ,
            new Product() {ProductID=5003 , ProductName="OnePlus" , ProductPrice=50000} 
            
            };



        }
        // GET: Products

        public ActionResult List() {
          //  ViewBag.employees = employees;
            ViewData["PageTilte"] = "Welcome To Employees List !";
            ViewData["PageTilte1"] = "Welcome To Product List !";

            ViewData["Employee"] = employees;

           /* ViewData["PageSubTilte"] = "Product List !";*/

            return View(products);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using Synechron.EventsPortal_DEMO.Models;
using Synechron.EventsPortal_DEMO.DAL;
using System.CodeDom;


namespace Synechron.EventsPortal_DEMO.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly EmployeeDal _employeeDal;
        /*  EmployeeDal employeeDal;*/

        /* public EmployeesController()
         {
             employeeDal = new EmployeeDal();
         } */

        public EmployeesController(EmployeeDal dal)
        {
            _employeeDal = dal;
        }

        // GET: Employees
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Welcome To Synechron Employee List !";
            ViewBag.PageSubTitle = "Core Development Team of India !";

            return View(_employeeDal.GetAllEmployees());
        }


        public ActionResult Details(int id)
        {
            ViewBag.PageTitle = "Welcome To Synechron Employees Details!";
            ViewBag.PageSubTitle = "Core Development Team Of India!";
            return View(_employeeDal.GetEmployeeDetails(id));
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Avatar = "~/Images/boy.png";
                int result = _employeeDal.InsertEmployee(employee);
                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
            return View();
        }



    }
}
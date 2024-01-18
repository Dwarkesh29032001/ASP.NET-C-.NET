using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Synechron.EventsPortal.Dal;
using Synechron.EventsPortal.Models;


namespace Synechron.EventsPortal.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeesDal _employeesDal;
        public EmployeesController(EmployeesDal dal)
        {
            _employeesDal= dal;
        }
        // GET: Employees
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Welcome To Synechron Employees List!";
            ViewBag.PageSubTitle = "Core Development Team Of India!";
            return View(_employeesDal.GetAllEmployees());
        }
        public ActionResult Details(int id)
        {
            ViewBag.PageTitle = "Welcome To Synechron Employees List!";
            ViewBag.PageSubTitle = "Core Development Team Of India!";
            return View(_employeesDal.GetEmployeeDetails(id));
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Avatar = "~/Images/noimage.png";
                int result = _employeesDal.InsertEmployee(employee);
                if (result>0)
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
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
    public class EventController : Controller
    {

        private readonly EventDal _eventDal;
        /*  EmployeeDal employeeDal;*/

        /* public EmployeesController()
         {
             employeeDal = new EmployeeDal();
         } */

        public EventController(EventDal dal)
        {
            _eventDal = dal;
        }

        // GET: Employees
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Welcome To Synechron Event List !";
            ViewBag.PageSubTitle = "Core Development Team of India !";

            return View(_eventDal.GetAllEvents());
        }


        public ActionResult Details(int id)
        {
            ViewBag.PageTitle = "Welcome To Synechron Event Details!";
            ViewBag.PageSubTitle = "Core Development Team Of India!";
            return View(_eventDal.GetEventDetails(id));
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Event events)
        {
            if (ModelState.IsValid)
            {
                events.Logo = "~/Images/logo1.jpeg";
                int result = _eventDal.InsertEvent(events);
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
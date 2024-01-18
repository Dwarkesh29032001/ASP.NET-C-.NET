using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagementExamples.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 1)]
        public ActionResult News()
        {
            return View();
        }
        public ActionResult WriteProfile()
        {
            HttpCookie profileCookie = new HttpCookie("Profile");
            profileCookie.Secure = true;
            profileCookie.HttpOnly = true;
            profileCookie.Expires= DateTime.Now.AddMinutes(2);
            profileCookie.Values.Add("FirstName", "Manish");
            profileCookie.Values.Add("LastName", "Kaushik");
            Response.AppendCookie(profileCookie);
            return RedirectToAction("ReadProfile");
        }
        public ActionResult ReadProfile()
        {
            HttpCookie readProfile = Request.Cookies["Profile"];
            if (readProfile != null)
            {
                ViewBag.FirstName = readProfile.Values.Get("FirstName");
                ViewBag.LastName = readProfile.Values.Get("LastName");
            }
            return View();
        }
        public ActionResult Index()
        {
            ViewBag.Discount = HttpContext.Application["Discount"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
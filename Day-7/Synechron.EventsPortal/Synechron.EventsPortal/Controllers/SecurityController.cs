using Synechron.EventsPortal.Dal;
using Synechron.EventsPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Synechron.EventsPortal.Controllers
{
    public class SecurityController : Controller
    {
        private readonly SecurityDal _securityDal;

        public SecurityController(SecurityDal securityDal)
        {
            _securityDal = securityDal;
        }

        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                User authenticatedUser = _securityDal.AuthenticateCredentials(user);
                if (authenticatedUser.Email != null)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
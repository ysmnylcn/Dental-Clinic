using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DentalClinic.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult Appointments()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Dentists()
        {
            return View();
        }
        public ActionResult Patients()
        {
            return View();
        }
        public ActionResult Treatments()
        {
            return View();
        }
        public ActionResult Diseases()
        {
            return View();
        }
        public ActionResult LogIn()
        {
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(string firstName, string lastName, string email, int phoneNumber, string password)
        {
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Email = email;
            ViewBag.PhoneNumber = phoneNumber;
            ViewBag.Password = password;
            return View();
        }

    }
}
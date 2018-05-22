using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Registration(int INPUT = 0)
        {
            ViewBag.data = INPUT;
            return View();
        }

        public ActionResult Welcome(int input = 0)
        {
            ViewBag.data = input;
            return View();
        }
    }
}
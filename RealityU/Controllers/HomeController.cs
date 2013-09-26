using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealityU.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Welcome     = "Welcome to RealityU";
            ViewBag.Sponsor     = "Brought to you by Communities in Schools";
            ViewBag.EnterPrompt = "Enter your group ID # right here:\t";
            ViewBag.AdminPrompt = "Admin - type your password here:\t";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabSupportWebApp.Controllers
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

        public ActionResult Queue()
        {
            ViewBag.Message = "You are now in a queue";

            return View();
        }

        public ActionResult HeadOfQueue()
        {
            ViewBag.Message = "You are now head of the queue";

            return View();
        }
    }
}
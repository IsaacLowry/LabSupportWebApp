using LabSupportWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;

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

        public ActionResult Queue()
        {
            ViewBag.Message = "User is in a queue";

            return View();
        }

        [HttpPost]
        public ActionResult Queue(int UserCode)
        {

            try
            {


                if (ModelState.IsValid && Request.IsAuthenticated)
                {
                    StudentUser studentUser = new StudentUser();
                    studentUser.Qcode = UserCode;
                    if (studentUser.Qcode == QueueObject.code)
                    {
                        QueueObject.StudentsInQueue.Enqueue(studentUser);
                        System.Diagnostics.Debug.WriteLine(QueueObject.StudentsInQueue.Count);
                    }


                    studentUser.Name = System.Security.Claims.ClaimsPrincipal.Current.FindFirst("name").Value;

                    System.Diagnostics.Debug.WriteLine(studentUser.Qcode);
                    System.Diagnostics.Debug.WriteLine(studentUser.Name);


                    return View("Queue");
                } else
                {
                    return View("Index");
                }

            }

            catch
            {
                return View("Index");
            }
        }

        public ActionResult HeadOfQueue()
        {
            ViewBag.Message = "You are now head of the queue";

            return View();
        }

        public ActionResult CreateAQueue()
        {
            ViewBag.Message = "Create your queue";

            return View();
        }

        public ActionResult QueueList()
        {
            ViewBag.Message = "Open Queues";

            return View();
        }

        public ActionResult QueueManager()
        {
            ViewBag.Message = "Open Queue";

            return View();
        }

        [HttpPost]
        public ActionResult QueueManager(string labName, string TeamsLink)
        {
            try
            {
                if (ModelState.IsValid && Request.IsAuthenticated)
                {
                    
                    QueueObject.labName = labName;
                    QueueObject.TeamsLink = TeamsLink;
                    System.Diagnostics.Debug.WriteLine(QueueObject.labName);
                    System.Diagnostics.Debug.WriteLine(QueueObject.TeamsLink);

                    Random QcodeRandomiser = new Random();
                    int code = QcodeRandomiser.Next(100000, 1000000);
                    System.Diagnostics.Debug.WriteLine(code);
                    QueueObject.code = code;
                    System.Diagnostics.Debug.WriteLine(QueueObject.code);

                    return View("QueueManager");
                }
                else
                {
                    return View();
                }
            } 
            catch
            {
                return View();
            }
            
        }

        public ActionResult NewAdminUser()
        {
            ViewBag.Message = "Open Queue";

            return View();
        }

        public ActionResult AddAdminToQueue()
        {
            ViewBag.Message = "Open Queue";

            return View();
        }

        public ActionResult RemoveAdminFromQueue()
        {
            ViewBag.Message = "Open Queue";

            return View();
        }

        public void SignIn()
        {
            if (!Request.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.Challenge(
                    new AuthenticationProperties { RedirectUri = "/" },
                    OpenIdConnectAuthenticationDefaults.AuthenticationType);
            }
        }

        /// <summary>
        /// Send an OpenID Connect sign-out request.
        /// </summary>
        public void SignOut()
        {
            HttpContext.GetOwinContext().Authentication.SignOut(
                    OpenIdConnectAuthenticationDefaults.AuthenticationType,
                    CookieAuthenticationDefaults.AuthenticationType);
        }

    }
}
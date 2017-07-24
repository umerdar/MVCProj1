using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Attendees()
        {
            ViewBag.Message = "Your Attendees List Page.";

            return View();
        }

        public ActionResult RegisterClient()
        {
            ViewBag.Message = "Register Attendee Client.";

            return View();
        }

        public ActionResult RegisterAttendee()
        {
            ViewBag.Message = "Register Attendee Page.";

            return View();
        }
        [HttpPost] 
        public ActionResult RegisterAttendees(Attendees r)
        {
            if (ModelState.IsValid)
            {
                using (ClarityConferenceEntities cce = new ClarityConferenceEntities())
                {
                    Attendees_tbl ar = new Attendees_tbl();
                    ar.FirstName = r.FirstName;
                    ar.LastName = r.LastName;
                    ar.Email = r.Email;
                    ar.ClientId = r.ClientId;
                    cce.Attendees_tbl.Add(ar);
                    cce.SaveChanges();
                    Response.Write("<script> alert('Submission successful.')</script>");
                    
                }
            }
        }
    }
}
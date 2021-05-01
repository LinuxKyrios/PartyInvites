using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Hello" : "Good Evening";
            return View();
        }

        public ViewResult RsvpForm()
        {
            return View();
        }
        //Method for RSVP form as user may want to confirm his presence 
    }
}

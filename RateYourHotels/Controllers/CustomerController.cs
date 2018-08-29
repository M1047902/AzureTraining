using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RateYourHotels.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
           
        }
        [ActionName("TryLogin")]
        public ActionResult Login(string id)
        {
            Session["UserName"] = "Geetha";
            Session["UserID"] = "sadfas";
            return this.RedirectToAction("HotelRating", "Hotel");

        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BussinessLayer;

namespace RateYourHotels.Controllers
{
    public class HotelController : Controller
    {
        // GET: Hotel
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HotelRating()
        {
            
            return View();
        }
        public ActionResult MustTry()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetHotels()
        {
            HotelRating hotelRating = new HotelRating();
            var hotels = hotelRating.GetAllHotels();
            return Json(hotels, JsonRequestBehavior.AllowGet);

        }

    }
}
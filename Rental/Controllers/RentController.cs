using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class RentController : Controller
    {
        // GET: Rent
        public ActionResult NewRent_ToView()
        {
            ViewBag.Title = "New Rental";
            return View();
        }
    }
}
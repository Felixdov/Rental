using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class CarsDescriptionController : Controller
    {
        // GET: CarsDescription
        public ActionResult CarsDescription_View()
        {
            ViewBag.Title = "רכבים מומלצים";
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
    }
}
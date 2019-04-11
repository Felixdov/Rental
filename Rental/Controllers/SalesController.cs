using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Sales_View()
        {
            ViewBag.Title = "מבצעים חמים";
            return View();
        }
    }
}
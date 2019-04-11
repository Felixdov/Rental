using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rental.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders_View
        public ActionResult Orders_View()
        {
            ViewBag.Title = "הזמנות";
            return View();
        }
    }
}
using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Rental.Dal;

//using Rental_BE;

namespace Rental.Controllers
{
    public class CarOrdersApiController : ApiController
    {
        //private RentCarEntities dal = new RentCarEntities();
        //private CarsDal dal = new CarsDal();

        public List<OrderList> GetAllOrders() // the methoda is called because its named Get... and by the call from the JQuery
        {
            using (CarsDal dal = new CarsDal())
            {
                return dal.OrderLists.ToList();

            }
        }
    }
}

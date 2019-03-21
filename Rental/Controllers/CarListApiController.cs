using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Rental.dal_sql;
using Rental_BE;

namespace Rental.Controllers
{
    public class CarListApiController : ApiController
    {
        // GET: CarListApi
        private RentCarEntities dal = new RentCarEntities();
       

      //  Cars_dal dal = new Cars_dal();
        //List<CarInventory> carList = new List<CarInventory>()
        //{
           
        //    //new CarModel {carTypeID=1,categorie="famaly",modelName="mazda3" },
        //    // new CarModel {carTypeID=2,categorie="mini",modelName="mazda2" },
        //    //  new CarModel {carTypeID=3,categorie="famaly",modelName="mazda6" },
        //};

        public IEnumerable<carinventory> GetAllCars() // the methoda is called because its named Get... and by the call from the JQuery
        {

            using (RentCarEntities dal=new RentCarEntities())
            {
                return dal.carinventories.ToList();
            }
                
        }

                
        public IHttpActionResult GetCar(int id) //GET that returns value by parameter.
        {

            var car = dal.carinventories.FirstOrDefault(c => c.CarID == id); //compare cartypeID to id;
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }

    }
}
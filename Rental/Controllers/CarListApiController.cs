using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Rental.Dal;
using Rental.BE_Logic;


namespace Rental.Controllers
{
    public class CarListApiController : ApiController
    {
     
        public IEnumerable<CarInventory> GetAllCars() // the methoda is called because its named Get... and by the call from the JQuery
        {
            //using (RentCarEntities dal=new RentCarEntities())
            //{
            //    return dal.carinventories.ToList();
            //}
            using (CarsDal dal = new CarsDal())
            {
                return dal.CarInventories.ToList();
                //return null;
            }
        }


        //method : returns car details by car ID (number)
        public CarInventory GetChosenCar(int CarID) // the methoda is called because its named Get... and by the call from the JQuery
        {

            //using (RentCarEntities dal=new RentCarEntities())
            //{
            //    return dal.carinventories.ToList();
            //}
            using (CarsLogic carsfromdb = new CarsLogic())
            {
                return carsfromdb.ChosenCar(CarID);
            }

        }

        //method returns chosen car by selected type from select tag
        public IQueryable<CarInventory> GetCarByCategory(string CarTypeName)
        {

            using (CarsLogic carsByCategory = new CarsLogic())
            {
                return carsByCategory.CarByCategory(CarTypeName).AsQueryable();
                //return from x in dal.CarInventories
                //       where x.CarTypeName.Contains(CarTypeName)
                //       select x;
            }
        }


        // not working yet
        public IQueryable<CarInventory> PostAvailableCars(DateTime dateIn, DateTime dateOut)
        {

            using (CarsLogic availableCars = new CarsLogic())
            {

                //DateTime parsedIn = DateTime.Parse(dateIn);
                //DateTime parsedOut = DateTime.Parse(dateOut);
                DateTime parsedIn = dateIn;
                DateTime parsedOut = dateOut;
                return availableCars.AvailableCars(parsedIn, parsedOut).AsQueryable();
                //return from x in dal.CarInventories
                //       where x.CarTypeName.Contains(CarTypeName)
                //       select x;
            }
        }

        //not working yet brcause of date type 

        public IQueryable<CarInventory> postneworder(string carType, DateTime dateIn, DateTime dateOut)
        {

            using (CarsLogic availableCars = new CarsLogic())
            {
                string cType = carType;
                DateTime In = dateIn;
                DateTime Out = dateOut;
                return availableCars.AvailableCars(dateIn, dateOut).AsQueryable();
                //return from x in dal.CarInventories
                //       where x.CarTypeName.Contains(CarTypeName)
                //       select x;
            }
        }

        //public IHttpActionResult GetCar(int id) //GET that returns value by parameter.
        //{

        //    var car = dal.carinventories.FirstOrDefault(c => c.CarID == id); //compare cartypeID to id;
        //    if (car == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(car);
        //}

    }
}
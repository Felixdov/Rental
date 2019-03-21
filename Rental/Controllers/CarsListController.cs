using Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rental.dal_sql;

namespace Rental.Controllers
{
    public class CarsListController : Controller
    {

        

        //Cars_dal carsdal = new Cars_dal();
        object cacheCars = HttpRuntime.Cache["cars"];
        public List<CarInventory> GetCars()
        {

            if (cacheCars == null)
            {
                cacheCars = new List<CarInventory>
                {
                    new CarInventory{carId=900,carTypeID=222,color="red",engine="1300"},
        
                };

            }
            return (List<CarInventory>)HttpRuntime.Cache["cars"];
        }

        // GET: CarsList
        public ActionResult Index()
        {
            return View(GetCars());
        }

        public ActionResult Inde2x()
        {

            
           //using (CarInventory carInventory = new CarInventory)
           // {


           //     List<CarInventory> cars2 = new List<CarInventory>();


              return View();
           // }
           // //{
            //    new CarModel
            //    {
            //        carTypeID=300,
            //        modelName="Fiat",
            //        pricePerDay=110.33M

            //    }
            //};
            

        }

    }
}
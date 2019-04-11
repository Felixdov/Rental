using Rental.BE_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rental.Models;

namespace Rental_BE
{
    public class CarsLogic : BaseLogic
    {
        public IEnumerable<CarInventory> CarList()
        {
            return null; /*DB.carinventories;*/
        }


        public CarInventory ChosenCar(int id)
        {
            //CarInventory oneCar = DB.carinventories.FirstOrDefault(c => c.ID == id);
            //if (oneCar == null)
            //{
            //    return null;
            //}
            //else
            //{
            //    return (oneCar);
            //}
            return null;

        }


        //public List<CarInventory> CarByCategory(string CarTypeName)
        //{
        //    return (NewMethod(CarTypeName)).ToList();
        //}

        //private IQueryable<CarInventory> NewMethod(string CarTypeName)
        //{
        //    return from x in DB.carinventories

        //           where x.CarTypeName.Contains(CarTypeName)
        //           select x;
        //}

        //public void PostCreateNewCar(CarInventory car)
        //{
        //    DB.carinventories.Add(car);
        //    DB.SaveChanges();
        //}

        //public List<OrderList> ShowOrderList()
        //{
        //    return DB.OrderLists.ToList();

        //}
        //return (from x in DB.carinventories

        //           where x.CarTypeName.Contains(CarTypeName)
        //           select x).ToList();

    }
}

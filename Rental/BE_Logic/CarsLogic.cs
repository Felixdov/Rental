﻿using Rental.BE_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rental.Models;
using Rental.Dal;
using System.Data.Entity;

namespace Rental.BE_Logic

{
    public class CarsLogic : BaseLogic
    {
        public IEnumerable<CarInventory> CarList()
        {
            return null; /*DB.carinventories;*/
        }


        public CarInventory ChosenCar(int id)
        {
            CarInventory oneCar = DB.CarInventories.FirstOrDefault(c => c.ID == id);
            if (oneCar == null)
            {
                return null;
            }
            else
            {
                return (oneCar);
            }

        }


        public List<CarInventory> CarByCategory(string CarTypeName)
        {
            return (NewMethod(CarTypeName)).ToList();
        }

        private IQueryable<CarInventory> NewMethod(string CarTypeName)
        {
            return from x in DB.CarInventories

                   where x.CarTypeName.Contains(CarTypeName)
                   select x;
        }


        public List<CarInventory> AvailableCars(DateTime dateIn ,DateTime dateOut)
        {
            return (NewMethod1(dateIn, dateOut)).ToList();
        }

        private IQueryable<CarInventory> NewMethod1(DateTime d1, DateTime d2)
        {
            return from x in DB.CarInventories
                   from ord in x.OrderLists

                   where  
                   d1> ord.DropOffDate && d2>ord.DropOffDate

                   select x;

            //where dateIn<x.PickUpDate && dateOut < x.DropOffDate
            //       where dateIn > x.PickUpDate && dateOut < x.DropOffDate
        }


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

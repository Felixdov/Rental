using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_BE
{
    public class CarsLogic : BaseLogic
    {
        public IEnumerable<carinventory> CarList()
        {
            return DB.carinventories.AsEnumerable();
        }


        public carinventory ChosenCar(int id)
        {
            carinventory oneCar = DB.carinventories.FirstOrDefault(c => c.ID == id);
            if (oneCar == null)
            {
                return null;
            }
            else
            {
                return (oneCar);
            }
        }


        public List<carinventory> CarByCategory(string CarTypeName)
        {
            return (NewMethod(CarTypeName)).ToList();
        }

        private IQueryable<carinventory> NewMethod(string CarTypeName)
        {
            return from x in DB.carinventories

                   where x.CarTypeName.Contains(CarTypeName)
                   select x;
        }

        public void PostCreateNewCar(carinventory car)
        {
            DB.carinventories.Add(car);
            DB.SaveChanges();
        }

        //public List<OrderList> ShowOrderList()
        //{
        //    return DB.OrderLists.ToList();

        //}
        //return (from x in DB.carinventories

        //           where x.CarTypeName.Contains(CarTypeName)
        //           select x).ToList();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_BE
{
    public class CarsLogic : BaseLogic
    {
        public List<carinventory> CarList()
        {
            return DB.carinventories.ToList();
        }


        public carinventory ChosenCar(int id)
        {
            carinventory oneCar = DB.carinventories.FirstOrDefault(c => c.CarID == id);
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
            return (from x in DB.carinventories
                    
                    where x.CarTypeName.Contains(CarTypeName)
                    select x).ToList();
        }


        public void PostCreateNewCar(carinventory car)
        {
            DB.carinventories.Add(car);
            DB.SaveChanges();
        }


    }
}

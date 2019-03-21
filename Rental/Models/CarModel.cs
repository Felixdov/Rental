using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rental.Models
{
    public class CarModel // מותאם ל שדות בדטה בייס
    {

        public int carTypeID { get; set; }
        public string modelName { get; set; }
        public string manufactorName { get; set; }
        public string manufactorYear { get; set; }
        public string categorie { get; set; }
        public decimal pricePerDay { get; set; }

       
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Rental.Models
{
    public class CarInventory
    {
        [Key]
        public int carId { get; set; }
        public int carTypeID { get; set; }
        public string color { get; set; }
        public string engine { get; set; }

    }
}
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
        public int CarTypeId { get; set; }
        [Key]
        public int ID { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public string CarTypeName { get; set; }
        public Nullable<decimal> PricePerDay { get; set; }
        public List<OrderList> OrderLists { get; set; }


        //public virtual List<OrderList> OrderLists { get; set; }

    }
}
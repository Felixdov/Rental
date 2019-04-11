using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rental.Models
{
    public class OrderList
    {
        //public partial class OrderList
        //{
        [Key]
        public int OrderID { get; set; }
        public string CustName { get; set; }
        //[ForeignKey("ID")]
        public int CarID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime PickUpDate { get; set; }
        public System.DateTime DropOffDate { get; set; }
        public Nullable<decimal> DiscountCode { get; set; }
        public Nullable<decimal> OrderCost { get; set; }
        [ForeignKey("CarID")]
        public CarInventory CarInventory { get; set; }

        //public virtual carinventory CarinventoryOld { get; set; }
        //}
    }
}
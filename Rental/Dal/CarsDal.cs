using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Rental.Models;


namespace Rental.Dal
{
    public class CarsDal : DbContext
    {
        //internal object carinventories;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderList>().ToTable("OrderList");
            modelBuilder.Entity<CarInventory>().ToTable("carinventory");

        }
        //public DbSet<CarInventory> CarInventories { get; set; }
        public DbSet<OrderList> OrderLists { get; set; }
        public DbSet<CarInventory> CarInventories { get; set; }

    }
}
//modelBuilder.Entity<Person>().HasMany(x => x.Roles).WithMany(); example
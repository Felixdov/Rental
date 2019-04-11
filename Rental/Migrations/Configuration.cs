namespace Rental.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Rental.Dal.CarsDal>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Rental.Dal.CarsListDal";
        }

        protected override void Seed(Rental.Dal.CarsDal context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}

namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.carinventory",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CarTypeId = c.Int(nullable: false),
                        Color = c.String(),
                        Engine = c.String(),
                        CarTypeName = c.String(),
                        PricePerDay = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.carinventory");
        }
    }
}

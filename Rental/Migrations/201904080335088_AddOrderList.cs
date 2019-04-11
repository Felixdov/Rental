namespace Rental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrderList : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.carinventory");
            CreateTable(
                "dbo.OrderLists",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustName = c.String(),
                        CarID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        PickUpDate = c.DateTime(nullable: false),
                        DropOffDate = c.DateTime(nullable: false),
                        DiscountCode = c.Decimal(precision: 18, scale: 2),
                        OrderCost = c.Decimal(precision: 18, scale: 2),
                        CarInventory_ID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.carinventory", t => t.CarInventory_ID)
                .Index(t => t.CarInventory_ID);
            
            AddColumn("dbo.carinventory", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.carinventory", "ID");
            DropColumn("dbo.carinventory", "CarID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.carinventory", "CarID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.OrderLists", "CarInventory_ID", "dbo.carinventory");
            DropIndex("dbo.OrderLists", new[] { "CarInventory_ID" });
            DropPrimaryKey("dbo.carinventory");
            DropColumn("dbo.carinventory", "ID");
            DropTable("dbo.OrderLists");
            AddPrimaryKey("dbo.carinventory", "CarID");
        }
    }
}

namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableOrderAndOrderDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Qtu = c.Double(nullable: false),
                        ExpireDateProduct = c.DateTime(),
                        ProductionDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .Index(t => t.OrderID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        DateOfOperation = c.DateTime(nullable: false),
                        StorageName = c.String(),
                        TypeOf = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "PersonID", "dbo.People");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropIndex("dbo.Orders", new[] { "PersonID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
        }
    }
}

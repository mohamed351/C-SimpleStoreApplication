namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredInTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MeasruingUnit = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ProductStores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        StoreID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Qtu = c.Double(nullable: false),
                        ExpireDate = c.DateTime(nullable: false),
                        ProductDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .ForeignKey("dbo.Stores", t => t.StoreID, cascadeDelete: true)
                .Index(t => t.StoreID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Stores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.People", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.People", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductStores", "StoreID", "dbo.Stores");
            DropForeignKey("dbo.ProductStores", "ProductID", "dbo.Products");
            DropIndex("dbo.ProductStores", new[] { "ProductID" });
            DropIndex("dbo.ProductStores", new[] { "StoreID" });
            AlterColumn("dbo.People", "Phone", c => c.String());
            AlterColumn("dbo.People", "Name", c => c.String());
            DropTable("dbo.Stores");
            DropTable("dbo.ProductStores");
            DropTable("dbo.Products");
        }
    }
}

namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableOrderAndOrderDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.OrderDetails", "ProductID");
            AddForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
        }
    }
}

namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWareHourseTransformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WareHouseTransformationLogs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DestinationStoreID = c.Int(nullable: false),
                        DestinationStoreName = c.String(),
                        SourceStoreID = c.Int(nullable: false),
                        ProductName = c.String(),
                        Quantity = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WareHouseTransformationLogs");
        }
    }
}

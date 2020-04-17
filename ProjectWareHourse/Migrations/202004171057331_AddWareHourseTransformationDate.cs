namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWareHourseTransformationDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WareHouseTransformationLogs", "TransfromationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.WareHouseTransformationLogs", "DestinationStoreName", c => c.String(nullable: false));
            AlterColumn("dbo.WareHouseTransformationLogs", "ProductName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WareHouseTransformationLogs", "ProductName", c => c.String());
            AlterColumn("dbo.WareHouseTransformationLogs", "DestinationStoreName", c => c.String());
            DropColumn("dbo.WareHouseTransformationLogs", "TransfromationDate");
        }
    }
}

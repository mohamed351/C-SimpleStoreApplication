namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWareHourseColumnStorageName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WareHouseTransformationLogs", "SourceStorageName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WareHouseTransformationLogs", "SourceStorageName");
        }
    }
}

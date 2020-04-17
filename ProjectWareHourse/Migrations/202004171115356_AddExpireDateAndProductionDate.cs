namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddExpireDateAndProductionDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WareHouseTransformationLogs", "ExpireDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.WareHouseTransformationLogs", "ProductionDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WareHouseTransformationLogs", "ProductionDate");
            DropColumn("dbo.WareHouseTransformationLogs", "ExpireDate");
        }
    }
}

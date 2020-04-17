namespace ProjectWareHourse.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCodeToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Code", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Products", "Code", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Products", new[] { "Code" });
            DropColumn("dbo.Products", "Code");
        }
    }
}

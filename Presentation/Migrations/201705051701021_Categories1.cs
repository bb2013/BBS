namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categories1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ParentId", c => c.Int());
            AddColumn("dbo.Categories", "Order", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Order");
            DropColumn("dbo.Categories", "ParentId");
        }
    }
}

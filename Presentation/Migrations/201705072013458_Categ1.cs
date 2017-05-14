namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categ1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ParentId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ParentId");
        }
    }
}

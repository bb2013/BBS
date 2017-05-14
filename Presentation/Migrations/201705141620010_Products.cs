namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "MetaTitle", c => c.String());
            AddColumn("dbo.Categories", "MetaKeywords", c => c.String());
            AddColumn("dbo.Categories", "MetaDescription", c => c.String());
            AddColumn("dbo.Categories", "Url", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Url");
            DropColumn("dbo.Categories", "MetaDescription");
            DropColumn("dbo.Categories", "MetaKeywords");
            DropColumn("dbo.Categories", "MetaTitle");
        }
    }
}

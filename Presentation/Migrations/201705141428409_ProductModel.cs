namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Url", c => c.String());
            AddColumn("dbo.Products", "MetaTitle", c => c.String());
            AddColumn("dbo.Products", "MetaKeywords", c => c.String());
            AddColumn("dbo.Products", "MetaDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "MetaDescription");
            DropColumn("dbo.Products", "MetaKeywords");
            DropColumn("dbo.Products", "MetaTitle");
            DropColumn("dbo.Products", "Url");
        }
    }
}

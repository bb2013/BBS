namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categ : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoriesModel_CategoriesModelId", c => c.Int());
            CreateIndex("dbo.Categories", "CategoriesModel_CategoriesModelId");
            AddForeignKey("dbo.Categories", "CategoriesModel_CategoriesModelId", "dbo.Categories", "CategoriesModelId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "CategoriesModel_CategoriesModelId", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "CategoriesModel_CategoriesModelId" });
            DropColumn("dbo.Categories", "CategoriesModel_CategoriesModelId");
        }
    }
}

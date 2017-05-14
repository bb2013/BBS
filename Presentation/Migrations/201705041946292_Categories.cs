namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Categories : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductsToCategoriesModels", "CategoriesModel_CategoriesModelId", "dbo.Categories");
            DropForeignKey("dbo.ProductsToCategoriesModels", "ProductsModel_ProductsModelId", "dbo.Products");
            DropIndex("dbo.ProductsToCategoriesModels", new[] { "CategoriesModel_CategoriesModelId" });
            DropIndex("dbo.ProductsToCategoriesModels", new[] { "ProductsModel_ProductsModelId" });
            RenameColumn(table: "dbo.ProductsToCategoriesModels", name: "CategoriesModel_CategoriesModelId", newName: "CategoriesModelId");
            RenameColumn(table: "dbo.ProductsToCategoriesModels", name: "ProductsModel_ProductsModelId", newName: "ProductsModelId");
            AlterColumn("dbo.ProductsToCategoriesModels", "CategoriesModelId", c => c.Int(nullable: false));
            AlterColumn("dbo.ProductsToCategoriesModels", "ProductsModelId", c => c.Int(nullable: false));
            CreateIndex("dbo.ProductsToCategoriesModels", "CategoriesModelId");
            CreateIndex("dbo.ProductsToCategoriesModels", "ProductsModelId");
            AddForeignKey("dbo.ProductsToCategoriesModels", "CategoriesModelId", "dbo.Categories", "CategoriesModelId", cascadeDelete: true);
            AddForeignKey("dbo.ProductsToCategoriesModels", "ProductsModelId", "dbo.Products", "ProductsModelId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsToCategoriesModels", "ProductsModelId", "dbo.Products");
            DropForeignKey("dbo.ProductsToCategoriesModels", "CategoriesModelId", "dbo.Categories");
            DropIndex("dbo.ProductsToCategoriesModels", new[] { "ProductsModelId" });
            DropIndex("dbo.ProductsToCategoriesModels", new[] { "CategoriesModelId" });
            AlterColumn("dbo.ProductsToCategoriesModels", "ProductsModelId", c => c.Int());
            AlterColumn("dbo.ProductsToCategoriesModels", "CategoriesModelId", c => c.Int());
            RenameColumn(table: "dbo.ProductsToCategoriesModels", name: "ProductsModelId", newName: "ProductsModel_ProductsModelId");
            RenameColumn(table: "dbo.ProductsToCategoriesModels", name: "CategoriesModelId", newName: "CategoriesModel_CategoriesModelId");
            CreateIndex("dbo.ProductsToCategoriesModels", "ProductsModel_ProductsModelId");
            CreateIndex("dbo.ProductsToCategoriesModels", "CategoriesModel_CategoriesModelId");
            AddForeignKey("dbo.ProductsToCategoriesModels", "ProductsModel_ProductsModelId", "dbo.Products", "ProductsModelId");
            AddForeignKey("dbo.ProductsToCategoriesModels", "CategoriesModel_CategoriesModelId", "dbo.Categories", "CategoriesModelId");
        }
    }
}

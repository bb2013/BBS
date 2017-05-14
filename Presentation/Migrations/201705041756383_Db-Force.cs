namespace Presentation.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class DbForce : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoriesModelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoriesModelId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductsModelId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProductsModelId);
            
            CreateTable(
                "dbo.ProductsToCategoriesModels",
                c => new
                    {
                        ProductsToCategoriesModelId = c.Int(nullable: false, identity: true),
                        CategoriesModel_CategoriesModelId = c.Int(),
                        ProductsModel_ProductsModelId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductsToCategoriesModelId)
                .ForeignKey("dbo.Categories", t => t.CategoriesModel_CategoriesModelId)
                .ForeignKey("dbo.Products", t => t.ProductsModel_ProductsModelId)
                .Index(t => t.CategoriesModel_CategoriesModelId)
                .Index(t => t.ProductsModel_ProductsModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductsToCategoriesModels", "ProductsModel_ProductsModelId", "dbo.Products");
            DropForeignKey("dbo.ProductsToCategoriesModels", "CategoriesModel_CategoriesModelId", "dbo.Categories");
            DropIndex("dbo.ProductsToCategoriesModels", new[] { "ProductsModel_ProductsModelId" });
            DropIndex("dbo.ProductsToCategoriesModels", new[] { "CategoriesModel_CategoriesModelId" });
            DropTable("dbo.ProductsToCategoriesModels");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}

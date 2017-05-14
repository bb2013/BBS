namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoriIni : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Categories", name: "CategoriesModel_CategoriesModelId", newName: "Parent_CategoriesModelId");
            RenameIndex(table: "dbo.Categories", name: "IX_CategoriesModel_CategoriesModelId", newName: "IX_Parent_CategoriesModelId");
            DropColumn("dbo.Categories", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ParentId", c => c.Int());
            RenameIndex(table: "dbo.Categories", name: "IX_Parent_CategoriesModelId", newName: "IX_CategoriesModel_CategoriesModelId");
            RenameColumn(table: "dbo.Categories", name: "Parent_CategoriesModelId", newName: "CategoriesModel_CategoriesModelId");
        }
    }
}

namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Nume", c => c.String());
            AddColumn("dbo.Products", "CodProdus", c => c.String());
            AddColumn("dbo.Products", "DescriereProdus", c => c.String());
            AddColumn("dbo.Products", "GreutateProdus", c => c.String());
            AddColumn("dbo.Products", "Pret", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Producator", c => c.String());
            AddColumn("dbo.Products", "Categorie", c => c.String());
            AddColumn("dbo.Products", "IsActiv", c => c.Boolean(nullable: false));
            DropColumn("dbo.Products", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "IsActiv");
            DropColumn("dbo.Products", "Categorie");
            DropColumn("dbo.Products", "Producator");
            DropColumn("dbo.Products", "Pret");
            DropColumn("dbo.Products", "GreutateProdus");
            DropColumn("dbo.Products", "DescriereProdus");
            DropColumn("dbo.Products", "CodProdus");
            DropColumn("dbo.Products", "Nume");
        }
    }
}

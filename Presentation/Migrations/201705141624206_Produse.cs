namespace Presentation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produse : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Nume", c => c.String());
            AddColumn("dbo.Categories", "Titlu", c => c.String());
            AddColumn("dbo.Categories", "Descriere", c => c.String());
            DropColumn("dbo.Categories", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Name", c => c.String());
            DropColumn("dbo.Categories", "Descriere");
            DropColumn("dbo.Categories", "Titlu");
            DropColumn("dbo.Categories", "Nume");
        }
    }
}

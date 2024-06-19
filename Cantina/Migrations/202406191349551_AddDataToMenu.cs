namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToMenu : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Data", c => c.DateTime(nullable: false));
            AddColumn("dbo.Menus", "Nome", c => c.String());
            AddColumn("dbo.Menus", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Menus", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Discriminator");
            DropColumn("dbo.Menus", "Valor");
            DropColumn("dbo.Menus", "Nome");
            DropColumn("dbo.Menus", "Data");
        }
    }
}

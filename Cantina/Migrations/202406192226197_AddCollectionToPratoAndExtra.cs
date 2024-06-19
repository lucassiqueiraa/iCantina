namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCollectionToPratoAndExtra : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Extras", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Pratoes", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.Extras", new[] { "Menu_Id" });
            DropIndex("dbo.Pratoes", new[] { "Menu_Id" });
            CreateTable(
                "dbo.MenuExtras",
                c => new
                    {
                        Menu_Id = c.Int(nullable: false),
                        Extra_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Menu_Id, t.Extra_Id })
                .ForeignKey("dbo.Menus", t => t.Menu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Extras", t => t.Extra_Id, cascadeDelete: true)
                .Index(t => t.Menu_Id)
                .Index(t => t.Extra_Id);
            
            CreateTable(
                "dbo.MenuPratos",
                c => new
                    {
                        MenuId = c.Int(nullable: false),
                        PratoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MenuId, t.PratoId })
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("dbo.Pratoes", t => t.PratoId, cascadeDelete: true)
                .Index(t => t.MenuId)
                .Index(t => t.PratoId);
            
            DropColumn("dbo.Extras", "Menu_Id");
            DropColumn("dbo.Pratoes", "Menu_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pratoes", "Menu_Id", c => c.Int());
            AddColumn("dbo.Extras", "Menu_Id", c => c.Int());
            DropForeignKey("dbo.MenuPratos", "PratoId", "dbo.Pratoes");
            DropForeignKey("dbo.MenuPratos", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.MenuExtras", "Extra_Id", "dbo.Extras");
            DropForeignKey("dbo.MenuExtras", "Menu_Id", "dbo.Menus");
            DropIndex("dbo.MenuPratos", new[] { "PratoId" });
            DropIndex("dbo.MenuPratos", new[] { "MenuId" });
            DropIndex("dbo.MenuExtras", new[] { "Extra_Id" });
            DropIndex("dbo.MenuExtras", new[] { "Menu_Id" });
            DropTable("dbo.MenuPratos");
            DropTable("dbo.MenuExtras");
            CreateIndex("dbo.Pratoes", "Menu_Id");
            CreateIndex("dbo.Extras", "Menu_Id");
            AddForeignKey("dbo.Pratoes", "Menu_Id", "dbo.Menus", "Id");
            AddForeignKey("dbo.Extras", "Menu_Id", "dbo.Menus", "Id");
        }
    }
}

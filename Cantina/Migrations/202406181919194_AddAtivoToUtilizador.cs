namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAtivoToUtilizador : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilizadors", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilizadors", "Ativo");
        }
    }
}

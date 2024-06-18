namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilizadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NIF = c.Int(nullable: false),
                        Saldo = c.Decimal(precision: 18, scale: 2),
                        NumEstudante = c.String(),
                        Email = c.String(),
                        Username = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Extras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativo = c.Boolean(nullable: false),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.Faturas",
                c => new
                    {
                        IdFatura = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IdItem = c.Int(),
                        Descricao = c.String(),
                        Preco = c.Decimal(precision: 18, scale: 2),
                        FaturaId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Fatura_IdFatura = c.Int(),
                    })
                .PrimaryKey(t => t.IdFatura)
                .ForeignKey("dbo.Faturas", t => t.Fatura_IdFatura)
                .Index(t => t.Fatura_IdFatura);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        QtdDisponivel = c.Int(nullable: false),
                        PrecoEstudante = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecoProfessor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pratoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Tipo = c.String(),
                        Ativo = c.Boolean(nullable: false),
                        Menu_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.Menu_Id)
                .Index(t => t.Menu_Id);
            
            CreateTable(
                "dbo.Multas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NumHoras = c.Int(nullable: false),
                        Reserva_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reservas", t => t.Reserva_Id)
                .Index(t => t.Reserva_Id);
            
            CreateTable(
                "dbo.Reservas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataHora = c.DateTime(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        MenuId = c.Int(nullable: false),
                        Utilizada = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadors", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.MenuId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Multas", "Reserva_Id", "dbo.Reservas");
            DropForeignKey("dbo.Reservas", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.Reservas", "ClienteId", "dbo.Utilizadors");
            DropForeignKey("dbo.Pratoes", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Extras", "Menu_Id", "dbo.Menus");
            DropForeignKey("dbo.Faturas", "Fatura_IdFatura", "dbo.Faturas");
            DropIndex("dbo.Reservas", new[] { "MenuId" });
            DropIndex("dbo.Reservas", new[] { "ClienteId" });
            DropIndex("dbo.Multas", new[] { "Reserva_Id" });
            DropIndex("dbo.Pratoes", new[] { "Menu_Id" });
            DropIndex("dbo.Faturas", new[] { "Fatura_IdFatura" });
            DropIndex("dbo.Extras", new[] { "Menu_Id" });
            DropTable("dbo.Reservas");
            DropTable("dbo.Multas");
            DropTable("dbo.Pratoes");
            DropTable("dbo.Menus");
            DropTable("dbo.Faturas");
            DropTable("dbo.Extras");
            DropTable("dbo.Utilizadors");
        }
    }
}

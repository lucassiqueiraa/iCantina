﻿namespace Cantina.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateTime2ToMenu : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Menus", "DataHora", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Menus", "DataHora", c => c.DateTime(nullable: false));
        }
    }
}

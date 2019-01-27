namespace TradingView.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuoteAndSymbolModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Quotes",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        SymbolId = c.Int(nullable: false),
                        Timestamp = c.Long(nullable: false),
                        Open = c.Single(nullable: false),
                        High = c.Single(nullable: false),
                        Low = c.Single(nullable: false),
                        Close = c.Single(nullable: false),
                        Volume = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Symbols", t => t.SymbolId, cascadeDelete: true)
                .Index(t => t.SymbolId);
            
            CreateTable(
                "dbo.Symbols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Quotes", "SymbolId", "dbo.Symbols");
            DropIndex("dbo.Quotes", new[] { "SymbolId" });
            DropTable("dbo.Symbols");
            DropTable("dbo.Quotes");
        }
    }
}

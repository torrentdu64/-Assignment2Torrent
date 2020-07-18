namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductTrolleyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductTrolleys",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        TrolleyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProductId, t.TrolleyId })
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Trolleys", t => t.TrolleyId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.TrolleyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductTrolleys", "TrolleyId", "dbo.Trolleys");
            DropForeignKey("dbo.ProductTrolleys", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductTrolleys", new[] { "TrolleyId" });
            DropIndex("dbo.ProductTrolleys", new[] { "ProductId" });
            DropTable("dbo.ProductTrolleys");
        }
    }
}

namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerToTrolley : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Trolleys", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Trolleys", new[] { "User_Id" });
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Trolleys", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Products", "Price", c => c.String());
            CreateIndex("dbo.Trolleys", "CustomerId");
            AddForeignKey("dbo.Trolleys", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
            DropColumn("dbo.Products", "Category");
            DropColumn("dbo.Trolleys", "UserID");
            DropColumn("dbo.Trolleys", "User_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trolleys", "User_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Trolleys", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Category", c => c.String());
            DropForeignKey("dbo.Trolleys", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Trolleys", new[] { "CustomerId" });
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.Trolleys", "CustomerId");
            DropTable("dbo.Customers");
            CreateIndex("dbo.Trolleys", "User_Id");
            AddForeignKey("dbo.Trolleys", "User_Id", "dbo.AspNetUsers", "Id");
        }
    }
}

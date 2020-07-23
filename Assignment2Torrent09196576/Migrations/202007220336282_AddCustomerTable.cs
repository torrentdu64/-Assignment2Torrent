namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Trolleys", "Customer_Id", c => c.Int());
            CreateIndex("dbo.Trolleys", "Customer_Id");
            AddForeignKey("dbo.Trolleys", "Customer_Id", "dbo.Customers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trolleys", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Trolleys", new[] { "Customer_Id" });
            DropColumn("dbo.Trolleys", "Customer_Id");
            DropTable("dbo.Customers");
        }
    }
}

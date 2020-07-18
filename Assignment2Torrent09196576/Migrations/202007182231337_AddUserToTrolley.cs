namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserToTrolley : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trolleys", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.Trolleys", "User_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Trolleys", "User_Id");
            AddForeignKey("dbo.Trolleys", "User_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trolleys", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Trolleys", new[] { "User_Id" });
            DropColumn("dbo.Trolleys", "User_Id");
            DropColumn("dbo.Trolleys", "UserID");
        }
    }
}

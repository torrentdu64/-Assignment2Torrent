namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributeToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Password", c => c.String());
            AddColumn("dbo.Customers", "Role", c => c.String());
            AddColumn("dbo.Customers", "Token", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Token");
            DropColumn("dbo.Customers", "Role");
            DropColumn("dbo.Customers", "Password");
        }
    }
}

namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAttributeForProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Price", c => c.String());
            AddColumn("dbo.Products", "Discount", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Discount");
            DropColumn("dbo.Products", "Price");
            DropColumn("dbo.Products", "Description");
        }
    }
}

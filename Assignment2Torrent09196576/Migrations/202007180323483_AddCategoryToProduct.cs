namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryToProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
        }
    }
}

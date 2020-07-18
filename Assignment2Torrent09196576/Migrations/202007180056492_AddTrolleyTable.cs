namespace Assignment2Torrent09196576.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTrolleyTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trolleys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trolleys");
        }
    }
}

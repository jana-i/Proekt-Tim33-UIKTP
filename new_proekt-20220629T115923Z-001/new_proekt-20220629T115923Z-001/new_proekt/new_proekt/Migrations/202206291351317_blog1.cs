namespace new_proekt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blog1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        BlogID = c.Int(nullable: false, identity: true),
                        BlogTitle = c.String(nullable: false),
                        BLogContent = c.String(nullable: false),
                        BLogTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BlogID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Blogs");
        }
    }
}

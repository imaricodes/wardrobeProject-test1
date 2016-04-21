namespace wardrobeProject_test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHomePage : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Type = c.String(),
                        AltText = c.String(),
                        Caption = c.String(),
                        ImageUrl = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Images");
        }
    }
}

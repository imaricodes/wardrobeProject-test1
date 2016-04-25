namespace wardrobeProject_test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShoesModels",
                c => new
                    {
                        ShoeID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.ShoeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ShoesModels");
        }
    }
}

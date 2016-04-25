namespace wardrobeProject_test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bottom1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bottoms",
                c => new
                    {
                        BottomID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.BottomID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bottoms");
        }
    }
}

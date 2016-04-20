namespace wardrobeProject_test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tops",
                c => new
                    {
                        TopsID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.TopsID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tops");
        }
    }
}

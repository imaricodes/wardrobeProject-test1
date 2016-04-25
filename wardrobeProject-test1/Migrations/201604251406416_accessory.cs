namespace wardrobeProject_test1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accessory : DbMigration
    {
      
        public override void Up()
        {
            CreateTable(
                "dbo.Accessories",
                c => new
                    {
                        AccessoryID = c.Int(nullable: false, identity: true),
                        Nickname = c.String(),
                        Photo = c.String(),
                        Type = c.String(),
                        Color = c.String(),
                        Season = c.String(),
                        Occasion = c.String(),
                    })
                .PrimaryKey(t => t.AccessoryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accessories");
        }
    }
}

namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBedTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Beds",
                c => new
                    {
                        BedId = c.Int(nullable: false, identity: true),
                        WardId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BedId)
                .ForeignKey("dbo.Wards", t => t.WardId, cascadeDelete: true)
                .Index(t => t.WardId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Beds", "WardId", "dbo.Wards");
            DropIndex("dbo.Beds", new[] { "WardId" });
            DropTable("dbo.Beds");
        }
    }
}

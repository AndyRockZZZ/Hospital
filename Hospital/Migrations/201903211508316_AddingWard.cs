namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingWard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Wards",
                c => new
                    {
                        WardId = c.Int(nullable: false, identity: true),
                        WardName = c.String(),
                    })
                .PrimaryKey(t => t.WardId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Wards");
        }
    }
}

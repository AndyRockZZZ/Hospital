namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRotaTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rotas",
                c => new
                    {
                        RotaId = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        WardId = c.Int(nullable: false),
                        WeekShiftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RotaId)
                .ForeignKey("dbo.Staffs", t => t.StaffId, cascadeDelete: true)
                .ForeignKey("dbo.Wards", t => t.WardId, cascadeDelete: true)
                .ForeignKey("dbo.WeekShifts", t => t.WeekShiftId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.WardId)
                .Index(t => t.WeekShiftId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rotas", "WeekShiftId", "dbo.WeekShifts");
            DropForeignKey("dbo.Rotas", "WardId", "dbo.Wards");
            DropForeignKey("dbo.Rotas", "StaffId", "dbo.Staffs");
            DropIndex("dbo.Rotas", new[] { "WeekShiftId" });
            DropIndex("dbo.Rotas", new[] { "WardId" });
            DropIndex("dbo.Rotas", new[] { "StaffId" });
            DropTable("dbo.Rotas");
        }
    }
}

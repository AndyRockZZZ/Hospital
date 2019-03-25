namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeekShifts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeekShifts",
                c => new
                    {
                        WeekShiftId = c.Int(nullable: false, identity: true),
                        WeekShiftName = c.String(),
                    })
                .PrimaryKey(t => t.WeekShiftId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WeekShifts");
        }
    }
}

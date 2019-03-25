namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWeekShifts : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT WeekShifts ON");
            Sql("INSERT INTO WeekShifts(WeekShiftId, WeekShiftName) VALUES (1, 'Early')");
            Sql("INSERT INTO WeekShifts(WeekShiftId, WeekShiftName) VALUES (2, 'Day')");
            Sql("INSERT INTO WeekShifts(WeekShiftId, WeekShiftName) VALUES (3, 'Late')");
            Sql("INSERT INTO WeekShifts(WeekShiftId, WeekShiftName) VALUES (4, 'Night')");
            Sql("INSERT INTO WeekShifts(WeekShiftId, WeekShiftName) VALUES (5, 'Holiday')");
        }
        
        public override void Down()
        {
        }
    }
}

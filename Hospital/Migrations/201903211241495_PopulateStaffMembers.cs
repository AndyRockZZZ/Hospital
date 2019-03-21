namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStaffMembers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT StaffGrades ON");
            Sql("INSERT INTO StaffGrades (Id, Name) VALUES (1, 'Doctor')");
            Sql("INSERT INTO StaffGrades (Id, Name) VALUES (2, 'Nurse')");
            Sql("INSERT INTO StaffGrades (Id, Name) VALUES (3, 'Staff')");
            Sql("INSERT INTO StaffGrades (Id, Name) VALUES (4, 'Charge')");
        }
        
        public override void Down()
        {
        }
    }
}

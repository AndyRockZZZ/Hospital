namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStaff : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Staffs ON");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(1, 'Moira Samuels', 12, 4)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(2, 'Greg Wallace', 32, 3)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(3, 'Ben Bedmade', 12, 3)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(4, 'Iva Pain', 14, 2)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(5, 'Benjamin Walters', 01, 1)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(6, 'Bailey Noble', 45, 1)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(7, 'Hollie Wilkins', 68, 3)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(8, 'William Lees', 75, 2)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(9, 'Chloe Ball', 20, 4)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(10, 'Dylan Tomlinson', 77, 1)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(11, 'Madison Howells', 18, 2)");
            Sql("INSERT INTO Staffs(StaffId, StaffName, PhoneNumber, StaffGradeId) VALUES(12, 'Aidan Bennett', 72, 1)");
        }
        
        public override void Down()
        {
        }
    }
}

namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateWards : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Wards ON");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(1, 'Accident and Emergency')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(2, 'Anaesthetics')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(3, 'Breast Screening')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(4, 'Cardiology')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(5, 'Critical Care')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(6, 'Diagnostic Imaging')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(7, 'General Surgery')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(8, 'Medical')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(9, 'Nutrition')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(10,'Orthopaedic')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(11, 'Pharmacy')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(12, 'Physiotherapy')");
            Sql("INSERT INTO Wards(WardId, WardName) VALUES(13, 'Surgical')");

        }

        public override void Down()
        {
        }
    }
}

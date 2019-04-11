namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBedNumbers1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Beds ON");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (14, 4, 'true', 14)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (15, 4, 'true', 15)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (16, 4, 'true', 16)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (17, 5, 'true', 17)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (18, 5, 'true', 18)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (19, 5, 'true', 19)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (20, 5, 'true', 20)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (21, 6, 'true', 21)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (22, 6, 'true', 22)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (23, 6, 'true', 23)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (24, 6, 'true', 24)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (25, 7, 'true', 25)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (26, 7, 'true', 26)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (27, 7, 'true', 27)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (28, 7, 'true', 28)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (29, 8, 'true', 29)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (30, 8, 'true', 30)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (31, 8, 'true', 31)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (32, 8, 'true', 32)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (33, 9, 'true', 33)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (34, 9, 'true', 34)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (35, 9, 'true', 35)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (36, 9, 'true', 36)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (37, 10, 'true', 37)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (38, 10, 'true', 38)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (39, 10, 'true', 39)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (40, 10, 'true', 40)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (41, 11, 'true', 41)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (42, 11, 'true', 42)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (43, 11, 'true', 43)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (44, 11, 'true', 44)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (45, 12, 'true', 45)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (46, 12, 'true', 46)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (47, 12, 'true', 47)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (48, 12, 'true', 48)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (49, 13, 'true', 49)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (50, 13, 'true', 50)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (51, 13, 'true', 51)");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (52, 13, 'true', 52)");
        }
        
        public override void Down()
        {
        }
    }
}

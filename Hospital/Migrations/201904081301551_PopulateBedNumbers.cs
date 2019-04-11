namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBedNumbers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Beds ON");
            Sql("INSERT INTO Beds (BedId, WardId, IsAvailable, BedNumber) VALUES (13, 4, 'true', 13)");
        }
        
        public override void Down()
        {
        }
    }
}

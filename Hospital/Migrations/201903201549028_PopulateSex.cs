namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSex : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Sexes ON");
            Sql("INSERT INTO Sexes (Id, Name) VALUES (1, 'Male')");
            Sql("INSERT INTO Sexes (Id, Name) VALUES (2, 'Female')");
        }
        
        public override void Down()
        {
        }
    }
}

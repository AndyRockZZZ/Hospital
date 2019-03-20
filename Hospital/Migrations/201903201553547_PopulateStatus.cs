namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateStatus : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Status ON");
            Sql("INSERT INTO Status (Id, Name) VALUES (1, 'Single')");
            Sql("INSERT INTO Status (Id, Name) VALUES (2, 'Married')");
            Sql("INSERT INTO Status (Id, Name) VALUES (3, 'Widowed')");
            Sql("INSERT INTO Status (Id, Name) VALUES (4, 'Divorced')");
            Sql("INSERT INTO Status (Id, Name) VALUES (5, 'Separated')");
        }
        
        public override void Down()
        {
        }
    }
}

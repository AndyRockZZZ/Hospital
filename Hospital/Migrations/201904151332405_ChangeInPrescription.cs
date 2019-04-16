namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInPrescription : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Prescriptions", "UnitsPerDay", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Prescriptions", "UnitsPerDay", c => c.Single(nullable: false));
        }
    }
}

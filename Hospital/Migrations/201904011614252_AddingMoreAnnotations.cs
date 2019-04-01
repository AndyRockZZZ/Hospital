namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoreAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PatientSurname", c => c.String(nullable: false));
            AlterColumn("dbo.Patients", "Address1", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Patients", "Address2", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Patients", "PostCode", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime());
            AlterColumn("dbo.Patients", "PostCode", c => c.String(maxLength: 10));
            AlterColumn("dbo.Patients", "Address2", c => c.String());
            AlterColumn("dbo.Patients", "Address1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Patients", "PatientSurname", c => c.String());
        }
    }
}

namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationsToPatientModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "PatientName", c => c.String(maxLength: 70));
            AlterColumn("dbo.Patients", "Address1", c => c.String(maxLength: 100));
            AlterColumn("dbo.Patients", "PostCode", c => c.String(maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "PostCode", c => c.String());
            AlterColumn("dbo.Patients", "Address1", c => c.String());
            AlterColumn("dbo.Patients", "PatientName", c => c.String());
        }
    }
}

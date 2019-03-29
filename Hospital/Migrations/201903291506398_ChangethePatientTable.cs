namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangethePatientTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderId = c.Int(nullable: false, identity: true),
                        GenderName = c.String(),
                    })
                .PrimaryKey(t => t.GenderId);
            
            AddColumn("dbo.Patients", "PatientFirstName", c => c.String(maxLength: 70));
            AddColumn("dbo.Patients", "PatientSurname", c => c.String());
            DropColumn("dbo.Patients", "PatientName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Patients", "PatientName", c => c.String(maxLength: 70));
            DropColumn("dbo.Patients", "PatientSurname");
            DropColumn("dbo.Patients", "PatientFirstName");
            DropTable("dbo.Genders");
        }
    }
}

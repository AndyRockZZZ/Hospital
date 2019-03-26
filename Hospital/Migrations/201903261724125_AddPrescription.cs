namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPrescription : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DrugId = c.Int(nullable: false),
                        DrugStartDate = c.DateTime(),
                        UnitsPerDay = c.Int(nullable: false),
                        DrugEndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Drugs", t => t.DrugId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .Index(t => t.PatientId)
                .Index(t => t.DrugId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Prescriptions", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.Prescriptions", "DrugId", "dbo.Drugs");
            DropIndex("dbo.Prescriptions", new[] { "DrugId" });
            DropIndex("dbo.Prescriptions", new[] { "PatientId" });
            DropTable("dbo.Prescriptions");
        }
    }
}

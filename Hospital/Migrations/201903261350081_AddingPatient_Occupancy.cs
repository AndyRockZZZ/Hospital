namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingPatient_Occupancy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PatientOccupancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PatientId = c.Int(nullable: false),
                        DateAdmitted = c.DateTime(),
                        WardId = c.Int(nullable: false),
                        BedId = c.Int(nullable: false),
                        DischargeDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Beds", t => t.BedId, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Wards", t => t.WardId, cascadeDelete: false)
                .Index(t => t.PatientId)
                .Index(t => t.WardId)
                .Index(t => t.BedId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PatientOccupancies", "WardId", "dbo.Wards");
            DropForeignKey("dbo.PatientOccupancies", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.PatientOccupancies", "BedId", "dbo.Beds");
            DropIndex("dbo.PatientOccupancies", new[] { "BedId" });
            DropIndex("dbo.PatientOccupancies", new[] { "WardId" });
            DropIndex("dbo.PatientOccupancies", new[] { "PatientId" });
            DropTable("dbo.PatientOccupancies");
        }
    }
}

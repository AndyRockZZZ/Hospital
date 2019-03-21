namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddADrugTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Drugs",
                c => new
                    {
                        DrugId = c.Int(nullable: false, identity: true),
                        DrugName = c.String(),
                        Dosage = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.DrugId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Drugs");
        }
    }
}

namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addingGender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "GenderId", c => c.Int(nullable: true));
            CreateIndex("dbo.Patients", "GenderId");
            AddForeignKey("dbo.Patients", "GenderId", "dbo.Genders", "GenderId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "GenderId", "dbo.Genders");
            DropIndex("dbo.Patients", new[] { "GenderId" });
            DropColumn("dbo.Patients", "GenderId");
        }
    }
}

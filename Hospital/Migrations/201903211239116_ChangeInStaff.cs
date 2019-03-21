namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInStaff : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StaffGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Staffs", "StaffGradeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Staffs", "StaffGradeId");
            AddForeignKey("dbo.Staffs", "StaffGradeId", "dbo.StaffGrades", "Id", cascadeDelete: true);
            DropColumn("dbo.Staffs", "Grade");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Staffs", "Grade", c => c.String());
            DropForeignKey("dbo.Staffs", "StaffGradeId", "dbo.StaffGrades");
            DropIndex("dbo.Staffs", new[] { "StaffGradeId" });
            DropColumn("dbo.Staffs", "StaffGradeId");
            DropTable("dbo.StaffGrades");
        }
    }
}

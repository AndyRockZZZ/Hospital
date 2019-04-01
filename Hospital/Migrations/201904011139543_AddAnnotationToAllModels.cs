namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAnnotationToAllModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wards", "WardName", c => c.String(maxLength: 70));
            AlterColumn("dbo.Drugs", "DrugName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Staffs", "StaffName", c => c.String(maxLength: 100));
            AlterColumn("dbo.StaffGrades", "Name", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StaffGrades", "Name", c => c.String());
            AlterColumn("dbo.Staffs", "StaffName", c => c.String());
            AlterColumn("dbo.Drugs", "DrugName", c => c.String());
            AlterColumn("dbo.Wards", "WardName", c => c.String());
        }
    }
}

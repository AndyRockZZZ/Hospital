namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoreAnnotationsToStaffWardDrug : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Drugs", "DrugName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Staffs", "StaffName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Staffs", "StaffName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Drugs", "DrugName", c => c.String(maxLength: 100));
        }
    }
}

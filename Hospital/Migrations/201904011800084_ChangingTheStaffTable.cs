namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingTheStaffTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Staffs", "StaffFirstName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Staffs", "StaffSurname", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Staffs", "StaffSurname");
            DropColumn("dbo.Staffs", "StaffFirstName");
        }
    }
}

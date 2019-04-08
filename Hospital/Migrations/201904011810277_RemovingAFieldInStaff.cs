namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingAFieldInStaff : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Staffs", "StaffName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Staffs", "StaffName", c => c.String(nullable: false, maxLength: 100));
        }
    }
}

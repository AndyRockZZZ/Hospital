namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldOnBed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beds", "IsAvailable", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Beds", "IsAvailable");
        }
    }
}

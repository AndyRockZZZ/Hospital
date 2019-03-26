namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingTheBedTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Beds", "BedNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Beds", "BedNumber");
        }
    }
}

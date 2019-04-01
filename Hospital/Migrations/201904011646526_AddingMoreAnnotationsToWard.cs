namespace Hospital.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingMoreAnnotationsToWard : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Wards", "WardName", c => c.String(nullable: false, maxLength: 70));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Wards", "WardName", c => c.String(maxLength: 70));
        }
    }
}

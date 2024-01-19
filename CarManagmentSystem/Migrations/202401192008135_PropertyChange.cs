namespace CarManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PropertyChange : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.StoresDatas", "ShowroomHours", c => c.String(unicode: false));
            AlterColumn("dbo.StoresDatas", "ServiceHours", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.StoresDatas", "ServiceHours", c => c.Int(nullable: false));
            AlterColumn("dbo.StoresDatas", "ShowroomHours", c => c.Int(nullable: false));
        }
    }
}

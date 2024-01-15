namespace CarManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class storesData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StoresDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(unicode: false),
                        AddressDetail = c.String(unicode: false),
                        Telephone = c.Int(nullable: false),
                        ShowroomDays = c.String(unicode: false),
                        ShowroomHours = c.Int(nullable: false),
                        ServiceDays = c.String(unicode: false),
                        ServiceHours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StoresDatas");
        }
    }
}

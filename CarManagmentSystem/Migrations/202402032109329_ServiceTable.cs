namespace CarManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        DateTime = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceDatas");
        }
    }
}

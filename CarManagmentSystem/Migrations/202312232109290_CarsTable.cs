namespace CarManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CarsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                name:"dbo.Cars",
                columnsAction:c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(unicode: false),
                        Miles = c.String(unicode: false),
                        Year = c.Int(nullable: false),
                        Company = c.String(unicode: false),
                        Type = c.String(unicode: false),
                        Image = c.Binary(),
                    })
                .PrimaryKey(keyExpression:t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable(name:"dbo.Cars");
        }
    }
}

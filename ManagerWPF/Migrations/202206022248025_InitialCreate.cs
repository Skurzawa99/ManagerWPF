namespace ManagerWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbp.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateToEmployee = c.String(),
                        DateDismiss = c.String(),
                        Money = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comments = c.String(),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbp.Employees", "GroupId", "dbo.Groups");
            DropIndex("dbp.Employees", new[] { "GroupId" });
            DropTable("dbo.Groups");
            DropTable("dbp.Employees");
        }
    }
}

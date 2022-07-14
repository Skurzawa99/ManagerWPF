namespace ManagerWPF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateToEmployeAndDateDismissType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbp.Employees", "DateToEmployee", c => c.DateTime(nullable: false));
            AlterColumn("dbp.Employees", "DateDismiss", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbp.Employees", "DateDismiss", c => c.String());
            AlterColumn("dbp.Employees", "DateToEmployee", c => c.String());
        }
    }
}

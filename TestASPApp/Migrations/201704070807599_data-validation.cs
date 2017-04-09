namespace TestASPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datavalidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "SecondName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "SecondName", c => c.String());
            AlterColumn("dbo.Users", "Name", c => c.String());
        }
    }
}

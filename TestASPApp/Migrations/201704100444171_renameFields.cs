namespace TestASPApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameFields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Users", "Name");
            DropColumn("dbo.Users", "SecondName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "SecondName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
        }
    }
}

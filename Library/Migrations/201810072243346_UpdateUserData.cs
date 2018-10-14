namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "hireDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Salary", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Salary");
            DropColumn("dbo.AspNetUsers", "hireDate");
        }
    }
}

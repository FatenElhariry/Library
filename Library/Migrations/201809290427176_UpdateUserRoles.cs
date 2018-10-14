namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUserRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "ConfirmedEmail", c => c.Boolean(defaultValue:true));
            AddColumn("dbo.AspNetUsers", "CompleteRegisterationStep", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CompleteRegisterationStep");
            DropColumn("dbo.AspNetRoles", "ConfirmedEmail");
        }
    }
}

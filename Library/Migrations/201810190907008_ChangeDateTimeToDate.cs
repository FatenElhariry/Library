namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "BirthDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "BirthDate", c => c.DateTime(nullable: false));
        }
    }
}

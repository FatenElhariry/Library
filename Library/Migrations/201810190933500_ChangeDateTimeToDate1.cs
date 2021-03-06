namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeDateTimeToDate1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Books", "PublishDate", c => c.DateTime(nullable: false, storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Books", "PublishDate", c => c.DateTime(nullable: false));
        }
    }
}

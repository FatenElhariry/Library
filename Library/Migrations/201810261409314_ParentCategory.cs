namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "parent", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "parent");
            AddForeignKey("dbo.Categories", "parent", "dbo.Categories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "parent", "dbo.Categories");
            DropIndex("dbo.Categories", new[] { "parent" });
            DropColumn("dbo.Categories", "parent");
        }
    }
}

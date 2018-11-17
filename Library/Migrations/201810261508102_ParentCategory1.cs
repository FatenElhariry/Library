namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ParentCategory1 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Categories", new[] { "parent" });
            AlterColumn("dbo.Categories", "parent", c => c.Int());
            CreateIndex("dbo.Categories", "parent");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Categories", new[] { "parent" });
            AlterColumn("dbo.Categories", "parent", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "parent");
        }
    }
}

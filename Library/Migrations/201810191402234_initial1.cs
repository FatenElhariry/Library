namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        BirthDate = c.String(),
                        bio = c.String(),
                        photo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        AuthorId = c.Int(nullable: false),
                        Description = c.String(),
                        ViewersNum = c.Int(nullable: false),
                        PublishDate = c.String(),
                        AvaliableNum = c.Int(nullable: false),
                        coverPath = c.String(),
                        bookPath = c.String(),
                        addedAt = c.DateTime(nullable: false),
                        AddBy = c.String(maxLength: 128),
                        IsActive = c.Boolean(nullable: false),
                        IsOnline = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.AddBy)
                .ForeignKey("dbo.Authors", t => t.AuthorId, cascadeDelete: true)
                .Index(t => t.AuthorId)
                .Index(t => t.AddBy);
            
            CreateTable(
                "dbo.UserFiles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        CreatedAt = c.DateTime(nullable: false),
                        sysgeneratedName = c.String(),
                        Name = c.String(),
                        FileType = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.CreatedAt })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.BooksCategories",
                c => new
                    {
                        BookId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Books", t => t.BookId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetRoles", "ConfirmedEmail", c => c.Boolean());
            AddColumn("dbo.AspNetUsers", "CompleteRegisterationStep", c => c.Int());
            AddColumn("dbo.AspNetUsers", "hireDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Salary", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BooksCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.BooksCategories", "BookId", "dbo.Books");
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropForeignKey("dbo.Books", "AddBy", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserFiles", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.BooksCategories", new[] { "CategoryId" });
            DropIndex("dbo.BooksCategories", new[] { "BookId" });
            DropIndex("dbo.UserFiles", new[] { "UserId" });
            DropIndex("dbo.Books", new[] { "AddBy" });
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropColumn("dbo.AspNetUsers", "Salary");
            DropColumn("dbo.AspNetUsers", "hireDate");
            DropColumn("dbo.AspNetUsers", "CompleteRegisterationStep");
            DropColumn("dbo.AspNetRoles", "ConfirmedEmail");
            DropTable("dbo.Categories");
            DropTable("dbo.BooksCategories");
            DropTable("dbo.UserFiles");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}

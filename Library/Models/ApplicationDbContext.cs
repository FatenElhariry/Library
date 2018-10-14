using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Library.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            
        }
        public new DbSet<UserRole> Roles { get; set; }
        public DbSet<UserFiles> UserFiles { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<BooksCategories> BooksCategories { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>().HasKey(c => c.Id)
                .ToTable("AspNetRoles").HasMany(c => c.Users);

            
            //Roles.Add(new UserRole { Name = "Admin", NameAr = "مشرف عن العاملين", DescriptionAr = "مشرف مسؤول عن العاملين" });
            //SaveChanges();
        }
    }
}
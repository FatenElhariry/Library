namespace Library.Migrations
{
    using Library.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

           // context.Roles.AddOrUpdate(new UserRole() { Name = "Admin", NameAr = "„‘—› ⁄‰ «·⁄«„·Ì‰", DescriptionAr = "„‘—› „”ƒÊ· ⁄‰ «·⁄«„·Ì‰" });
            
            //ApplicationDbContext context = new ApplicationDbContext();
            var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var roleManager = new RoleManager<UserRole>(new RoleStore<UserRole>(new ApplicationDbContext()));
            const string name = "admin@yahoo.com";
            const string password = "P@$$word";
            const string roleName = "Basic Admin";

            //Create Role Admin if it does not exist
            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new UserRole(roleName) { DescriptionAr = "„”ƒÊ· «·‰Ÿ«„ ·· Õﬂ„ ›Ï ﬂ· «·»Ì«‰«  " ,NameAr = "„”ƒÊ· ⁄‰ «·‰Ÿ«„ "};
                roleManager.Create(role);
            }
            context.SaveChanges();
            var user = userManager.FindByName(name);
            if (user == null)
            {
                user = new ApplicationUser { UserName = name, Email = name };
                userManager.Create(user, password);
                userManager.SetLockoutEnabled(user.Id, false);
            }
            context.SaveChanges();
            // Add user admin to Role Admin if not already added
            var rolesForUser = userManager.GetRoles(user.Id);
            if (!rolesForUser.Contains(role.Name))
            {
                userManager.AddToRole(user.Id, role.Name);
            }
            context.SaveChanges();
        }
    }
}

using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AbcWebUl.Identity
{
    public class IdentityInitializer :CreateDatabaseIfNotExists<IdentityDataContext> 
    {
        protected override void Seed(IdentityDataContext context)
        {
            // Rolleri
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager =new  RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() {Name="admin",Description="admin rolü" };
                manager.Create(role);
            }

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }

            if (!context.Users.Any(i => i.Name == "saliihdonmez"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "salih", Surname = "dönmez", UserName = "saliihdonmez",Email="saliihdonmez@gmail.com" };



                manager.Create(user,"salih1903");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }

            if (!context.Users.Any(i => i.Name == "salihdonmez"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name = "saliih", Surname = "dönmez", UserName = "salihdonmez", Email = "salihdonmez@gmail.com" };



                manager.Create(user, "salih1903");
                manager.AddToRole(user.Id, "user");

            }

            //user




            base.Seed(context);
        }

    }
}
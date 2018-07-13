using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BeerPlaylist.models;

namespace Trash_Collector
{
    public class IdentityHelper
    {
        

        public const string ROLE_Employee = "Admin";

        public const string ROLE_Customer = "Customer";

        internal static void SeedIdentities(System.Data.Entity.DbContext context)

        {

            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            if (!roleManager.RoleExists(ROLE_Employee))

            {

                var roleresult = roleManager.Create(new IdentityRole(ROLE_Employee));

            }

            if (!roleManager.RoleExists(ROLE_Customer))

            {

                var roleresult = roleManager.Create(new IdentityRole(ROLE_Customer));

            }

        }


    }
}

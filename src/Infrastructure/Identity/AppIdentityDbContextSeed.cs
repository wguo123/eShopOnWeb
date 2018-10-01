﻿using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Microsoft.eShopWeb.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager)
        {
            var defaultUser = new ApplicationUser { UserName = "demouser@microsoft.com", Email = "demouser@microsoft.com", Id = "64ea8383-b9b1-43fb-b5df-93498df69b40" };
            await userManager.CreateAsync(defaultUser, "Pass@word1");

            var ankit = new ApplicationUser { UserName = "ankit@microsoft.com", Email = "ankit@microsoft.com", Id = "6e892e44-1c04-4e3b-b55e-fb75a95831fa" };
            await userManager.CreateAsync(ankit, "Pass@word1");

            var cesar = new ApplicationUser { UserName = "cesardl@microsoft.com", Email = "cesardl@microsoft.com", Id = "71013715-676a-4a6b-91d3-7faf136e27a6" };
            await userManager.CreateAsync(cesar, "Pass@word1");

            var gal = new ApplicationUser { UserName = "gaoshri@microsoft.com", Email = "gaoshri@microsoft.com", Id = "295051dc-d109-4008-92e5-548b44b7175f" };
            await userManager.CreateAsync(gal, "Pass@word1");
        }
    }
}

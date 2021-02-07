using AKNProje.ToDo.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            var AdminRole = await roleManager.FindByNameAsync("Admin");
            if (AdminRole == null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Admin"});
            }
            var MemberRole = await roleManager.FindByNameAsync("Member");
            if (MemberRole == null)
            {
                await roleManager.CreateAsync(new AppRole() { Name = "Member" });
            }
            var IsAdminUser = await userManager.FindByNameAsync("aliakincii");
            if (IsAdminUser == null)
            {
                AppUser user = new AppUser { UserName = "aliakincii", Name = "Ali", Surname = "Akıncı", Email = "aliakincii@hotmail.com.tr" };
                await userManager.CreateAsync(user, "Ali*159639*");
                 await userManager.AddToRoleAsync(user,"Admin");
            }            
        }
    }
}

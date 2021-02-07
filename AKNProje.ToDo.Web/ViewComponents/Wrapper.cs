using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace AKNProje.ToDo.Web.Areas.Admin.ViewComponents
{
    public class Wrapper:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        public Wrapper(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {

            var user = _userManager.FindByNameAsync(User.Identity.Name).Result;
            AppUserListViewModel model = new AppUserListViewModel();
            model.Id = user.Id;
            model.ad = user.Name;
            model.Surad = user.Surname;
            model.Picture = user.PictureUrl;
            model.Email = user.Email;

            var roles = _userManager.GetRolesAsync(user).Result;
            if(roles.Contains("Admin"))
            {
                return View(model);
            }
            return View("Member",model);
        }
    }
}

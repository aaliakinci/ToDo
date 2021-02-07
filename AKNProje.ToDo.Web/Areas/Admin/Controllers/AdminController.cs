using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserListViewModel model = new AppUserListViewModel();
            model.Name = appUser.Name;
            model.Id = appUser.Id;
            model.Surname = appUser.Surname;
            model.Email = appUser.Email;
            return View();
        }
    }
}

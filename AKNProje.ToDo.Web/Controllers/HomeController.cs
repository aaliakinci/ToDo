using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public HomeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {

            return View(new AppUserLoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var Myuser = await _userManager.FindByNameAsync(model.UserName);
               
                if (Myuser != null)
                {
                    var IdentityResult = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, model.IsPresistent, false);
                    if (IdentityResult.Succeeded)
                    {
                        var userRole = await _userManager.GetRolesAsync(Myuser);
                        if (userRole.Contains("Admin"))
                        {
                            return RedirectToAction("Index", "Home", new { area ="Admin"});
                        }
                        if (userRole.Contains("Member"))
                        {
                            return RedirectToAction("Index", "Home", new { area = "Member" });
                        }
                    }
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            return View("Index",model);

        }
        public IActionResult Register()
        {


            return View(new AppUserAddViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(AppUserAddViewModel model)
        {
            if (ModelState.IsValid)
            {

                AppUser user = new AppUser()
                {
                    UserName = model.UserName,
                    Name = model.Name,
                    Surname = model.Surname,
                    //PasswordHash = model.Password,
                    Email = model.Email,
                };
                var identityResult = await _userManager.CreateAsync(user, model.Password);
                if (identityResult.Succeeded)
                {
                    var AddRoleResult = await _userManager.AddToRoleAsync(user, "Member");
                    if (AddRoleResult.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    foreach (var error in AddRoleResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                }
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
    }
}

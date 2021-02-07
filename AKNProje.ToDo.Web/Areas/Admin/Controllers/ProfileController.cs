using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            TempData["Active"] = "profil";
            var appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserListViewModel model = new AppUserListViewModel();
            model.ad = appUser.Name;
            model.Id = appUser.Id;
            model.Surad = appUser.Surname;
            model.Picture = appUser.PictureUrl;
            model.Email = appUser.Email;

            return View(model);
           
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserListViewModel model,IFormFile Picture)
        {
            if(ModelState.IsValid)
            {
                var updatedUser = _userManager.Users.FirstOrDefault(x => x.Id == model.Id);
                if(Picture != null)
                {
                    string pictureUrl = Path.GetExtension(Picture.FileName); 
                    string picturead = Guid.NewGuid()+pictureUrl;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + picturead);
                    using (var stream = new FileStream(path,FileMode.Create))
                    {
                        await Picture.CopyToAsync(stream);
                    }
                    updatedUser.PictureUrl = picturead;
                }
                updatedUser.Name = model.ad;
                updatedUser.Surname = model.Surad;
                updatedUser.Email = model.Email;

                var result = await _userManager.UpdateAsync(updatedUser);
                if(result.Succeeded)
                {
                    TempData["Updated"] = "Updateme işleminiz başarı ile gerçekleşti";
                    return RedirectToAction("Index");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
 
            

            return View(model);

        }
    }
}

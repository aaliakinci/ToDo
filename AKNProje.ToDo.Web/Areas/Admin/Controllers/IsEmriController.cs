using AKNProje.ToDo.BLL.Interface;
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
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class IsEmriController : Controller
    {


        private readonly IAppUserService _appUserService;
        private readonly IGorevService _gorevService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IDosyaService _dosyaManager;
        public IsEmriController(IAppUserService appUserService, IGorevService gorevService, UserManager<AppUser> userManager, IDosyaService dosyaManager)
        {
            _appUserService = appUserService;
            _gorevService = gorevService;
            _userManager = userManager;
            _dosyaManager = dosyaManager;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "isemirleri";
            List<Gorev> gorevler = _gorevService.GetGorevleriwithAllColumns();
            List<GorevListAllViewModel> models = new List<GorevListAllViewModel>();
            foreach (var item in gorevler)
            {
                GorevListAllViewModel model = new GorevListAllViewModel();
                model.ID = item.ID;
                model.Aciklama = item.Aciklama;
                model.Aciliyet = item.Aciliyet;
                model.Ad = item.Ad;
                model.AppUser = item.AppUser;
                model.OlusturulmaTarihi = item.OlusturulmaTarihi;
                model.Rapor = item.Rapor;
                models.Add(model);
            }


            //var model = _appUserService.GetAppUsersWithoutAdmin();
            return View(models);
        }
        public IActionResult AtaPersonel(int id,string s ,int sayfa=1 )
        {
            TempData["Active"] = "isemirleri";
            ViewBag.AktifSayfa = sayfa;
            ViewBag.Aranan = s;
            
            int toplamSayfa;
            var personeller =_appUserService.GetAppUsersWithoutAdmin(out toplamSayfa ,s,sayfa);
            List<AppUserListViewModel> appuserModels = new List<AppUserListViewModel>();
            ViewBag.ToplamSayfa = toplamSayfa;
            foreach (var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel();

               model.Id = item.Id;
               model.Name = item.Name;
               model.Surname=item.Surname ;
               model.Email = item.Email ;
               model.Picture = item.PictureUrl;

                appuserModels.Add(model);
            }

            ViewBag.Personeller = appuserModels;

            var gorev = _gorevService.GetGorevwithAciliyetandId(id);
            GorevWithIDViewModel gorevModel = new GorevWithIDViewModel();
            gorevModel.Id = gorev.ID;
            gorevModel.Name = gorev.Ad;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;
            


            return View(gorevModel);
        }
        [HttpPost]
        public IActionResult AtaPersonel(PersonelAtaGorevViewModel model)
        {
            var guncellenecekGorev = _gorevService.GetGorevwithAciliyetandId(model.GorevId);
            guncellenecekGorev.AppUserId = model.AppUserId;
            _gorevService.Güncelle(guncellenecekGorev);
            return RedirectToAction("Index");
        }
        public IActionResult Detaylandir(int id)
        {
            TempData["Active"] = "isemirleri";
            var gorev = _gorevService.GetirGorevRaporlarile(id);

            GorevListAllViewModel gorevModel = new GorevListAllViewModel();
            gorevModel.ID = gorev.ID;
            gorevModel.Ad = gorev.Ad;
            gorevModel.AppUser = gorev.AppUser;
            gorevModel.Rapor = gorev.Rapor;



            return View(gorevModel);

        }
        public IActionResult PersonelGorevlendir(PersonelAtaGorevViewModel model)
        {
            TempData["Active"] = "isemirleri";
            var user = _userManager.Users.FirstOrDefault(x => x.Id == model.AppUserId);
            var gorev = _gorevService.GetGorevwithAciliyetandId(model.GorevId);

            GorevListAllViewModel gorevModel = new GorevListAllViewModel();
            gorevModel.ID = gorev.ID;
            gorevModel.Ad = gorev.Ad;
            gorevModel.Aciklama = gorev.Aciklama;
            gorevModel.Aciliyet = gorev.Aciliyet;


            AppUserListViewModel userModel = new AppUserListViewModel();
            userModel.Id = user.Id;
            userModel.Name = user.Name;
            userModel.Surname = user.Surname;
            userModel.Picture = user.PictureUrl;
            userModel.Email = user.Email;

            PersonelGorevViewModel personelGorevModel = new PersonelGorevViewModel();
            personelGorevModel.AppUser = userModel;
            personelGorevModel.Gorev = gorevModel;
            
            return View(personelGorevModel);
        }

        public IActionResult ExcelGetir(int id)
        {
            return File (_dosyaManager.AktarExcel(_gorevService.GetirGorevRaporlarile(id).Rapor),"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",Guid.NewGuid()+".xlsx");

        }
        public IActionResult PdfGetir(int id)
        {
            var path = _dosyaManager.AktarPdf(_gorevService.GetirGorevRaporlarile(id).Rapor);
            return File(path, "application/pdf", Guid.NewGuid() + ".xlsx");
        }

    }
}

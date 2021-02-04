using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class GorevController : Controller
    {
        private readonly IGorevService _gorevService;
        private readonly IAciliyetService _aciliyetService;

        public GorevController(IGorevService gorevService, IAciliyetService aciliyetService)
        {
            _gorevService = gorevService;
            _aciliyetService = aciliyetService;
        }


        public IActionResult Index()
        {
            TempData["Active"] = "gorev";
            List<Gorev> gorevler = _gorevService.GetGorevleriwithAllColumns();
            List<GorevListViewModel> models = new List<GorevListViewModel>();
            foreach (var item in gorevler)
            {
                GorevListViewModel model = new GorevListViewModel()
                {
                    Aciklama = item.Aciklama,
                    Ad = item.Ad,
                    ID = item.ID,
                    Aciliyet = item.Aciliyet,
                    OlusturulmaTarihi = item.OlusturulmaTarihi,
                    AciliyetId = item.AciliyetId,
                    Durum = item.Durum,

                };
                models.Add(model);
            }
            return View(models);
        }


        public IActionResult AddGorev()
        {
            TempData["Active"] = "gorev";
            
            ViewBag.Aciliyetler =new SelectList( _aciliyetService.GetirHepsi(),"Id","Tanim");


            return View(new GorevAddViewModel());
        }

        [HttpPost]
        public IActionResult AddGorev(GorevAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _gorevService.Kaydet(new Gorev()
                {
                    Ad = model.Ad,
                    Aciklama = model.Aciklama,
                    AciliyetId = model.AciliyetId
                });

                return RedirectToAction("Index");
            }

            return View(model);

        }

        public IActionResult UpdateGorev(int id)
        {
            TempData["Active"] = "gorev";
            var gtGorev = _gorevService.GetirIdile(id);
            ViewBag.Aciliyetler = new SelectList(_aciliyetService.GetirHepsi(), "Id", "Tanim", gtGorev.AciliyetId);
            GorevUpdateViewModel model = new GorevUpdateViewModel() { Aciklama = gtGorev.Aciklama, Ad = gtGorev.Ad, AciliyetId = gtGorev.AciliyetId, Id = gtGorev.ID };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateGorev(GorevUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
               _gorevService.Güncelle(new Gorev()
                {
                    ID = model.Id,
                    Ad = model.Ad,
                    Aciklama = model.Aciklama,
                    AciliyetId = model.AciliyetId,
                    //Durum = model.Durum,
                    //Rapor = model.Rapor

                });
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public IActionResult DeleteGorev(int id)
        {
            _gorevService.Sil(new Gorev() {ID=id });

            return Json(null);
        }
    }
}

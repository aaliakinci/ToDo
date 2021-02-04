using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    [Area("Admin")]
    public class AciliyetController : Controller
    {
        private readonly IAciliyetService _aciliyetService;
        public AciliyetController(IAciliyetService aciliyetService)
        {
            _aciliyetService = aciliyetService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "aciliyet";
           List<Aciliyet> aciliyetler = _aciliyetService.GetirHepsi();

            List<AciliyetViewModel> model = new List<AciliyetViewModel>();
            foreach (var item in aciliyetler)
            {
                AciliyetViewModel models = new AciliyetViewModel();
                models.Id = item.Id;
                models.Tanim = item.Tanim;
                model.Add(models);
            }

            return View(model);
        }
        
        public IActionResult AddAciliyet()
        {
            TempData["Active"] = "aciliyet";
            return View(new AciliyetAddViewModel());
        }
        [HttpPost]
        public IActionResult AddAciliyet(AciliyetAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Kaydet(new Aciliyet() {Tanim=model.Tanim }); 

                return RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult UpdateAciliyet(int id)
        {
            TempData["Active"] = "aciliyet";
            var aciliyet =  _aciliyetService.GetirIdile(id);
            AciliyetUpdateViewModel aciliyetUpdate = new AciliyetUpdateViewModel() { Tanim = aciliyet.Tanim, Id = aciliyet.Id };

            return View(aciliyetUpdate);
        }
        [HttpPost]
        public IActionResult UpdateAciliyet(AciliyetUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _aciliyetService.Güncelle(new Aciliyet()
                {
                    Id = model.Id,
                    Tanim = model.Tanim
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}

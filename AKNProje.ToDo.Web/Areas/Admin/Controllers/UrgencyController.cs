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
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UrgencyController : Controller
    {
        private readonly IUrgencyService _UrgencyService;
        public UrgencyController(IUrgencyService UrgencyService)
        {
            _UrgencyService = UrgencyService;
        }

        public IActionResult Index()
        {
            TempData["Active"] = "Urgency";
           List<Urgency> Urgencyler = _UrgencyService.GetAll();

            List<UrgencyViewModel> model = new List<UrgencyViewModel>();
            foreach (var item in Urgencyler)
            {
                UrgencyViewModel models = new UrgencyViewModel();
                models.Id = item.Id;
                models.Description = item.Description;
                model.Add(models);
            }

            return View(model);
        }
        
        public IActionResult AddUrgency()
        {
            TempData["Active"] = "Urgency";
            return View(new UrgencyAddViewModel());
        }
        [HttpPost]
        public IActionResult AddUrgency(UrgencyAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _UrgencyService.Save(new Urgency() {Description=model.Description }); 

                return RedirectToAction("Index");
            }

            return View();
        }
        public IActionResult UpdateUrgency(int id)
        {
            TempData["Active"] = "Urgency";
            var Urgency =  _UrgencyService.GetById(id);
            UrgencyUpdateViewModel UrgencyUpdate = new UrgencyUpdateViewModel() { Description = Urgency.Description, Id = Urgency.Id };

            return View(UrgencyUpdate);
        }
        [HttpPost]
        public IActionResult UpdateUrgency(UrgencyUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
                _UrgencyService.Update(new Urgency()
                {
                    Id = model.Id,
                    Description = model.Description
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }

    }
}

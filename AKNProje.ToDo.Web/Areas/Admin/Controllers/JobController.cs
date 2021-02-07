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
    public class JobController : Controller
    {
        private readonly IJobService _JobService;
        private readonly IUrgencyService _UrgencyService;

        public JobController(IJobService JobService, IUrgencyService UrgencyService)
        {
            _JobService = JobService;
            _UrgencyService = UrgencyService;
        }


        public IActionResult Index()
        {
            TempData["Active"] = "Job";
            List<Job> Jobs = _JobService.GetJobsWithAllColumns();
            List<JobListViewModel> models = new List<JobListViewModel>();
            foreach (var item in Jobs)
            {
                JobListViewModel model = new JobListViewModel()
                {
                    Description = item.Description,
                    ad = item.Name,
                    ID = item.ID,
                    Urgency = item.Urgency,
                    CreatedAt = item.CreatedAt,
                    UrgencyId = item.UrgencyId,
                    Status = item.Status,

                };
                models.Add(model);
            }
            return View(models);
        }


        public IActionResult AddJob()
        {
            TempData["Active"] = "Job";
            
            ViewBag.Urgencyler =new SelectList( _UrgencyService.GetAll(),"Id","Description");


            return View(new JobAddViewModel());
        }

        [HttpPost]
        public IActionResult AddJob(JobAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                _JobService.Save(new Job()
                {
                    Name = model.ad,
                    Description = model.Description,
                    UrgencyId = model.UrgencyId
                });

                return RedirectToAction("Index");
            }

            return View(model);

        }

        public IActionResult UpdateJob(int id)
        {
            TempData["Active"] = "Job";
            var gtJob = _JobService.GetById(id);
            ViewBag.Urgencyler = new SelectList(_UrgencyService.GetAll(), "Id", "Description", gtJob.UrgencyId);
            JobUpdateViewModel model = new JobUpdateViewModel() { Description = gtJob.Description, ad = gtJob.Name, UrgencyId = gtJob.UrgencyId, Id = gtJob.ID };
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateJob(JobUpdateViewModel model)
        {
            if (ModelState.IsValid)
            {
               _JobService.Update(new Job()
                {
                    ID = model.Id,
                   Name = model.ad,
                    Description = model.Description,
                    UrgencyId = model.UrgencyId,
                    //Status = model.Status,
                    //Report = model.Report

                });
                return RedirectToAction("Index");
            }

            return View(model);
        }


        public IActionResult DeleteJob(int id)
        {
            _JobService.Delete(new Job() {ID=id });

            return Json(null);
        }
    }
}

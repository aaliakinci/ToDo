using AKNProje.ToDo.BLL.Interface;
using AKNProje.ToDo.Entities.Concrete;
using AKNProje.ToDo.Web.Areas.Admin.Models;
using AKNProje.ToDo.Web.Areas.Member.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.Areas.Member.Controllers
{
    [Authorize(Roles = "Member")]
    [Area("Member")]

    public class JobController : Controller
    {

        private readonly IJobService _JobService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IReportService _ReportService;

        public object ReportViewModel { get; private set; }

        public JobController(IJobService JobService, UserManager<AppUser> userManager, IReportService ReportService)
        {
            _userManager = userManager;
            _JobService = JobService;
            _ReportService = ReportService;
        }
        public async Task<IActionResult> Index(int id)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var jobs = _JobService.GetJobsWithAllColumns(x => x.AppUser.Id == user.Id && !x.Status);
            List<JobListAllViewModel> models = new List<JobListAllViewModel>();
            foreach (var item in jobs)
            {
                JobListAllViewModel model = new JobListAllViewModel();
                model.ID = item.ID;
                model.ad = item.Name;
                model.Description = item.Description;
                model.Urgency = item.Urgency;
                model.CreatedAt = item.CreatedAt;
                model.Report = item.Report;
                models.Add(model);
            }
            return View(models);
        }
        public IActionResult AddReport(int id)
        {
            var job = _JobService.GetJobsWithUrgencyByID(id);
            ReportAddViewModel model = new ReportAddViewModel();
            model.JobId = id;
            model.Job = job;
                return View(model);
        }

        [HttpPost]
        public IActionResult AddReport(ReportAddViewModel model)
        {
            if(ModelState.IsValid)
            {
                _ReportService.Save(new Report()
                {
                    JobId = model.JobId,
                    Detail=model.Detail,
                    Description=model.Description

                });
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult UpdateReport(int id)
        {
            var Report = _ReportService.GetJobsWithReportAndUrgencyById(id);
            ReportUpdateViewModel model = new ReportUpdateViewModel();
            model.Description = Report.Description;
            model.Id = Report.Id;
            model.Detail = Report.Detail;
            model.Job = Report.Job;
            model.JobId = Report.JobId;
            return View(model);
        }
        [HttpPost]
        public IActionResult UpdateReport(ReportUpdateViewModel model)
        {
            if(ModelState.IsValid)
            {
                var updatedReport = _ReportService.GetById(model.Id);
                updatedReport.Description = model.Description;
                updatedReport.Detail = model.Detail;
                _ReportService.Update(updatedReport);

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult CompleteJob(int jobId)
        {
            var updatedJob = _JobService.GetJobsWithUrgencyByID(jobId);
            updatedJob.Status = true;
            _JobService.Update(updatedJob);

            return Json(null);
        }

    }
}

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
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class JobCommentController : Controller
    {


        private readonly IAppUserService _appUserService;
        private readonly IJobService _JobService;
        private readonly UserManager<AppUser> _userManager;
        private readonly IDocumentService _dosyaManager;
        public JobCommentController(IAppUserService appUserService, IJobService JobService, UserManager<AppUser> userManager, IDocumentService dosyaManager)
        {
            _appUserService = appUserService;
            _JobService = JobService;
            _userManager = userManager;
            _dosyaManager = dosyaManager;
        }
        public IActionResult Index()
        {
            TempData["Active"] = "isemirleri";
            List<Job> Jobs = _JobService.GetJobsWithAllColumns();
            List<JobListAllViewModel> models = new List<JobListAllViewModel>();
            foreach (var item in Jobs)
            {
                JobListAllViewModel model = new JobListAllViewModel();
                model.ID = item.ID;
                model.Description = item.Description;
                model.Urgency = item.Urgency;
                model.ad = item.Name;
                model.AppUser = item.AppUser;
                model.CreatedAt = item.CreatedAt;
                model.Report = item.Report;
                models.Add(model);
            }


            //var model = _appUserService.GetAppUsersWithoutAdmin();
            return View(models);
        }
        public IActionResult AssignStaff(int id,string s ,int page=1 )
        {
            TempData["Active"] = "isemirleri";
            ViewBag.Aktifpage = page;
            ViewBag.Aranan = s;
            
            int totalPage;
            var personeller =_appUserService.GetAppUsersWithoutAdmin(out totalPage ,s,page);
            List<AppUserListViewModel> appuserModels = new List<AppUserListViewModel>();
            ViewBag.totalPage = totalPage;
            foreach (var item in personeller)
            {
                AppUserListViewModel model = new AppUserListViewModel();

               model.Id = item.Id;
               model.ad = item.Name;
               model.Surad=item.Surname ;
               model.Email = item.Email ;
               model.Picture = item.PictureUrl;

                appuserModels.Add(model);
            }

            ViewBag.Personeller = appuserModels;

            var Job = _JobService.GetJobsWithUrgencyByID(id);
            JobWithIDViewModel JobModel = new JobWithIDViewModel();
            JobModel.Id = Job.ID;
            JobModel.ad = Job.Name;
            JobModel.Description = Job.Description;
            JobModel.Urgency = Job.Urgency;
            


            return View(JobModel);
        }
        [HttpPost]
        public IActionResult AssignStaff(AssignStaffJobViewModel model)
        {
            var guncellenecekJob = _JobService.GetJobsWithUrgencyByID(model.JobId);
            guncellenecekJob.AppUserId = model.AppUserId;
            _JobService.Update(guncellenecekJob);
            return RedirectToAction("Index");
        }
        public IActionResult Detaillandir(int id)
        {
            TempData["Active"] = "isemirleri";
            var Job = _JobService.GetJobsWithReport(id);

            JobListAllViewModel JobModel = new JobListAllViewModel();
            JobModel.ID = Job.ID;
            JobModel.ad = Job.Name;
            JobModel.AppUser = Job.AppUser;
            JobModel.Report = Job.Report;



            return View(JobModel);

        }
        public IActionResult AssignJob(AssignStaffJobViewModel model)
        {
            TempData["Active"] = "isemirleri";
            var user = _userManager.Users.FirstOrDefault(x => x.Id == model.AppUserId);
            var Job = _JobService.GetJobsWithUrgencyByID(model.JobId);

            JobListAllViewModel JobModel = new JobListAllViewModel();
            JobModel.ID = Job.ID;
            JobModel.ad = Job.Name;
            JobModel.Description = Job.Description;
            JobModel.Urgency = Job.Urgency;


            AppUserListViewModel userModel = new AppUserListViewModel();
            userModel.Id = user.Id;
            userModel.ad = user.Name;
            userModel.Surad = user.Surname;
            userModel.Picture = user.PictureUrl;
            userModel.Email = user.Email;

            StaffJobViewModel personelJobModel = new StaffJobViewModel();
            personelJobModel.AppUser = userModel;
            personelJobModel.Job = JobModel;
            
            return View(personelJobModel);
        }

        public IActionResult ExcelGetir(int id)
        {
            return File (_dosyaManager.ImportExcel(_JobService.GetJobsWithReport(id).Report),"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",Guid.NewGuid()+".xlsx");

        }
        public IActionResult PdfGetir(int id)
        {
            var path = _dosyaManager.ImportPdf(_JobService.GetJobsWithReport(id).Report);
            return File(path, "application/pdf", Guid.NewGuid() + ".xlsx");
        }

    }
}

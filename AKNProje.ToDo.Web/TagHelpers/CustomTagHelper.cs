using AKNProje.ToDo.BLL.Interface;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
 

namespace AKNProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("getJobWithAppUserById")]
    public class CustomTagHelper:TagHelper
    {
        private readonly IJobService _JobService;
        public CustomTagHelper(IJobService JobService)
        {
            _JobService = JobService;
        }
        public int AppUserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int tamamladigiJobSayisi = _JobService.GetJobsWithAppUserID(AppUserId).Where(x=>x.Status).Count();
            int calistigiJobSayisi = _JobService.GetJobsWithAppUserID(AppUserId).Where(x => !x.Status).Count();

            string html = $"<p> Tamamladığı görev sayısı:<strong>{tamamladigiJobSayisi}</strong></p>" +
                $"<p>Üstünde çalıştığı görev sayısı:<strong>{calistigiJobSayisi}</strong></p>";

            output.Content.SetHtmlContent(html);
        }
    }
}

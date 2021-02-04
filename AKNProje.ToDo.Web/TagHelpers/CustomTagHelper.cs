using AKNProje.ToDo.BLL.Interface;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AKNProje.ToDo.Web.TagHelpers
{
    [HtmlTargetElement("getirGorevileAppUserId")]
    public class CustomTagHelper:TagHelper
    {
        private readonly IGorevService _gorevService;
        public CustomTagHelper(IGorevService gorevService)
        {
            _gorevService = gorevService;
        }
        public int AppUserId { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            int tamamladigiGorevSayisi = _gorevService.GetGorevwithAppUserID(AppUserId).Where(x=>x.Durum).Count();
            int calistigiGorevSayisi = _gorevService.GetGorevwithAppUserID(AppUserId).Where(x => !x.Durum).Count();

            string html = $"<p> Tamamladığı görev sayısı:<strong>{tamamladigiGorevSayisi}</strong></p>" +
                $"<p>Üstünde çalıştığı görev sayısı:<strong>{calistigiGorevSayisi}</strong></p>";

            output.Content.SetHtmlContent(html);
        }
    }
}

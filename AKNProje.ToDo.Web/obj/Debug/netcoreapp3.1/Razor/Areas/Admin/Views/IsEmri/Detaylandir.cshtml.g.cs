#pragma checksum "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff4acf6e7f876536ef3a0f603f38f0e4b888c309"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_Detaylandir), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/Detaylandir.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\_ViewImports.cshtml"
using AKNProje.ToDo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff4acf6e7f876536ef3a0f603f38f0e4b888c309", @"/Areas/Admin/Views/IsEmri/Detaylandir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54fe533a0b5452554111bca79c2761fe6af2a3d2", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_Detaylandir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GorevListAllViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcelGetir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PdfGetir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
  
    ViewData["Title"] = "Detaylandir";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
 if (Model.Rapor.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4acf6e7f876536ef3a0f603f38f0e4b888c3094895", async() => {
                WriteLiteral("<i class=\"fas fa-file-excel mr-2\"></i>Excel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                            WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff4acf6e7f876536ef3a0f603f38f0e4b888c3097295", async() => {
                WriteLiteral("<i class=\"fas fa-file-pdf mr-2\"></i>Pdf");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                          WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <table class=\"table table-hover table-bordered text-center mt-2\">\r\n        <thead>\r\n            <tr>\r\n                <th colspan=\"3\"> ");
#nullable restore
#line 14 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                            Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                Write(Model.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" çalışanının ");
#nullable restore
#line 14 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                                                   Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" görevi üzerinde yazdığı raporlar</th>\r\n            </tr>\r\n            <tr>\r\n                <th>#</th>\r\n                <th>Tanım</th>\r\n                <th>Detay</th>\r\n            </tr>\r\n        </thead>\r\n");
#nullable restore
#line 22 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
         foreach (var rapor in Model.Rapor)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 26 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                   Write(rapor.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 27 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                   Write(rapor.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 28 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                   Write(rapor.Detay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 31 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 33 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <p>");
#nullable restore
#line 37 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
      Write(Model.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" görevi üzerinde çalışan ");
#nullable restore
#line 37 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                        Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 37 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"
                                                            Write(Model.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" çalışanınız henüz herhangi bir rapor yazmadı.</p>\r\n    </div>\r\n");
#nullable restore
#line 39 "C:\Users\aliak\Desktop\Çalışmalar\Todo\AKNProje.ToDo.Web\Areas\Admin\Views\IsEmri\Detaylandir.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GorevListAllViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56ae8f881cc0183cf84e0b1b717b5d8a2c41e18a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bloglar_Index), @"mvc.1.0.view", @"/Views/Bloglar/Index.cshtml")]
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
#line 1 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/_ViewImports.cshtml"
using Sarih_Law;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/_ViewImports.cshtml"
using Sarih_Law.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56ae8f881cc0183cf84e0b1b717b5d8a2c41e18a", @"/Views/Bloglar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ce58a92f43029f766b2184cd69e295142e4bf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Bloglar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sarih_Law.Models.BlogYorum>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/seba.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
   Layout = "/Views/Shared/AsilLayout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Blog Start -->\r\n<div class=\"blog\">\r\n    <div class=\"container\">\r\n        <div class=\"section-header\">\r\n            <h2>Bloglarımız</h2>\r\n        </div>\r\n\r\n        <div class=\"row blog-page\">\r\n");
#nullable restore
#line 11 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
             foreach (var x in Model.Deger1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-lg-4 col-md-6 blog-item\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "56ae8f881cc0183cf84e0b1b717b5d8a2c41e18a4442", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h3>");
#nullable restore
#line 15 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
   Write(x.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <div class=\"meta\">\r\n        <i class=\"fa fa-list-alt\"></i>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 534, 0);
            EndWriteAttribute();
            WriteLiteral(">Civil Law</a>\r\n        <i class=\"fa fa-calendar-alt\"></i>\r\n        <p>");
#nullable restore
#line 20 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
      Write(x.Tarih.ToString("dd.MM.yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <p>\r\n        ");
#nullable restore
#line 23 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
   Write(Html.Raw(x.Aciklama.Substring(0, 30)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <a class=\"btn\"");
            BeginWriteAttribute("href", " href=\"", 740, "\"", 771, 2);
            WriteAttributeValue("", 747, "/Bloglar/BlogDetay/", 747, 19, true);
#nullable restore
#line 25 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
WriteAttributeValue("", 766, x.ID, 766, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More <i class=\"fa fa-angle-right\"></i></a>\r\n</div>");
#nullable restore
#line 26 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Bloglar/Index.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""row"">
            <div class=""col-12"">
                <ul class=""pagination justify-content-center"">
                    <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
                </ul>
            </div>
        </div>
    </div>
</div>
<!-- Blog End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sarih_Law.Models.BlogYorum> Html { get; private set; }
    }
}
#pragma warning restore 1591

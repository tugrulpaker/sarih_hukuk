#pragma checksum "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1197e50e974c1599d3974645539765a0d3085054"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adminler_BlogGetir), @"mvc.1.0.view", @"/Views/Adminler/BlogGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1197e50e974c1599d3974645539765a0d3085054", @"/Views/Adminler/BlogGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ce58a92f43029f766b2184cd69e295142e4bf5", @"/Views/_ViewImports.cshtml")]
    public class Views_Adminler_BlogGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sarih_Law.Models.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
  
    ViewBag.Title = "BlogGetir";
    Layout = "/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1197e50e974c1599d3974645539765a0d30850543694", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h2>Blog Güncelleme Sayfası</h2>\n<br />\n\n");
#nullable restore
#line 13 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
 using (Html.BeginForm("BlogGuncelle", "Adminler", FormMethod.Post, new { enctype = "multipart/form-data" })) // Blog güncelle action result devrey girdiginde çalısacak ,, bloggüncelle adminler controllerinda ,,Sayfada butona tıklanıp post islemi gerçekletirildiginde calisacak
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.LabelFor(x => x.ID));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.TextBoxFor(x => x.ID, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 18 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.LabelFor(x => x.Baslik));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.TextBoxFor(x => x.Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 21 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.LabelFor(x => x.Tarih));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.TextBoxFor(x => x.Tarih, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
#nullable restore
#line 24 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.LabelFor(x => x.Kategori));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.TextBoxFor(x => x.Kategori, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n");
            WriteLiteral("    <br />\n    <input type=\"file\" name=\"fileobj\" />\n    <br />\n");
#nullable restore
#line 32 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.LabelFor(x => x.Aciklama));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"
Write(Html.TextAreaFor(x => x.Aciklama, 15, 1, new { @id = "editorid", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\n    <button class=\"btn btn-success\">Blog Guncelle</button>\n");
#nullable restore
#line 36 "/Users/tugrulpaker/Projects/Sarih_Law/Sarih_Law/Views/Adminler/BlogGetir.cshtml"


}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1197e50e974c1599d3974645539765a0d30850547969", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script>CKEDITOR.replace(\"editorid\");</script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sarih_Law.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591

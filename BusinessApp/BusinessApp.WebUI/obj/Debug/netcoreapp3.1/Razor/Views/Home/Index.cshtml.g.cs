#pragma checksum "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07ebcb88a990500cb289f1f3c4cee4e82d25095a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.RequestsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.ServiceModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.LogsViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.UsersModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.DepartmentsModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.AccountModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models.CompanyModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using BusinessApp.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07ebcb88a990500cb289f1f3c4cee4e82d25095a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bac7183d4a43b242342d727cbfeb2b0a0c6454", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-light"">
    <div class=""col-md-5 p-lg-5 mx-auto my-5"">
        <h1 class=""display-4 font-weight-normal"">Punny headline</h1>
        <p class=""lead font-weight-normal"">And an even wittier subheading to boot. Jumpstart your marketing efforts with this example based on Apple's marketing pages.</p>
        <a class=""btn btn-outline-secondary"" href=""#"">Coming soon</a>
    </div>
    <div class=""product-device box-shadow d-none d-md-block""></div>
    <div class=""product-device product-device-2 box-shadow d-none d-md-block""></div>
</div>

<main role=""main"">
    <div class=""album py-5 bg-light"">
        <div class=""container"">

            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""card mb-4 box-shadow"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07ebcb88a990500cb289f1f3c4cee4e82d25095a8369", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""card-body"">
                            <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                                </div>
                                <small class=""text-muted"">9 mins</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card mb-4 box-shadow"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07ebcb88a990500cb289f1f3c4cee4e82d25095a10634", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""card-body"">
                            <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                                </div>
                                <small class=""text-muted"">9 mins</small>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-4"">
                    <div class=""card mb-4 box-shadow"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07ebcb88a990500cb289f1f3c4cee4e82d25095a12900", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <div class=""card-body"">
                            <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                            <div class=""d-flex justify-content-between align-items-center"">
                                <div class=""btn-group"">
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                                    <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                                </div>
                                <small class=""text-muted"">9 mins</small>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

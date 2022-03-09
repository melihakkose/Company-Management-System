#pragma checksum "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8898d4be788851da9ac67bbb28014410d4592c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Request_SearchRequest), @"mvc.1.0.view", @"/Views/Request/SearchRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8898d4be788851da9ac67bbb28014410d4592c", @"/Views/Request/SearchRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bac7183d4a43b242342d727cbfeb2b0a0c6454", @"/Views/_ViewImports.cshtml")]
    public class Views_Request_SearchRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestsListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Service", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RequestHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.11.4/css/dataTables.bootstrap4.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.11.4/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.11.4/js/dataTables.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#UserTable').DataTable();
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n<div class=\"card p-5\">\r\n    <div class=\"card-header bg-dark\">\r\n        Filter Section\r\n    </div>\r\n    <div class=\"card-cody\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff8898d4be788851da9ac67bbb28014410d4592c6992", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <input type=\"text\" class=\"form-control \" placeholder=\"Search\" name=\"q\"");
                BeginWriteAttribute("value", " value=\"", 803, "\"", 811, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-sm btn-danger btn-block\">Search</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>
<div class=""card p-5"">
    <div class=""card-header bg-dark"">
        Users Application List
    </div>
    <div class=""card-body"">
        <table id=""UserTable"" class=""table table-bordered table-striped mt-3"">
            <thead>
                <tr>
                    <td style=""width:250px;"">Service Name</td>
                    <td style=""width:300px;"">Title</td>
                    <td style=""width:250px;"">Request Date</td>
                    <td style=""width:150px;"">Request Status</td>
                    <td style=""width:min-content;"">Options</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 44 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                 if (Model.Requests.Count() > 0)
                {

                    foreach (var request in Model.Requests)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                         if (request.UserId == Model.User.Id)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr");
            BeginWriteAttribute("class", " class=\"", 1884, "\"", 2191, 1);
#nullable restore
#line 52 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
WriteAttributeValue("", 1892, request.RequestStatus==Request.EnumRequestStatus.Waiting ? "bg-info":
                                       request.RequestStatus==Request.EnumRequestStatus.Accepted ? "bg-success":
                                       request.RequestStatus==Request.EnumRequestStatus.Closed ? "bg-danger":"", 1892, 299, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                <td>");
#nullable restore
#line 56 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                               Write(request.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                               Write(request.RequestDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                               Write(request.RequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2609, "\"", 2648, 2);
            WriteAttributeValue("", 2616, "/Admin/RequestDetail/", 2616, 21, true);
#nullable restore
#line 60 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
WriteAttributeValue("", 2637, request.Id, 2637, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 63 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                         

                    }

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Applications</h3>\r\n                    </div>\r\n");
#nullable restore
#line 73 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Request\SearchRequest.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RequestsListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

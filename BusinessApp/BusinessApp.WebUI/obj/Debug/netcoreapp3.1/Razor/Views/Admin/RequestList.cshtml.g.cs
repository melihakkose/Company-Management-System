#pragma checksum "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eae4ef38faa2b8ddb9de9c0cb0a21711e28de0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RequestList), @"mvc.1.0.view", @"/Views/Admin/RequestList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eae4ef38faa2b8ddb9de9c0cb0a21711e28de0d", @"/Views/Admin/RequestList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bac7183d4a43b242342d727cbfeb2b0a0c6454", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RequestList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestsListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("Styles", async() => {
                WriteLiteral(@"
    <link href=""https://cdn.datatables.net/1.11.4/css/dataTables.bootstrap4.min.css"" rel=""stylesheet"" />
    <style>
        .table {
            table-layout: fixed;
        }
            .table td {
                white-space: nowrap;
                overflow: hidden;
                text-overflow: ellipsis;
            }
    </style>
");
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
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
 if (User.IsInRole("Employee"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <ul class=""nav nav-tabs"">
        <li class=""nav-item"">
            <a class=""nav-link"" on href=""/Admin/RequestList"">All</a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Admin/EmployeeRequestList"">Assigned to me </a>
        </li>
    </ul>
");
#nullable restore
#line 35 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0eae4ef38faa2b8ddb9de9c0cb0a21711e28de0d7344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<div class=""card"">
    <div class=""card-header bg-dark"">
        Users Application List
    </div>
    <div class=""card-body table-responsive-sm"">
        <table id=""UserTable"" class=""table table-bordered table-striped mt-3 w-100"">
            <thead>
                <tr>
                    <td style=""width:300px;"">Title</td>
                    <td style=""width: 300px; "">Description</td>
                    <td style=""width:300px;"">Request Date</td>
                    <td style=""width:150px;"">Request Status</td>
                    <td style=""width:min-content;"">Options</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 55 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
                 if (Model.Requests.Count() > 0)
                {
                    foreach (var request in Model.Requests)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr");
            BeginWriteAttribute("class", " class=\"", 1937, "\"", 2244, 1);
#nullable restore
#line 59 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
WriteAttributeValue("", 1945, request.RequestStatus==Request.EnumRequestStatus.Waiting ? "bg-info":
                                       request.RequestStatus==Request.EnumRequestStatus.Accepted ? "bg-success":
                                       request.RequestStatus==Request.EnumRequestStatus.Closed ? "bg-danger":"", 1945, 299, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
                           Write(request.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td ><div style=\"line-height: 50px; max-height:50px; overflow: hidden\">");
#nullable restore
#line 63 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
                                                                                              Write(Html.Raw(request.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> </td>\r\n                            <td>");
#nullable restore
#line 64 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
                           Write(request.RequestDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 65 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
                           Write(request.RequestStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2632, "\"", 2671, 2);
            WriteAttributeValue("", 2639, "/Admin/RequestDetail/", 2639, 21, true);
#nullable restore
#line 67 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
WriteAttributeValue("", 2660, request.Id, 2660, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm\"><i class=\"fas fa-edit\"></i></a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"

                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"alert alert-warning\">\r\n                        <h3>No Applications</h3>\r\n                    </div>\r\n");
#nullable restore
#line 78 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\RequestList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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

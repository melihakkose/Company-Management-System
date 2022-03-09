#pragma checksum "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0f64bd07276ccddd01e3f25cd7391ab0387403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_LogList), @"mvc.1.0.view", @"/Views/Admin/LogList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0f64bd07276ccddd01e3f25cd7391ab0387403", @"/Views/Admin/LogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83bac7183d4a43b242342d727cbfeb2b0a0c6454", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_LogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LogsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
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
            $('#logTable').DataTable();
        });
    </script>
");
            }
            );
            WriteLiteral(@"<div class=""card shadow mt-5"">
    <div class=""card-header bg-dark"">
        <a href=""#collapseCompanyList"" class=""card-link p-1"" data-toggle=""collapse"">
            Logs
        </a>
    </div>
    <div id=""collapseCompanyList"" class=""collapse show"">
        <div class=""card-body table-responsive-sm"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <table id=""logTable"" class=""table table-bordered mt-3 w-100"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th style=""overflow: hidden"" class=""w-25"">Message</th>
                                <th style=""width:70px"" class=""w-25"">MessageTemplate</th>
                                <th style=""width: 50px; height: 50px;"">Level</th>
                                <th style=""width: 100px;"">TimeStamp</th>
                                <th style=""width:200px"" class=""w-25"">Exception</th>
                          ");
            WriteLiteral("      <th style=\"width: 200px ;\" class=\"w-25\">Properties</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                             if (Model.Logs.Count() > 0)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                 foreach (var log in Model.Logs)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 43 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                       Write(log.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><div style=\"line-height: 50px; max-height: 50px; overflow: hidden; text-overflow: ellipsis;\">");
#nullable restore
#line 44 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                                                                                                                    Write(log.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> </td>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                       Write(log.MessageTemplate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 47 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                         if (log.Level == "Warning")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"bg-warning\">\r\n                                                ");
#nullable restore
#line 50 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                           Write(log.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 52 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                         if (log.Level == "Error")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"bg-danger\">\r\n                                                ");
#nullable restore
#line 56 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                           Write(log.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 58 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                         if (log.Level == "Information")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td class=\"bg-info\">\r\n                                                ");
#nullable restore
#line 62 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                           Write(log.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n");
#nullable restore
#line 64 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <td>");
#nullable restore
#line 66 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                       Write(log.TimeStamp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td><div style=\"line-height: 50px; max-height:50px;  max-width: 400px; overflow: hidden; text-overflow:ellipsis\">");
#nullable restore
#line 67 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                                                                                                                                    Write(log.Exception);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> </td>\r\n                                        <td><div style=\"line-height: 50px; max-height: 50px; max-width: 400px; overflow: hidden; text-overflow: ellipsis\">");
#nullable restore
#line 68 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                                                                                                                                     Write(log.Properties);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div> </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 70 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                                 

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-warning\">\r\n                                    <h3>No Logsg</h3>\r\n                                </div>\r\n");
#nullable restore
#line 78 "C:\Users\dell\source\repos\BusinessApp\BusinessApp.WebUI\Views\Admin\LogList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

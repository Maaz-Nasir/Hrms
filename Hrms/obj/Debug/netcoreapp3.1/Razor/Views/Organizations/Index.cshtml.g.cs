#pragma checksum "E:\Hrms\Hrms\Hrms\Views\Organizations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56787a7b1691d28801422d34479b868af6ed93f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organizations_Index), @"mvc.1.0.view", @"/Views/Organizations/Index.cshtml")]
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
#line 1 "E:\Hrms\Hrms\Hrms\Views\_ViewImports.cshtml"
using Hrms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Hrms\Hrms\Hrms\Views\_ViewImports.cshtml"
using Hrms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56787a7b1691d28801422d34479b868af6ed93f1", @"/Views/Organizations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69583a24c156ca7a725f8df82b95060522fc5810", @"/Views/_ViewImports.cshtml")]
    public class Views_Organizations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("LinkScriptSection", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            var columns = [
                { ""data"": ""id"", ""name"": ""ID"" },
                {
                    ""data"": ""logo"",
                    ""render"": function (data) {
                        return '<img src=""/' + data + '"" width=""40px"" style=""border-radius: 50%;"">';
                    }
                },
                { ""data"": ""code"", ""name"": ""Code"" },
                { ""data"": ""name"", ""name"": ""Name"" },
                { ""data"": ""status"", ""name"": ""Status"" },
                { ""data"": ""createdDateTime"", ""name"": ""CreatedDateTime"" },
                { ""data"": ""updatedDateTime"", ""name"": ""UpdatedDateTime"" },
                {
                    ""render"": function (data, type, row) { return ActionButton(data, type, row) }
                }
            ];
            ServerSideDataTable(columns);
        })
    </script>
");
            }
            );
            WriteLiteral(@"
<div class=""col-md-12 mb-4"">
    <div class=""card text-left"">
        <div class=""Header""></div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""display table table-striped table-hover table-bordered DataGrid"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Logo</th>
                            <th>Code</th>
                            <th>Name</th>
                            <th>Status</th>
                            <th>Created Date</th>
                            <th>Updated Date</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    ");
#nullable restore
#line 44 "E:\Hrms\Hrms\Hrms\Views\Organizations\Index.cshtml"
               Write(await Html.PartialAsync("DataTable"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

#pragma checksum "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534187e27e009220fe02213f624d683a8640d767"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Statistics), @"mvc.1.0.view", @"/Views/Home/Statistics.cshtml")]
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
#line 1 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\_ViewImports.cshtml"
using SolarPanels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\_ViewImports.cshtml"
using SolarPanels.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534187e27e009220fe02213f624d683a8640d767", @"/Views/Home/Statistics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a2157c9fbffef652fa7d0de10c408fe2280d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SolarPanels.Models.Entites.SensorsReading>>
    {
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml"
  
    ViewData["Title"] = "Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row welcome text-center d-flex justify-content-center"">
        <h1 style=""font-size:25px"" class=""display-4"">Here where you can make statistics and expectations about the gaining current across a certain dates.</h1>
        <hr>
    </div>
</div>
<div class=""row"">
    <div class=""card"" style=""border-color:black;height:270px;margin-top:80px;margin-left:30px"">
        <div class=""card-body"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534187e27e009220fe02213f624d683a8640d7674389", async() => {
                WriteLiteral(@"
                <fieldset disabled>
                    <div class=""form-group"">
                        <Label style=""background-color:white; font-size:large"">Enter Start Date:</Label>
                        <div class=""input-group date form_datetime"" data-date=""2020-01-01T05:25:07Z"" data-date-format=""dd MM yyyy - HH:ii p"" data-link-field=""dtp_input1"" style=""width:300px"">
                            <input id=""min"" class=""form-control"" type=""text"" style=""font-size:20px"" readonly />
                            <span class=""input-group-addon""><span class=""glyphicon glyphicon-th""></span></span>
                            <span class=""input-group-addon""><span class=""glyphicon glyphicon-remove""></span></span>
                        </div>
                        <div class=""form-group"">
                            <Label style=""background-color:white; font-size:large"">Enter End Date:</Label>
                            <div class=""input-group date form_datetime"" data-date=""2020-01-01T05:25:07Z"" dat");
                WriteLiteral(@"a-date-format=""dd MM yyyy - HH:ii p"" data-link-field=""dtp_input1"" style=""width:300px"">
                                <input id=""max"" class=""form-control"" type=""text"" style=""font-size:20px"" readonly />
                                <span class=""input-group-addon""><span class=""glyphicon glyphicon-th""></span></span>
                                <span class=""input-group-addon""><span class=""glyphicon glyphicon-remove""></span></span>
                            </div>
                        </div>
                    </div>
                </fieldset>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
    <div class=""col-8 container rounded"" style=""background-color: white;"">
        <table class=""table-striped table-bordered"" id=""Readings"">
            <thead>
                <tr class=""bg-dark"" style=""color:white"">
                    <th>Sensor ID</th>
                    <th>Current</th>
                    <th>Date</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 48 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SensorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml"
                       Write(Html.DisplayFor(modelItem => item.current));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AddedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 61 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\Statistics.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"


    <script>
        $('.form_datetime').datetimepicker({
            //language:  'fr',
            format: 'm/dd/yyyy H:ii:ss P',
            weekStart: 1,
            todayBtn: 1,
            autoclose: 1,
            todayHighlight: 1,
            startView: 2,
            forceParse: 0,
            showMeridian: 1
        });
        $(document).ready(function () {
            $.fn.dataTable.ext.search.push(
                function (settings, data, dataIndex) {
                    var min = $('#min').val();
                    var max = $('#max').val();


                    var startDate = data[2];

                    if (min == """" && max == """") {
                        return true;
                    }
                    if (min == """" && startDate <= max) {
                        return true;
                    }
                    if (max == """" && startDate >= min) {
                        return true;
                    }
                    if (startDate");
                WriteLiteral(@" <= max && startDate >= min) {
                        return true;
                    }
                    return false;
                }
            );
            var table = $(""#Readings"").DataTable({
                dom: 'lBfrtip',
                buttons: [
                    'pdf', 'copy', 'excel', 'print'
                ]
            });
            $('#min, #max').change(function () {
                table.draw();
            });
        });
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SolarPanels.Models.Entites.SensorsReading>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\AutomaticControl.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a0d8299cbf10cbbb9c6ffe7dbd9af176163260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AutomaticControl), @"mvc.1.0.view", @"/Views/Home/AutomaticControl.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1a0d8299cbf10cbbb9c6ffe7dbd9af176163260", @"/Views/Home/AutomaticControl.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a2157c9fbffef652fa7d0de10c408fe2280d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AutomaticControl : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SolarPanels.Models.Entites.SensorsReading>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\AutomaticControl.cshtml"
  
    ViewData["Title"] = "AutomaticControl";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1a0d8299cbf10cbbb9c6ffe7dbd9af1761632603849", async() => {
                WriteLiteral("\r\n    <style>\r\n        .dt-TextAlignCenter {\r\n            text-align: center;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<marquee direction=""right"" scrollamount=""25"" style=""color:black;background-color:#ddd;height:30px""><p style=""font-size:20px"">Automatic Mode Is On</p></marquee>

<div class=""container-fluid padding"">
    <div class=""row padding"">
        <div class=""col-md-12 col-lg-6"">
            <h2>Automatic Controling</h2>
            <p>Automatic Controling is simply clicking on the automatic controling button to let the sensor track the sun for the perfect spot to get the maximum DC.</p>
            <br>

        </div>
        <div class=""col-lg-6"">
            <h5>The position of the sun according to the panel's position.</h5>
            <table id=""SunPositionTable"" style="" font-family:Sans-serif;font-size:small"" class="" table table-striped table-hover table-bordered"">
                <thead class=""thead-dark"">
                    <tr>
                        <th>Altitude Angle (degrees)</th>
                        <th>Azimuth Angle (degrees)</th>
                    </tr>
                </thead");
            WriteLiteral(">\r\n                <tbody>\r\n");
#nullable restore
#line 35 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\AutomaticControl.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\AutomaticControl.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Altitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\AutomaticControl.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Azimuth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 45 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\AutomaticControl.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<hr class=\"my-4\">\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#SunPositionTable"").DataTable({
                ""searching"": false,
                ""ordering"": false,
                ""bPaginate"": false,
                ""bLengthChange"": false,
                ""bFilter"": true,
                ""bInfo"": false,
            });
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SolarPanels.Models.Entites.SensorsReading>> Html { get; private set; }
    }
}
#pragma warning restore 1591

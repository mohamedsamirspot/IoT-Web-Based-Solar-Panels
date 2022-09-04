#pragma checksum "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4725db653f13c16a5a6ac71b2881844b05c39ce8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LiveReadings), @"mvc.1.0.view", @"/Views/Home/LiveReadings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4725db653f13c16a5a6ac71b2881844b05c39ce8", @"/Views/Home/LiveReadings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a2157c9fbffef652fa7d0de10c408fe2280d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LiveReadings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SolarPanels.Models.Entites.SensorsReading>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml"
  
    ViewData["Title"] = "LiveReadings";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid padding"">
    <div class=""row padding"">
        <div class=""col-lg-4"">
            <div class=""container rounded"" style=""width:490px"">
                <table id=""CurrentTable"" style=""font-family:Sans-serif;font-size:small"" class=""table table-striped table-hover table-bordered"">
                    <thead class=""thead-dark"">
                        <tr>
                            <th>Panel ID</th>
                            <th>Sensor ID</th>
                            <th>Current (Milliampere)</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 19 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 23 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Panel_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 26 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SensorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 29 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml"
                               Write(Html.DisplayFor(modelItem => item.current));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 32 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\LiveReadings.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </tbody>
                </table>
            </div>
        </div>
        <div class=""col-md-12 col-lg-8"">
            <div id=""chart"" style=""margin-top:20px; width:auto"">
            </div>
        </div>
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        window.onload = function () {
            $(""#CurrentTable"").DataTable({
                 ""searching"": false,
                    ""ordering"": true,
                    ""bPaginate"": false,
                    ""bLengthChange"": false,
                    ""bFilter"": true,
                    ""bInfo"": false,
            });
            var c;
            //var count = 0;
            var count = 0;
            var layout = {
                //autosize: false,

                title: 'Gaining Current',
                xaxis: {
                    title: 'Seconds',
                    automargin: true,
                    //range: [0, 24],
                    //autorange: false
                    showticklabels: false
                },
                yaxis: {
                    title: 'Milliampere',
                    automargin: true,

                }
            };

            Plotly.plot('chart', [{ y: [], type: 'bar', }], layout); //type:'line'
    ");
                WriteLiteral(@"        function send() {
                $.ajax({
                    url: 'Get_data',
                    dataType: ""json"",
                    type: ""Get"",
                    success: $.get(""Get_data"", {}, function (data) {



                        for (var i = data.length - 1; i >= 0; i--) {
                            c = data[i].current;
                            Plotly.extendTraces('chart', { y: [[c]] }, [0]);
                            count++;
                            if (count >= 30) {
                                Plotly.relayout('chart', {
                                    xaxis: {
                                        range: [count - 30, count],
                                        title: 'Seconds',
                                        automargin: true,
                                        showticklabels: false
                                    }
                                });
                            }
                            //count++");
                WriteLiteral(@";
                        }
                        setTimeout(function () {
                            //if (count >= 50) {
                            //    Plotly.window.yaxis.
                            //    Plotly.newPlot('chart', [{ y: [], type: 'line', }], layout);
                            //    count = 0;
                            //}

                            send();
                        }, 5000);
                    }),
                });
            }
            send();
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
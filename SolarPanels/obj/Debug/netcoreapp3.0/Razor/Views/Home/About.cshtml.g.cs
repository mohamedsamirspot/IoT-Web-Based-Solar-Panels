#pragma checksum "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0221a77d74460f39137bce760839ffa83a5cbc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0221a77d74460f39137bce760839ffa83a5cbc2", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d68a2157c9fbffef652fa7d0de10c408fe2280d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/background4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/pic10.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/pic11.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "E:\Educational courses\University\Year 4\The Graduation Project\Versions\WebAPI Version Upgraded (.NET Core) With Panels Table\SolarPanels\SolarPanels\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!--- Image Slider -->
<div class=""carousel slide"" data-ride=""carousel"">
    <ul class=""carousel-indicators"">
        <li data-target=""#slides"" data-slide-to=""0"" class=""active""></li>

    </ul>
    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0221a77d74460f39137bce760839ffa83a5cbc25399", async() => {
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
            WriteLiteral(@"
            <div class=""carousel-caption"">
                <h1 class=""display-2"">Access to Energy for Everyone</h1>
                <h3>Let's help stop the planet from overheating</h3>
            </div>
        </div>
    </div>
</div>

<!-- Top of the page !-->
<div class=""container-fluid padding"">
    <div class=""row welcome text-center"">
        <div class=""col-12"">
            <h1 class=""display-4"">There's Couple of things that we provide services for in a wide range</h1>
        </div>
    </div>
</div>


<!--- Two Column Section -->
<div class=""container-fluid padding"">
    <div class=""row padding"">
        <div class=""col-md-12 col-lg-6"">
            <h2>Our Sustainability Impact</h2>
            <p>Reducing Environmental Impact</p>
            <p>Access to Energy</p>
            <p>Tackling the Energy Gap: the Foundation</p>
            <p>Ethics and Compliance</p>
            <p>Sustainable People Practices</p>
            <p>Awards and Rankings</p>
            <br>
 ");
            WriteLiteral(@"           <br>
            <br>
            <h2>Access to Energy for Everyone</h2>
            <p>
                We want everyone on our planet to have access to reliable, safe, efficient, and sustainable energy. To achieve this goal, we
                develop products and solutions that meet a wide range of both individual and community needs across the energy chain:
            </p>
            <p>???	For homes and micro businesses</p>
            <p>???	For fundamental public services: education, healthcare, etc.</p>
            <p>???	For micro-entreprises: agriculture, services</p>
            <p>???	For villages and communities</p>
            <p>???	For emergency situations</p>
            <br>
        </div>
        <div class=""col-lg-6"">
            <br>
            <br>
            <br>
            <br>
            <br>
            <br>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0221a77d74460f39137bce760839ffa83a5cbc28388", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
    <hr class=""my-4"">
</div>
<div class=""container-fluid padding"">
    <div class=""row padding"">
        <p>
            The main problem we have here is that the solar panels are permanent, and the sun is always moving and because of that movement we can???t consume the maximum power from the sun and these panels are usually put in an open area to be in the best position to consume the solar energy, leading to be unclean and dusty from the pollution
            Since a panel which is incident to the sun can gather more amount of solar energy, the solar panel is attached to a motor.
            We managed to make the panels move with the sun and what made that possible is the equation that indicates that the sun position in Egypt and by using the code we developed, we made the panels move with sun either by automatic mode or manual mode.
        </p>
    </div>
</div>

<div class=""container-fluid padding"">
    <div class=""row padding"">
        <div class=""col-md-12 co");
            WriteLiteral(@"l-lg-6"">
            <h2>Our Objective</h2>
            <p>???	To move the panels with the sun.  </p>
            <p>???	To clean the solar panel effectively. </p>
            <p>???	To make the system automated using Raspberry.</p>
            <p>???	To avoid much manual work. </p>
            <p>???	To avoid dust associated problems on solar panels.</p>
            <br>
            <br>
            <br>
            <h2>Problem Definition</h2>
            <p>Problem definitions divides into two directions (can???t getting maximum power of the sun, cleaning difficulty) </p>
            <p>???	The main problem we have here is that the solar panels are permanent, and the sun is always moving and because of that movement we can???t consume the maximum power from the sun. </p>
            <p>???	And these panels are usually put in an open area to be in the best position to consume the solar energy which will lead to it getting dirty and dusted from the pollution. </p>

        </div>
        <div class=""col-lg-6"">");
            WriteLiteral("\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0221a77d74460f39137bce760839ffa83a5cbc211637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div>
            <h2>Why Solar Energy</h2>
            <p>Solar energy - a clean source No greenhouse gas emissions are released into the atmosphere when you use solar panels to create electricity. And because the sun provides more energy than we'll ever need, electricity from solar power is a very important energy source in the move to clean energy production.</p>
            <h2> Our Tasks</h2>
            <p>Work Breakdown Structure (WBS)-the process of dividing the project into manageable tasks and logically ordering them to ensure a smooth evolution between tasks. Some tasks may be performed in parallel where as others must follow one another sequentially.</p>
            <br>
            <p>???	Task sequence depends on which tasks produce deliverables needed in other tasks. </p>

            <p>???	The characteristics of a task can be done by one person or a well-defined group. </p>

            <p>???	Has a single and identifiable deliverable. </p>

            <p>???	Has");
            WriteLiteral(@" a known method or technique? </p>

            <p>???	Has well-accepted predecessor and successor steps. </p>

            <p>???	Is measurable so that percent completed can be determined. </p>
        </div>
        <div>
            <h2>Our Plan</h2>
            <br>
            <p>The second phase of the project management process that focus on defining clear, discrete activities and the work needed to complete each activity within a single project spilt two part first one-project tasks, second project team and tasks.</p>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9eced340b32d104a90815046e8e2452cfd0438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WeatherAnalysis_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/WeatherAnalysis/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/WeatherAnalysis/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_WeatherAnalysis_Views_Shared__Layout))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9eced340b32d104a90815046e8e2452cfd0438", @"/Areas/WeatherAnalysis/Views/Shared/_Layout.cshtml")]
    public class Areas_WeatherAnalysis_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Syncfusion.JavaScript.TagHelperScriptManager __Syncfusion_JavaScript_TagHelperScriptManager;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(99, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(134, 1356, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d69002eb55463b9f63460cfd4c09b5", async() => {
                BeginContext(140, 299, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Essential Studio for ASP.NET Core | Showcase Sample | Weather Analysis</title>
    <meta name=""description"" content=""Analyze weather data using charts and grids. It displays the Temperature, Humidity, Precipitation and Sunlight | ASP.NET Core"">
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 439, "\"", 485, 1);
#line 10 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 446, Url.Content("~/css/bootstrap.min.css"), 446, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(486, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 533, "\"", 581, 1);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 540, Url.Content("~/css/weatheranalysis.css"), 540, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(582, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 629, "\"", 699, 1);
#line 12 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 636, Url.Content("~/css/ejthemes/default-theme/ej.web.all.min.css"), 636, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(700, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 747, "\"", 817, 1);
#line 13 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 754, Url.Content("~/css/ejthemes/responsive-css/ej.responsive.css"), 754, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(818, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 865, "\"", 939, 1);
#line 14 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 872, Url.Content("~/css/ejthemes/responsive-css/ejgrid.responsive.css"), 872, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(940, 78, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(1019, 45, false);
#line 16 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(1064, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1135, "\"", 1186, 1);
#line 19 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1141, Url.Content("~/scripts/jquery-3.4.1.min.js"), 1141, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1187, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1232, "\"", 1279, 1);
#line 21 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1238, Url.Content("~/scripts/jsrender.min.js"), 1238, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1280, 46, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1326, "\"", 1368, 1);
#line 22 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1332, Url.Content("~/scripts/respond.js"), 1332, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1369, 52, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1421, "\"", 1470, 1);
#line 24 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1427, Url.Content("~/scripts/ej.web.all.min.js"), 1427, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1471, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1490, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1492, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a33d531fffc4dd0ad7d1a324337ace0", async() => {
                BeginContext(1498, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(1507, 12, false);
#line 28 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1519, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 30 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("ControlsSection"))
    {
        

#line default
#line hidden
                BeginContext(1586, 49, false);
#line 32 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
   Write(RenderSection("ControlsSection", required: false));

#line default
#line hidden
                EndContext();
#line 32 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\WeatherAnalysis\Views\Shared\_Layout.cshtml"
                                                          
    }

#line default
#line hidden
                BeginContext(1644, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(1648, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd8f11a95c4b49a99af36193ae8d49b3", async() => {
                }
                );
                __Syncfusion_JavaScript_TagHelperScriptManager = CreateTagHelper<global::Syncfusion.JavaScript.TagHelperScriptManager>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TagHelperScriptManager);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1687, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1698, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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

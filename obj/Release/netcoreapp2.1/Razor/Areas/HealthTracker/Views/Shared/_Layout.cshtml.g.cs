#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f63a510686802192975b829fa0d42f69e8414595"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HealthTracker_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/HealthTracker/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/HealthTracker/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_HealthTracker_Views_Shared__Layout))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f63a510686802192975b829fa0d42f69e8414595", @"/Areas/HealthTracker/Views/Shared/_Layout.cshtml")]
    public class Areas_HealthTracker_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(134, 1470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c97af1b9aef248128ae8e3a2ad6cd624", async() => {
                BeginContext(140, 314, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Essential Studio for ASP.NET Core | Showcase Sample | Health Tracker</title>
	<meta name=""description"" content=""The ASP.NET Core Health Tracker application is helpful used to track and visualize your health details such as food intake and, activity history."">
    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 454, "\"", 500, 1);
#line 10 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 461, Url.Content("~/css/bootstrap.min.css"), 461, 39, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(501, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 548, "\"", 618, 1);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 555, Url.Content("~/css/ejthemes/default-theme/ej.web.all.min.css"), 555, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(619, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 666, "\"", 736, 1);
#line 12 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 673, Url.Content("~/css/ejthemes/responsive-css/ej.responsive.css"), 673, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(737, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 784, "\"", 858, 1);
#line 13 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 791, Url.Content("~/css/ejthemes/responsive-css/ejgrid.responsive.css"), 791, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(859, 47, true);
                WriteLiteral(" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 906, "\"", 967, 1);
#line 14 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 913, Url.Content("~/css/health-tracker/healthtracker.css"), 913, 54, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(968, 62, true);
                WriteLiteral(" rel=\"stylesheet\" />\r\n    <!--[if lt IE 9]>\r\n    <script src=\"");
                EndContext();
                BeginContext(1031, 45, false);
#line 16 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
            Write(Url.Content("~/scripts/jquery-1.11.3.min.js"));

#line default
#line hidden
                EndContext();
                BeginContext(1076, 71, true);
                WriteLiteral("\"></script>\r\n    <![endif]-->\r\n    <!--[if gte IE 9]><!-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1147, "\"", 1198, 1);
#line 19 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1153, Url.Content("~/scripts/jquery-3.4.1.min.js"), 1153, 45, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1199, 45, true);
                WriteLiteral("></script>\r\n    <!--<![endif]-->\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1244, "\"", 1299, 1);
#line 21 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1250, Url.Content("~/scripts/jquery.globalize.min.js"), 1250, 49, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1300, 46, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1346, "\"", 1393, 1);
#line 22 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1352, Url.Content("~/scripts/jsrender.min.js"), 1352, 41, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1394, 46, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1440, "\"", 1482, 1);
#line 23 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1446, Url.Content("~/scripts/respond.js"), 1446, 36, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1483, 52, true);
                WriteLiteral(" type=\"text/javascript\"></script>\r\n    \r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 1535, "\"", 1584, 1);
#line 25 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1541, Url.Content("~/scripts/ej.web.all.min.js"), 1541, 43, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1585, 12, true);
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
            BeginContext(1604, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1606, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5979e3efbf254c1cb6084cb7e02bd86a", async() => {
                BeginContext(1612, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1619, 12, false);
#line 28 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1631, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1637, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-script-manager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "004f4e82bdcd477e8d93b6ed7adfc876", async() => {
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
                BeginContext(1676, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
     if (IsSectionDefined("ControlsSection"))
    {
        

#line default
#line hidden
                BeginContext(1741, 49, false);
#line 32 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
   Write(RenderSection("ControlsSection", required: false));

#line default
#line hidden
                EndContext();
#line 32 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
                                                          
    }

#line default
#line hidden
                BeginContext(1799, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(1804, 41, false);
#line 34 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Areas\HealthTracker\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1845, 4, true);
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
            BeginContext(1856, 11, true);
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

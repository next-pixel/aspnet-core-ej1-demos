#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29c0e6f1af33b851b1f61aa04a3773c2cf7f1f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pager_Default), @"mvc.1.0.view", @"/Views/Pager/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pager/Default.cshtml", typeof(AspNetCore.Views_Pager_Default))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c0e6f1af33b851b1f61aa04a3773c2cf7f1f84", @"/Views/Pager/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pager_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("slide-height", "350px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pager"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "pagerChange", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.RotatorProperties __Syncfusion_JavaScript_Models_RotatorProperties;
        private global::Syncfusion.JavaScript.Models.RotatorBase __Syncfusion_JavaScript_Models_RotatorBase;
        private global::Syncfusion.JavaScript.Models.RotatorBaseItem __Syncfusion_JavaScript_Models_RotatorBaseItem;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        private global::Syncfusion.JavaScript.Models.PagerProperties __Syncfusion_JavaScript_Models_PagerProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("MetaTags", async() => {
                BeginContext(20, 125, true);
                WriteLiteral("\r\n   <meta name=\"description\" content=\"This example demonstrates the default functionalities of the Pager in ASP.NET Core\">\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(171, 69, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Pager / Default Functionalities</span>");
                EndContext();
            }
            );
            BeginContext(243, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(270, 70, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n            ");
                EndContext();
                BeginContext(340, 1991, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-rotator", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26781df17ba544d8853059e21cc7ede6", async() => {
                    BeginContext(499, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(517, 1787, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "998412e0e3c0489a8116936f02a4d625", async() => {
                        BeginContext(534, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(556, 324, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33f3cd87d7854801a2a298a28d762c13", async() => {
                            BeginContext(572, 26, true);
                            WriteLiteral("\r\n                        ");
                            EndContext();
                            BeginContext(598, 243, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5f17d8d29a64b29afa43f2eae84c17c", async() => {
                                BeginContext(618, 87, true);
                                WriteLiteral("\r\n                            <div>\r\n                                <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 705, "\"", 754, 1);
#line 16 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
WriteAttributeValue("", 711, Url.Content("~/Images/rotator/nature.jpg"), 711, 43, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(755, 65, true);
                                WriteLiteral(" />\r\n                            </div>\r\n                        ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(841, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(880, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(902, 322, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98f6369a9fc0452db6c20ae0aa647fe4", async() => {
                            BeginContext(918, 26, true);
                            WriteLiteral("\r\n                        ");
                            EndContext();
                            BeginContext(944, 241, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a6da845aef4845bd8a136277d8fbc1", async() => {
                                BeginContext(964, 87, true);
                                WriteLiteral("\r\n                            <div>\r\n                                <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1051, "\"", 1098, 1);
#line 23 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
WriteAttributeValue("", 1057, Url.Content("~/Images/rotator/bird.jpg"), 1057, 41, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1099, 65, true);
                                WriteLiteral(" />\r\n                            </div>\r\n                        ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1185, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1224, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1246, 327, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1948b5d2de1465ebed0add36a2b8c03", async() => {
                            BeginContext(1262, 26, true);
                            WriteLiteral("\r\n                        ");
                            EndContext();
                            BeginContext(1288, 246, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36bc0f5a3e174b8bb31914d5c7e78cb4", async() => {
                                BeginContext(1308, 87, true);
                                WriteLiteral("\r\n                            <div>\r\n                                <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1395, "\"", 1447, 1);
#line 30 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
WriteAttributeValue("", 1401, Url.Content("~/Images/rotator/sculpture.jpg"), 1401, 46, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1448, 65, true);
                                WriteLiteral(" />\r\n                            </div>\r\n                        ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1534, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1573, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1595, 325, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df2ca3374b94488498c9b500900fe8b9", async() => {
                            BeginContext(1611, 26, true);
                            WriteLiteral("\r\n                        ");
                            EndContext();
                            BeginContext(1637, 244, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c1f3e0f1ffa4e4c897ff40049e6a3df", async() => {
                                BeginContext(1657, 87, true);
                                WriteLiteral("\r\n                            <div>\r\n                                <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 1744, "\"", 1794, 1);
#line 37 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
WriteAttributeValue("", 1750, Url.Content("~/Images/rotator/seaview.jpg"), 1750, 44, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(1795, 65, true);
                                WriteLiteral(" />\r\n                            </div>\r\n                        ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(1881, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1920, 22, true);
                        WriteLiteral("\r\n                    ");
                        EndContext();
                        BeginContext(1942, 326, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-rotator-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8364e8f4e0a44a4a10b3777d6a2f96f", async() => {
                            BeginContext(1958, 26, true);
                            WriteLiteral("\r\n                        ");
                            EndContext();
                            BeginContext(1984, 245, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60ed51c529f3444cb3c38e903e3bab0e", async() => {
                                BeginContext(2004, 87, true);
                                WriteLiteral("\r\n                            <div>\r\n                                <img class=\"image\"");
                                EndContext();
                                BeginWriteAttribute("src", " src=\"", 2091, "\"", 2142, 1);
#line 44 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
WriteAttributeValue("", 2097, Url.Content("~/Images/rotator/snowfall.jpg"), 2097, 45, false);

#line default
#line hidden
                                EndWriteAttribute();
                                BeginContext(2143, 65, true);
                                WriteLiteral(" />\r\n                            </div>\r\n                        ");
                                EndContext();
                            }
                            );
                            __Syncfusion_JavaScript_ContentTemplate = CreateTagHelper<global::Syncfusion.JavaScript.ContentTemplate>();
                            __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_ContentTemplate);
                            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                            if (!__tagHelperExecutionContext.Output.IsContentModified)
                            {
                                await __tagHelperExecutionContext.SetOutputContentAsync();
                            }
                            Write(__tagHelperExecutionContext.Output);
                            __tagHelperExecutionContext = __tagHelperScopeManager.End();
                            EndContext();
                            BeginContext(2229, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_RotatorBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBaseItem);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(2268, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_RotatorBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2304, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_RotatorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.RotatorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_RotatorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideWidth = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Syncfusion_JavaScript_Models_RotatorProperties.SlideHeight = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowPager = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-pager", __Syncfusion_JavaScript_Models_RotatorProperties.ShowPager, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowNavigateButton = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-navigate-button", __Syncfusion_JavaScript_Models_RotatorProperties.ShowNavigateButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_RotatorProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton = false;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-play-button", __Syncfusion_JavaScript_Models_RotatorProperties.ShowPlayButton, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2331, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(2345, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ca485125bd4216b8e3a454cd0cad68", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_PagerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.PagerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_PagerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 50 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.PageCount = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __Syncfusion_JavaScript_Models_PagerProperties.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 50 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.PageSize = 1;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __Syncfusion_JavaScript_Models_PagerProperties.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 50 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_PagerProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 50 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pager\Default.cshtml"
__Syncfusion_JavaScript_Models_PagerProperties.TotalRecordsCount = 5;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("total-records-count", __Syncfusion_JavaScript_Models_PagerProperties.TotalRecordsCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_PagerProperties.Change = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2472, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2528, 186, true);
                WriteLiteral("\r\n    <script>\r\n\r\n    function pagerChange(args) {\r\n        slider_obj = $(\"#content\").ejRotator(\"instance\");\r\n        slider_obj.gotoIndex(args.currentPage - 1);\r\n    }\r\n    </script>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2739, 254, true);
                WriteLiteral("\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n        .frame {\r\n            width: 100%;\r\n            box-sizing: border-box;\r\n        }\r\n\r\n        #content > li .image {\r\n            width: 100%;\r\n            height: 350px;\r\n        }\r\n    </style>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

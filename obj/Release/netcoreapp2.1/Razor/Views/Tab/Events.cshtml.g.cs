#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Tab\Events.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1de6900e044a7e79981df9d6513e9b2248c51575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tab_Events), @"mvc.1.0.view", @"/Views/Tab/Events.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tab/Events.cshtml", typeof(AspNetCore.Views_Tab_Events))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1de6900e044a7e79981df9d6513e9b2248c51575", @"/Views/Tab/Events.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Tab_Events : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "tools", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "chart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "ASP.NET MVC", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", "grid", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Javascript", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "../css/samplecontent/javascript.html", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("eventTab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-before-load", "onClientBeforeLoad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-load", "onClientLoad", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("create", "onClientCreate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("before-active", "onClientBeforeActive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("item-active", "onClientActive", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectControls_input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target-id", "tabTarget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("change", "evtpropcheckevent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.TabProperties __Syncfusion_JavaScript_Models_TabProperties;
        private global::Syncfusion.JavaScript.Models.TabBase __Syncfusion_JavaScript_Models_TabBase;
        private global::Syncfusion.JavaScript.Models.TabBaseItem __Syncfusion_JavaScript_Models_TabBaseItem;
        private global::Syncfusion.JavaScript.ContentTemplate __Syncfusion_JavaScript_ContentTemplate;
        private global::Syncfusion.JavaScript.Models.DropDownListProperties __Syncfusion_JavaScript_Models_DropDownListProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 45, true);
                WriteLiteral(" <span class=\"sampleName\">Tab / Events</span>");
                EndContext();
            }
            );
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(98, 44, true);
                WriteLiteral("\r\n\r\n    <div style=\"width: 500px\">\r\n        ");
                EndContext();
                BeginContext(142, 1839, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tab", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a951da96549a4cb9ba598e37b6496782", async() => {
                    BeginContext(341, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(355, 1607, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-items", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dae7b19b1ffc48f69a6632f0ae7a1566", async() => {
                        BeginContext(368, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(386, 655, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "527b494adc5643c2b1a39c2f3647b9ff", async() => {
                            BeginContext(424, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(446, 564, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff9801e335a6490dbb1fe5969e1aabd8", async() => {
                                BeginContext(466, 523, true);
                                WriteLiteral(@"
                        <div>
                            Microsoft ASP.NET is a set of technologies in the Microsoft .NET Framework for building Web applications and XML Web services. ASP.NET pages execute on the server and generate markup such as HTML, WML, or XML that is sent to a desktop or mobile browser. ASP.NET pages use a compiled, event-driven programming model that improves performance and enables the separation of application logic and user interface.
                        </div>
                    ");
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
                            BeginContext(1010, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TabBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBaseItem);
                        __Syncfusion_JavaScript_Models_TabBaseItem.ID = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Text = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1041, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1059, 743, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39b591747f9444d19393d5b610b6eecf", async() => {
                            BeginContext(1101, 22, true);
                            WriteLiteral("\r\n                    ");
                            EndContext();
                            BeginContext(1123, 648, false);
                            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-content-template", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed2545a4001d4dadb460de8162ec0832", async() => {
                                BeginContext(1143, 607, true);
                                WriteLiteral(@"
                        <div>
                            The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The ASP.NET MVC framework provides an alternative to the ASP.NET Web Forms pattern for creating Web applications. The ASP.NET MVC framework is a lightweight, highly testable presentation framework that (as with Web Forms-based applications) is integrated with existing ASP.NET features, such as master pages and membership-based authentication.
                        </div>
                    ");
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
                            BeginContext(1771, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TabBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBaseItem);
                        __Syncfusion_JavaScript_Models_TabBaseItem.ID = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Text = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1802, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1820, 114, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-tab-item", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abe9fde26ea64ec59d77853758d3b2da", async() => {
                            BeginContext(1903, 18, true);
                            WriteLiteral("\r\n                ");
                            EndContext();
                        }
                        );
                        __Syncfusion_JavaScript_Models_TabBaseItem = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBaseItem>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBaseItem);
                        __Syncfusion_JavaScript_Models_TabBaseItem.ID = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Text = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        __Syncfusion_JavaScript_Models_TabBaseItem.Url = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1934, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_TabBase = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabBase>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabBase);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1962, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_TabProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.TabProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_TabProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Tab\Events.cshtml"
__Syncfusion_JavaScript_Models_TabProperties.SelectedItemIndex = 0;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("selected-item-index", __Syncfusion_JavaScript_Models_TabProperties.SelectedItemIndex, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_TabProperties.AjaxBeforeLoad = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Syncfusion_JavaScript_Models_TabProperties.AjaxLoad = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_TabProperties.Create = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_TabProperties.BeforeActive = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                __Syncfusion_JavaScript_Models_TabProperties.ItemActive = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1981, 17, true);
                WriteLiteral("\r\n    </div>\r\n   ");
                EndContext();
            }
            );
            BeginContext(2001, 171, true);
            WriteLiteral("<div id=\"tabTarget\">\r\n    <ul>\r\n        <li>ajaxBeforeLoad</li>\r\n        <li>ajaxLoad</li>\r\n        <li>beforeActive</li>\r\n        <li>itemActive</li>\r\n    </ul>\r\n</div>\r\n");
            EndContext();
            DefineSection("EventsDropdown", async() => {
                BeginContext(2196, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2202, 152, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-drop-down-list", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfe1402515994b468835b07ca3530c34", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_DropDownListProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.DropDownListProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_DropDownListProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __Syncfusion_JavaScript_Models_DropDownListProperties.TargetID = (string)__tagHelperAttribute_14.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
#line 37 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Tab\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-checkbox", __Syncfusion_JavaScript_Models_DropDownListProperties.ShowCheckbox, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Tab\Events.cshtml"
__Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("check-all", __Syncfusion_JavaScript_Models_DropDownListProperties.CheckAll, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_DropDownListProperties.Change = (string)__tagHelperAttribute_15.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2354, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(2382, 1566, true);
                WriteLiteral(@"
    <script>
        function evtpropcheckevent(args) {
            tabObj = $(""#eventTab"").data(""ejTab"");
            if (args.isChecked) {
                switch (args.selectedText) {
                    case ""ajaxBeforeLoad"": tabObj.option(args.selectedText, ""onClientBeforeLoad""); break;
                    case ""ajaxLoad"": tabObj.option(args.selectedText, ""onClientLoad""); break;
                    case ""beforeActive"": tabObj.option(args.selectedText, ""onClientBeforeActive""); break;
                    case ""itemActive"": tabObj.option(args.selectedText, ""onClientActive""); break;
                }
            }
            else tabObj.option(args.selectedText, null);
        }

        function onClientBeforeLoad(e) {
            jQuery.addEventLog(""<span class='eventTitle'>BeforeLoad</span> event is fired.</br>"");
        }
        function onClientLoad(e) {
            jQuery.addEventLog(""Ajax content has been <span class='eventTitle'>loaded</span>.</br>"");
        }
        functio");
                WriteLiteral(@"n onClientCreate(e) {
            jQuery.addEventLog(""Tab is <span class='eventTitle'>created</span>. </br>"");
        }
        function onClientActive(e) {
            jQuery.addEventLog(""Index "" + e.activeIndex + "" is <span class='eventTitle'>activated</span>. </br>"");
        }
        function onClientBeforeActive(e) {
            jQuery.addEventLog(""<span class='eventTitle'>BeforeActive </span>event is fired. </br>"");
        }
        function onClear() {
            jQuery.clearEventLog();
        }
    </script>

");
                EndContext();
            }
            );
            BeginContext(3951, 4, true);
            WriteLiteral("\r\n\r\n");
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

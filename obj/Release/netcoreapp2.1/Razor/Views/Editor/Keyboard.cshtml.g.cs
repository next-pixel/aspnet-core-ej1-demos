#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Editor\Keyboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b9037492a46a27bba47785246a64844d5331c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editor_Keyboard), @"mvc.1.0.view", @"/Views/Editor/Keyboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Editor/Keyboard.cshtml", typeof(AspNetCore.Views_Editor_Keyboard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b9037492a46a27bba47785246a64844d5331c1", @"/Views/Editor/Keyboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Editor_Keyboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("numeric"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("percent"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("currency"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.EditorProperties __Syncfusion_JavaScript_Models_EditorProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("ScriptReferenceSection", async() => {
                BeginContext(32, 13, true);
                WriteLiteral("\r\n    <script");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 45, "\"", 109, 1);
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Editor\Keyboard.cshtml"
WriteAttributeValue("", 51, Url.Content("~/Scripts/cultures/ej.culture.en-US.min.js"), 51, 58, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(110, 12, true);
                WriteLiteral("></script>\r\n");
                EndContext();
            }
            );
            DefineSection("SampleHeading", async() => {
                BeginContext(148, 50, true);
                WriteLiteral("<span class=\"sampleName\">Editor / Keyboard </span>");
                EndContext();
            }
            );
            BeginContext(201, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(228, 204, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>Numeric Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(432, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-numeric-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8ce4da7426641cb8517e4711ba6ae64", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Editor\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 1000;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(494, 218, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>Percentage Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(712, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-percentage-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93992a2069154b2e8d869cd0bbd33bc0", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 21 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Editor\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 100;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(776, 216, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"column\">\r\n                <span>Currency Textbox</span>\r\n            </div>\r\n            <div class=\"column\">\r\n                ");
                EndContext();
                BeginContext(992, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-currency-text-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05a83de8dbf844bfb761e6f6c7cb156d", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_EditorProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.EditorProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_EditorProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 29 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Editor\Keyboard.cshtml"
__Syncfusion_JavaScript_Models_EditorProperties.Value = 50;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Syncfusion_JavaScript_Models_EditorProperties.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_EditorProperties.Width = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1054, 50, true);
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(1134, 738, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + j
        </div>
        <div class=""col-md-3"">
            Focuses the control.
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Up
        </div>
        <div class=""col-md-3"">
            Increments the value
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Down
        </div>
        <div class=""col-md-3"">
            Decrements the value
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-3"">
            Tab
        </div>
        <div class=""col-md-3"">
            Focus the next element
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1898, 373, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            $(document).on(""keydown"", function (e) {
                if (e.altKey && e.keyCode === 74) { // j- key code.
                    $(""#numeric"").siblings("".e-input"").focus();
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(2296, 241, true);
                WriteLiteral("\r\n\r\n    <style type=\"text/css\" class=\"cssStyles\">\r\n       .frame {\r\n            width: 38%;\r\n            padding: 30px;\r\n        }\r\n        .column {\r\n            padding-bottom: 5px;\r\n            padding-top: 5px;\r\n        }\r\n    </style>\r\n");
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

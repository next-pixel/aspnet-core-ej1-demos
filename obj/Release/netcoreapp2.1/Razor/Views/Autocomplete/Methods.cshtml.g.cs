#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Autocomplete\Methods.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3088b0c5eebaf74689e834d4a833ceba8f551c33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autocomplete_Methods), @"mvc.1.0.view", @"/Views/Autocomplete/Methods.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Autocomplete/Methods.cshtml", typeof(AspNetCore.Views_Autocomplete_Methods))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3088b0c5eebaf74689e834d4a833ceba8f551c33", @"/Views/Autocomplete/Methods.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Autocomplete_Methods : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("key", "key", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("selectCountry"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("watermark-text", "Select a country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("check21"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "105px", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("default-text", "Disable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("active-text", "Enable", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "changeState", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("getValue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "Get value", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("click", "btnClick", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.AutocompleteProperties __Syncfusion_JavaScript_Models_AutocompleteProperties;
        private global::Syncfusion.JavaScript.AutocompleteFields __Syncfusion_JavaScript_AutocompleteFields;
        private global::Syncfusion.JavaScript.Models.ToggleButtonProperties __Syncfusion_JavaScript_Models_ToggleButtonProperties;
        private global::Syncfusion.JavaScript.Models.ButtonProperties __Syncfusion_JavaScript_Models_ButtonProperties;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 60, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Autocomplete / Methods</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(104, 166, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to disable and get the selected value in the Syncfusion ASP.NET Core Autocomplete component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(298, 83, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"control\">\r\n           \r\n            ");
                EndContext();
                BeginContext(381, 200, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-autocomplete", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa7e62aaf95a4224a57b86c13f4a9db7", async() => {
                    BeginContext(496, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                    BeginContext(514, 35, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-autocomplete-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "297e7444c6604d6e9fcce457903e1eb9", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_AutocompleteFields = CreateTagHelper<global::Syncfusion.JavaScript.AutocompleteFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_AutocompleteFields);
                    __Syncfusion_JavaScript_AutocompleteFields.Key = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(549, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_AutocompleteProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.AutocompleteProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AutocompleteProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 10 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Autocomplete\Methods.cshtml"
__Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource = ViewBag.datasource;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_AutocompleteProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.Width = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Syncfusion_JavaScript_Models_AutocompleteProperties.WatermarkText = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(581, 57, true);
                WriteLiteral("\r\n            \r\n           \r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("PropertiesSection", async() => {
                BeginContext(668, 70, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(738, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-toggle-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "959314d2ba984236a0820e3a14bf1c72", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ToggleButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ToggleButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ToggleButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.DefaultText = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.ActiveText = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Syncfusion_JavaScript_Models_ToggleButtonProperties.Click = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(847, 65, true);
                WriteLiteral("\r\n          </div>\r\n        <div class=\"col-md-12\">\r\n            ");
                EndContext();
                BeginContext(912, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da30b6169e8042fb9e67cbd19e6956a9", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ButtonProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ButtonProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ButtonProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Syncfusion_JavaScript_Models_ButtonProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_Models_ButtonProperties.Text = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Syncfusion_JavaScript_Models_ButtonProperties.Click = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(986, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(1042, 595, true);
                WriteLiteral(@"
    <script type=""text/javascript"" class=""jsScript"">
        var autocomplete;
        $(function () {
            $(""#sampleProperties"").ejPropertiesPanel();
            autocomplete = $('#selectCountry').data(""ejAutocomplete"");
        });
        function changeState(args) {
            autocomplete = $('#selectCountry').data(""ejAutocomplete"");
            if (args.isChecked) autocomplete.disable();
            else autocomplete.enable();
        }
        function btnClick() {
            alert(""Current value is : "" + autocomplete.getValue());
        }
    </script>
");
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

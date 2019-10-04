#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ListBox\DragAndDrop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "657b911fff05912ccb1c720d6902398fda92175c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ListBox_DragAndDrop), @"mvc.1.0.view", @"/Views/ListBox/DragAndDrop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ListBox/DragAndDrop.cshtml", typeof(AspNetCore.Views_ListBox_DragAndDrop))]
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
#line 1 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"657b911fff05912ccb1c720d6902398fda92175c", @"/Views/ListBox/DragAndDrop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_ListBox_DragAndDrop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("list1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("list2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.ListBoxProperties __Syncfusion_JavaScript_Models_ListBoxProperties;
        private global::Syncfusion.JavaScript.Models.ListBoxFields __Syncfusion_JavaScript_Models_ListBoxFields;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 61, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">ListBox / Drag and Drop</span>");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(105, 189, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This example demonstrates how to drag list items from one ListBox component and drop them into another Syncfusion ASP.NET Core ListBox component.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(322, 169, true);
                WriteLiteral("\r\n    <div class=\"frame\">\r\n        <div class=\"row\">\r\n            <div class=\"ctrllabel\">Drag and drop skills</div>\r\n            <div class=\"contents\">\r\n                ");
                EndContext();
                BeginContext(491, 174, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "498f163e1dd4403c86ce2e081725fed3", async() => {
                    BeginContext(578, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(600, 33, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-list-box-fields", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d021f1730e9426aabbd8aedf41496bb", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_ListBoxFields = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxFields>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxFields);
                    __Syncfusion_JavaScript_Models_ListBoxFields.Text = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(633, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 11 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ListBox\DragAndDrop.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.AllowDragAndDrop = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-drag-and-drop", __Syncfusion_JavaScript_Models_ListBoxProperties.AllowDragAndDrop, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ListBox\DragAndDrop.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.DataSource = ViewBag.datasourcelang;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_Models_ListBoxProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(665, 106, true);
                WriteLiteral("                \r\n            </div>\r\n            <div class=\"contents col-sm-offset-2\">\r\n                ");
                EndContext();
                BeginContext(771, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-list-box", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13880550f6cd4253a0ca0a76298467c0", async() => {
                }
                );
                __Syncfusion_JavaScript_Models_ListBoxProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.ListBoxProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_ListBoxProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 16 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\ListBox\DragAndDrop.cshtml"
__Syncfusion_JavaScript_Models_ListBoxProperties.AllowDragAndDrop = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-drag-and-drop", __Syncfusion_JavaScript_Models_ListBoxProperties.AllowDragAndDrop, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(836, 66, true);
                WriteLiteral("                \r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            DefineSection("StyleSection", async() => {
                BeginContext(927, 373, true);
                WriteLiteral(@"
    <style class=""cssStyles"">
        .ctrllabel {
            padding: 0px 0px 12px 36px;
            font-weight: 600;
        }

        .contents {
            padding-left: 36px;
            position: relative;
            margin: 0 auto;
            float: left;
        }
        
        .frame {
            width: 500px;
        }
    </style>
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
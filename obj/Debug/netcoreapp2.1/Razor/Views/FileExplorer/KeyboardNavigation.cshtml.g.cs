#pragma checksum "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\KeyboardNavigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b390060085e6fdb5ab2c2cd42a7b7606f4e5ee13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileExplorer_KeyboardNavigation), @"mvc.1.0.view", @"/Views/FileExplorer/KeyboardNavigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FileExplorer/KeyboardNavigation.cshtml", typeof(AspNetCore.Views_FileExplorer_KeyboardNavigation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b390060085e6fdb5ab2c2cd42a7b7606f4e5ee13", @"/Views/FileExplorer/KeyboardNavigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_FileExplorer_KeyboardNavigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Download{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/GetImage{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "/FileExplorer/Upload{0}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("keyboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("path", "wwwroot/css/images/FileExplorerContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", "100%", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.FileExplorerProperties __Syncfusion_JavaScript_Models_FileExplorerProperties;
        private global::Syncfusion.JavaScript.Models.AjaxSettings __Syncfusion_JavaScript_Models_AjaxSettings;
        private global::Syncfusion.JavaScript.jQueryAjaxOptions __Syncfusion_JavaScript_jQueryAjaxOptions;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 67, true);
                WriteLiteral("<span class=\"sampleName\">FileExplorer / Keyboard Navigation </span>");
                EndContext();
            }
            );
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("ControlsSection", async() => {
                BeginContext(120, 5, true);
                WriteLiteral("\r\n   ");
                EndContext();
                BeginContext(125, 449, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-file-explorer", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e32b6a3340d47a28b47582f7dd862db", async() => {
                    BeginContext(299, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                    BeginContext(305, 248, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-file-ajax-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3802ef8a2e60491186371fbeb488286f", async() => {
                        BeginContext(327, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(337, 57, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-download", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a0d4711a554a3e9d03ad2b9a0e1834", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_jQueryAjaxOptions = CreateTagHelper<global::Syncfusion.JavaScript.jQueryAjaxOptions>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_jQueryAjaxOptions);
                        __Syncfusion_JavaScript_jQueryAjaxOptions.Url = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(394, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(404, 59, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-get-image", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f95c4b787b945d285046378ff313217", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_jQueryAjaxOptions = CreateTagHelper<global::Syncfusion.JavaScript.jQueryAjaxOptions>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_jQueryAjaxOptions);
                        __Syncfusion_JavaScript_jQueryAjaxOptions.Url = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(463, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                        BeginContext(473, 51, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-upload", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74221b3239aa41dd95f5a23f233e920b", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_jQueryAjaxOptions = CreateTagHelper<global::Syncfusion.JavaScript.jQueryAjaxOptions>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_jQueryAjaxOptions);
                        __Syncfusion_JavaScript_jQueryAjaxOptions.Url = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(524, 6, true);
                        WriteLiteral("\r\n    ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_Models_AjaxSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.AjaxSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_AjaxSettings);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(553, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_FileExplorerProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.FileExplorerProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_FileExplorerProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Path = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\KeyboardNavigation.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.Layout = global::Syncfusion.JavaScript.LayoutType.Tile;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("layout", __Syncfusion_JavaScript_Models_FileExplorerProperties.Layout, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\KeyboardNavigation.cshtml"
                                                                                                WriteLiteral(Url.Content("FileActionDefault"));

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("ajax-action", __Syncfusion_JavaScript_Models_FileExplorerProperties.AjaxAction, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_Models_FileExplorerProperties.Width = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 4 "D:\Samples_17.2.0.46\ASPNETCORE\samplebrowser_core_2_0\Views\FileExplorer\KeyboardNavigation.cshtml"
__Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("is-responsive", __Syncfusion_JavaScript_Models_FileExplorerProperties.IsResponsive, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(574, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(579, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("PropertiesSection", async() => {
                BeginContext(608, 4395, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + j
        </div>
        <div class=""col-md-3"">
            Focuses the control
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Shift + 1
        </div>
        <div class=""col-md-3"">
            Focuses the Toolbar
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Shift + 2
        </div>
        <div class=""col-md-3"">
            Focuses the Treeview
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Shift + 3
        </div>
        <div class=""col-md-3"">
            Focuses the Splitter
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Shift + 4
        </div>
        <div class=""col-md-3"">
            Focuses the Grid view
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
  ");
                WriteLiteral(@"          Ctrl + Shift + 5
        </div>
        <div class=""col-md-3"">
            Focuses the Tile view
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Shift + 6
        </div>
        <div class=""col-md-3"">
            Focuses the LargeIcons view
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + Shift + 7
        </div>
        <div class=""col-md-3"">
            Focuses the Statusbar
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Right
        </div>
        <div class=""col-md-3"">
            Focusing next item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Left
        </div>
        <div class=""col-md-3"">
            Focusing previous item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Enter
        </div>
        <div class=""col-md-3"">");
                WriteLiteral(@"
            Selection the focused item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Esc
        </div>
        <div class=""col-md-3"">
            Closes the opened dialog
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            F2
        </div>
        <div class=""col-md-3"">
            Renames the selected item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + A
        </div>
        <div class=""col-md-3"">
            Selects the all items
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + N
        </div>
        <div class=""col-md-3"">
            Opens Create Folder dialog
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + U
        </div>
        <div class=""col-md-3"">
            Opens Upload dialog
        </div>
    </div>
    <div class=""");
                WriteLiteral(@"row"">
        <div class=""col-md-3"">
            F5
        </div>
        <div class=""col-md-3"">
            Refresh the content
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Alt + Enter
        </div>
        <div class=""col-md-3"">
            Get the details of selected item
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + X
        </div>
        <div class=""col-md-3"">
            To cut the selected items
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + C
        </div>
        <div class=""col-md-3"">
            To copy the selected items
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Ctrl + V
        </div>
        <div class=""col-md-3"">
            Pastes the copied items
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Delete
        ");
                WriteLiteral(@"</div>
        <div class=""col-md-3"">
            Deletes the selected items
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            Shift + F10
        </div>
        <div class=""col-md-3"">
            Opens the ContextMenu
        </div>
    </div>
");
                EndContext();
            }
            );
            DefineSection("ScriptSection", async() => {
                BeginContext(5029, 268, true);
                WriteLiteral(@"
    <script>
        $(document).on(""keydown"", function (e) {
            if (e.altKey && e.keyCode === 74) { // j- key code.
                $(""#keyboard"").focus();
            }
        });
        $(""#sampleProperties"").ejPropertiesPanel();
    </script>
");
                EndContext();
            }
            );
            BeginContext(5300, 4, true);
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
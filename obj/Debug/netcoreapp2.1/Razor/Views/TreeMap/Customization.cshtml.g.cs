#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "306e823c72fdc34941cecff33f6d9063f33c2f49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeMap_Customization), @"mvc.1.0.view", @"/Views/TreeMap/Customization.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeMap/Customization.cshtml", typeof(AspNetCore.Views_TreeMap_Customization))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"306e823c72fdc34941cecff33f6d9063f33c2f49", @"/Views/TreeMap/Customization.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeMap_Customization : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("item-template", "imageTemplate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label-path", "GameName", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#D73028", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color-value-path", "GoldMedals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("weight-value-path", "TotalMedals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties;
        private global::Syncfusion.JavaScript.DataVisualization.Models.LeafItemsSetting __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapUniColorMapping __Syncfusion_JavaScript_DataVisualization_Models_TreeMapUniColorMapping;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 61, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">TreeMap / Customization</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(266, 146, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample demonstrates USA Olympics medals 2012 in the Syncfusion ASP.NET Web Forms Treemap control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(444, 223, true);
                WriteLiteral("\r\n   <div class=\"Common\">\r\n     <div>\r\n        <span style=\"color:gray;font-size:x-large;font-family:\'Segoe UI\';font-weight:normal;\" >US Olympic Medals FY2012</span>\r\n    </div>\r\n    <div style=\"min-height:380px\">\r\n        ");
                EndContext();
                BeginContext(667, 359, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-map", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bb89daf2be24402be3fb5303c933ecf", async() => {
                    BeginContext(785, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(799, 130, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-leaf-item-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c93f2aec4d441fe971ad96a8f8307f1", async() => {
                        BeginContext(892, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.LeafItemsSetting>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting);
#line 19 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.ShowLabels = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-labels", __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.ShowLabels, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.ItemTemplate = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Syncfusion_JavaScript_DataVisualization_Models_LeafItemsSetting.LabelPath = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(929, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(943, 59, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-uni-color-mapping", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dd80cefacc54cbd9042ad57eafa43e5", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_TreeMapUniColorMapping = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapUniColorMapping>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapUniColorMapping);
                    __Syncfusion_JavaScript_DataVisualization_Models_TreeMapUniColorMapping.Color = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1002, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 18 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Customization.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource = ViewBag.medals;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ColorValuePath = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.WeightValuePath = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1026, 288, true);
                WriteLiteral(@"
                </div>
   </div>
          <script id=""imageTemplate"" type=""application/jsrender"">
            <div style=""border:1px solid white;background:url({{:Data.GameImage}}) no-repeat center center;height:{{:ItemHeight}}px;width:{{:ItemWidth}}px;"" />
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

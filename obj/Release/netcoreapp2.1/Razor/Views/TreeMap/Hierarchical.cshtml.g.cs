#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537898d7e2be70ad40d3db471e3972bb59610d50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TreeMap_Hierarchical), @"mvc.1.0.view", @"/Views/TreeMap/Hierarchical.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TreeMap/Hierarchical.cshtml", typeof(AspNetCore.Views_TreeMap_Hierarchical))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
using Syncfusion.MVC.EJ;

#line default
#line hidden
#line 3 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
#line 4 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
using Syncfusion.JavaScript.DataVisualization.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"537898d7e2be70ad40d3db471e3972bb59610d50", @"/Views/TreeMap/Hierarchical.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_TreeMap_Hierarchical : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("group-path", "Country", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label-template", "labeltemplate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color", "#41B8C4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("tooltip-template", "tooltiptemp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("color-value-path", "Expense", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("weight-value-path", "Sales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.TreeMapCollectionTag __Syncfusion_JavaScript_TreeMapCollectionTag;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel;
        private global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapDesaturationColorMapping __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(159, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(184, 60, true);
                WriteLiteral("\r\n\t<span class=\"sampleName\">TreeMap / Hierarchical</span>\r\n\t");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(267, 168, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This sample indicates to define levels for hierarchical data collection in the Syncfusion ASP.NET Web Forms TreeMap control.\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(463, 73, true);
                WriteLiteral("\r\n  <div class=\"Common\">\r\n    <div style=\"min-height:381px;\">  \r\n        ");
                EndContext();
                BeginContext(536, 573, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-tree-map", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6209b7c662243e2ab82800a9bc31695", async() => {
                    BeginContext(728, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(742, 162, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-levels", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dff7ef33a6a6479ab56a50c7a19aa045", async() => {
                        BeginContext(752, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(770, 109, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-level", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a6aa185c20647ceb958bbbada5aa8cb", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapLevel>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.GroupPath = (string)__tagHelperAttribute_0.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 18 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight = 25;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("header-height", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.HeaderHeight, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 18 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("show-labels", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.ShowLabels, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __Syncfusion_JavaScript_DataVisualization_Models_TreeMapLevel.LabelTemplate = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(879, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_TreeMapCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.TreeMapCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_TreeMapCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(904, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(918, 167, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-desaturation-color-mapping", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "923a482713f24bf5b7fe565c9d26dd75", async() => {
                        BeginContext(1024, 30, true);
                        WriteLiteral("                \r\n            ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapDesaturationColorMapping>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping);
#line 20 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.From = 1;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("from", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.From, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.To = 0.5;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("to", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.To, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.Color = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 20 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.RangeMinimum = 2000;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("range-minimum", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.RangeMinimum, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.RangeMaximum = 8000;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("range-maximum", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapDesaturationColorMapping.RangeMaximum, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1085, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties = CreateTagHelper<global::Syncfusion.JavaScript.DataVisualization.Models.TreeMapProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#line 15 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource = ViewBag.hierarchicalData;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("datasource", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.DataSource, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.TooltipTemplate = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 15 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\TreeMap\Hierarchical.cshtml"
__Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ShowTooltip = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("show-tooltip", __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ShowTooltip, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.ColorValuePath = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Syncfusion_JavaScript_DataVisualization_Models_TreeMapProperties.WeightValuePath = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1109, 3574, true);
                WriteLiteral(@"     
                 </div>

    <div id=""tooltiptemp"" style=""display: none;"">
         <table style=""background-color:#222222;width: 166px;height: 107px;"">
            <tr>
                <td colspan=""3"">
                    <span style=""font-size:18px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">{{:Country}}</span>
                </td>
            </tr>
            <tr>
                <td> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">Region</span></td>
                <td> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">:</span></td>
                <td colspan=""3""> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">{{:Name}}</span></td>
                <td style=""width:20px;""></td>
            </tr>
            <tr>
               <td> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">Sales</span></td>
 ");
                WriteLiteral(@"              <td> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">:</span></td>
                <td colspan=""3""> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">{{:Sales}}</span></td>
            </tr>
            <tr>
                 <td> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">Expense</span></td>
                 <td> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">:</span></td>
                <td colspan=""3""> <span style=""font-size:14px;color:white;margin-left:10px;opacity:0.8;font-weight:normal;"">{{:Expense}}</span></td>
            </tr>
            <tr></tr>
            <tr></tr>
        </table>
    </div>
  </div>
    <script  id=""headertemplate"" type=""application/jsrender"">

         <div>
            <span style=""color:gray;font-size:18px;font-weight:normal;"" id=""span1"">{{:header}}</span><br />
         </d");
                WriteLiteral(@"iv>
      </script>
    <script  id=""labeltemplate"" type=""application/jsrender"">

           <div align=""center""  style=""width:120px; height:120px;background-image:url('../images/treemap/circle.png');"">
             <table style=""text-align:center;margin-left:-10px; margin-top:10px;"" >
               <tr>
                <td></td>
                <th>
                <div style=""margin-top:10px;margin-left:10px;"">
                <span style=""color:white;font-size:16px;font-weight:normal;"" id=""span2"">Sales</span>
                </div></th>
              </tr>
              <tr>
                <td></td>
                <td>
                <div style=""margin-top:-5px;"">
                <span style=""color:white;font-size:15px;font-weight:normal;"" id=""span5"">98486</span>
                </div>
                </td>
              </tr>
              <tr />
              <tr>
                <td></td>
                <th>
                <div style=""margin-top:3px;margin-left:2px;"">
   ");
                WriteLiteral(@"             <span style=""color:white;font-size:16px;margin-top:-5px;font-weight:normal;"" id=""span3"">Expense</span>
                </div></th>
              </tr>
              <tr>

                 <td></td>
                <td>
                <div style=""margin-top:-5px;"">
                <span style=""color:white;font-size:15px;font-weight:normal;"" id=""span4"">87000</span>
                </div></td>
              </tr>
            </table>
          </div>
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
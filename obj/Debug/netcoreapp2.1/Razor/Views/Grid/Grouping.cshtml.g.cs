#pragma checksum "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474746e79c92c13e0e8592afdaa74642186c2f28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grid_Grouping), @"mvc.1.0.view", @"/Views/Grid/Grouping.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Grid/Grouping.cshtml", typeof(AspNetCore.Views_Grid_Grouping))]
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
#line 1 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser;

#line default
#line hidden
#line 2 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using samplebrowser.Models;

#line default
#line hidden
#line 3 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 4 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#line 5 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"474746e79c92c13e0e8592afdaa74642186c2f28", @"/Views/Grid/Grouping.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Grid_Grouping : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("url", "//js.syncfusion.com/demos/ejServices/Wcf/Northwind.svc/Orders/?$top=45", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "OrderID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Order ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "CustomerID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Customer ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "EmployeeID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Employee ID", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Freight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("format", "{0:C2}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("field", "ShipCity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-text", "Ship City", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FlatGrid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Syncfusion.JavaScript.Models.GridProperties __Syncfusion_JavaScript_Models_GridProperties;
        private global::Syncfusion.JavaScript.Models.GroupSettings __Syncfusion_JavaScript_Models_GroupSettings;
        private global::Syncfusion.JavaScript.DataSource __Syncfusion_JavaScript_DataSource;
        private global::Syncfusion.JavaScript.GridCollectionTag __Syncfusion_JavaScript_GridCollectionTag;
        private global::Syncfusion.JavaScript.Models.Column __Syncfusion_JavaScript_Models_Column;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 48, true);
                WriteLiteral("<span class=\"sampleName\">Grid / Grouping</span> ");
                EndContext();
            }
            );
            DefineSection("MetaTags", async() => {
                BeginContext(92, 195, true);
                WriteLiteral("\r\n    <meta name=\"description\" content=\"This demo explains the basic functionalities of grouping and how to group a column in the initial rendering of Syncfusion ASP.NET Core DataGrid control\">\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(315, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
       
        var GroupedCols = new List<string>() { "CustomerID" };
    

#line default
#line hidden
                BeginContext(394, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(398, 888, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("ej-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "670eaf753fb54f50994779e3a97f8cd6", async() => {
                    BeginContext(463, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(473, 67, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-group-settings", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0c346a9650541269acc60342bc87cdb", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_Models_GroupSettings = CreateTagHelper<global::Syncfusion.JavaScript.Models.GroupSettings>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GroupSettings);
#line 10 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_GroupSettings.GroupedColumns = GroupedCols;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("grouped-columns", __Syncfusion_JavaScript_Models_GroupSettings.GroupedColumns, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(540, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(550, 143, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-datamanager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb3fc577a9c245ca89965705480eb719", async() => {
                    }
                    );
                    __Syncfusion_JavaScript_DataSource = CreateTagHelper<global::Syncfusion.JavaScript.DataSource>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_DataSource);
                    __Syncfusion_JavaScript_DataSource.URL = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_DataSource.Offline = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("offline", __Syncfusion_JavaScript_DataSource.Offline, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 11 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_DataSource.CrossDomain = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("cross-domain", __Syncfusion_JavaScript_DataSource.CrossDomain, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(693, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(703, 567, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-columns", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "880ca97a1b4743f2ad773dcb64dd68e1", async() => {
                        BeginContext(714, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(728, 112, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "154f5fc2b3834883a8c41439d9c39692", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_1.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_2.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 13 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.IsPrimaryKey = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("is-primary-key", __Syncfusion_JavaScript_Models_Column.IsPrimaryKey, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 75;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(840, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(854, 77, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbd20374fcbb4c648f8a94d287b72e49", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_3.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_4.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 14 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 80;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(931, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(945, 96, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dce24a36943d44d0bb97dec07af54c1f", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_5.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_6.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 15 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 15 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 75;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1041, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1055, 105, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bad2b06c6bdf45c594add63f21d0daa1", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_7.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_8.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                        __Syncfusion_JavaScript_Models_Column.Format = (string)__tagHelperAttribute_9.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.TextAlign = global::Syncfusion.JavaScript.TextAlign.Right;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("text-align", __Syncfusion_JavaScript_Models_Column.TextAlign, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 75;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1160, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(1174, 74, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("e-column", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73e4698a207e4a6f9eaecdab33ea6bd3", async() => {
                        }
                        );
                        __Syncfusion_JavaScript_Models_Column = CreateTagHelper<global::Syncfusion.JavaScript.Models.Column>();
                        __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_Column);
                        __Syncfusion_JavaScript_Models_Column.Field = (string)__tagHelperAttribute_10.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                        __Syncfusion_JavaScript_Models_Column.HeaderText = (string)__tagHelperAttribute_11.Value;
                        __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
#line 17 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_Column.Width = 110;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("width", __Syncfusion_JavaScript_Models_Column.Width, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1248, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Syncfusion_JavaScript_GridCollectionTag = CreateTagHelper<global::Syncfusion.JavaScript.GridCollectionTag>();
                    __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_GridCollectionTag);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1270, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Syncfusion_JavaScript_Models_GridProperties = CreateTagHelper<global::Syncfusion.JavaScript.Models.GridProperties>();
                __tagHelperExecutionContext.Add(__Syncfusion_JavaScript_Models_GridProperties);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
#line 9 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.AllowPaging = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-paging", __Syncfusion_JavaScript_Models_GridProperties.AllowPaging, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "D:\Samples_18.1.0.42\ASPNETCORE\samplebrowser\Views\Grid\Grouping.cshtml"
__Syncfusion_JavaScript_Models_GridProperties.AllowGrouping = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("allow-grouping", __Syncfusion_JavaScript_Models_GridProperties.AllowGrouping, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1286, 2, true);
                WriteLiteral("\r\n");
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
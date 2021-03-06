#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\ImportAndStamp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe05c11164b598be8142f3e88ce3a33a8ce54f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pdf_ImportAndStamp), @"mvc.1.0.view", @"/Views/Pdf/ImportAndStamp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pdf/ImportAndStamp.cshtml", typeof(AspNetCore.Views_Pdf_ImportAndStamp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe05c11164b598be8142f3e88ce3a33a8ce54f5", @"/Views/Pdf/ImportAndStamp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Pdf_ImportAndStamp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("SampleHeading", async() => {
                BeginContext(23, 80, true);
                WriteLiteral("\r\n    <span class=\"sampleName\">Modify Documents / ImportAndStamp Sample</span>\r\n");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(131, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 5 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\ImportAndStamp.cshtml"
      Html.BeginForm("ImportAndStamp", "Pdf", FormMethod.Post, new { enctype = "multipart/form-data" });
        {

#line default
#line hidden
                BeginContext(250, 455, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"" style=""font-size: 17px;font-weight: 400;"">
                    This sample demonstrates how to stamp an existing PDF document using text. The Essential PDF supports both stamp or watermark with text and images in the PDF document.
                </div>
                <div id=""errorlabel"" value=""error"">
                    <p style=""color: #FF0000;"">
                        ");
                EndContext();
                BeginContext(706, 35, false);
#line 13 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\ImportAndStamp.cshtml"
                   Write(Html.Label("", (string)ViewBag.lab));

#line default
#line hidden
                EndContext();
                BeginContext(741, 1471, true);
                WriteLiteral(@"
                </div>
                <br />
                <div>
                    <label> PDF document to import</label>
                    <input type=""file"" name=""file"" margin-left 12px"" accept=""application/pdf"" />
                </div>
                <div style=""padding-top:7px"">
                    <label>Stamping Text</label>
                    <input type=""text"" style=""width: 50%; margin-left: 12px"" id=""Stamptext"" value=""imported content using essential pdf""
                           name=""Stamptext"">
                </div>
                <br />
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        <div class=""celldiv"">
                            <div>
                                <input type=""submit"" class=""Button"" value=""Generate PDF"" style=""width: 150px;"" />
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <");
                WriteLiteral(@"div style=""font-size: 17px;font-weight: 400;"">
                    This feature can be used to stamp the PDF document for draft, confidential, review purpose only, company logo, copyright notice and more.
                    More information about the stamp or watermark can be found in this documentation <a href=""https://help.syncfusion.com/file-formats/pdf/working-with-watermarks"">section.</a>

                </div>
            </div>
");
                EndContext();
#line 42 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\Pdf\ImportAndStamp.cshtml"
            Html.EndForm();
        }
    

#line default
#line hidden
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

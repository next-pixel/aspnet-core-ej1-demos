#pragma checksum "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\SimpleReplace.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916902dd54fc91bba900acc683db2447852c78ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DocIO_SimpleReplace), @"mvc.1.0.view", @"/Views/DocIO/SimpleReplace.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/DocIO/SimpleReplace.cshtml", typeof(AspNetCore.Views_DocIO_SimpleReplace))]
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
#line 1 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\SimpleReplace.cshtml"
using Syncfusion.JavaScript;

#line default
#line hidden
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\_ViewImports.cshtml"
using Syncfusion.JavaScript.Models;

#line default
#line hidden
#line 2 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\SimpleReplace.cshtml"
using Syncfusion.JavaScript.DataVisualization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916902dd54fc91bba900acc683db2447852c78ae", @"/Views/DocIO/SimpleReplace.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f24ad629059c907b4a44ce80df0925aecc3212ba", @"/Views/_ViewImports.cshtml")]
    public class Views_DocIO_SimpleReplace : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("SampleHeading", async() => {
                BeginContext(104, 55, true);
                WriteLiteral(" <span class=\"sampleName\">Editing/Simple Replace</span>");
                EndContext();
            }
            );
            DefineSection("ControlsSection", async() => {
                BeginContext(187, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 6 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\SimpleReplace.cshtml"
      ViewBag.Title = "    Essential DocIO (Word) : Simple Replace : Syncfusion";

#line default
#line hidden
                BeginContext(273, 4, true);
                WriteLiteral("    ");
                EndContext();
#line 7 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\SimpleReplace.cshtml"
      Html.BeginForm("SimpleReplace", "DocIO", FormMethod.Post);
        {

#line default
#line hidden
                BeginContext(350, 4969, true);
                WriteLiteral(@"            <div class=""Common"">
                <div class=""tablediv"">
                    <div class=""rowdiv"">
                        This sample demonstrates how to replace a specific text in the Word document with another text using the Find and Replace functionality of Essential DocIO.
                    </div>
                    &nbsp;
                    <div class=""rowdiv"" style=""border-width: 0.5px;border-style:solid; border-color: lightgray; padding: 1px 5px 7px 5px"">
                        Click the button to view the generated Word document. Please note that Microsoft Word Viewer or Microsoft Word is required to view the resultant Word document.
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            Text to Find
                            <input type=""text"" id=""textBox1"" name=""FindText"" value=""Adventure"" />
                            &nbsp;
                            Text to Replace
                            <input type=""text"" id=""te");
                WriteLiteral(@"xtBox2"" name=""ReplaceText"" value=""Adventures"" />
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <input type=""checkbox"" name=""MatchCase"" value=""MatchCase"" id=""matchcase"" />
                            Match case
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <input type=""checkbox"" name=""MatchWholeWord"" value=""MatchWholeWord"" id=""matchwholeword"" />
                            Match whole word
                            &nbsp;&nbsp;&nbsp;&nbsp;
                            <input type=""checkbox"" name=""ReplaceFirst"" value=""ReplaceFirst"" id=""replacefirst"" />
                            Replace only the first occurrence
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 10px"">
                            <div class=""celldiv"">
                                Save As :
                                <input type=""radio"" id=""rdButtonDoc"" name=""Gro");
                WriteLiteral(@"up1"" value=""WordDoc"" style=""margin-left: 7px"" />
                                <label for=""rdButtonDoc"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Doc format"">DOC</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonDocx"" name=""Group1"" value=""WordDocx"" style=""margin-left: 7px"" checked=""checked"" />
                                <label for=""rdButtonDocx"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document as Word Docx format"">DOCX</label>
                                &nbsp;
                                <input type=""radio"" id=""rdButtonWordML"" name=""Group1"" value=""WordML"" style=""margin-left: 7px"" />
                                <label for=""rdButtonWordML"" style=""font-size:13px;font-weight:normal;text-align:match-parent"" data-toggle=""tooltip"" title=""Saves the resultant document a");
                WriteLiteral(@"s WordML format"">WordML</label>
                            </div>
                        </div>
                        <div class=""rowdiv"" style=""margin-top: 8px"">
                            <input id=""viewtemplate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""View Template"" style=""width: 150px; height: 27px"" />
                            &nbsp;
                            <input id=""generate"" name=""Button"" class=""buttonStyle"" type=""submit"" value=""Generate Document"" style=""width:150px;height:27px"" />
                        </div>
                    </div>
                    <br />
                    <div class=""rowdiv"">
                        DocIO allows you to replace a specific text in the Word document with another text.
                        <ul>
                            <li>
                                You can replace either the first occurrence or all the occurrences of the text with other elements such as text, part of the document or an entire document.
   ");
                WriteLiteral(@"                         </li>
                            <li>
                                You can replace the text by matching case, whole word and all occurrence or first occurrence alone.
                            </li>
                            <li>
                                You can also replace the content that spans across several paragraphs.
                            </li>
                        </ul>
                    </div>
                    <div class=""rowdiv"" style=""margin-top: 15px"">
                        More information about the Find and Replace functionality can be found in this
                        <a href=""https://help.syncfusion.com/file-formats/docio/working-with-find-and-replace"">documentation</a>
                        section.
                    </div>
                </div>
            </div>
");
                EndContext();
#line 75 "D:\Samples_18.2.0.44\ASPNETCORE\samplebrowser\Views\DocIO\SimpleReplace.cshtml"
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
#pragma checksum "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\DemoPrintFile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213d0bb4f9c6568bfbed50689771d55c3e2e4cf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.v5_0_WebClientPrint5_Sample_WCPAspNetCoreMvcCS_Views_DemoPrintFile_Index), @"mvc.1.0.view", @"/v5.0/WebClientPrint5-Sample/WCPAspNetCoreMvcCS/Views/DemoPrintFile/Index.cshtml")]
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
#nullable restore
#line 1 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\_ViewImports.cshtml"
using WCPAspNetCoreMvcCS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\_ViewImports.cshtml"
using WCPAspNetCoreMvcCS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213d0bb4f9c6568bfbed50689771d55c3e2e4cf8", @"/v5.0/WebClientPrint5-Sample/WCPAspNetCoreMvcCS/Views/DemoPrintFile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7217c38892838b1610ab600866e39b60f4b29808", @"/v5.0/WebClientPrint5-Sample/WCPAspNetCoreMvcCS/Views/_ViewImports.cshtml")]
    public class v5_0_WebClientPrint5_Sample_WCPAspNetCoreMvcCS_Views_DemoPrintFile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Samples", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-md btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\DemoPrintFile\Index.cshtml"
  
    ViewData["Title"] = "Printing Files";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf84889", async() => {
                WriteLiteral("<i class=\"fa fa-chevron-left\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"&nbsp;Print Known File Formats without displaying any Print dialog! <small>(if needed)</small></h3>
        <p>
            With <strong>WebClientPrint for ASP.NET</strong> solution you can <strong>print most common file formats</strong> <em>(PDF, TXT, DOC/X, XLS/X, JPG/JPEG, PNG, TIF/TIFF)</em> right to any installed printer at the client side.
        </p>

        <div class=""panel-group"" id=""accordion"" role=""tablist"" aria-multiselectable=""true"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"" role=""tab"" id=""headingOne"">
                    <h4 class=""panel-title"">
                        <a role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"" class=""btn btn-info btn-lg"">
                            Client System Requirements
                        </a>
                    </h4>
                </div>
                <div id=""collapseOne"" class=""panel-collapse collapse in"" r");
            WriteLiteral(@"ole=""tabpanel"" aria-labelledby=""headingOne"">
                    <div class=""panel-body"">
                        <table class=""table table-bordered"">
                            <thead>
                                <tr style=""background-color: #ececec; font-weight: bold; color: #666"">
                                    <td style=""width: 20%"">File Format</td>
                                    <td style=""width: 40%"">Windows Clients</td>
                                    <td style=""width: 40%"">Linux, Raspberry Pi &amp; Mac Clients</td>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>DOC, DOCX</td>
                                    <td><span class=""badge alert-warning""><i class=""glyphicon glyphicon-info-sign""></i></span>Microsoft Word is required</td>
                                    <td><span class=""badge alert-warning""><i class=""glyphicon glyphic");
            WriteLiteral(@"on-info-sign""></i></span>LibreOffice is required</td>
                                </tr>
                                <tr>
                                    <td>XLS, XLSX</td>
                                    <td><span class=""badge alert-warning""><i class=""glyphicon glyphicon-info-sign""></i></span>Microsoft Excel is required</td>
                                    <td><span class=""badge alert-warning""><i class=""glyphicon glyphicon-info-sign""></i></span>LibreOffice is required</td>
                                </tr>
                                <tr>
                                    <td>PDF</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                </tr>
                                <tr>
                ");
            WriteLiteral(@"                    <td>TXT</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                </tr>
                                <tr>
                                    <td>JPEG</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                </tr>
                                <tr>
                                    <td>PNG</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively su");
            WriteLiteral(@"pported!</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                </tr>
                                <tr>
                                    <td>BMP</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                    <td><span class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>Natively supported!</td>
                                </tr>
                                <tr>
                                    <td>Printer Support</td>
                                    <td><span class=""badge alert-warning""><i class=""glyphicon glyphicon-info-sign""></i></span>You can print files to local installed printers ONLY! Parallel, Serial and IP/Ethernet printers are NOT supported.</td>
                                    <td><span ");
            WriteLiteral(@"class=""badge alert-success""><i class=""glyphicon glyphicon-ok-sign""></i></span>You can print files to any installed printers through CUPS system.</td>
                                </tr>
                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
            <div class=""panel panel-default"">
                <div class=""panel-heading"" role=""tab"" id=""headingTwo"">
                    <h4 class=""panel-title"">
                        <a class=""collapsed btn btn-info btn-lg"" role=""button"" data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                            Test Printing Now!
                        </a>
                    </h4>
                </div>
                <div id=""collapseTwo"" class=""panel-collapse collapse"" role=""tabpanel"" aria-labelledby=""headingTwo"">
                    <div class=""panel-body"">
                        <p>
   ");
            WriteLiteral(@"                         The following are pre-selected files to test WebClientPrint File Printing feature.
                        </p>
                        <div class=""row"">
                            <div class=""col-md-4 col-md-offset-2"">
                                <hr />
                                <div class=""checkbox"">
                                    <label>
                                        <input type=""checkbox"" id=""useDefaultPrinter"" />
                                        <strong>Print to Default printer</strong> or...
                                    </label>
                                </div>
                                <div id=""loadPrinters"">
                                    Click to load and select one of the installed printers!
                                    <br />
                                    <a onclick=""javascript:jsWebClientPrint.getPrinters();"" class=""btn btn-success"">Load installed printers...</a>
                          ");
            WriteLiteral(@"          <br />
                                    <br />
                                </div>
                                <div id=""installedPrinters"" style=""visibility: hidden"">
                                    <label for=""installedPrinterName"">Select an installed Printer:</label>
                                    <select name=""installedPrinterName"" id=""installedPrinterName"" class=""form-control""></select>
                                </div>
                                <script type=""text/javascript"">
                                    //var wcppGetPrintersDelay_ms = 0;
                                    var wcppGetPrintersTimeout_ms = 60000; //60 sec
                                    var wcppGetPrintersTimeoutStep_ms = 500; //0.5 sec
                                    function wcpGetPrintersOnSuccess() {
                                        // Display client installed printers
                                        if (arguments[0].length > 0) {
                     ");
            WriteLiteral(@"                       var p = arguments[0].split(""|"");
                                            var options = '';
                                            for (var i = 0; i < p.length; i++) {
                                                options += '<option>' + p[i] + '</option>';
                                            }
                                            $('#installedPrinters').css('visibility', 'visible');
                                            $('#installedPrinterName').html(options);
                                            $('#installedPrinterName').focus();
                                            $('#loadPrinters').hide();
                                        } else {
                                            alert(""No printers are installed in your system."");
                                        }
                                    }
                                    function wcpGetPrintersOnFailure() {
                                        ");
            WriteLiteral(@"// Do something if printers cannot be got from the client
                                        alert(""No printers are installed in your system."");
                                    }
                                </script>
                            </div>
                            <div class=""col-md-4"">
                                <hr />
                                <div id=""fileToPrint"">
                                    <label for=""ddlFileType"">Select a sample File to print:</label>
                                    <select id=""ddlFileType"" class=""form-control"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf816703", async() => {
                WriteLiteral("PDF");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf817699", async() => {
                WriteLiteral("TXT");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf818695", async() => {
                WriteLiteral("DOC");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf819691", async() => {
                WriteLiteral("XLS");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf820687", async() => {
                WriteLiteral("JPG");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf821683", async() => {
                WriteLiteral("PNG");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213d0bb4f9c6568bfbed50689771d55c3e2e4cf822679", async() => {
                WriteLiteral("TIF");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                    <br />
                                    <a class=""btn btn-success btn-lg"" onclick=""javascript:jsWebClientPrint.print('useDefaultPrinter=' + $('#useDefaultPrinter').attr('checked') + '&printerName=' + encodeURIComponent($('#installedPrinterName').val()) + '&filetype=' + $('#ddlFileType').val());"">Print File...</a>
                                </div>
                            </div>
                        </div>
                        <h5>File Preview</h5>
                        <iframe id=""ifPreview"" style=""width: 100%; height: 500px;"" frameborder=""0""></iframe>

                    </div>
                </div>
            </div>

        </div>




    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 178 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\DemoPrintFile\Index.cshtml"
Write(Html.Raw(ViewData["WCPScript"]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";


    <script type=""text/javascript"">
        $(""#ddlFileType"").change(function () {
            var s = $(""#ddlFileType option:selected"").text();
            if (s == 'DOC') $(""#ifPreview"").attr(""src"", ""//docs.google.com/gview?url=http://webclientprint.azurewebsites.net/files/LoremIpsum.doc&embedded=true"");
            if (s == 'PDF') $(""#ifPreview"").attr(""src"", ""//docs.google.com/gview?url=http://webclientprint.azurewebsites.net/files/LoremIpsum.pdf&embedded=true"");
            if (s == 'TXT') $(""#ifPreview"").attr(""src"", ""//docs.google.com/gview?url=http://webclientprint.azurewebsites.net/files/LoremIpsum.txt&embedded=true"");
            if (s == 'TIF') $(""#ifPreview"").attr(""src"", ""//docs.google.com/gview?url=http://webclientprint.azurewebsites.net/files/patent2pages.tif&embedded=true"");
            if (s == 'XLS') $(""#ifPreview"").attr(""src"", ""//docs.google.com/gview?url=http://webclientprint.azurewebsites.net/files/SampleSheet.xls&embedded=true"");
            if (s == 'JPG') $(""#ifPreview"").at");
                WriteLiteral("tr(\"src\", \"//webclientprint.azurewebsites.net/files/penguins300dpi.jpg\");\r\n            if (s == \'PNG\') $(\"#ifPreview\").attr(\"src\", \"//webclientprint.azurewebsites.net/files/SamplePngImage.png\");\r\n        }).change();\r\n    </script>\r\n");
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

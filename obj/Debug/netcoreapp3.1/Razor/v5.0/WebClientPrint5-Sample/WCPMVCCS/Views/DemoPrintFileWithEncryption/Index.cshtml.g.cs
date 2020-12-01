#pragma checksum "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPMVCCS\Views\DemoPrintFileWithEncryption\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3173ffad5db621b198b31fb32628f4cdaae8e158"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.v5_0_WebClientPrint5_Sample_WCPMVCCS_Views_DemoPrintFileWithEncryption_Index), @"mvc.1.0.view", @"/v5.0/WebClientPrint5-Sample/WCPMVCCS/Views/DemoPrintFileWithEncryption/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3173ffad5db621b198b31fb32628f4cdaae8e158", @"/v5.0/WebClientPrint5-Sample/WCPMVCCS/Views/DemoPrintFileWithEncryption/Index.cshtml")]
    public class v5_0_WebClientPrint5_Sample_WCPMVCCS_Views_DemoPrintFileWithEncryption_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPMVCCS\Views\DemoPrintFileWithEncryption\Index.cshtml"
  
    ViewBag.Title = "Print Known File Formats with Encryption";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">

        <h3><a href=""/home/samples"" class=""btn btn-md btn-danger""><i class=""fa fa-chevron-left""></i></a>&nbsp;Print Encrypted Files without displaying any Print dialog! <small>(if needed)</small></h3>
        <p>
            With <strong>WebClientPrint for ASP.NET</strong> solution you can <strong>print encrypted files in PDF, TXT, JPG/JPEG &amp; PNG formats</strong> right to any installed printer at the client side.
        </p>

        <div class=""alert alert-info"">
            <strong>WebClientPrint uses RSA</strong> asymetric encryption with a <strong>dynamic public key generated by WCPP utility</strong> for each printing request to encrypt the <strong>AES-256</strong> params. The file to print is encrypted by using <strong>AES-256</strong> symetric encryption in the server side and stored at the client machine disk. At printing time, WCPP will decrypt the file to print in system memory.
        </div>

        <div class=""well"">
            <");
            WriteLiteral(@"p>
                The following are pre-selected files to test WebClientPrint File Printing with Encryption feature enabled.
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
                        <br />
                        <br />
                    </div>
                    <div id=""installedPrinters"" style=""visibility: hidden"">
      ");
            WriteLiteral(@"                  <label for=""installedPrinterName"">Select an installed Printer:</label>
                        <select name=""installedPrinterName"" id=""installedPrinterName"" class=""form-control""></select>
                    </div>
                    <script type=""text/javascript"">
                            //var wcppGetPrintersDelay_ms = 0;
                            var wcppGetPrintersTimeout_ms = 60000; //60 sec
                            var wcppGetPrintersTimeoutStep_ms = 500; //0.5 sec
                            function wcpGetPrintersOnSuccess() {
                                // Display client installed printers
                                if (arguments[0].length > 0) {
                                    var p = arguments[0].split(""|"");
                                    var options = '';
                                    for (var i = 0; i < p.length; i++) {
                                        options += '<option>' + p[i] + '</option>';
                              ");
            WriteLiteral(@"      }
                                    $('#installedPrinters').css('visibility', 'visible');
                                    $('#installedPrinterName').html(options);
                                    $('#installedPrinterName').focus();
                                    $('#loadPrinters').hide();
                                } else {
                                    alert(""No printers are installed in your system."");
                                }
                            }
                            function wcpGetPrintersOnFailure() {
                                // Do something if printers cannot be got from the client
                                alert(""No printers are installed in your system."");
                            }
                    </script>
                </div>
                <div class=""col-md-4"">
                    <hr />
                    <div id=""fileToPrint"">
                        <label for=""ddlFileType"">Select a sample File t");
            WriteLiteral(@"o print:</label>
                        <select id=""ddlFileType"" class=""form-control"">
                            <option>PDF</option>
                            <option>TXT</option>
                            <option>JPG</option>
                            <option>PNG</option>
                        </select>
                        <br />
                        <a class=""btn btn-success btn-lg"" onclick=""javascript:jsWebClientPrint.print('encrypt=true' + '&useDefaultPrinter=' + $('#useDefaultPrinter').attr('checked') + '&printerName=' + encodeURIComponent($('#installedPrinterName').val()) + '&filetype=' + $('#ddlFileType').val());"">Print File...</a>
                    </div>
                </div>
            </div>

        </div>


    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    \r\n");
                WriteLiteral("\r\n");
#nullable restore
#line 93 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPMVCCS\Views\DemoPrintFileWithEncryption\Index.cshtml"
Write(Html.Raw(ViewBag.WCPScript));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n    ");
            }
            );
            WriteLiteral("\r\n");
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

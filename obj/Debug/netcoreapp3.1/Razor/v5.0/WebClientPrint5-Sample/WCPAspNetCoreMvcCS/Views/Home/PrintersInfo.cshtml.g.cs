#pragma checksum "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\Home\PrintersInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ffd40fa0733877174a765e92cd5649d0c61bad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.v5_0_WebClientPrint5_Sample_WCPAspNetCoreMvcCS_Views_Home_PrintersInfo), @"mvc.1.0.view", @"/v5.0/WebClientPrint5-Sample/WCPAspNetCoreMvcCS/Views/Home/PrintersInfo.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ffd40fa0733877174a765e92cd5649d0c61bad", @"/v5.0/WebClientPrint5-Sample/WCPAspNetCoreMvcCS/Views/Home/PrintersInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7217c38892838b1610ab600866e39b60f4b29808", @"/v5.0/WebClientPrint5-Sample/WCPAspNetCoreMvcCS/Views/_ViewImports.cshtml")]
    public class v5_0_WebClientPrint5_Sample_WCPAspNetCoreMvcCS_Views_Home_PrintersInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\Home\PrintersInfo.cshtml"
  
    ViewData["Title"] = "PrintersInfo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n\r\n    <style type=\"text/css\">\r\n        .glyphicon-refresh-animate {\r\n            -animation: spin .7s infinite linear;\r\n            -webkit-animation: spin2 .7s infinite linear;\r\n        }\r\n\r\n        ");
                WriteLiteral("@-webkit-keyframes spin2 {\r\n            from {\r\n                -webkit-transform: rotate(0deg);\r\n            }\r\n\r\n            to {\r\n                -webkit-transform: rotate(360deg);\r\n            }\r\n        }\r\n\r\n        ");
                WriteLiteral("@keyframes spin {\r\n            from {\r\n                transform: scale(1) rotate(0deg);\r\n            }\r\n\r\n            to {\r\n                transform: scale(1) rotate(360deg);\r\n            }\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58ffd40fa0733877174a765e92cd5649d0c61bad5634", async() => {
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
            WriteLiteral(@"&nbsp;Getting Printers Info</h2>

<p>The following section shows you how to get useful info from the client printers. Please click in the button <strong>Get Printers Info</strong> below.</p>

<hr />

<div class=""container"">
    <div class=""row"">

        <div class=""col-md-3"">
            <a onclick=""javascript:jsWebClientPrint.getPrintersInfo(); $('#spinner').css('visibility', 'visible');"" class=""btn btn-success"">Get Printers Info...</a>
        </div>
        <div class=""col-md-9"">
            <h3 id=""spinner"" style=""visibility: hidden""><span class=""label label-info""><span class=""glyphicon glyphicon-refresh glyphicon-refresh-animate""></span>Please wait a few seconds...</span></h3>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-md-3"">

                        <label for=""lstPrinters"">Printers:</label>
                        <select name=""lstPr");
            WriteLiteral(@"inters"" id=""lstPrinters"" onchange=""showSelectedPrinterInfo();"" class=""form-control form-control-sm""></select>

                    </div>
                    <div class=""col-md-3"">
                        <label>It seems to be a...</label>
                        <div>
                            <h2 id=""deviceType""></h2>
                        </div>
                    </div>
                    <div class=""col-md-3"">

                        <label for=""lstPrinterTrays"">Supported Trays:</label>
                        <select name=""lstPrinterTrays"" id=""lstPrinterTrays"" class=""form-control form-control-sm""></select>


                    </div>
                    <div class=""col-md-3"">

                        <label for=""lstPrinterPapers"">Supported Papers:</label>
                        <select name=""lstPrinterPapers"" id=""lstPrinterPapers"" class=""form-control form-control-sm""></select>

                    </div>
                </div>
                <div class=""row"">
          ");
            WriteLiteral(@"          <div class=""col-md-12"">
                        <br />
                        <br />
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <td><strong>Port Name:</strong></td>
                                    <td>
                                        <span id=""txtPortName"" />
                                    </td>
                                    <td><strong>Horizontal Resolution (dpi):</strong></td>
                                    <td>
                                        <span id=""txtHRes"" />
                                    </td>
                                    <td><strong>Vertical Resolution (dpi):</strong></td>
                                    <td>
                                        <span id=""txtVRes"" />
                                    </td>
                                </tr>
                                <tr>
                      ");
            WriteLiteral(@"              <td colspan=""2"">
                                        <h4><span id=""isConnected"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Is Connected?</h4>

                                    </td>
                                    <td colspan=""2"">
                                        <h4><span id=""isDefault"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Is Default?</h4>
                                    </td>
                                    <td colspan=""2"">
                                        <h4><span id=""isBIDIEnabled"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Is BIDI Enabled?</h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""2"">
                                        <h4><span id=""isLocal"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Is Local?</h4>
         ");
            WriteLiteral(@"                           </td>
                                    <td colspan=""2"">
                                        <h4><span id=""isNetwork"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Is Network?</h4>
                                    </td>
                                    <td colspan=""2"">
                                        <h4><span id=""isShared"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Is Shared?</h4>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan=""2"">
                                        <h4><span id=""duplex"" class=""label label-default glyphicon glyphicon-minus"">&nbsp;</span> Duplex Support?</h4>
                                    </td>
                                    <td colspan=""2"">
                                    </td>
                                    <td colspan=""2"">
                   ");
            WriteLiteral(@"                 </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

</div>


<script type=""text/javascript"">

    var clientPrinters = null;

    var wcppGetPrintersTimeout_ms = 60000; //60 sec
    var wcppGetPrintersTimeoutStep_ms = 500; //0.5 sec
    function wcpGetPrintersOnSuccess() {
        $('#spinner').css('visibility', 'hidden');
        // Display client installed printers
        if (arguments[0].length > 0) {
            if (JSON) {
                try {
                    clientPrinters = JSON.parse(arguments[0]);
                    if (clientPrinters.error) {
                        alert(clientPrinters.error)
                    } else {
                        var options = '';
                        for (var i = 0; i < clientPrinters.length; i++) {
                            options += '<option>' + cli");
            WriteLiteral(@"entPrinters[i].name + '</option>';
                        }
                        $('#lstPrinters').html(options);
                        $('#lstPrinters').focus();

                        showSelectedPrinterInfo();
                    }
                } catch (e) {
                    alert(e.message)
                }
            }


        } else {
            alert(""No printers are installed in your system."");
        }
    }
    function wcpGetPrintersOnFailure() {
        $('#spinner').css('visibility', 'hidden');
        // Do something if printers cannot be got from the client
        alert(""No printers are installed in your system."");
    }


    function showSelectedPrinterInfo() {
        // get selected printer index
        var idx = $(""#lstPrinters"")[0].selectedIndex;
        // get supported trays
        var options = '';
        if (clientPrinters[idx].trays) {
            for (var i = 0; i < clientPrinters[idx].trays.length; i++) {
                option");
            WriteLiteral(@"s += '<option>' + clientPrinters[idx].trays[i] + '</option>';
            }
        }
        $('#lstPrinterTrays').html(options);
        // get supported papers
        options = '';
        if (clientPrinters[idx].papers) {
            for (var i = 0; i < clientPrinters[idx].papers.length; i++) {
                options += '<option>' + clientPrinters[idx].papers[i] + '</option>';
            }
        }
        $('#lstPrinterPapers').html(options);
        // additional info...
        $('#txtPortName').text(clientPrinters[idx].portName);
        $('#txtHRes').text(clientPrinters[idx].hRes);
        $('#txtVRes').text(clientPrinters[idx].vRes);
        $('#isConnected').attr('class', (clientPrinters[idx].isConnected ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        $('#isDefault').attr('class', (clientPrinters[idx].isDefault ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        $('#is");
            WriteLiteral(@"BIDIEnabled').attr('class', (clientPrinters[idx].isBIDIEnabled ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        $('#isLocal').attr('class', (clientPrinters[idx].isLocal ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        $('#isNetwork').attr('class', (clientPrinters[idx].isNetwork ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        $('#isShared').attr('class', (clientPrinters[idx].isShared ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        $('#duplex').attr('class', (clientPrinters[idx].duplex ? 'label label-info glyphicon glyphicon-ok' : 'label label-danger glyphicon glyphicon-remove'));
        let isVirtual = isVirtualPrinter(clientPrinters[idx]);
        $('#deviceType').attr('class', (isVirtual ? 'label label-danger' : 'label label-primary'));
        $('#deviceType').text(isVirtual ? ");
            WriteLiteral(@"'VIRTUAL PRINTER' : 'REAL/PHYSICAL PRINTER');
    }

    //Guessing whether a printer is Virtual or real/physical
    function isVirtualPrinter(clientPrinter) {
        let printerPort = clientPrinter.portName.toLowerCase();
        //For Windows
        if (printerPort != ""nul"" && clientPrinter.isBIDIEnabled) return false;
        //For Unix
        if (printerPort.indexOf(""usb"") >= 0 && printerPort.indexOf(""?serial="") >= 0) return false;

        return true;
    }

</script>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n    ");
#nullable restore
#line 244 "D:\Demo\Demo Print\Report-Export-DinkToPdf\v5.0\WebClientPrint5-Sample\WCPAspNetCoreMvcCS\Views\Home\PrintersInfo.cshtml"
Write(Html.Raw(ViewData["WCPScript"]));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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

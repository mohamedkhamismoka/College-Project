#pragma checksum "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e80ae773ca146f838dd5bbb7a3e8236b9b7b0e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_GetPayment), @"mvc.1.0.view", @"/Views/Statistics/GetPayment.cshtml")]
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
#line 1 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\_ViewImports.cshtml"
using WebApplication13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\_ViewImports.cshtml"
using WebApplication13.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\_ViewImports.cshtml"
using WebApplication13.BL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\_ViewImports.cshtml"
using WebApplication13.BL.VM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\_ViewImports.cshtml"
using WebApplication13.BL.Reposatory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e80ae773ca146f838dd5bbb7a3e8236b9b7b0e5", @"/Views/Statistics/GetPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0d31c8b583839d0a0665f6dd5429ed0ef42863", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_GetPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<paymentVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/custom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            DefineSection("css", async() => {
                WriteLiteral(@"

<link href=""../assets/plugins/datatable/dataTables.bootstrap4.min.css"" rel=""stylesheet"" />


<!-- Slect2 css -->
<link href=""../assets/plugins/select2/select2.min.css"" rel=""stylesheet"" />

<!-- Skin css-->
<link id=""theme"" rel=""stylesheet"" type=""text/css"" media=""all"" href=""../assets/skins/hor-skin/leftmenu-icon-default.css"" />
<link rel=""stylesheet"" href=""../assets/skins/demo.css"" />
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e80ae773ca146f838dd5bbb7a3e8236b9b7b0e55514", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"card-body\" style=\"position:absolute;width:800px;left:50%;margin-left:-400px;margin-top:5px\">\r\n    <center>\r\n        <h2 class=\"text-danger font-weight-bold\">");
#nullable restore
#line 20 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml"
                                            Write(std.Getbyid(ViewBag.stdid).Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    </center>
    <div class=""table-responsive"" style=""margin-top:5px"">
        <table id=""example"" class=""table table-striped table-bordered w-100 "" style=""text-align:center;color:white"">

            <thead>
                <tr>
                    <th>Academic year</th>
                    <th>Term</th>
                  
               
                         <th>Payed money</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 35 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 38 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml"
                       Write(item.Academic_year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 39 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml"
                       Write(item.Term);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 40 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml"
                       Write(item.money);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       \r\n                       \r\n                       \r\n                    </tr>\r\n");
#nullable restore
#line 45 "C:\Users\EL-Masria\Documents\GitHub\College-Project\WebApplication13\WebApplication13\Views\Statistics\GetPayment.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("js", async() => {
                WriteLiteral(@"

<script src=""../assets/plugins/datatable/jquery.dataTables.min.js""></script>
<script src=""../assets/plugins/datatable/dataTables.bootstrap4.min.js""></script>
<script src=""../assets/js/datatables.js""></script>

<!-- Select2 js -->
<script src=""../assets/plugins/select2/select2.full.min.js""></script>

<!-- Custom js-->
<script src=""../assets/js/custom.js""></script>
");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e80ae773ca146f838dd5bbb7a3e8236b9b7b0e59932", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    ");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStudent std { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<paymentVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

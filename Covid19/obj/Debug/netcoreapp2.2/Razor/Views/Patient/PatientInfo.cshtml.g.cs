#pragma checksum "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79cc5346f456f83bf196d2e0c714f382a2e6f6d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientInfo), @"mvc.1.0.view", @"/Views/Patient/PatientInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/PatientInfo.cshtml", typeof(AspNetCore.Views_Patient_PatientInfo))]
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
#line 1 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\_ViewImports.cshtml"
using Covid19;

#line default
#line hidden
#line 2 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\_ViewImports.cshtml"
using Covid19.Models;

#line default
#line hidden
#line 3 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\_ViewImports.cshtml"
using Covid19.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79cc5346f456f83bf196d2e0c714f382a2e6f6d5", @"/Views/Patient/PatientInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacc22ddb3c590898d9f739f9aa84f9744e6437d", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Patient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 210, true);
            WriteLiteral("\r\n<div id=\"DivToPrint\" runat=\"server\">\r\n    <div>\r\n        <table class=\"table table-striped\">\r\n            <tbody>\r\n                <tr>\r\n                    <th scope=\"row\">JMBG</th>\r\n                    <td>");
            EndContext();
            BeginContext(227, 10, false);
#line 9 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.JMBG);

#line default
#line hidden
            EndContext();
            BeginContext(237, 122, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Ime</th>\r\n                    <td>");
            EndContext();
            BeginContext(360, 15, false);
#line 13 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(375, 126, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Prezime</th>\r\n                    <td>");
            EndContext();
            BeginContext(502, 14, false);
#line 17 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(516, 132, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Broj telefona</th>\r\n                    <td>");
            EndContext();
            BeginContext(649, 17, false);
#line 21 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(666, 131, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Email adresa</th>\r\n                    <td>");
            EndContext();
            BeginContext(798, 10, false);
#line 25 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(808, 126, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Vakcina</th>\r\n                    <td>");
            EndContext();
            BeginContext(935, 15, false);
#line 29 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.VaccineId);

#line default
#line hidden
            EndContext();
            BeginContext(950, 145, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n                <tr>\r\n                    <th scope=\"row\">Datum prvog vakcinisanja</th>\r\n                    <td>");
            EndContext();
            BeginContext(1096, 16, false);
#line 34 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.FirstDateV);

#line default
#line hidden
            EndContext();
            BeginContext(1112, 140, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Broj serije prve doze</th>\r\n                    <td>");
            EndContext();
            BeginContext(1253, 23, false);
#line 38 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.FirstSerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1276, 144, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Datum drugog vakcinisanja</th>\r\n                    <td>");
            EndContext();
            BeginContext(1421, 17, false);
#line 42 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.SecondDateV);

#line default
#line hidden
            EndContext();
            BeginContext(1438, 141, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <th scope=\"row\">Broj serije druge doze</th>\r\n                    <td>");
            EndContext();
            BeginContext(1580, 24, false);
#line 46 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\PatientInfo.cshtml"
                   Write(Model.SecondSerialNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1604, 103, true);
            WriteLiteral("</td>\r\n                </tr>\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1707, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79cc5346f456f83bf196d2e0c714f382a2e6f6d58635", async() => {
                BeginContext(1728, 5, true);
                WriteLiteral("Nazad");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1737, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8749d7bcf7d065db12d4f9a111bfc9a41d4c549"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_List), @"mvc.1.0.view", @"/Views/Patient/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Patient/List.cshtml", typeof(AspNetCore.Views_Patient_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8749d7bcf7d065db12d4f9a111bfc9a41d4c549", @"/Views/Patient/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bacc22ddb3c590898d9f739f9aa84f9744e6437d", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PatientListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
 foreach (var patient in Model.Patients)
{

#line default
#line hidden
            BeginContext(76, 72, true);
            WriteLiteral("<ul class=\"list-group\">\r\n    <li class=\"list-group-item active\">Patient ");
            EndContext();
            BeginContext(149, 17, false);
#line 6 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
                                          Write(patient.PatientId);

#line default
#line hidden
            EndContext();
            BeginContext(166, 39, true);
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(206, 17, false);
#line 7 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
                           Write(patient.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(223, 39, true);
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(263, 16, false);
#line 8 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
                           Write(patient.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(279, 39, true);
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(319, 30, false);
#line 9 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
                           Write(patient.PhoneNumber.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(349, 39, true);
            WriteLiteral("</li>\r\n    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(389, 12, false);
#line 10 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
                           Write(patient.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(401, 31, true);
            WriteLiteral("</li>\r\n</ul>\r\n<div>\r\n\r\n</div>\r\n");
            EndContext();
#line 15 "C:\Users\Amer\source\repos\Covid19\Covid19\Views\Patient\List.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PatientListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "079a59519f7f8b33adb9298412db0dc8af51fa43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index2.cshtml", typeof(AspNetCore.Views_Home_Index2))]
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
#line 1 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\_ViewImports.cshtml"
using Views_Section3;

#line default
#line hidden
#line 2 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\_ViewImports.cshtml"
using Views_Section3.Views.ViewComponents;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"079a59519f7f8b33adb9298412db0dc8af51fa43", @"/Views/Home/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbfef69c7c5489ee78eb6f8ad6cd6ae33cc8a9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Views_Section3.Models.Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(166, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(177, 93, true);
            WriteLiteral("\r\nHello. This text will be rendered in the body of the layout page<br/> <br/> <br/> <br/>\r\n\r\n");
            EndContext();
            BeginContext(271, 36, false);
#line 11 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index2.cshtml"
Write(Html.Partial("_EmployeeList", Model));

#line default
#line hidden
            EndContext();
            BeginContext(307, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Views_Section3.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f72c8ec4b3001da792869d7fffc2743a32f39212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index3), @"mvc.1.0.view", @"/Views/Home/Index3.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index3.cshtml", typeof(AspNetCore.Views_Home_Index3))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f72c8ec4b3001da792869d7fffc2743a32f39212", @"/Views/Home/Index3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffbfef69c7c5489ee78eb6f8ad6cd6ae33cc8a9d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Views_Section3.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(169, 443, true);
            WriteLiteral(@"
<form asp-controller=""Home"" asp-action=""Index3"">
    <table>
        <tr>
            <td><label asp-for=""Name"">Name</label></td>
            <td><input asp-for=""Name"" /></td>
        </tr>
        <tr>
            <td><label asp-for=""Age"">Age</label></td>
            <td><input asp-for =""Age"" /></td>
        </tr>
        <tr>
            <td colspan=""2"" type=""submit"" value=""Submit""></td>
        </tr>
    </table>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Views_Section3.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\bryan\OneDrive\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\WebApplication1\Views\Home\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a33dcac763561ee565cf89e35b6e25dd3755356f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee), @"mvc.1.0.view", @"/Views/Home/Employee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Employee.cshtml", typeof(AspNetCore.Views_Home_Employee))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33dcac763561ee565cf89e35b6e25dd3755356f", @"/Views/Home/Employee.cshtml")]
    public class Views_Home_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(140, 381, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e492df44fd6b4604af38a83f70e21718", async() => {
                BeginContext(146, 21, true);
                WriteLiteral("\r\n    Employee Name: ");
                EndContext();
                BeginContext(168, 10, false);
#line 9 "C:\Users\bryan\OneDrive\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\WebApplication1\Views\Home\Employee.cshtml"
              Write(Model.Name);

#line default
#line hidden
                EndContext();
                BeginContext(178, 35, true);
                WriteLiteral(" <br />\r\n    Employee Designation: ");
                EndContext();
                BeginContext(214, 17, false);
#line 10 "C:\Users\bryan\OneDrive\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\WebApplication1\Views\Home\Employee.cshtml"
                     Write(Model.Designation);

#line default
#line hidden
                EndContext();
                BeginContext(231, 19, true);
                WriteLiteral(" <br />\r\n    <!--\r\n");
                EndContext();
                BeginContext(294, 9, true);
                WriteLiteral("    -->\r\n");
                EndContext();
                BeginContext(410, 22, true);
                WriteLiteral("    Employee Company: ");
                EndContext();
                BeginContext(433, 19, false);
#line 16 "C:\Users\bryan\OneDrive\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\WebApplication1\Views\Home\Employee.cshtml"
                 Write(ViewData["Company"]);

#line default
#line hidden
                EndContext();
                BeginContext(452, 30, true);
                WriteLiteral(" <br/>\r\n    Company Location: ");
                EndContext();
                BeginContext(483, 23, false);
#line 17 "C:\Users\bryan\OneDrive\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\WebApplication1\Views\Home\Employee.cshtml"
                 Write(ViewBag.CompanyLocation);

#line default
#line hidden
                EndContext();
                BeginContext(506, 8, true);
                WriteLiteral(" <br/>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

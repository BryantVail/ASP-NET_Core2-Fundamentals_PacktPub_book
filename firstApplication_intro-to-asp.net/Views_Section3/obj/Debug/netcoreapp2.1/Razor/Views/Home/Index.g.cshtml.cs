#pragma checksum "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f92af3b7d789d6d2aa6cae0c01370d874eccf38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f92af3b7d789d6d2aa6cae0c01370d874eccf38", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 14, true);
            WriteLiteral("\r\n<html>\r\n    ");
            EndContext();
            BeginContext(144, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fecf7af381e4ce5a9aa1ec15ee386eb", async() => {
                BeginContext(150, 41, true);
                WriteLiteral("\r\n        <title>Views Demo</title>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(198, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(204, 2922, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f5fd5fcc0e54e17b4c19ff2ea05fd6c", async() => {
                BeginContext(210, 157, true);
                WriteLiteral("\r\n\r\n        <h1>\r\n            Loop through an Element 5 times and increment each time:\r\n        </h1>\r\n        \r\n        <h2>For Loop:</h2>\r\n\r\n        <ul>\r\n");
                EndContext();
                BeginContext(453, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 26 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
              
                //loop through an element 5 times & increment each time
                for (int i = 0; i < 5; i++)
                {

#line default
#line hidden
                BeginContext(610, 24, true);
                WriteLiteral("                    <li>");
                EndContext();
                BeginContext(636, 5, false);
#line 30 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                    Write(i + 1);

#line default
#line hidden
                EndContext();
                BeginContext(642, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 31 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                }
            

#line default
#line hidden
                BeginContext(683, 88, true);
                WriteLiteral("\r\n\r\n        </ul>\r\n\r\n        <h2>\r\n            While Loop\r\n        </h2>\r\n        <ul>\r\n");
                EndContext();
#line 41 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
               
                int m = 0;
                while (m < 5)
                {

#line default
#line hidden
                BeginContext(866, 24, true);
                WriteLiteral("                    <li>");
                EndContext();
                BeginContext(892, 5, false);
#line 45 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                    Write(m + 1);

#line default
#line hidden
                EndContext();
                BeginContext(898, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 46 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                    m++;
                }
            

#line default
#line hidden
                BeginContext(965, 88, true);
                WriteLiteral("        </ul>\r\n\r\n        <h2>\r\n            ForEach Loop\r\n        </h2>\r\n\r\n        <ul>\r\n");
                EndContext();
#line 56 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
              

                List<int> integers = new List<int>();
                for (int k = 0; k < 7; k++)
                {
                    integers.Add(k);
                }
                //{
                //    1,2,3,4,5
                //};
                foreach (int j in integers)
                {

#line default
#line hidden
                BeginContext(1387, 50, true);
                WriteLiteral("                    <li>\r\n                        ");
                EndContext();
                BeginContext(1438, 1, false);
#line 69 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                   Write(j);

#line default
#line hidden
                EndContext();
                BeginContext(1439, 29, true);
                WriteLiteral("\r\n                    </li>\r\n");
                EndContext();
#line 71 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                }

            

#line default
#line hidden
                BeginContext(1504, 91, true);
                WriteLiteral("\r\n        </ul>\r\n\r\n        <h2>\r\n            If statement for Greater-Than &amp; Less-Than ");
                EndContext();
#line 78 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                                                             int num = 5;

#line default
#line hidden
                BeginContext(1611, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1613, 3, false);
#line 78 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                                                                      Write(num);

#line default
#line hidden
                EndContext();
                BeginContext(1616, 35, true);
                WriteLiteral("  \r\n        </h2>\r\n\r\n        <ul>\r\n");
                EndContext();
#line 82 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
               
                for(int l = 0; l<num*2; l++)
                {
                    if(l > num)
                    {

#line default
#line hidden
                BeginContext(1789, 89, true);
                WriteLiteral("                        <li>\r\n                            <text>iterator is Greater-Than ");
                EndContext();
                BeginContext(1879, 3, false);
#line 88 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                                                      Write(num);

#line default
#line hidden
                EndContext();
                BeginContext(1882, 40, true);
                WriteLiteral("</text>\r\n                        </li>\r\n");
                EndContext();
#line 90 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
                BeginContext(1994, 86, true);
                WriteLiteral("                        <li>\r\n                            <text>iterator is Less-Than ");
                EndContext();
                BeginContext(2081, 3, false);
#line 94 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                                                   Write(num);

#line default
#line hidden
                EndContext();
                BeginContext(2084, 40, true);
                WriteLiteral("</text>\r\n                        </li>\r\n");
                EndContext();
#line 96 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                        
                    }
                }
            

#line default
#line hidden
                BeginContext(2207, 51, true);
                WriteLiteral("        </ul>\r\n\r\n        <h1>IsPrime Example</h1>\r\n");
                EndContext();
                BeginContext(2849, 14, true);
                WriteLiteral("        <ul>\r\n");
                EndContext();
#line 124 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
               
                for(var o = 1; o< 100; o++)
                {
                    if (IsPrime(o))
                    {

#line default
#line hidden
                BeginContext(3004, 28, true);
                WriteLiteral("                        <li>");
                EndContext();
                BeginContext(3033, 1, false);
#line 129 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                       Write(o);

#line default
#line hidden
                EndContext();
                BeginContext(3034, 7, true);
                WriteLiteral("</li>\r\n");
                EndContext();
#line 130 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
                    }
                }
            

#line default
#line hidden
                BeginContext(3098, 21, true);
                WriteLiteral("        </ul>\r\n\r\n    ");
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
            BeginContext(3126, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
#line 104 "C:\Users\bvail\Documents\GitHub\ASP-NET_Core2-Fundamentals_PacktPub_book\firstApplication_intro-to-asp.net\Views_Section3\Views\Home\Index.cshtml"
         
            public bool IsPrime(int n)
            {
                if (n <= 1) return false;
                if (n <= 3) return true;
                if(n % 2 == 0 || n%3 == 0)
                {
                    return false;
                }
                for(var i = 5; i * i <= n; i = i + 6)
                {
                    if(n % i == 0 || n % (i + 2) == 0)
                    {
                        return false;
                    }
                }
                return true;
            }//end IsPrime
        

#line default
#line hidden
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

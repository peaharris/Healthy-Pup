#pragma checksum "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ffc65aef87687430d0f14dbb74ec2649bb1cc2c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walk_Index), @"mvc.1.0.view", @"/Views/Walk/Index.cshtml")]
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
#line 1 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\_ViewImports.cshtml"
using HealthyPUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\_ViewImports.cshtml"
using HealthyPUP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ffc65aef87687430d0f14dbb74ec2649bb1cc2c", @"/Views/Walk/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f3913e6e22ab51ea7dce39c565aac399e5c26b", @"/Views/_ViewImports.cshtml")]
    public class Views_Walk_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Walk>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffc65aef87687430d0f14dbb74ec2649bb1cc2c3249", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title> Walk </title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ffc65aef87687430d0f14dbb74ec2649bb1cc2c4313", async() => {
                WriteLiteral("\r\n    <hr />\r\n    <table>\r\n        <tr>\r\n            <th> Id </th>\r\n            <th> Date </th>\r\n            <th> Distance </th>\r\n            <th> Duration </th>\r\n            <th> Location </th>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
         foreach (Walk w in Model)
        {
            if (w != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td> ");
#nullable restore
#line 27 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
                    Write(w.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 28 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
                    Write(w.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 29 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
                    Write(w.Distance);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 30 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
                    Write(w.Duration);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td> ");
#nullable restore
#line 31 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
                    Write(w.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\wwstudent\Documents\Healthy-PUP\HealthyPUP\Views\Walk\Index.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Walk>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\DayX.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1edcb93c980df79f077a282a4b511aa07439f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Days_DayX), @"mvc.1.0.view", @"/Views/Days/DayX.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Days/DayX.cshtml", typeof(AspNetCore.Views_Days_DayX))]
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
#line 1 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\_ViewImports.cshtml"
using AoC18;

#line default
#line hidden
#line 2 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\_ViewImports.cshtml"
using AoC18.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1edcb93c980df79f077a282a4b511aa07439f9", @"/Views/Days/DayX.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34203670868e967905f65771cdedff8698e047bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Days_DayX : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AoC18.Models.DayModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(46, 10, true);
            WriteLiteral("\r\n<h2>Day ");
            EndContext();
            BeginContext(57, 15, false);
#line 7 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\DayX.cshtml"
   Write(Model.DayNumber);

#line default
#line hidden
            EndContext();
            BeginContext(72, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(76, 11, false);
#line 7 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\DayX.cshtml"
                      Write(Model.title);

#line default
#line hidden
            EndContext();
            BeginContext(87, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(94, 459, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a6f3133ea31474b977ae801aaf89565", async() => {
                BeginContext(114, 182, true);
                WriteLiteral("\r\n    <div class=\"dayDisplayContainer\" style=\"width:100%;\">\r\n\r\n\r\n\r\n        <div class=\"dayDisplay\" id=\"problem\" >\r\n            <textarea name=\"problem\" rows=\"14\" style=\"width:100%;\">");
                EndContext();
                BeginContext(297, 30, false);
#line 14 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\DayX.cshtml"
                                                              Write(ViewData["problem"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(327, 139, true);
                WriteLiteral("</textarea>\r\n\r\n        </div>\r\n        <div class=\"dayDisplay\" id=\"solution\" >\r\n            <input type=\"submit\" style=\"height:20px;\" /><p>");
                EndContext();
                BeginContext(467, 41, false);
#line 18 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\DayX.cshtml"
                                                      Write(Html.Raw(ViewData["solution"].ToString()));

#line default
#line hidden
                EndContext();
                BeginContext(508, 38, true);
                WriteLiteral("</p>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(553, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AoC18.Models.DayModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

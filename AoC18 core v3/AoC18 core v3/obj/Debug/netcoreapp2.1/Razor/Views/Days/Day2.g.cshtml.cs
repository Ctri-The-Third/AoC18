#pragma checksum "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Day2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "951ffe4302ea278f8ee24f9a726fb4ee2028f7c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Days_Day2), @"mvc.1.0.view", @"/Views/Days/Day2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Days/Day2.cshtml", typeof(AspNetCore.Views_Days_Day2))]
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
using AoC18_core_v3;

#line default
#line hidden
#line 2 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\_ViewImports.cshtml"
using AoC18_core_v3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"951ffe4302ea278f8ee24f9a726fb4ee2028f7c3", @"/Views/Days/Day2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a09d0fa47588c1ce0e470913e3e9f0ad0ee81ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Days_Day2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Day2.cshtml"
  
    ViewData["Title"] = "Day2";


#line default
#line hidden
            BeginContext(44, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(51, 17, false);
#line 7 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Day2.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(68, 38, true);
            WriteLiteral("</h2>\r\n<div style=\"width:100%;\">\r\n    ");
            EndContext();
            BeginContext(106, 611, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "433c8c1a36774ca39ec13d47a2e96ff4", async() => {
                BeginContext(126, 171, true);
                WriteLiteral("\r\n        \r\n        \r\n        <div style=\"width:50%; top:20px;border:2px solid black; float:left;\" id=\"problem\">\r\n            <textarea name=\"problem\" rows=\"20\" cols=\"50\">");
                EndContext();
                BeginContext(298, 30, false);
#line 13 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Day2.cshtml"
                                                    Write(ViewData["problem"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(328, 222, true);
                WriteLiteral("</textarea>\r\n\r\n        </div>\r\n        <div style=\" width:50%;top:20px;border:2px solid black; float:left;\" id=\"solution\">\r\n            <input type=\"submit\" style=\"height:20px;\" /> </br/>\r\n            Checksum of boxes = [");
                EndContext();
                BeginContext(551, 31, false);
#line 18 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Day2.cshtml"
                            Write(ViewData["Checksum"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(582, 64, true);
                WriteLiteral("]<br />\r\n            non-unique characters in paired box IDs = [");
                EndContext();
                BeginContext(647, 36, false);
#line 19 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Day2.cshtml"
                                                  Write(ViewData["matchingChars"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(683, 27, true);
                WriteLiteral("]\r\n\r\n\r\n        </div>\r\n    ");
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
            BeginContext(717, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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

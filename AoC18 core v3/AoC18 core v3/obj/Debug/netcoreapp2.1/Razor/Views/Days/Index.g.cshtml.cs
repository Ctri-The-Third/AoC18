#pragma checksum "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f39aa7ef4adf45689dc46ca022c98cc2aa453415"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Days_Index), @"mvc.1.0.view", @"/Views/Days/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Days/Index.cshtml", typeof(AspNetCore.Views_Days_Index))]
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
#line 1 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\_ViewImports.cshtml"
using AoC18;

#line default
#line hidden
#line 2 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\_ViewImports.cshtml"
using AoC18.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f39aa7ef4adf45689dc46ca022c98cc2aa453415", @"/Views/Days/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34203670868e967905f65771cdedff8698e047bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Days_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AoC18.Models.AllDaysModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Days", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("day-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"

    ViewData["Title"] = "Days Page";




#line default
#line hidden
            BeginContext(94, 37, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"daysContainer\">\r\n\r\n");
            EndContext();
#line 15 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
     foreach (DayModel day in Model.allDays)
    {

#line default
#line hidden
            BeginContext(184, 43, true);
            WriteLiteral("        <div class=\"day-box\">\r\n            ");
            EndContext();
            BeginContext(227, 271, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4208b583f5d4f66a74b13afd0e67104", async() => {
                BeginContext(306, 26, true);
                WriteLiteral("\r\n                <h2>Day ");
                EndContext();
                BeginContext(333, 13, false);
#line 19 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
                   Write(day.DayNumber);

#line default
#line hidden
                EndContext();
                BeginContext(346, 7, true);
                WriteLiteral(" - <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 353, "\"", 377, 1);
#line 19 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
WriteAttributeValue("", 359, day.firstStarPath, 359, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(378, 22, true);
                WriteLiteral("class=\"starimg\" /><img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 400, "\"", 425, 1);
#line 19 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
WriteAttributeValue("", 406, day.secondStarPath, 406, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(426, 44, true);
                WriteLiteral(" class=\"starimg\" /></h2>\r\n\r\n                ");
                EndContext();
                BeginContext(471, 9, false);
#line 21 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
           Write(day.title);

#line default
#line hidden
                EndContext();
                BeginContext(480, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
#line 18 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
                                                 WriteLiteral(day.action);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(498, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\Index.cshtml"
     }

#line default
#line hidden
            BeginContext(524, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AoC18.Models.AllDaysModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

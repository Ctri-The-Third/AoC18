#pragma checksum "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81fa0dbc848468be219843f5f1f6c08732c8b5db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Days_View), @"mvc.1.0.view", @"/Views/Days/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Days/View.cshtml", typeof(AspNetCore.Views_Days_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81fa0dbc848468be219843f5f1f6c08732c8b5db", @"/Views/Days/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34203670868e967905f65771cdedff8698e047bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Days_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AoC18.Models.Day1Model>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(55, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7aa35a7b078240058ae88efe5ca07097", async() => {
                BeginContext(78, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(92, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(185, 47, false);
#line 10 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.DisplayNameFor(model => model.problemText));

#line default
#line hidden
            EndContext();
            BeginContext(232, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(288, 53, false);
#line 13 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.DisplayNameFor(model => model.SolutionFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(341, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(459, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(508, 46, false);
#line 22 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.problemText));

#line default
#line hidden
            EndContext();
            BeginContext(554, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(610, 52, false);
#line 25 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.DisplayFor(modelItem => item.SolutionFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(662, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(718, 65, false);
#line 28 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(783, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(804, 71, false);
#line 29 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(875, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(896, 69, false);
#line 30 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(965, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\petergoudie\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\View.cshtml"
}

#line default
#line hidden
            BeginContext(1004, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AoC18.Models.Day1Model>> Html { get; private set; }
    }
}
#pragma warning restore 1591

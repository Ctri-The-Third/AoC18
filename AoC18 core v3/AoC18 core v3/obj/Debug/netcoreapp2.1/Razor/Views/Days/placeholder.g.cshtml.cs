#pragma checksum "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\placeholder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77142d49281b6da9e3464cd262b8822f1078f17c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Days_placeholder), @"mvc.1.0.view", @"/Views/Days/placeholder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Days/placeholder.cshtml", typeof(AspNetCore.Views_Days_placeholder))]
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
using AoC18_core_v3;

#line default
#line hidden
#line 2 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\_ViewImports.cshtml"
using AoC18_core_v3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77142d49281b6da9e3464cd262b8822f1078f17c", @"/Views/Days/placeholder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a09d0fa47588c1ce0e470913e3e9f0ad0ee81ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Days_placeholder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AoC18_core_v3.Models.DayModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(58, 10, true);
            WriteLiteral("\r\n<h2>Day ");
            EndContext();
            BeginContext(69, 15, false);
#line 7 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\placeholder.cshtml"
   Write(Model.DayNumber);

#line default
#line hidden
            EndContext();
            BeginContext(84, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(88, 11, false);
#line 7 "C:\Users\C'tri\Documents\GitHub\AoC18\AoC18 core v3\AoC18 core v3\Views\Days\placeholder.cshtml"
                      Write(Model.title);

#line default
#line hidden
            EndContext();
            BeginContext(99, 176, true);
            WriteLiteral("</h2>\r\n<div style=\"width:100%;\">\r\n\r\n    <p>\r\n        This problem hasn\'t been started yet.\r\n        Enjoy this delightful placeholder instead.\r\n    </p>        \r\n\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AoC18_core_v3.Models.DayModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

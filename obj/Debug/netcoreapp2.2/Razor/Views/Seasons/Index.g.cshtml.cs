#pragma checksum "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Seasons/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274ab1ee9660acc4eaca970522076e209b2fb98f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seasons_Index), @"mvc.1.0.view", @"/Views/Seasons/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Seasons/Index.cshtml", typeof(AspNetCore.Views_Seasons_Index))]
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
#line 1 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/_ViewImports.cshtml"
using Survivor;

#line default
#line hidden
#line 1 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Seasons/Index.cshtml"
using Survivor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274ab1ee9660acc4eaca970522076e209b2fb98f", @"/Views/Seasons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f21a881865e1afaa1c90549dd376dc54e7bbad1", @"/Views/_ViewImports.cshtml")]
    public class Views_Seasons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 26, true);
            WriteLiteral("\n<h1>Survivors!</h1>\n<ul>\n");
            EndContext();
#line 5 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Seasons/Index.cshtml"
 foreach (Season season in Model)
{
    

#line default
#line hidden
            BeginContext(90, 14, true);
            WriteLiteral("    <li>Name: ");
            EndContext();
            BeginContext(105, 17, false);
#line 8 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Seasons/Index.cshtml"
         Write(season.SeasonName);

#line default
#line hidden
            EndContext();
            BeginContext(122, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Survivor.Solution/Survivor/Views/Seasons/Index.cshtml"
   
}

#line default
#line hidden
            BeginContext(134, 5, true);
            WriteLiteral("</ul>");
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

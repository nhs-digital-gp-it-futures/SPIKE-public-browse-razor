#pragma checksum "/Users/charlotte.wainwright/Documents/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "959fdbc24371c863c4af34cf47b2b95b6a6982fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicBrowse.Pages.Pages_Solution), @"mvc.1.0.razor-page", @"/Pages/Solution.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Solution.cshtml", typeof(PublicBrowse.Pages.Pages_Solution), @"{SolutionID}")]
namespace PublicBrowse.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/charlotte.wainwright/Documents/SPIKE-public-browse-razor/PublicBrowse/Pages/_ViewImports.cshtml"
using PublicBrowse;

#line default
#line hidden
#line 2 "/Users/charlotte.wainwright/Documents/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{SolutionID}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"959fdbc24371c863c4af34cf47b2b95b6a6982fb", @"/Pages/Solution.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bdbf883d1501015e1ae6e7ab13a124a87654f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Solution : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 76, true);
            WriteLiteral("<div id=\"marketing-page\">\r\n    <img src=\"/images/MarketingPage.png\">\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SolutionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SolutionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SolutionModel>)PageContext?.ViewData;
        public SolutionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

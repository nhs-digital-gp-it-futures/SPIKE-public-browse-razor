#pragma checksum "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a339b08897d3068ceeb5cea860ca5d63cda4f964"
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
#line 1 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/_ViewImports.cshtml"
using PublicBrowse;

#line default
#line hidden
#line 2 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{SolutionID}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a339b08897d3068ceeb5cea860ca5d63cda4f964", @"/Pages/Solution.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bdbf883d1501015e1ae6e7ab13a124a87654f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Solution : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 610, true);
            WriteLiteral(@"<div id=""marketing-page"">
    <div class=""return-container"">
        <a href=""/Results"">< Return to Results</a>
    </div>
    <div>
        <h1>Marketing Page</h1>
    </div>

    <div class=""panel-container"">
        <div class=""left-panel"">
            <div class=""headings"">
                <h2>Page Contents</h2>
                <ul>
                    <li><a href=""#summary"">Summary</a></li>
                    <li><a href=""#""></a></li>
                </ul>
            </div>
        </div>
        <div class=""right-panel"">
            <section id=""summary"">
                <h2>");
            EndContext();
            BeginContext(746, 57, false);
#line 27 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
               Write(Html.DisplayFor(modelItem => Model.SelectedSolution.Name));

#line default
#line hidden
            EndContext();
            BeginContext(803, 26, true);
            WriteLiteral("</h2>\r\n                <p>");
            EndContext();
            BeginContext(830, 64, false);
#line 28 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
              Write(Html.DisplayFor(modelItem => Model.SelectedSolution.Description));

#line default
#line hidden
            EndContext();
            BeginContext(894, 124, true);
            WriteLiteral("</p>\r\n            </section>\r\n            <section id=\"features\">\r\n                <h2>Features</h2>\r\n                <ul>\r\n");
            EndContext();
#line 33 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                     foreach (var feature in Model.SelectedSolution.Features) {

#line default
#line hidden
            BeginContext(1099, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(1158, 37, false);
#line 35 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                       Write(Html.DisplayFor(modelItem => feature));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 37 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                    }

#line default
#line hidden
            BeginContext(1251, 81, true);
            WriteLiteral("                </ul>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>");
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

#pragma checksum "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b09c1f3fee3a09ca21d1e2c47a4fa6a38e6a1a7a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b09c1f3fee3a09ca21d1e2c47a4fa6a38e6a1a7a", @"/Pages/Solution.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bdbf883d1501015e1ae6e7ab13a124a87654f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Solution : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(135, 932, true);
            WriteLiteral(@"<div id=""marketing-page"">
    <div class=""return-container"">
        <a href=""/Results"">< Return to Results</a>
    </div>
    <div class=""page-title"">
        <h1>Marketing Page</h1>
    </div>

    <div class=""panel-container"">
        <div class=""left-panel"">
            <div class=""headings"">
                <h2>Page Contents</h2>
                <ul>
                    <li><a href=""#summary"">Summary</a></li>
                    <li><a href=""#features"">Features</a></li>
                    <li><a href=""#commercial-arrangements"">Commercial Arrangements</a></li>
                    <li><a href=""#pricing"">Pricing</a></li>
                    <li><a href=""#associated-services"">Associated Services</a></li>
                    <li><a href=""#additional-services"">Additional Services</a></li>
                </ul>
            </div>
        </div>
        <div class=""right-panel"">
                <p>");
            EndContext();
            BeginContext(1068, 65, false);
#line 30 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
              Write(Html.DisplayFor(modelItem => Model.SelectedSolution.Organisation));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 26, true);
            WriteLiteral("</p>\r\n                <h2>");
            EndContext();
            BeginContext(1160, 57, false);
#line 31 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
               Write(Html.DisplayFor(modelItem => Model.SelectedSolution.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1217, 96, true);
            WriteLiteral("</h2>\r\n            <section id=\"summary\">\r\n                <h2>Summary</h2>\r\n                <p>");
            EndContext();
            BeginContext(1314, 64, false);
#line 34 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
              Write(Html.DisplayFor(modelItem => Model.SelectedSolution.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 149, true);
            WriteLiteral("</p>\r\n            </section>\r\n            <section id=\"features\">\r\n                <h2>Features</h2>\r\n                <ul class=\"features-listing\">\r\n");
            EndContext();
#line 39 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                     foreach (var feature in Model.SelectedSolution.Features) {

#line default
#line hidden
            BeginContext(1608, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(1667, 37, false);
#line 41 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                       Write(Html.DisplayFor(modelItem => feature));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 33, true);
            WriteLiteral("\r\n                        </li>\r\n");
            EndContext();
#line 43 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                    }

#line default
#line hidden
            BeginContext(1760, 370, true);
            WriteLiteral(@"                </ul>
            </section>
            <section id=""commercial-arrangements"">
                <h2>Commercial Arrangements</h2>
                <table>
                    <tr>
                        <td>
                            <h3>Framework</h3>
                        </td>
                        <td>
                            <p>");
            EndContext();
            BeginContext(2131, 62, false);
#line 54 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                          Write(Html.DisplayFor(modelItem => Model.SelectedSolution.Framework));

#line default
#line hidden
            EndContext();
            BeginContext(2193, 406, true);
            WriteLiteral(@"</p>
                        </td>
                    </tr>
                </table>
            </section>
            <section id=""pricing"">
                <h2>Pricing</h2>
                <table>
                    <tr>
                        <td>
                            <h3>List Price</h3>
                        </td>
                        <td>
                            <p>");
            EndContext();
            BeginContext(2600, 62, false);
#line 67 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                          Write(Html.DisplayFor(modelItem => Model.SelectedSolution.ListPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2662, 244, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n                </table>\r\n            </section>\r\n            <section id=\"associated-services\">\r\n                <h2>Associated Services (Optional)</h2>\r\n                <table>\r\n");
            EndContext();
#line 75 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                     foreach (var service in Model.SelectedSolution.AssociatedServices) {

#line default
#line hidden
            BeginContext(2997, 88, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <h3>");
            EndContext();
            BeginContext(3086, 42, false);
#line 78 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                           Write(Html.DisplayFor(modelItem => service.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3128, 99, true);
            WriteLiteral("</h3>\r\n                        </td>\r\n                        <td>\r\n                            <p>");
            EndContext();
            BeginContext(3228, 43, false);
#line 81 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                          Write(Html.DisplayFor(modelItem => service.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3271, 64, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 84 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                    }

#line default
#line hidden
            BeginContext(3358, 180, true);
            WriteLiteral("                </table>\r\n            </section>\r\n            <section id=\"additional-services\">\r\n                <h2>Additional Services (Optional)</h2>\r\n                <table>\r\n");
            EndContext();
#line 90 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                     foreach (var service in Model.SelectedSolution.AdditionalServices) {

#line default
#line hidden
            BeginContext(3629, 88, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <h3>");
            EndContext();
            BeginContext(3718, 42, false);
#line 93 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                           Write(Html.DisplayFor(modelItem => service.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3760, 99, true);
            WriteLiteral("</h3>\r\n                        </td>\r\n                        <td>\r\n                            <p>");
            EndContext();
            BeginContext(3860, 43, false);
#line 96 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                          Write(Html.DisplayFor(modelItem => service.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3903, 64, true);
            WriteLiteral("</p>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 99 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Solution.cshtml"
                    }

#line default
#line hidden
            BeginContext(3990, 84, true);
            WriteLiteral("                </table>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>");
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
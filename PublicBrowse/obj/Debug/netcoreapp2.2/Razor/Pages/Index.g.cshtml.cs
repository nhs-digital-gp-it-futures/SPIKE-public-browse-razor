#pragma checksum "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec6654577463767bb8c5d17ca180fbb7c11db10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PublicBrowse.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(PublicBrowse.Pages.Pages_Index), null)]
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
#line 2 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec6654577463767bb8c5d17ca180fbb7c11db10", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45bdbf883d1501015e1ae6e7ab13a124a87654f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 5 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(155, 463, true);
            WriteLiteral(@"
<div id=""capability-selector-page"">
    <div class=""page-description"">
        <h1>Select the Capabilities you are looking for</h1>
        <p>Select the Capabilites you want to search for. Once you have selected all the capabilities you want solutions to provide you can apply your search</p>
        <p><a href=""/results"">View All solutions</a></p>
        <p><a href=""/results?onlyFoundation=true"">View All Foundation Solutions</a></p>
    </div>
    ");
            EndContext();
            BeginContext(618, 2394, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec6654577463767bb8c5d17ca180fbb7c11db104216", async() => {
                BeginContext(638, 336, true);
                WriteLiteral(@"
        <section class=""form-controls"">
            <button type=""submit"">Apply Search</button>
        </section>
        <!-- collapsible should be turned into a partial. -->
        <div class=""collapsible"">
            <h2 class=""collapsible-label"">Foundation Capabilities</h2>
            <ul class=""capability-selector"">
");
                EndContext();
#line 24 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                 for (var i=0; i < Model.Capabilities.Count; i++) {
                    

#line default
#line hidden
#line 25 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                     if (Model.Capabilities[i].IsFoundation) {

#line default
#line hidden
                BeginContext(1107, 117, true);
                WriteLiteral("                        <li>\r\n                            <div class=\"upper\">\r\n                                <h3><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 1224, "", 1282, 1);
#line 28 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
WriteAttributeValue("", 1230, Html.DisplayFor(model => Model.Capabilities[i].URL), 1230, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1282, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(1284, 57, false);
#line 28 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => Model.Capabilities[i].Title));

#line default
#line hidden
                EndContext();
                BeginContext(1341, 93, true);
                WriteLiteral("</a></h3>\r\n                            </div>\r\n                            <p class=\"middle\">");
                EndContext();
                BeginContext(1435, 55, false);
#line 30 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                                         Write(Html.DisplayFor(model => Model.Capabilities[i].Summary));

#line default
#line hidden
                EndContext();
                BeginContext(1490, 94, true);
                WriteLiteral("</p>\r\n                            <div class=\"lower\">\r\n                                <label>");
                EndContext();
                BeginContext(1585, 69, false);
#line 32 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                                  Write(Html.CheckBoxFor(model => Model.SelectableCapabilities[i].IsSelected));

#line default
#line hidden
                EndContext();
                BeginContext(1654, 57, true);
                WriteLiteral(" Add Capability</label>\r\n                                ");
                EndContext();
                BeginContext(1712, 55, false);
#line 33 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                           Write(Html.HiddenFor(m => Model.SelectableCapabilities[i].ID));

#line default
#line hidden
                EndContext();
                BeginContext(1767, 69, true);
                WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
                EndContext();
#line 36 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                    }

#line default
#line hidden
#line 36 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(1878, 183, true);
                WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"collapsible\">\r\n            <h2 class=\"collapsible-label\">Other Capabilities</h2>\r\n            <ul class=\"capability-selector\">\r\n");
                EndContext();
#line 43 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                 for (var i=0; i < Model.Capabilities.Count; i++) {
                    

#line default
#line hidden
#line 44 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                     if (!Model.Capabilities[i].IsFoundation) {

#line default
#line hidden
                BeginContext(2195, 117, true);
                WriteLiteral("                        <li>\r\n                            <div class=\"upper\">\r\n                                <h3><a");
                EndContext();
                BeginWriteAttribute("href", " href=", 2312, "", 2370, 1);
#line 47 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
WriteAttributeValue("", 2318, Html.DisplayFor(model => Model.Capabilities[i].URL), 2318, 52, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2370, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(2372, 57, false);
#line 47 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => Model.Capabilities[i].Title));

#line default
#line hidden
                EndContext();
                BeginContext(2429, 93, true);
                WriteLiteral("</a></h3>\r\n                            </div>\r\n                            <p class=\"middle\">");
                EndContext();
                BeginContext(2523, 55, false);
#line 49 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                                         Write(Html.DisplayFor(model => Model.Capabilities[i].Summary));

#line default
#line hidden
                EndContext();
                BeginContext(2578, 94, true);
                WriteLiteral("</p>\r\n                            <div class=\"lower\">\r\n                                <label>");
                EndContext();
                BeginContext(2673, 69, false);
#line 51 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                                  Write(Html.CheckBoxFor(model => Model.SelectableCapabilities[i].IsSelected));

#line default
#line hidden
                EndContext();
                BeginContext(2742, 57, true);
                WriteLiteral(" Add Capability</label>\r\n                                ");
                EndContext();
                BeginContext(2800, 55, false);
#line 52 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                           Write(Html.HiddenFor(m => Model.SelectableCapabilities[i].ID));

#line default
#line hidden
                EndContext();
                BeginContext(2855, 69, true);
                WriteLiteral("\r\n                            </div>\r\n                        </li>\r\n");
                EndContext();
#line 55 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                    }

#line default
#line hidden
#line 55 "/home/adam/github/nhsd/SPIKE-public-browse-razor/PublicBrowse/Pages/Index.cshtml"
                     
                }

#line default
#line hidden
                BeginContext(2966, 39, true);
                WriteLiteral("            </ul>\r\n        </div>\r\n    ");
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
            BeginContext(3012, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

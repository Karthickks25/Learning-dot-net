#pragma checksum "C:\Users\40830\Documents\git\Learning-dot-net\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "613279cf09ba44c61305d959f11c0793990ca8f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Post), @"mvc.1.0.view", @"/Views/Shared/_Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Post.cshtml", typeof(AspNetCore.Views_Shared__Post))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613279cf09ba44c61305d959f11c0793990ca8f3", @"/Views/Shared/_Post.cshtml")]
    public class Views_Shared__Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(97, 39, true);
            WriteLiteral("\r\n<article class=\"blog-post\">\r\n    <h1>");
            EndContext();
            BeginContext(137, 123, false);
#line 5 "C:\Users\40830\Documents\git\Learning-dot-net\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
   Write(Html.ActionLink(Model.Title, "Post", "Blog", new { year = Model.Posted.Year, month = Model.Posted.Month, key = Model.Key }));

#line default
#line hidden
            EndContext();
            BeginContext(260, 55, true);
            WriteLiteral("</h1>\r\n    <div class=\"details\">\r\n        Posted <span>");
            EndContext();
            BeginContext(316, 36, false);
#line 7 "C:\Users\40830\Documents\git\Learning-dot-net\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
                Write(Format.AsReadableDate(@Model.Posted));

#line default
#line hidden
            EndContext();
            BeginContext(352, 18, true);
            WriteLiteral("</span> by <span> ");
            EndContext();
            BeginContext(371, 12, false);
#line 7 "C:\Users\40830\Documents\git\Learning-dot-net\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
                                                                       Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(383, 56, true);
            WriteLiteral("</span>\r\n    </div>\r\n    <div class=\"content\">\r\n        ");
            EndContext();
            BeginContext(440, 10, false);
#line 10 "C:\Users\40830\Documents\git\Learning-dot-net\ExploreCalifornia\ExploreCalifornia\Views\Shared\_Post.cshtml"
   Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(450, 24, true);
            WriteLiteral("\r\n    </div>\r\n</article>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ExploreCalifornia.Models.FormattingService Format { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreCalifornia.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
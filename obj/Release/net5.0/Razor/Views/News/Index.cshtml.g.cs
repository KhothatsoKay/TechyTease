#pragma checksum "C:\Users\Khothatso\Blog\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84d2b33c7fca16123109d96df90458cebff74e69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Khothatso\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Khothatso\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84d2b33c7fca16123109d96df90458cebff74e69", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsArticle>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>News Articles</h1>\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
 foreach (var article in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"article\">\r\n\r\n            <h2>");
#nullable restore
#line 9 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
           Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 10 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
          Write(article.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        \r\n        <div class=\"authorimage\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 258, "\"", 278, 1);
#nullable restore
#line 13 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
WriteAttributeValue("", 264, article.Image, 264, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Article Image\" style=\"max-width: 200px; height: auto;\" class=\"blog-image\">\r\n        </div>\r\n        <p><a");
            BeginWriteAttribute("href", " href=\"", 390, "\"", 409, 1);
#nullable restore
#line 15 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
WriteAttributeValue("", 397, article.Url, 397, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Read More</a></p>\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsArticle>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Khothatso\Blog\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf482a6ab466f52582c6f2c31aebdb60b136858a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf482a6ab466f52582c6f2c31aebdb60b136858a", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsArticle>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Tech News Articles</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
     foreach (var article in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 137, "\"", 156, 1);
#nullable restore
#line 9 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
WriteAttributeValue("", 144, article.Url, 144, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">");
#nullable restore
#line 9 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
                                              Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            <p>Published At: ");
#nullable restore
#line 10 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
                        Write(article.PublishedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </li>\r\n");
#nullable restore
#line 12 "C:\Users\Khothatso\Blog\Views\News\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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

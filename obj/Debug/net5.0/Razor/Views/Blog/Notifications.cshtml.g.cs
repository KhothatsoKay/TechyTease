#pragma checksum "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9a6685cc79d1e62ec5d5ab120a9b5dc9ceb1fb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Notifications), @"mvc.1.0.view", @"/Views/Blog/Notifications.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a6685cc79d1e62ec5d5ab120a9b5dc9ceb1fb3", @"/Views/Blog/Notifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Notifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"notifications\">\r\n");
#nullable restore
#line 2 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
     if(ViewBag.Notifications != null){
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
     foreach (var notification in ViewBag.Notifications)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 207, 2);
            WriteAttributeValue("", 152, "notification", 152, 12, true);
#nullable restore
#line 5 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
WriteAttributeValue(" ", 164, notification.IsRead ? "read" : "unread", 165, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span>");
#nullable restore
#line 6 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
             Write(notification.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span class=\"date\">");
#nullable restore
#line 7 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
                          Write(notification.CreatedDate.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Khothatso\Blog\Views\Blog\Notifications.cshtml"
     
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac0ead2016fcc17984a02ed09803e66a0f091d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac0ead2016fcc17984a02ed09803e66a0f091d04", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac0ead2016fcc17984a02ed09803e66a0f091d044049", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input type=\"text\" name=\"search\" class=\"form-control\" placeholder=\"Search\">\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary searchbtn\">Search</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 5 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
AddHtmlAttributeValue("", 171, Url.Action("Index", "Blog"), 171, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<h2>Top News Articles</h2>\r\n<div class=\"top-news-container\">\r\n    <div class=\"top-news-list\">\r\n");
#nullable restore
#line 14 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
         foreach (var article in Enumerable.Take(ViewBag.Top3Articles, 3))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"top-news-card\">\r\n                <h3>");
#nullable restore
#line 17 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
               Write(article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 700, "\"", 720, 1);
#nullable restore
#line 18 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 706, article.Image, 706, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 721, "\"", 741, 1);
#nullable restore
#line 18 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 727, article.Title, 727, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<h1 class=\"posts\">Recent Posts</h1>\r\n");
#nullable restore
#line 24 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
 if (SignInManager.IsSignedIn(User)){

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/Blog/Create\">\r\n<i i class=\"icon\" data-feather=\"plus-circle\"></i>\r\n</a>\r\n");
#nullable restore
#line 28 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""avatar-container"">
        <img src=""/Images/avatar.jpg"" alt=""Avatar"" class=""avatar"">
        <div class=""message"">
            <p>I'm guessing you can't write your own blogs at the moment, what could be the problem?🤔<br />
               Well it's because your haven't logged in, log in now🤣
            </p>
        </div>
    </div>
");
#nullable restore
#line 37 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
    
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
 foreach (var item in Model) {
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"article\">\r\n            <div class=\"authorname\">\r\n");
#nullable restore
#line 45 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
              if (item.AuthorProfilePicture != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("               <img");
            BeginWriteAttribute("src", " src=\"", 1540, "\"", 1621, 2);
            WriteAttributeValue("", 1546, "data:image/jpeg;base64,", 1546, 23, true);
#nullable restore
#line 46 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 1569, Convert.ToBase64String(@item.AuthorProfilePicture), 1570, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("alt=\"Author Profile Picture\" \r\n                style=\"height:50px ; width: 50px; border-radius: 50%;  ;\">\r\n");
#nullable restore
#line 48 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2 style=\"display: inline-block; vertical-align: middle;\">");
#nullable restore
#line 49 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                                                                  Write(item.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <div class=\"authorimage\">\r\n");
#nullable restore
#line 51 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
          if (item.ImagePaths.Count > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"grid-container\">\r\n");
#nullable restore
#line 54 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
             foreach (var imagePath in item.ImagePaths)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"grid-item\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2095, "\"", 2117, 1);
#nullable restore
#line 57 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2102, imagePath.Path, 2102, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2149, "\"", 2170, 1);
#nullable restore
#line 58 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2155, imagePath.Path, 2155, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2171, "\"", 2177, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"blog-image\" />\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 61 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 63 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
    }
    else if (item.ImagePaths.Count == 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 2349, "\"", 2380, 1);
#nullable restore
#line 66 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2356, item.ImagePaths[0].Path, 2356, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2400, "\"", 2430, 1);
#nullable restore
#line 67 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2406, item.ImagePaths[0].Path, 2406, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2431, "\"", 2437, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"blog-image\" />\r\n        </a>\r\n");
#nullable restore
#line 69 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </div>\r\n        </div>\r\n        <div class=\"contents\">\r\n            <h2>");
#nullable restore
#line 73 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <p>");
#nullable restore
#line 74 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
          Write(Html.Raw(@item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 75 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
          Write(item.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n           \r\n            <h3>Reactions</h3>\r\n             <ul>\r\n");
#nullable restore
#line 79 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                 foreach(var reaction in item.Reactions)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                     if(reaction != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div>\r\n                            <p class=\"reactor\">");
#nullable restore
#line 83 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                                          Write(reaction.reactor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"reactionValue\">");
#nullable restore
#line 84 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                                                Write(reaction.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 84 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                                                                Write(reaction.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \r\n                        </div>\r\n");
#nullable restore
#line 86 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </ul>\r\n");
#nullable restore
#line 89 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
              if (SignInManager.IsSignedIn(User)){

#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac0ead2016fcc17984a02ed09803e66a0f091d0416047", async() => {
                WriteLiteral("Comment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
             }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Sign In to comment</h4>\r\n");
#nullable restore
#line 93 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
               if (User.Identity.Name == item.AuthorName){

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"actions\">\r\n                \r\n               </div>\r\n");
#nullable restore
#line 98 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 101 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 102 "C:\Users\Khothatso\Blog\Views\Blog\Index.cshtml"
 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; } = default!;
        #nullable disable
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

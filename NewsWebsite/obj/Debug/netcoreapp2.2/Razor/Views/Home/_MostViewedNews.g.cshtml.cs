#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8886510e64a33f59ed8cbb3ef512d0a715d00545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__MostViewedNews), @"mvc.1.0.view", @"/Views/Home/_MostViewedNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_MostViewedNews.cshtml", typeof(AspNetCore.Views_Home__MostViewedNews))]
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
#line 2 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8886510e64a33f59ed8cbb3ef512d0a715d00545", @"/Views/Home/_MostViewedNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__MostViewedNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.News.NewsViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 439, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-12"">
        <!-- Section Heading -->
        <div class=""section-heading"">
            <h4>پربازدید ترین اخبار</h4>
            <div class=""line""></div>
        </div>
    </div>
</div>

<nav class=""w-25 m-auto"">
    <div class=""nav nav-tabs nav-fill"" id=""nav-tab"" role=""tablist"">
        <a class=""nav-item nav-link active most-view"" id=""most-viewed-day-tab"" data-toggle=""tab"" data-url=""");
            EndContext();
            BeginContext(523, 82, false);
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                      Write(Url.Action("Index","Home",values:new {duration="day",TypeOfNews="MostViewedNews"}));

#line default
#line hidden
            EndContext();
            BeginContext(605, 114, true);
            WriteLiteral("\">امروز</a>\r\n        <a class=\"nav-item nav-link most-view\" id=\"most-viewed-week-tab\" data-toggle=\"tab\" data-url=\"");
            EndContext();
            BeginContext(720, 83, false);
#line 16 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                Write(Url.Action("Index","Home",values:new {duration="week",TypeOfNews="MostViewedNews"}));

#line default
#line hidden
            EndContext();
            BeginContext(803, 114, true);
            WriteLiteral("\">هفته</a>\r\n        <a class=\"nav-item nav-link most-view\" id=\"most-viewed-month-tab\" data-toggle=\"tab\" data-url=\"");
            EndContext();
            BeginContext(918, 84, false);
#line 17 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                 Write(Url.Action("Index","Home",values:new {duration="month",TypeOfNews="MostViewedNews"}));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 192, true);
            WriteLiteral("\">ماه</a>\r\n    </div>\r\n</nav>\r\n<div class=\"tab-content py-3 px-3 px-sm-0\" id=\"nav-tabContent\">\r\n    <div class=\"tab-pane fade show active\" id=\"nav-mostViewedNews\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 23 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
             if (Model.Count() != 0)
            {
                

#line default
#line hidden
#line 25 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1312, 263, true);
            WriteLiteral(@"                    <div class=""col-12 col-md-4"">
                        <div class=""single-post-area mb-80 border"">
                            <!-- Post Thumbnail -->
                            <div class=""post-thumbnail"">
                                ");
            EndContext();
            BeginContext(1575, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8886510e64a33f59ed8cbb3ef512d0a715d005456410", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1585, "~/newsImage/", 1585, 12, true);
#line 31 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
AddHtmlAttributeValue("", 1597, item.ImageName, 1597, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 31 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
AddHtmlAttributeValue("", 1619, item.ImageName, 1619, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1636, 122, true);
            WriteLiteral("\r\n\r\n                                <!-- Video Duration -->\r\n                                <span class=\"video-duration\">");
            EndContext();
            BeginContext(1759, 58, false);
#line 34 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                        Write(item.PublishDateTime.ConvertMiladiToShamsi("dd MMMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 246, true);
            WriteLiteral("</span>\r\n                            </div>\r\n\r\n                            <!-- Post Content -->\r\n                            <div class=\"post-content clearfix\">\r\n                                <a href=\"#\" class=\"post-cata cata-sm cata-success\">");
            EndContext();
            BeginContext(2064, 21, false);
#line 39 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                              Write(item.NameOfCategories);

#line default
#line hidden
            EndContext();
            BeginContext(2085, 40, true);
            WriteLiteral("</a>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2125, "\"", 2155, 4);
            WriteAttributeValue("", 2132, "/", 2132, 1, true);
#line 40 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
WriteAttributeValue("", 2133, item.NewsId, 2133, 12, false);

#line default
#line hidden
            WriteAttributeValue("", 2145, "/", 2145, 1, true);
#line 40 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
WriteAttributeValue("", 2146, item.Url, 2146, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2156, 25, true);
            WriteLiteral(" class=\"post-title p-2\"> ");
            EndContext();
            BeginContext(2182, 15, false);
#line 40 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                     Write(item.ShortTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2197, 187, true);
            WriteLiteral(" </a>\r\n                                <div class=\"post-meta d-flex float-left pb-1\">\r\n                                    <a href=\"#\"><i class=\"fa fa-comments-o\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2385, 21, false);
#line 42 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                               Write(item.NumberOfComments);

#line default
#line hidden
            EndContext();
            BeginContext(2406, 99, true);
            WriteLiteral("</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2506, 18, false);
#line 43 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                        Write(item.NumberOfVisit);

#line default
#line hidden
            EndContext();
            BeginContext(2524, 107, true);
            WriteLiteral("</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2632, 17, false);
#line 44 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                Write(item.NumberOfLike);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 109, true);
            WriteLiteral("</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
            EndContext();
            BeginContext(2759, 20, false);
#line 45 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                  Write(item.NumberOfDisLike);

#line default
#line hidden
            EndContext();
            BeginContext(2779, 142, true);
            WriteLiteral("</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 50 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                }

#line default
#line hidden
#line 50 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(2988, 101, true);
            WriteLiteral("                <p class=\"col-md-12 alert alert-info text-center\">پربازدیدترین خبر یافت نشد ...</p>\r\n");
            EndContext();
#line 55 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
            }

#line default
#line hidden
            BeginContext(3104, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsWebsite.ViewModels.News.NewsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

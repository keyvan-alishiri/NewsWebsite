#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8886510e64a33f59ed8cbb3ef512d0a715d00545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__MostViewedNews), @"mvc.1.0.view", @"/Views/Home/_MostViewedNews.cshtml")]
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
#line 2 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8886510e64a33f59ed8cbb3ef512d0a715d00545", @"/Views/Home/_MostViewedNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__MostViewedNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.News.NewsViewModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
#nullable restore
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                      Write(Url.Action("Index","Home",values:new {duration="day",TypeOfNews="MostViewedNews"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">امروز</a>\r\n        <a class=\"nav-item nav-link most-view\" id=\"most-viewed-week-tab\" data-toggle=\"tab\" data-url=\"");
#nullable restore
#line 16 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                Write(Url.Action("Index","Home",values:new {duration="week",TypeOfNews="MostViewedNews"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">هفته</a>\r\n        <a class=\"nav-item nav-link most-view\" id=\"most-viewed-month-tab\" data-toggle=\"tab\" data-url=\"");
#nullable restore
#line 17 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                 Write(Url.Action("Index","Home",values:new {duration="month",TypeOfNews="MostViewedNews"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">ماه</a>\r\n    </div>\r\n</nav>\r\n<div class=\"tab-content py-3 px-3 px-sm-0\" id=\"nav-tabContent\">\r\n    <div class=\"tab-pane fade show active\" id=\"nav-mostViewedNews\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
             if (Model.Count() != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-12 col-md-4"">
                        <div class=""single-post-area mb-80 border"">
                            <!-- Post Thumbnail -->
                            <div class=""post-thumbnail"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8886510e64a33f59ed8cbb3ef512d0a715d005455941", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1585, "~/newsImage/", 1585, 12, true);
#nullable restore
#line 31 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
AddHtmlAttributeValue("", 1597, item.ImageName, 1597, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 31 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
AddHtmlAttributeValue("", 1619, item.ImageName, 1619, 15, false);

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
            WriteLiteral("\r\n\r\n                                <!-- Video Duration -->\r\n                                <span class=\"video-duration\">");
#nullable restore
#line 34 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                        Write(item.PublishDateTime.ConvertMiladiToShamsi("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n\r\n                            <!-- Post Content -->\r\n                            <div class=\"post-content clearfix\">\r\n                                <a href=\"#\" class=\"post-cata cata-sm cata-success\">");
#nullable restore
#line 39 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                              Write(item.NameOfCategories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 2125, "\"", 2155, 4);
            WriteAttributeValue("", 2132, "/", 2132, 1, true);
#nullable restore
#line 40 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
WriteAttributeValue("", 2133, item.NewsId, 2133, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2145, "/", 2145, 1, true);
#nullable restore
#line 40 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
WriteAttributeValue("", 2146, item.Url, 2146, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"post-title p-2\"> ");
#nullable restore
#line 40 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                     Write(item.ShortTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                                <div class=\"post-meta d-flex float-left pb-1\">\r\n                                    <a href=\"#\"><i class=\"fa fa-comments-o\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 42 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                               Write(item.NumberOfComments);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-eye\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 43 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                        Write(item.NumberOfVisit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-o-up\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 44 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                Write(item.NumberOfLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    <a href=\"#\"><i class=\"fa fa-thumbs-o-down\" aria-hidden=\"true\"></i> ");
#nullable restore
#line 45 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                                                                                                  Write(item.NumberOfDisLike);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"col-md-12 alert alert-info text-center\">پربازدیدترین خبر یافت نشد ...</p>\r\n");
#nullable restore
#line 55 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\_MostViewedNews.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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

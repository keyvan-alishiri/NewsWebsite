#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec1291f6ea2de947ec2a04a6a1332dc2d53b8ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewsInCategoryAndTag), @"mvc.1.0.view", @"/Views/Home/NewsInCategoryAndTag.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewsInCategoryAndTag.cshtml", typeof(AspNetCore.Views_Home_NewsInCategoryAndTag))]
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
#line 2 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
using NewsWebsite.Common;

#line default
#line hidden
#line 3 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
using NewsWebsite.ViewModels.Newsletter;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec1291f6ea2de947ec2a04a6a1332dc2d53b8ab2", @"/Views/Home/NewsInCategoryAndTag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewsInCategoryAndTag : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebsite.ViewModels.Home.CategoryOrTagInfoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
  
    ViewData["Title"] = "NewsInCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(229, 422, true);
            WriteLiteral(@"

<div class=""vizew-breadcrumb"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <nav aria-label=""breadcrumb"">
                    <ol class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""/""><i class=""fa fa-home"" aria-hidden=""true""></i> خانه</a></li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">");
            EndContext();
            BeginContext(652, 11, false);
#line 17 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
                                                                          Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(663, 668, true);
            WriteLiteral(@"</li>
                    </ol>
                </nav>
            </div>
        </div>
    </div>
</div>
<!-- ##### Breadcrumb Area End ##### -->
<!-- ##### Archive List Posts Area Start ##### -->
<div class=""vizew-archive-list-posts-area mb-80"">
    <div class=""container"">
        <div class=""row justify-content-center"">
            <div class=""col-12 col-lg-8"">
                <!-- Archive Catagory & View Options -->
                <div class=""archive-catagory-view mb-30 d-flex align-items-center justify-content-between"">
                    <!-- Catagory -->
                    <div class=""archive-catagory"">
                        <h4> ");
            EndContext();
            BeginContext(1332, 11, false);
#line 34 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
                        Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1343, 846, true);
            WriteLiteral(@" </h4>
                    </div>
                    <!-- View Options -->
                    <div class=""view-options"">
                        <a href=""archive-grid.html""><i class=""fa fa-th-large"" aria-hidden=""true""></i></a>
                        <a href=""archive-list.html"" class=""active""><i class=""fa fa-list-ul"" aria-hidden=""true""></i></a>
                    </div>
                </div>
                <div id=""container""></div>
                <div id=""progress"" class=""text-center"" style=""display:none"">
                    <p>در حال بارگزاری اطلاعات ...</p>
                    <div class=""loadingCricle m-auto""></div>
                </div>
            </div>

            <div class=""col-12 col-md-6 col-lg-4"">
                <div class=""sidebar-area"">
                    <!-- ***** MostPopularNews***** -->
");
            EndContext();
            BeginContext(2406, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2429, 75, false);
#line 57 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
               Write(await Html.PartialAsync("_RegisterInNewsletter", new NewsletterViewModel()));

#line default
#line hidden
            EndContext();
            BeginContext(2504, 58, true);
            WriteLiteral("\r\n                    <!-- ***** Single Widget ***** -->\r\n");
            EndContext();
            BeginContext(2737, 526, true);
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</div>

<script>
    var pageSize = 5;
    var pageIndex = 0;
    GetData();
    $(window).scroll(function () {
        if (Math.ceil($(window).scrollTop()) == $(document).height() - $(window).height()) {
            GetData();
        }
    });

    function GetData() {
        $.ajax({
            type: 'GET',
            url: '/Home/GetNewsInCategoryAndTag',
            data:{""pageindex"":pageIndex,""pagesize"":pageSize,""categoryId"":'");
            EndContext();
            BeginContext(3264, 8, false);
#line 82 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Home\NewsInCategoryAndTag.cshtml"
                                                                     Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3272, 1911, true);
            WriteLiteral(@"'},
            dataType: 'json',
            success: function (data) {
                if (data != null) {
                   $.each(data, function (i) {
                       $(""#container"").append(""<div class='single-post-area style-2'><div class='row align-items-center'><div class='col-12 col-md-6'> <div class='post-thumbnail'><img src='/newsImage/"" + data[i].imageName + ""' alt='"" + data[i].imageName + ""' /><span class='video-duration'>"" + data[i].persianPublishTime + ""</span></div></div><div class='col-12 col-md-6'><div class='post-content mt-0'><a href='#' class='post-cata cata-sm cata-success'>"" + data[i].nameOfCategories + ""</a> <a href='/News/"" + data[i].newsId + ""/"" + data[i].url + ""' class='post-title mb-2'>"" + data[i].title + ""</a><div class='post-meta d-flex align-items-center mb-2'><a href='#' class='post-author'>"" + data[i].authorName + ""</a><i class='fa fa-circle' aria-hidden='true'></i><a href='#' class='post-date'>"" + data[i].persianPublishDate + ""</a></div><p class='mb-2'>""
        ");
            WriteLiteral(@"                  +data[i].abstract+""</p><div class='post-meta d-flex'><a href='#'><i class='fa fa-comments-o' aria-hidden='true'></i> ""+ data[i].numberOfComments+""</a><a href='#'><i class='fa fa-eye' aria-hidden='true'></i> ""+ data[i].numberOfVisit+""</a><a href='#'><i class='fa fa-thumbs-o-up' aria-hidden='true'></i> ""+ data[i].numberOfLike+""</a><a href='#'><i class='fa fa-thumbs-o-down' aria-hidden='true'></i> ""+ data[i].numberOfDisLike+""</a></div></div></div></div></div> "");
                   });
                   pageIndex++;
                }
            },
            beforeSend : function () {
                $(""#progress"").show();
            },
            complete : function () {
                $(""#progress"").hide();
            },
            error: function () {
                 ShowSweetErrorAlert();
            }
        });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.ViewModels.Home.CategoryOrTagInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6491c30e7513bb0b15b8889167eb6b406074f8fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6491c30e7513bb0b15b8889167eb6b406074f8fa", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(95, 444, true);
            WriteLiteral(@"
<div id=""modal-placeholder""></div>
<nav class=""navbar navbar-top navbar-expand-md navbar-dark"" id=""navbar-main"">
    <div class=""container-fluid"">
        <!-- Brand -->
        <ul class=""nav nav-sitemap justify-content-center justify-content-xl-end"">
            <li>
                <a class=""h4 mb-0 text-white d-lg-inline-block"" href=""./index.html""> داشبورد </a>
            </li>
        </ul>

        <!-- User -->
        ");
            EndContext();
            BeginContext(540, 38, false);
#line 18 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Dashboard\Index.cshtml"
   Write(await Html.PartialAsync("_AdminLogin"));

#line default
#line hidden
            EndContext();
            BeginContext(578, 4867, true);
            WriteLiteral(@"
    </div>
</nav>
<!-- Header -->
<div class=""header bg-gradient-primary pb-6 pt-5 pt-md-8"">
</div>

<div class=""container-fluid mt--7"">
    <div class=""header-body"">
        <!-- Card stats -->
        <div class=""row"">
            <div class=""col-xl-3 col-lg-6"">
                <div class=""card card-stats mb-4 mb-xl-0"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Traffic</h5>
                                <span class=""h2 font-weight-bold mb-0"">350,897</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-danger text-white rounded-circle shadow"">
                                    <i class=""fas fa-chart-bar""></i>
                                </div>
                            </div>
                        ");
            WriteLiteral(@"</div>
                        <p class=""mt-3 mb-0 text-muted text-sm"">
                            <span class=""text-success mr-2""><i class=""fa fa-arrow-up""></i> 3.48%</span>
                            <span class=""text-nowrap"">Since last month</span>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-6"">
                <div class=""card card-stats mb-4 mb-xl-0"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">New users</h5>
                                <span class=""h2 font-weight-bold mb-0"">2,356</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-warning text-white rounded-circle shadow"">
                                    <i cla");
            WriteLiteral(@"ss=""fas fa-chart-pie""></i>
                                </div>
                            </div>
                        </div>
                        <p class=""mt-3 mb-0 text-muted text-sm"">
                            <span class=""text-danger mr-2""><i class=""fas fa-arrow-down""></i> 3.48%</span>
                            <span class=""text-nowrap"">Since last week</span>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-6"">
                <div class=""card card-stats mb-4 mb-xl-0"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">کاربران</h5>
                                <span class=""h2 font-weight-bold mb-0"">924</span>
                            </div>
                            <div class=""col-auto"">
                        ");
            WriteLiteral(@"        <div class=""icon icon-shape bg-yellow text-white rounded-circle shadow"">
                                    <i class=""fas fa-users""></i>
                                </div>
                            </div>
                        </div>
                        <p class=""mt-3 mb-0 text-muted text-sm"">
                            <span class=""text-warning mr-2""><i class=""fas fa-arrow-down""></i> 1.10%</span>
                            <span class=""text-nowrap"">Since yesterday</span>
                        </p>
                    </div>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-6"">
                <div class=""card card-stats mb-4 mb-xl-0"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <div class=""col"">
                                <h5 class=""card-title text-uppercase text-muted mb-0"">Performance</h5>
                                <span class=""h2 font-weight-bold mb-0""");
            WriteLiteral(@">49,65%</span>
                            </div>
                            <div class=""col-auto"">
                                <div class=""icon icon-shape bg-info text-white rounded-circle shadow"">
                                    <i class=""fas fa-percent""></i>
                                </div>
                            </div>
                        </div>
                        <p class=""mt-3 mb-0 text-muted text-sm"">
                            <span class=""text-success mr-2""><i class=""fas fa-arrow-up""></i> 12%</span>
                            <span class=""text-nowrap"">Since last month</span>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad06ac01bdd5ed0f6bec6a5c381f11ccfda3e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News__SubCategories), @"mvc.1.0.view", @"/Areas/Admin/Views/News/_SubCategories.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/_SubCategories.cshtml", typeof(AspNetCore.Areas_Admin_Views_News__SubCategories))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad06ac01bdd5ed0f6bec6a5c381f11ccfda3e50", @"/Areas/Admin/Views/News/_SubCategories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News__SubCategories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsWebsite.ViewModels.News.NewsCategoriesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
     foreach (var item in Model.Categories)
    {

#line default
#line hidden
            BeginContext(120, 10, true);
            WriteLiteral("    <li>\r\n");
            EndContext();
#line 7 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
         if (Model.CategoryIds != null)
        {
            if (Model.CategoryIds.Contains(item.id))
            {

#line default
#line hidden
            BeginContext(251, 57, true);
            WriteLiteral("                <input type=\"checkbox\" name=\"CategoryIds\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 308, "\"", 324, 1);
#line 11 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
WriteAttributeValue("", 316, item.id, 316, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(325, 12, true);
            WriteLiteral(" checked /> ");
            EndContext();
            BeginContext(338, 10, false);
#line 11 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
                                                                                 Write(item.title);

#line default
#line hidden
            EndContext();
#line 11 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
                                                                                                 
            }
            else
            {

#line default
#line hidden
            BeginContext(398, 57, true);
            WriteLiteral("                <input type=\"checkbox\" name=\"CategoryIds\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 455, "\"", 471, 1);
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
WriteAttributeValue("", 463, item.id, 463, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(472, 4, true);
            WriteLiteral(" /> ");
            EndContext();
            BeginContext(477, 10, false);
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
                                                                         Write(item.title);

#line default
#line hidden
            EndContext();
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
                                                                                         
            }
        }

        else
        {

#line default
#line hidden
            BeginContext(542, 53, true);
            WriteLiteral("            <input type=\"checkbox\" name=\"CategoryIds\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 595, "\"", 611, 1);
#line 21 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
WriteAttributeValue("", 603, item.id, 603, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(612, 4, true);
            WriteLiteral(" /> ");
            EndContext();
            BeginContext(617, 10, false);
#line 21 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
                                                                     Write(item.title);

#line default
#line hidden
            EndContext();
#line 21 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
                                                                                     
        }

#line default
#line hidden
            BeginContext(640, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
           Model.Categories = item.subs;

#line default
#line hidden
            BeginContext(685, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(694, 48, false);
#line 25 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
   Write(await Html.PartialAsync("_SubCategories", Model));

#line default
#line hidden
            EndContext();
            BeginContext(742, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
#line 27 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\News\_SubCategories.cshtml"
    }

#line default
#line hidden
            BeginContext(762, 7, true);
            WriteLiteral("\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsWebsite.ViewModels.News.NewsCategoriesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

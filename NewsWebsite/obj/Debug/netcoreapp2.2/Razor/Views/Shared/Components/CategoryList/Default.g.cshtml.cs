#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f97720ed7796485a5a2f6034f2cce5b9367c461c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/CategoryList/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_CategoryList_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97720ed7796485a5a2f6034f2cce5b9367c461c", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewsWebsite.ViewModels.Category.TreeViewCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 64, true);
            WriteLiteral("\r\n<div class=\"classynav\">\r\n    <ul>\r\n        <li class=\"active\">");
            EndContext();
            BeginContext(127, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f97720ed7796485a5a2f6034f2cce5b9367c461c3804", async() => {
                BeginContext(171, 4, true);
                WriteLiteral("خانه");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(179, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 6 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model.OrderBy(t=>t.title))
        {

#line default
#line hidden
            BeginContext(255, 36, true);
            WriteLiteral("            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 291, "\"", 317, 4);
            WriteAttributeValue("", 298, "/", 298, 1, true);
#line 9 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 299, item.id, 299, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 307, "/", 307, 1, true);
#line 9 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 308, item.url, 308, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(318, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(320, 10, false);
#line 9 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                                         Write(item.title);

#line default
#line hidden
            EndContext();
            BeginContext(330, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 10 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                 if (item.subs.Count() != 0)
                {

#line default
#line hidden
            BeginContext(401, 43, true);
            WriteLiteral("                    <ul class=\"dropdown\">\r\n");
            EndContext();
#line 13 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                         foreach (var sub in item.subs)
                        {

#line default
#line hidden
            BeginContext(528, 34, true);
            WriteLiteral("                            <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 562, "\"", 586, 4);
            WriteAttributeValue("", 569, "/", 569, 1, true);
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 570, sub.id, 570, 7, false);

#line default
#line hidden
            WriteAttributeValue("", 577, "/", 577, 1, true);
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
WriteAttributeValue("", 578, sub.url, 578, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(587, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(589, 9, false);
#line 15 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                                                       Write(sub.title);

#line default
#line hidden
            EndContext();
            BeginContext(598, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 16 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(636, 31, true);
            WriteLiteral("\r\n\r\n                    </ul>\r\n");
            EndContext();
#line 20 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(686, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 23 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(718, 76, true);
            WriteLiteral("\r\n\r\n\r\n        <li><a href=\"contact.html\">ویدئوها</a></li>\r\n    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewsWebsite.ViewModels.Category.TreeViewCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Category\_CategoryTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18fd8e1636d5619f585781aa041918226ac849b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category__CategoryTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/_CategoryTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18fd8e1636d5619f585781aa041918226ac849b4", @"/Areas/Admin/Views/Category/_CategoryTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category__CategoryTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"toolbar\">\r\n    <button type=\"button\" class=\"btn btn-success\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 3 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Category\_CategoryTable.cshtml"
                                                                                Write(Url.Action("RenderCategory","Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n        <i class=\"fa fa-plus\"></i> | افزودن دسته بندی جدید\r\n    </button>\r\n\r\n    <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 7 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Category\_CategoryTable.cshtml"
                                                                               Write(Url.Action("DeleteGroup","Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
        <i class=""fa fa-trash""></i> | حذف گروهی
    </button>
</div>
<table id=""table""
       data-toolbar=""#toolbar""
       data-search=""true""
       data-show-refresh=""true""
       data-show-toggle=""true""
       data-show-fullscreen=""true""
       data-show-columns=""true""
       data-detail-view=""true""
       data-show-export=""true""
       data-click-to-select=""true""
       data-detail-formatter=""detailFormatter""
       data-minimum-count-columns=""2""
       data-show-pagination-switch=""true""
       data-pagination=""true""
       data-id-field=""id""
       data-page-list=""[10, 25, 50, 100, all]""
       data-show-footer=""true""
       data-side-pagination=""server""
       data-url=""/Admin/Category/GetCategories""
       data-response-handler=""responseHandler""></table>


<script>
        var $table = $('#table')
        var selections = []


  function get_query_params(p) {
    return {
        extraParam: 'abc',
        search: p.title,
        sort: p.sort,
        order: p.o");
            WriteLiteral(@"rder,
        limit: p.limit,
        offset: p.offset
    }
}


        function responseHandler(res) {
            $.each(res.rows, function (i, row) {
                row.state = $.inArray(row.id, selections) !== -1
            })
            return res
        }

         function detailFormatter(index, row) {
            var html = []
            $.each(row, function (key, value) {
                if (key != ""state"" && key != ""Id"" && key!='آدرس' && key!=""ردیف"")
                    html.push('<p><b>' + key + ':</b> ' + value + '</p>')
                if (key == 'آدرس') {
                    var url = '");
#nullable restore
#line 63 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Category\_CategoryTable.cshtml"
                          Write(string.Format("{0}://{1}", Context.Request.Scheme, Context.Request.Host));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/' + row.Id + '/' + value;
                    html.push('<p><b style=""float:right"">' + key + ':</b> ' + '<a href=""' + url + '"" style=""float:right;direction:ltr;margin-right:2px;"">' + url + '</a>' + '</p>')

                }
            })
            return html.join('')
        }


         function operateFormatter(value, row, index) {
        return [
            '<button type=""button"" class=""btn-link text-success"" data-toggle=""ajax-modal"" data-url=");
#nullable restore
#line 74 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Category\_CategoryTable.cshtml"
                                                                                              Write(Url.Action("RenderCategory", "Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?categoryId=\' + row.Id + \' title=\"ویرایش\">\',\r\n            \'<i class=\"fa fa-edit\"></i>\',\r\n            \'</button >\',\r\n\r\n            \'<button type=\"button\" class=\"btn-link text-danger\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 78 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Category\_CategoryTable.cshtml"
                                                                                             Write(Url.Action("Delete", "Category"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/?categoryId=' + row.Id + ' title=""حذف"">',
            '<i class=""fa fa-trash""></i>',
            '</button >'
        ].join('')
    }

     function checkBoxFormat(value, row) {
       return '<input type=""checkbox"" name=""btSelectItem"" value=""' + row.Id + '"" />';
    }


        function totalTextFormatter(data) {
            return 'تعداد'
        }

        function totalNameFormatter(data) {
            return data.length
        }


        function initTable() {
            $table.bootstrapTable('destroy').bootstrapTable({
                height: 600,
                locale: 'fa-IR',
                columns: [
                    [{
                        field: 'state',
                        checkbox: true,
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        formatter: checkBoxFormat
                    }, {
                        title: 'ردیف',
                        field");
            WriteLiteral(@": 'ردیف',
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    }, {
                        title: 'جزئیات اطلاعات دسته بندی ها',
                        colspan: 3,
                        align: 'center'
                    }],
                    [{
                        field: 'دسته',
                        title: 'دسته',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                        align: 'center'
                    }, {
                        field: 'دسته پدر',
                        title: 'دسته پدر',
                        sortable: true,
                        align: 'center'
                    }, {
                        field: 'operate',
                        title: 'عملیات',
                        align: 'center',
                        events: window.op");
            WriteLiteral("erateEvents,\r\n                        formatter: operateFormatter\r\n                    }]\r\n                ]\r\n            })\r\n        }\r\n\r\n        $(function () {\r\n            initTable()\r\n            $(\'#locale\').change(initTable)\r\n        })</script>");
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

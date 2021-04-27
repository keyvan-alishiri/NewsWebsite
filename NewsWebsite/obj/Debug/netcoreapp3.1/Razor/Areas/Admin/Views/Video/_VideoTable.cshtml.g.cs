#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed7171e7f03d5e6a5f3ea23d79a1e12ed41cd166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Video__VideoTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Video/_VideoTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7171e7f03d5e6a5f3ea23d79a1e12ed41cd166", @"/Areas/Admin/Views/Video/_VideoTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Video__VideoTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div id=\"toolbar\">\r\n        <button type=\"button\" class=\"btn btn-success\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 3 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                    Write(Url.Action("RenderVideo","Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            <i class=\"fa fa-plus\"></i> | افزودن ویدیو جدید\r\n        </button>\r\n        <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
#nullable restore
#line 6 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                   Write(Url.Action("DeleteGroup","Video"));

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
       data-url=""/Admin/Video/GetVideos""
       data-response-handler=""responseHandler""></table>


<script>
        var $table = $('#table')
        var selections = []


  function get_query_params(p) {
    return {
        extraParam: 'abc',
        search: p.title,
        sort: p.sort,
        order");
            WriteLiteral(@": p.order,
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
        var posterUrl;
        var videoUrl;
        $.each(row, function (key, value) {
            if (key == ""poster"")
               posterUrl ='");
#nullable restore
#line 63 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                      Write(string.Format("{0}://{1}", Context.Request.Scheme, Context.Request.Host));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' + '/posters/' + value;
            if (key != ""state"" && key != ""Id"" && key != ""ردیف"" && key != ""poster"" && key!=""url"")
                html.push('<p><b>' + key + ':</b> ' + value + '</p>')
            if (key == ""url"")
                videoUrl = value;
        })
            html.push('<video height=""240"" poster=""' + posterUrl + '"" controls><source src=""' + videoUrl + '"">Your browser does not support the video tag.</video>')
            return html.join('')
        }


     function operateFormatter(value, row, index) {
        return [
            '<button type=""button"" class=""btn-link text-success"" data-toggle=""ajax-modal"" data-url=");
#nullable restore
#line 76 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                              Write(Url.Action("RenderVideo", "Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral("?videoId=\' + row.Id + \' title=\"ویرایش\">\',\r\n            \'<i class=\"fa fa-edit\"></i>\',\r\n            \'</button >\',\r\n\r\n            \'<button type=\"button\" class=\"btn-link text-danger\" data-toggle=\"ajax-modal\" data-url=");
#nullable restore
#line 80 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Video\_VideoTable.cshtml"
                                                                                             Write(Url.Action("Delete", "Video"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/?videoId=' + row.Id + ' title=""حذف"">',
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
                        field: '");
            WriteLiteral(@"ردیف',
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    }, {
                        title: 'جزئیات اطلاعات ویدیو ها',
                        colspan: 3,
                        align: 'center'
                    }],
                    [{
                        field: 'عنوان ویدیو',
                        title: 'عنوان ویدیو',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                    },{
                        field: 'تاریخ انتشار',
                        title: 'تاریخ انتشار',
                        sortable: true,
                        align: 'center'
                    }, {
                        field: 'operate',
                        title: 'عملیات',
                        align: 'center',
                        events: window.operateEvents,
             ");
            WriteLiteral("           formatter: operateFormatter\r\n                    }]\r\n                ]\r\n            })\r\n        }\r\n\r\n        $(function () {\r\n            initTable()\r\n            $(\'#locale\').change(initTable)\r\n        })</script>");
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

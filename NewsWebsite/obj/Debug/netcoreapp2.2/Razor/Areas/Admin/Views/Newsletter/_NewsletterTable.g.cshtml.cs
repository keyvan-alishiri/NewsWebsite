#pragma checksum "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Newsletter\_NewsletterTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "045eff297c9182dcdd3d266819997dc1ba468b9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Newsletter__NewsletterTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Newsletter/_NewsletterTable.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Newsletter/_NewsletterTable.cshtml", typeof(AspNetCore.Areas_Admin_Views_Newsletter__NewsletterTable))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"045eff297c9182dcdd3d266819997dc1ba468b9c", @"/Areas/Admin/Views/Newsletter/_NewsletterTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"263f5f7032912694fc818ebb6bd514c8d5a64492", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Newsletter__NewsletterTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 114, true);
            WriteLiteral("\r\n    <div id=\"toolbar\">\r\n        <button type=\"button\" class=\"btn btn-danger\" data-toggle=\"ajax-modal\" data-url=\"");
            EndContext();
            BeginContext(115, 38, false);
#line 3 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Newsletter\_NewsletterTable.cshtml"
                                                                                   Write(Url.Action("DeleteGroup","Newsletter"));

#line default
#line hidden
            EndContext();
            BeginContext(153, 1936, true);
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
       data-url=""/Admin/Newsletter/GetNewsletter""
       data-response-handler=""responseHandler""></table>


<script>
        var $table = $('#table')
        var selections = []


  function get_query_params(p) {
    return {
        extraParam: 'abc',
        search: p.title,
        sort: p.sort,
    ");
            WriteLiteral(@"    order: p.order,
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
                if (key != ""state"" && key != ""Id"" && key!=""ردیف"" && key!=""IsActive"")
                    html.push('<p><b>' + key + ':</b> ' + value + '</p>')
                if(key==""Id"")
                    html.push('<p><b> ایمیل:</b> ' + value + '</p>')
            })
            return html.join('')
        }




     function operateFormatter(value, row, index) {
        return [
            '<button type=""button"" class=""btn-link text-danger"" data-toggle=""ajax-modal"" data-url=");
            EndContext();
            BeginContext(2090, 34, false);
#line 69 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Newsletter\_NewsletterTable.cshtml"
                                                                                             Write(Url.Action("Delete", "Newsletter"));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 403, true);
            WriteLiteral(@"?email=' + row.Id + ' title=""حذف"">',
            '<i class=""fa fa-trash""></i>',
            '</button >'
        ].join('')
    }

    function isActiveFormatter(value, row, index) {
       var attr = """";
       if (row.IsActive) {
           attr = ""checked"";
       }

       return [
          '<label class=""custom-toggle mb-0""> <input type=""checkbox"" data-toggle=""ajax-model"" data-url=");
            EndContext();
            BeginContext(2528, 44, false);
#line 82 "C:\Users\keyvan\Desktop\جزوه .net core\NewsWebsite\NewsWebsite\Areas\Admin\Views\Newsletter\_NewsletterTable.cshtml"
                                                                                                  Write(Url.Action("ActiveOrInactive", "Newsletter"));

#line default
#line hidden
            EndContext();
            BeginContext(2572, 2417, true);
            WriteLiteral(@"?email=' row.Id +' value=""'+row.Id+'"" '+attr+' /><span class=""custom-toggle-slider rounded-circle""></span></label>'
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
                        f");
            WriteLiteral(@"ield: 'ردیف',
                        rowspan: 2,
                        align: 'center',
                        valign: 'middle',
                        footerFormatter: totalTextFormatter
                    }, {
                        title: 'جزئیات اطلاعات خبرنامه',
                        colspan: 4,
                        align: 'center'
                    }],
                    [{
                        field: 'Id',
                        title: 'ایمیل',
                        sortable: true,
                        footerFormatter: totalNameFormatter,
                    },{
                        field: 'تاریخ عضویت',
                        title: 'تاریخ عضویت',
                        sortable: true,
                    },{
                        field: '',
                        title: 'وضعیت',
                        align: 'center',
                        formatter: isActiveFormatter
                   },{
                        field: 'operate',
        ");
            WriteLiteral(@"                title: 'عملیات',
                        align: 'center',
                        events: window.operateEvents,
                        formatter: operateFormatter
                    }]
                ]
            })
        }

        $(function () {
            initTable()
            $('#locale').change(initTable)
        })</script>");
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
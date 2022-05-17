#pragma checksum "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\ThiCu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "130a011d795b848aaa95097a5b27a489dd0c3bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ThiCu_Index), @"mvc.1.0.view", @"/Views/ThiCu/Index.cshtml")]
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
#line 1 "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\_ViewImports.cshtml"
using QuanLyDaoTao.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\_ViewImports.cshtml"
using QuanLyDaoTao.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"130a011d795b848aaa95097a5b27a489dd0c3bc8", @"/Views/ThiCu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4127fd792eb740c22f9bf7e17bc0b0179fe27ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_ThiCu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\ThiCu\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table--database\">\r\n    <div class=\"container\">\r\n        <div class=\"section--title\">\r\n            <h3>DANH SÁCH THI CỬ</h3>\r\n        </div>\r\n        <div class=\"box-bordertop\">\r\n            <table class=\"table table-hover table-bordered\"");
            BeginWriteAttribute("id", " id=\"", 426, "\"", 431, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Mã lớp</th>
                        <th>Tên môn học</th>
                        <th>Hình thức thi</th>
                        <th>Ngày thi</th>
                        <th>Mã đề thi</th>
                        <th>SL tham dự</th>
                        <th>SL vắng</th>
                        <th>Mã nhân viên</th>
                        <th>Chức năng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
    $(document).ready(function () {
        LoadClassList();
    })

    function LoadClassList() {
        $.ajax({
            url: '/ThiCu/DanhSach',
            type: 'GET',
            data: {
                id: null,
            },
            success: function (data) {
                if (data.code == 200) {
                    let stt = 0;
                    $.each(data.thicu, function (key, value) {
                        stt = stt + 1;
                        let tr = '<tr id=""' + value.id + '"">';
                        tr += '<td>' + stt + '</td>';
                        tr += '<td>' + value.maLop + '</td>';
                        tr += '<td>' + value.tenMonHoc + '</td>';
                        tr += '<td>' + value.hinhThucthi + '</td>';
                        tr += '<td>' + value.ngayThi + '</td>';
                        tr += '<td>' + value.maDeThi + '</td>';
                        tr += '<td>' + value.slThamDu + '</td>';
                        t");
                WriteLiteral(@"r += '<td>' + value.slVang + '</td>';
                        tr += '<td>' + value.maNV + '</td>';
                        tr += '<td>'
                        tr += '<button class=""btn btn-sm btn-info"" id=""btnEdit"" name=""edit""><i class=""fa fa-info-circle""></i></button>';
                        tr += '<button class=""btn btn-sm btn-danger"" id=""btnDelete"" name=""delete""><i class=""fa fa-trash""></i></button>';
                        tr += '</td>'
                        tr += '</tr>'
                        $('#table-body').append(tr);
                    });
                }
            }
        });
    }
    </script>
");
            }
            );
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

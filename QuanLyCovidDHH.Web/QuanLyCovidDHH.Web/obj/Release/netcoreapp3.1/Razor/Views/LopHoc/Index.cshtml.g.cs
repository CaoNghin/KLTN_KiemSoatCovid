#pragma checksum "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\LopHoc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a7ad0d10949a7166d332679758f9fc38f9a2a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LopHoc_Index), @"mvc.1.0.view", @"/Views/LopHoc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a7ad0d10949a7166d332679758f9fc38f9a2a1", @"/Views/LopHoc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4127fd792eb740c22f9bf7e17bc0b0179fe27ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_LopHoc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "null", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formLopHoc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\LopHoc\Index.cshtml"
  
    ViewData["Title"] = "Lớp học";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"toolbar\">\r\n    <div class=\"container\">\r\n        <h2>Lớp học</h2>\r\n        <hr />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a7ad0d10949a7166d332679758f9fc38f9a2a15443", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <label>Mã lớp</label>\r\n                    <select class=\"form-control\" id=\"search-id\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a7ad0d10949a7166d332679758f9fc38f9a2a15916", async() => {
                    WriteLiteral("- Tất cả - ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"col\">\r\n                    <label>Mã chương trình</label>\r\n                    <select class=\"form-control\" id=\"search-idCT\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a7ad0d10949a7166d332679758f9fc38f9a2a17394", async() => {
                    WriteLiteral("- Tất cả - ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row d-flex justify-content-between"" style=""padding: 15px"">
                <a class=""btn btn-success"" id=""btnCreate"">
                    <i class=""fa fa-plus""></i>
                    <span>Tạo mới</span>
                </a>
                <a class=""btn btn-danger"" id=""btnSearch"">
                    <i class=""fa fa-search""></i>
                    <span>Tìm kiếm</span>
                </a>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""table--database"">
    <div class=""container"">
        <div class=""section--title"">
            <h3>DANH SÁCH LỚP HỌC</h3>
        </div>
        <div class=""box-bordertop"">
            <table class=""table table-hover table-bordered""");
            BeginWriteAttribute("id", " id=\"", 1531, "\"", 1536, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th style=""width:4%"">STT</th>
                        <th style=""width:10%"">Mã lớp</th>
                        <th style=""width:8%"">Mã CT</th>
                        <th style=""width:13%"">Ngày khai giảng</th>
                        <th style=""width:13%"">Ngày kết thúc</th>
                        <th style=""width:8%"">Số lượng</th>
                        <th style=""width:13%"">Quyết định</th>
                        <th style=""width:13%"">Thời khóa biểu</th>
                        <th style=""width:8%"">Ghi chú</th>
                        <th style=""width:10%"">Chức năng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>
</div>

<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modalLopHoc"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a7ad0d10949a7166d332679758f9fc38f9a2a111602", async() => {
                WriteLiteral("\r\n                <h2 class=\"text-center m-2\">LỚP HỌC</h2>\r\n                <input id=\"hiddenvalue\" hidden type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2726, "\"", 2734, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                <div class=""errorTxt"" id=""errorTxt""></div>
                <div class=""form-group"">
                    <label>Mã lớp</label>
                    <input class=""form-control"" id=""maLop"" name=""maLop"" />
                </div>
                <div class=""form-group"">
                    <label>ID chương trình</label>
                    <select class=""form-control"" id=""ctDaoTaoID"" name=""ctDaoTaoID"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a7ad0d10949a7166d332679758f9fc38f9a2a112613", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group"">
                    <label>Ngày khai giảng</label>
                    <input class=""form-control"" id=""ngayKhaiGiang"" name=""ngayKhaiGiang"" placeholder=""DD/MM/YYYY"" />
                </div>
                <div class=""form-group"">
                    <label>Ngày kết thúc</label>
                    <input class=""form-control"" id=""ngayKetThuc"" name=""ngayKetThuc"" placeholder=""DD/MM/YYYY"" />
                </div>
                <div class=""form-group"">
                    <label>Số lượng học viên</label>
                    <input class=""form-control"" id=""soLuongHV"" name=""soLuongHV"" />
                </div>
                <div class=""form-group"">
                    <label>Quyết định mở lớp</label>
                    <div class=""file-info"" id=""file-info-1"">
                        <div class=""file-icon""><i class=""fa fa-file-word fa-2x""></i></div>
                        <div class=""file-content""");
                WriteLiteral(@">
                            <a class=""file-name"" id=""file-name-1""></a>
                        </div>
                    </div>
                    <div class=""custom-file"" id=""custom-file-1"">
                        <label for=""fileUpload1"">Đính kèm</label>
                        <input type=""file"" id=""fileUpload1"" name=""fileUpload1"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label>Thời khóa biểu</label>
                    <div class=""file-info"" id=""file-info-2"">
                        <div class=""file-icon""><i class=""fa fa-file-word fa-2x""></i></div>
                        <div class=""file-content"">
                            <a class=""file-name"" id=""file-name-2""></a>
                        </div>
                    </div>
                    <div class=""custom-file"" id=""custom-file-2"">
                        <label for=""fileUpload2"">Đính kèm</label>
                        <input type=""file"" id=""fileUpload");
                WriteLiteral(@"2"" name=""fileUpload2"" />
                    </div>
                </div>
                <div class=""form-group"">
                    <label>Ghi chú</label>
                    <textarea class=""form-control"" id=""ghiChu"" name=""ghiChu"" rows=""3""></textarea>
                </div>
                <div class=""form-group"">
                    <button type=""button"" class=""btn btn-primary"" id=""btnSubmit"">Lưu lại</button>
                    <button type=""button"" class=""btn btn-secondary"" id=""btnClose"" data-dismiss=""modal"">Đóng</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""modal fade"" id=""notification"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Thông báo</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
            </div>
            <div class=""modal-body"" id=""notiMessenger""></div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-success"" id=""btnConfirm"">Xác nhận</button>
                <button type=""button"" class=""btn btn-danger"" id=""btnClose"" data-dismiss=""modal"">Đóng lại</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            LoadClassList();
            LoadChuongTrinhDTData();
            ValidateForm();
            $('#ngayKhaiGiang').datepicker({ dateFormat: ""dd/mm/yy"" });
            $('#ngayKetThuc').datepicker({ dateFormat: ""dd/mm/yy"" });
        });

        function LoadClassList() {
            $.ajax({
                url: '/LopHoc/DanhSach',
                type: 'GET',
                success: function (data) {
                    if (data.code == 200) {
                        $.each(data.lophoc, function (key, value) {

                            //Convert Datetime to String
                            let today1 = new Date(value.ngayKhaiGiang);
                            let dd1 = String(today1.getDate()).padStart(2, '0');
                            let mm1 = String(today1.getMonth() + 1).padStart(2, '0'); //January is 0!
                            let yyyy1 = today1.getFullYear();
                            today1 = dd1 +");
                WriteLiteral(@" '/' + mm1 + '/' + yyyy1;

                            let today2 = new Date(value.ngayKetThuc);
                            let dd2 = String(today2.getDate()).padStart(2, '0');
                            let mm2 = String(today2.getMonth() + 1).padStart(2, '0'); //January is 0!
                            let yyyy2 = today2.getFullYear();
                            today2 = dd2 + '/' + mm2 + '/' + yyyy2;

                            let tr = '<tr id=""' + value.id + '"">';
                            tr += '<td>' + value.stt + '</td>';
                            tr += '<td>' + value.maLop + '</td>';
                            tr += '<td>' + value.maCT + '</td>';
                            tr += '<td>' + today1 + '</td>';
                            tr += '<td>' + today2 + '</td>';
                            tr += '<td>' + value.soLuongHV + '</td>';
                            tr += '<td>' + value.qdMoLop + '</td>';
                            tr += '<td>' + value.thoiKhoaBieu + '</td>';
 ");
                WriteLiteral(@"                           tr += '<td>' + value.ghiChu + '</td>';
                            tr += '<td>'
                            tr += '<button class=""btn btn-sm"" id=""btnEdit"" name=""edit"" style=""color:blue""><i class=""fa fa-info-circle""></i></button>';
                            tr += '<button class=""btn btn-sm"" id=""btnDelete"" name=""delete""><i class=""fa fa-trash"" style=""color:red""></i></button>';
                            tr += '</td>'
                            tr += '</tr>'
                            $('#table-body').append(tr);
                        });

                        // Load Searching
                        $.each(data.lophoc, function (key, value) {
                            let option1 = '<option  value=""' + value.id + '"" class=""form-control"">' + value.maLop + '</option>';
                            $('#search-id').append(option1);
                            let option2 = '<option  value=""' + value.ctDaoTaoID + '"" class=""form-control"">' + value.maCT + '</option>';");
                WriteLiteral(@"
                            $('#search-idCT').append(option2);
                        });
                    }
                }
            });
        }
        function LoadChuongTrinhDTData() {
            $.ajax({
                url: '/ChuongTrinhDaoTao/DanhSach',
                type: 'get',
                success: function (data) {
                    console.log(data.ctdt);
                    if (data.code === 200) {
                        $.each(data.ctdt, function (key, value) {
                            let option = '<option  value=""' + value.id + '"" class=""form-control"">' + value.maCT + '</option>';
                            $('#ctDaoTaoID').append(option);
                        });
                    }
                }
            })
        };
        function ResetForm() {
            $(""#maLop"").val('');
            $(""#ctDaoTaoID"").val('');
            $(""#ngayKhaiGiang"").val('');
            $(""#ngayKetThuc"").val('');
            $(""#soLuongHV"").val(");
                WriteLiteral(@"'');
            $(""#ghiChu"").val('');
            $('#fileUpload1').val('');
            $('#fileUpload2').val('');
            $('#file-name-1').text('');
            $('#file-name-2').text('');
            $('#file-name-1').attr('href', "" "");
            $('#file-name-2').attr('href', "" "");
            $('#errorTxt').empty();
        };
        function ThongBao(messenger) {
            $(""#notiMessenger"").empty();
            $(""#notiMessenger"").append(messenger);
            $(""#btnConfirm"").hide();
            $(""#notification"").modal();
        };
        function ValidateForm() {
            $(""form[id='formLopHoc']"").validate({
                rules: {
                    maLop: ""required"",
                    ctDaoTaoID: ""required"",
                    ngayKhaiGiang: ""required"",
                    ngayKetThuc: ""required"",
                    soLuongHV: {
                        required: true,
                        digits: true
                    },
                   ");
                WriteLiteral(@" fileUpload1: ""required"",
                    fileUpload2: ""required"",
                    ghiChu: { maxlength: 1024 }
                },
                messages: {
                    maLop: ""Vui lòng nhập Mã lớp"",
                    ctDaoTaoID: ""Vui lòng nhập Mã chương trình"",
                    ngayKhaiGiang: ""Vui lòng nhập Ngày khai giảng"",
                    ngayKetThuc: ""Vui lòng nhập Ngày kết thúc"",
                    soLuongHV: {
                        required: ""Vui lòng nhập Số lượng HV"",
                        digits: ""Vui lòng nhập số lớn hơn 0"",
                    },
                    fileUpload1: ""Vui lòng đính kèm file"",
                    fileUpload2: ""Vui lòng đính kèm file"",
                    ghiChu: { maxlength: ""Chiều dài không vượt quá 1024 ký tự""}
                },
                errorElement: 'div',
                errorLabelContainer: '.errorTxt',
                submitHandler: function (form) {
                }
            });
        }

       ");
                WriteLiteral(@" $(""#btnCreate"").click(function () {
            ResetForm();
            $('#file-info-1').hide();
            $('#file-info-2').hide();
            $(""#hiddenvalue"").val('');
            $(""#modalLopHoc"").modal();
        })
        $(""#btnSearch"").click(function () {
            let select1 = document.getElementById('search-id');
            let option1 = select1.options[select1.selectedIndex];
            let id = option1.value;
            let select2 = document.getElementById('search-idCT');
            let option2 = select2.options[select2.selectedIndex];
            let ctDaoTaoID = option2.value;
            $.ajax({
                url: ""LopHoc/DanhSach"",
                type: ""get"",
                data: {
                    id: id,
                    ctDaoTaoID: ctDaoTaoID
                },
                success: function (data) {
                    if (data.code === 200) {
                        if (data.code == 200) {
                            $('#table-body').em");
                WriteLiteral(@"pty();
                            $.each(data.lophoc, function (k, v) {
                                console.log(data.lophoc);
                                let tr = '<tr id=""' + value.id + '"">';
                                tr += '<td>' + value.stt + '</td>';
                                tr += '<td>' + value.maLop + '</td>';
                                tr += '<td>' + value.maCT + '</td>';
                                tr += '<td>' + today1 + '</td>';
                                tr += '<td>' + today2 + '</td>';
                                tr += '<td>' + value.soLuongHV + '</td>';
                                tr += '<td>' + value.qdMoLop + '</td>';
                                tr += '<td>' + value.thoiKhoaBieu + '</td>';
                                tr += '<td>' + value.ghiChu + '</td>';
                                tr += '<td>'
                                tr += '<button class=""btn btn-sm"" id=""btnEdit"" name=""edit"" style=""color:blue""><i class=""fa fa-info-c");
                WriteLiteral(@"ircle""></i></button>';
                                tr += '<button class=""btn btn-sm"" id=""btnDelete"" name=""delete""><i class=""fa fa-trash"" style=""color:red""></i></button>';
                                tr += '</td>'
                                tr += '</tr>'
                                $('#table-body').append(tr);
                            });
                        }
                    }
                }
            })
        })   /// Còn tìm kiếm tất cả chưa làm đc
        $(""#btnSubmit"").click(function () {
            let hiddenvalue = $('#hiddenvalue').val();

            let getdate1 = $('#ngayKhaiGiang').val().trim();
            let dd1 = getdate1.slice(0, 2);
            let mm1 = getdate1.slice(3, 5);
            let yyyy1 = getdate1.slice(6, 10);
            ngayKhaiGiang = mm1 + '-' + dd1 + '-' + yyyy1;

            let getdate2 = $('#ngayKetThuc').val().trim();
            let dd2 = getdate2.slice(0, 2);
            let mm2 = getdate2.slice(3, 5);
        ");
                WriteLiteral(@"    let yyyy2 = getdate2.slice(6, 10);
            ngayKetThuc = mm2 + '-' + dd2 + '-' + yyyy2;

            let maLop = $('#maLop').val().trim();
            let ctDaoTaoID = $('#ctDaoTaoID').val().trim();
            let soLuongHV = $('#soLuongHV').val().trim();
            let fileUpload1 = $('#fileUpload1')[0].files[0];
            let fileUpload2 = $('#fileUpload2')[0].files[0];
            let ghiChu = $('#ghiChu').val().trim();

            let formData1 = new FormData();
            formData1.append('maLop', maLop);
            formData1.append('ctDaoTaoID', ctDaoTaoID);
            formData1.append('ngayKhaiGiang', ngayKhaiGiang);
            formData1.append('ngayKetThuc', ngayKetThuc);
            formData1.append('soLuongHV', soLuongHV);
            formData1.append('fileQDMoLop', fileUpload1);
            formData1.append('fileThoiKhoaBieu', fileUpload2);
            formData1.append('ghiChu', ghiChu);

            let formData2 = new FormData();
            formData2 = formD");
                WriteLiteral(@"ata1;
            formData2.append('id', hiddenvalue);
            formData2.append('qdMoLop', $(""#file-name-1"").text());
            formData2.append('thoiKhoaBieu', $(""#file-name-2"").text());

            if ($(""#formLopHoc"").valid()) {
                if (hiddenvalue.length == 0) {
                    $.ajax({
                        url: '/LopHoc/TaoMoi',
                        type: 'post',
                        data: formData1,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                ResetForm();
                                $('#table-body').empty();
                                $('#file-info-1').hide();
                                $('#file-info-2').hide();
                                LoadClassList();
                                $('#btnClose').click();
                                ThongBao(data.m");
                WriteLiteral(@"sg);
                            }
                            else {
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
                        }
                    })
                }
                else if (hiddenvalue.length != 0) {
                    $.ajax({
                        url: '/LopHoc/LopHocChinhSua',
                        type: 'put',
                        data: formData2,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                $('#table-body').empty();
                                LoadClassList();
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
                            else {
                                $('#btnC");
                WriteLiteral(@"lose').click();
                                ThongBao(data.msg);
                            }
                        }
                    })
                }
            }
        })

        $(document).on('click', 'button[id=""btnEdit""]', function () {
            ResetForm();
            $('#file-info-1').show();
            $('#file-info-2').show();
            let id = $(this).closest('tr').attr('id');
            $('#hiddenvalue').val(id);
            $.ajax({
                url: '/LopHoc/LopHocLayID',
                type: 'get',
                data: { id: id },
                success: function (data) {
                    let today1 = new Date(data.lophoc.ngayKhaiGiang);
                    let dd1 = String(today1.getDate()).padStart(2, '0');
                    let mm1 = String(today1.getMonth() + 1).padStart(2, '0'); //January is 0!
                    let yyyy1 = today1.getFullYear();
                    today1 = dd1 + '/' + mm1 + '/' + yyyy1;

                   ");
                WriteLiteral(@" let today2 = new Date(data.lophoc.ngayKetThuc);
                    let dd2 = String(today2.getDate()).padStart(2, '0');
                    let mm2 = String(today2.getMonth() + 1).padStart(2, '0'); //January is 0!
                    let yyyy2 = today2.getFullYear();
                    today2 = dd2 + '/' + mm2 + '/' + yyyy2;


                    document.getElementById('maLop').value = data.lophoc.maLop;
                    $('#ctDaoTaoID').val(data.lophoc.ctDaoTaoID);
                    document.getElementById('ngayKhaiGiang').value = today1;
                    document.getElementById('ngayKetThuc').value = today2;
                    document.getElementById('soLuongHV').value = data.lophoc.soLuongHV;
                    document.getElementById('file-name-1').text = data.lophoc.qdMoLop;
                    document.getElementById('file-name-2').text = data.lophoc.thoiKhoaBieu;
                    document.getElementById('ghiChu').value = data.lophoc.ghiChu;
                    $(""#modalL");
                WriteLiteral(@"opHoc"").modal();
                }
            });
            $.ajax({
                url: '/FileUpload/LayTheoDoiTuongID',
                type: 'get',
                data: { doiTuongID: id },
                success: function (data) {
                    for (let i = 0; i < data.files.length ; i++) {
                        if (data.files[i].sttTep === 1) {
                            console.log(data.files[i]);
                            $('#file-name-1').attr('href', data.files[i].noiLuuTru);
                        }
                        if (data.files[i].sttTep === 2) {
                            $('#file-name-2').attr('href', data.files[i].noiLuuTru);
                        }
                    }
                }
            });
        });
        $(document).on('click', 'button[id=""btnDelete""]', function () {
            let id = $(this).closest('tr').attr('id');
            var noti = confirm(""Bạn có muốn xóa không?"");
            if (noti == true) {
              ");
                WriteLiteral(@"  $.ajax({
                    url: '/LopHoc/LopHocXoaBo',
                    type: 'delete',
                    data: { id: id },
                    success: function (data) {
                        if (data.code === 200) {
                            $('#table-body').empty();
                            LoadClassList();
                            ThongBao(data.msg);
                        }
                        else ThongBao(data.msg);
                    }
                })
            } else {
                alert(""You pressed Cancel!"");
            }
        })

        $(""#fileUpload1"").change(function () {
            let inputfile = document.getElementById(""fileUpload1"").files;
            let file = inputfile[0];
            $('#file-info-1').show();
            $('#file-name-1').text(file.name);
        });
        $(""#fileUpload2"").change(function () {
            let inputfile = document.getElementById(""fileUpload2"").files;
            let file = inputfile[0];
                WriteLiteral("\n            $(\'#file-info-2\').show();\r\n            $(\'#file-name-2\').text(file.name);\r\n        });\r\n    </script>\r\n");
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
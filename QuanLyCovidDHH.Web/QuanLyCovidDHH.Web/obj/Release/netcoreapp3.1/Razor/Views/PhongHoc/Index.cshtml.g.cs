#pragma checksum "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\PhongHoc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaf6ac2b49a8e3640183a01dfd640d919d273552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhongHoc_Index), @"mvc.1.0.view", @"/Views/PhongHoc/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaf6ac2b49a8e3640183a01dfd640d919d273552", @"/Views/PhongHoc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4127fd792eb740c22f9bf7e17bc0b0179fe27ad6", @"/Views/_ViewImports.cshtml")]
    public class Views_PhongHoc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyDaoTao.Web.Models.PhongHoc.TaoMoi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formGV"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\HueCIT\QuanLyDaoTao\quanlydt-main\QuanLyDaoTao.Web\QuanLyDaoTao.Web\Views\PhongHoc\Index.cshtml"
  
    ViewData["Title"] = "Phòng học";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table--database\">\r\n    <div class=\"container\">\r\n        <div class=\"section--title\">\r\n            <h3>DANH SÁCH THÔNG TIN PHÒNG HỌC 22</h3>\r\n            <hr />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf6ac2b49a8e3640183a01dfd640d919d2735525564", async() => {
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"col\">\r\n                        <label>Mã số</label>\r\n                        <select class=\"form-control\" id=\"timkiem-timtheomaGV\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf6ac2b49a8e3640183a01dfd640d919d2735526066", async() => {
                    WriteLiteral("- Tất cả -");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
                    <div class=""col"">
                        <label>Họ tên</label>
                        <input type=""text"" class=""form-control"" id=""timkiem-timtheoten"">
                    </div>
                    <!--  <div class=""col"">
                        <label>Skill</label>
                        <input type=""text"" class=""form-control"" id=""timkiem-timtheoskill"">
                    </div>
                    -->
                </div>
                <div class=""row d-flex justify-content-between"" style=""padding: 15px"">
                    <a class=""btn btn-success"" id=""btnAdd"" data-toggle=""modal"" data-target=""#exampleModal"">
                        <i class=""fa fa-plus""></i>
                        <span>Thêm mới</span>
                    </a>
                    <a class=""btn btn-primary"" id=""btnSearch"">
                        <i class=""fa fa-search""></i>
                        <span>Tìm kiếm</span>
        ");
                WriteLiteral("            </a>\r\n                </div>\r\n            ");
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"box-bordertop\">\r\n            <table class=\"table table-hover table-bordered\"");
            BeginWriteAttribute("id", " id=\"", 1817, "\"", 1822, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th style=""width:1%"">STT</th>
                        <th style=""width:10%"">Mã GV</th>
                        <th style=""width:15%"">Họ và tên</th>
                        <th style=""width:15%"">Địa chỉ</th>
                        <th style=""width:10%"">Số điện thoại</th>
                        <th style=""width:10%"">Email</th>
                        <th style=""width:10%"">Đơn vị công tác</th>
                        <th style=""width:10%"">Mã số thuế</th>
                        <th style=""width:5%"">Trình độ</th>
                        <th style=""width:5%"">Bằng cấp</th>
                        <th style=""width:5%"">Chứng chỉ</th>
                        <th style=""width:10%"">Chức năng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>



    <!-- Modal -->
    <div class=""modal fade"" id=""modalGV"" tabindex=""-1"" role");
            WriteLiteral(@"=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h2 class=""text-center m-2"" id=""modal-title"">GIẢNG VIÊN</h2>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaf6ac2b49a8e3640183a01dfd640d919d27355211358", async() => {
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"text\" hidden id=\"hiddenvalue\"");
                BeginWriteAttribute("value", " value=\"", 3507, "\"", 3515, 0);
                EndWriteAttribute();
                WriteLiteral(@" /> <!--Phân biệt nút Lưu lại trong Tạo mới và Chỉnh sửa-->
                        <div class=""errorTxt form-group"" id=""errorTxt""></div> <!--Khu vực validate-->
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Mã giảng viên</label>
                                    <input id=""maGV"" name=""maGV"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Họ tên</label>
                                    <input id=""tenGV"" name=""tenGV"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
     ");
                WriteLiteral(@"                       <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Địa chỉ</label>
                                    <input id=""diaChi"" name=""diaChi"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Số điện thoại</label>
                                    <input id=""soDienThoai"" name=""soDienThoai"" class=""form-control"" type=""tel"" />
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Email</label>
                ");
                WriteLiteral(@"                    <input id=""email"" name=""email"" class=""form-control"" type=""email"" />
                                </div>
                            </div>
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Nơi công tác</label>
                                    <input id=""noiCongTac"" name=""noiCongTac"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Mã số thuế</label>
                                    <input id=""maSoThue"" name=""maSoThue"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                          ");
                WriteLiteral(@"  <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Trình độ chuyên môn</label>
                                    <input id=""trinhDo"" name=""trinhDo"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label"">Bằng cấp</label>
                            <div class=""file-info"" id=""file-info-1"">
                                <div class=""file-icon""><i class=""fa fa-file-word fa-2x""></i></div>
                                <div class=""file-content"">
                                    <a class=""file-name"" id=""file-name-1""></a>
                                </div>
                            </div>
                            <div class=""custom-file"" id=""custom-file-1"">
                                <label for=""fileUp");
                WriteLiteral(@"load1"">Đính kèm</label>
                                <input type=""file"" id=""fileUpload1"" name=""fileUpload1"" />
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label class=""control-label"">Chứng chỉ</label>
                            <div class=""file-info"" id=""file-info-2"">
                                <div class=""file-icon""><i class=""fa fa-file-word fa-2x""></i></div>
                                <div class=""file-content"">
                                    <a class=""file-name"" id=""file-name-2""></a>
                                </div>
                            </div>
                            <div class=""custom-file"" id=""custom-file-2"">
                                <label for=""fileUpload2"">Đính kèm</label>
                                <input type=""file"" id=""fileUpload2"" name=""fileUpload2"" />
                            </div>
                        </div>
                    ");
                WriteLiteral(@"    <div class=""form-group"">
                            <div id=""trangThai"" name=""trangThai"">
                                <label>Trạng thái: </label>
                                <input type=""radio"" id=""trangThai"" name=""trangThai"" value=""1"" />Tạm dừng
                                <input type=""radio"" id=""trangThai"" name=""trangThai"" value=""0"" />Đang hoạt động
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <div class=""form-group"">
                            <button type=""button"" class=""btn btn-primary"" id=""btnSubmit"">Lưu lại</button>
                            <button type=""button"" class=""btn btn-secondary"" id=""btnClose"" data-dismiss=""modal"">Đóng</button>
                        </div>
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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            LoadTeacherList();

            //$('#ngayBanHanh').datepicker();

        });
        function ResetForm() {
            $(""#maGV"").val('');
            $(""#tenGV"").val('');
            $(""#diaChi"").val('');
            $(""#soDienThoai"").val('');
            $(""#email"").val('');
            $(""#noiCongTac"").val('');
            $(""#maSoThue"").val('');
            $('#trinhDo').empty();
            $('#file-name-1').text('');
            $('#file-name-2').text('');
            $('#file-name-1').attr('href', "" "");
            $('#file-name-2').attr('href', "" "");

        };
        $('#btnAdd').click(function () {
            ResetForm();
            $('#trangThai').hide();
            $('#file-info-1').hide();
            $('#file-info-2').hide();
            $('#hiddenvalue').val(''); // Hidden id
            $('#modalGV').modal();
        });
        function LoadTeacherList() {
            $.ajax({
        ");
                WriteLiteral(@"        url: 'GiangVien/DanhSach',
                type: 'GET',
                data: {
                    id: null,
                    ten:""""

                },
                success: function (data) {
                    if (data.code == 200) {
                        let stt = 0;

                        $.each(data.giangvien, function (key, value) {

                             stt = stt + 1;

                            let tr = '<tr id=""' + value.id+ '"">';
                            tr += '<td>' + stt + '</td>';
                            tr += '<td>' + value.maGV + '</td>';
                            tr += '<td >' + value.hoTen + '</td>';
                            tr += '<td>' + value.diaChi + '</td>';
                            tr += '<td>' + value.sdt + '</td>';
                            tr += '<td>' + value.email + '</td>';
                            tr += '<td>' + value.donViCongTac + '</td>';
                            tr += '<td>' + value.maSoThue + '</td>';");
                WriteLiteral(@"
                            tr += '<td>' + value.trinhDo + '</td>';
                            tr += '<td>' + value.bangCap + '</td>';
                            tr += '<td>' + value.chungChi + '</td>';
                            tr += '<td>'
                            tr += '<button class=""btn btn-sm"" name=""edit"" style=""color:green""><i class=""fa fa-info-circle""></i></button>';
                            tr += '<button class=""btn btn-sm"" name=""delete"" style=""color:red""><i class=""fa fa-trash""></i></button>';
                            tr += '</td>'
                            tr += '</tr>'
                            $('#table-body').append(tr);
                        });
                        $.each(data.giangvien, function (key, value) {
                            let option = '<option  value=""' + value.id + '"" class=""form-control"">' + value.maGV + '</option>';
                            $('#timkiem-timtheomaGV').append(option);
                        });
                    }
  ");
                WriteLiteral(@"              }
            });
        };

        $('#btnSearch').click(function () {
            let select1 = document.getElementById('timkiem-timtheomaGV');
            let option1 = select1.options[select1.selectedIndex];
            let idmagv = option1.value;
            let trangThai = $('#timkiem-timtheoten').val();
            $.ajax({
                url: 'GiangVien/DanhSach',
                type: 'GET',
                data: {
                    id: idmagv,
                   ten: trangThai,
                },
                success: function (data) {
               if (data.code == 200) {
                        let stt = 0;
                        $('#table-body').empty();
                        $.each(data.giangvien, function (key, value) {
                             stt = stt + 1;
                            //Convert Datetime to String
");
                WriteLiteral("\r\n                            let tr = \'<tr id=\"\' + value.id+ \'\">\';\r\n");
                WriteLiteral(@"                            tr += '<td>' + stt + '</td>';
                            tr += '<td>' + value.maGV + '</td>';
                            tr += '<td >' + value.hoTen + '</td>';
                            tr += '<td>' + value.diaChi + '</td>';
                            tr += '<td>' + value.sdt + '</td>';
                            tr += '<td>' + value.email + '</td>';
                            tr += '<td>' + value.donViCongTac + '</td>';
                            tr += '<td>' + value.maSoThue + '</td>';
                            tr += '<td>' + value.trinhDo + '</td>';
                            tr += '<td>' + value.bangCap + '</td>';
                            tr += '<td>' + value.chungChi + '</td>';
                            tr += '<td>'
                            tr += '<button class=""btn btn-sm"" name=""edit"" style=""color:green""><i class=""fa fa-info-circle""></i></button>';
                            tr += '<button class=""btn btn-sm"" name=""delete"" style=""color:red""><i ");
                WriteLiteral(@"class=""fa fa-trash""></i></button>';
                            tr += '</td>'
                            tr += '</tr>'
                            $('#table-body').append(tr);
                        });
                    }
                }
            });
        });

       function ThongBao(messenger) {
            $(""#notiMessenger"").empty();
            $(""#notiMessenger"").append(messenger);
            $(""#btnConfirm"").hide();
            $(""#notification"").modal();
        };

         $('#btnSubmit').click(function () {
            let hiddenvalue = $('#hiddenvalue').val();

            let maGV = $('#maGV').val().trim();
            let tenGV = $('#tenGV').val().trim();
            let diaChi = $('#diaChi').val().trim();
            let soDienThoai = $('#soDienThoai').val().trim();
            let email = $('#email').val().trim();
            let noiCongTac = $('#noiCongTac').val().trim();
            let maSoThue = $('#maSoThue').val().trim();
            let trinhDo =");
                WriteLiteral(@" $('#trinhDo').val().trim();
            let fileUpload1 = $('#fileUpload1')[0].files[0];
            let fileUpload2 = $('#fileUpload2')[0].files[0];
            let trangThai = $('input[id=""trangThai""]:checked').val();

            let formData1 = new FormData();
            formData1.append('maGV', maGV);
            formData1.append('HoTen', tenGV);
            formData1.append('diaChi', diaChi);
            formData1.append('SDT', soDienThoai);
            formData1.append('email', email);
            formData1.append('DonViCongTac', noiCongTac);
            formData1.append('maSoThue', maSoThue);
            formData1.append('trinhDo', trinhDo);
            formData1.append('filebangCap', fileUpload1);
            formData1.append('fileChungChi', fileUpload2);

            let formData2 = new FormData();
            formData2 = formData1;
            formData2.append('id', hiddenvalue);
            formData2.append('trangThai', trangThai);
            formData2.append('bangCap', $(""");
                WriteLiteral(@"#file-name-1"").text());
            formData2.append('chungChi', $(""#file-name-2"").text());

            if ($(""#formGV"").valid()) {
                if (hiddenvalue.length == 0) {
                    //Thêm mới
                    $.ajax({
                        url: '/GiangVien/TaoMoi',
                        type: 'POST',
                        data: formData1,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                console.log(formData1);
                                ResetForm();
                                $('#btnClose').click();
                                ThongBao(data.msg);
                                $('#table-body').empty();
                                LoadTeacherList();
                            } else {
                                $('#btnClose').click();
                               ");
                WriteLiteral(@" ThongBao(data.msg);
                            }
                        }
                    });
                }
                else if (hiddenvalue.length != 0) {
                    //Chỉnh sửa
                    //alert(ngayBanHanh);
                    $.ajax({
                        url: '/GiangVien/ChinhSua',
                        type: 'PUT',
                        data: formData2,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                $('#table-body').empty();
                                LoadTeacherList();
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            } else {
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
             ");
                WriteLiteral(@"           }
                    })
                }
            }
        });

         $(document).on('click', ""button[name='edit']"", function () {
            ResetForm();
            $('#file-info-1').show();
            $('#file-info-2').show();
            $('#trangThai').show();
            let id = $(this).closest('tr').attr('id');
            $('#hiddenvalue').val(id);

            $.ajax({
                url: '/GiangVien/LayTheoID',
                type: 'GET',
                data: { id: id },
                success: function (data) {
                    let $radios = $('input:radio[name=trangThai]');
                    $('#maGV').val(data.giangvien.maGV);
                    $('#tenGV').val(data.giangvien.hoTen);
                    $('#diaChi').val(data.giangvien.diaChi);
                    $('#soDienThoai').val(data.giangvien.sdt);
                    $('#email').val(data.giangvien.email);
                    $('#noiCongTac').val(data.giangvien.donViCongTac);
     ");
                WriteLiteral(@"               $('#maSoThue').val(data.giangvien.maSoThue);
                    $('#trinhDo').val(data.giangvien.trinhDo);
                    $('#file-name-1').text(data.giangvien.bangCap);
                    $('#file-name-2').text(data.giangvien.chungChi);
                    if (data.giangvien.trangThai === 0) {
                        $radios.filter('[value=0]').prop('checked', true);
                    }
                    else if (data.giangvien.trangThai === 1) {
                        $radios.filter('[value=1]').prop('checked', true);
                    }
                    $('#modalGV').modal();
                }
            });
            $.ajax({
                url: '/FileUpload/LayTheoDoiTuongID',
                type: 'get',
                data: { doiTuongID: id },
                success: function (data) {
                    for (let i = 0; i < data.files.length; i++) {
                        if (data.files[i].sttTep === 1) {
                            $('#file-na");
                WriteLiteral(@"me-1').attr('href', data.files[i].noiLuuTru);
                        }
                        if (data.files[i].sttTep === 2) {
                            $('#file-name-2').attr('href', data.files[i].noiLuuTru);
                        }
                    }
                }
            });
         });
        $(document).on('click', ""button[name='delete']"", function () {
            let id = $(this).closest('tr').attr('id');
            var noti = confirm(""Bạn có muốn xóa không?"");
            if (noti == true) {
                $.ajax({
                    url: 'GiangVien/XoaBo',
                    type: 'DELETE',
                    data: { id: id },
                    success: function (data) {
                        if (data.code == 200) {
                            $('#table-body').empty();
                            LoadTeacherList();
                            ThongBao(data.msg);
                        }
                        else ThongBao(data.msg);
            ");
                WriteLiteral(@"        }
                })
            } else {
                alert(""You pressed Cancel!"");
            }
        });
        $(""#fileUpload1"").change(function () {
            let inputfile = document.getElementById(""fileUpload1"").files;
            let file = inputfile[0];
            $('#file-info-1').show();
            $('#file-name-1').text(file.name);
        });
        $(""#fileUpload2"").change(function () {
            let inputfile = document.getElementById(""fileUpload2"").files;
            let file = inputfile[0];
            $('#file-info-2').show();
            $('#file-name-2').text(file.name);
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyDaoTao.Web.Models.PhongHoc.TaoMoi> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\KhoaLuanTotNghiep\QuanLyCovidDHH\quanlycoviddhh\QuanLyCovidDHH.Web\QuanLyCovidDHH.Web\Views\Vaccine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff70313e7c4d57145397aa8019259e3f4cc3e534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vaccine_Index), @"mvc.1.0.view", @"/Views/Vaccine/Index.cshtml")]
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
#line 1 "D:\KhoaLuanTotNghiep\QuanLyCovidDHH\quanlycoviddhh\QuanLyCovidDHH.Web\QuanLyCovidDHH.Web\Views\_ViewImports.cshtml"
using QuanLyCovidDHH.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\KhoaLuanTotNghiep\QuanLyCovidDHH\quanlycoviddhh\QuanLyCovidDHH.Web\QuanLyCovidDHH.Web\Views\_ViewImports.cshtml"
using QuanLyCovidDHH.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff70313e7c4d57145397aa8019259e3f4cc3e534", @"/Views/Vaccine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b38dad89131103367ff9d659211e15551a74304", @"/Views/_ViewImports.cshtml")]
    public class Views_Vaccine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyCovidDHH.Web.Models.Vaccine.TaoMoi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formVaccine"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\KhoaLuanTotNghiep\QuanLyCovidDHH\quanlycoviddhh\QuanLyCovidDHH.Web\QuanLyCovidDHH.Web\Views\Vaccine\Index.cshtml"
  
    ViewData["Title"] = "Vaccine";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"table--database\">\r\n    <div class=\"container\">\r\n        <div class=\"section--title\">\r\n            <h3>DANH SÁCH THÔNG TIN VACCINE </h3>\r\n            <hr />\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff70313e7c4d57145397aa8019259e3f4cc3e5344860", async() => {
                WriteLiteral(@"
               
                <div class=""row d-flex justify-content-between"" style=""padding: 15px"">
                    <a class=""btn btn-success"" id=""btnAdd"" data-toggle=""modal"" data-target=""#exampleModal"">
                        <i class=""fa fa-plus""></i>
                        <span>Thêm mới</span>
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
            WriteLiteral("\r\n        </div>\r\n        <div class=\"box-bordertop\">\r\n            <table class=\"table table-hover table-bordered\"");
            BeginWriteAttribute("id", " id=\"", 861, "\"", 866, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <thead>
                    <tr>
                        <th style=""width:10%"">STT</th>
                        <th style=""width:60%"">Tên Vaccine</th>
                        
                        <th style=""width:15%"">Chức năng</th>
                    </tr>
                </thead>
                <tbody id=""table-body""></tbody>
            </table>
        </div>
    </div>



    <!-- Modal -->
    <div class=""modal fade"" id=""modalVaccine"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h2 class=""text-center m-2"" id=""modal-title"">TRƯỜNG</h2>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff70313e7c4d57145397aa8019259e3f4cc3e5347795", async() => {
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"text\" hidden id=\"hiddenvalue\"");
                BeginWriteAttribute("value", " value=\"", 2032, "\"", 2040, 0);
                EndWriteAttribute();
                WriteLiteral(@" /> <!--Phân biệt nút Lưu lại trong Tạo mới và Chỉnh sửa-->
                        <div class=""errorTxt form-group"" id=""errorTxt""></div> <!--Khu vực validate-->
                        <div class=""row"">
                       
                            <div class=""col"">
                                <div class=""form-group"">
                                    <label class=""control-label"">Tên vaccine</label>
                                    <input id=""tenVaccine"" name=""tenVaccine"" class=""form-control"" type=""text"" />
                                </div>
                            </div>
                        </div>
                        
                    
                      
                           
                        <div class=""form-group"">
                            <div id=""trangThai"" name=""trangThai"">
                                <label>Trạng thái: </label>
                                <input type=""radio"" id=""trangThai"" name=""trangThai"" value=""1"" />Tạm ");
                WriteLiteral(@"dừng
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
            Load_Danhsach_Vaccine();
            ValidateForm();
            $('#trangThai').hide();
            //$('#ngayBanHanh').datepicker();

        });
        function ResetForm() {
            //$(""#loVaccine"").val('');
            $(""#tenVaccine"").val('');
          

        };
         function ThongBao(messenger) {
            $(""#notiMessenger"").empty();
            $(""#notiMessenger"").append(messenger);
            $(""#btnConfirm"").hide();
            $(""#notification"").modal();
        };
        function ValidateForm() {
            $(""form[id='formVaccine']"").validate({
                rules: {
               
                    tenVaccine: {
                        required: true,
                        minlength: 1,
                        maxlength: 50
                    },
                  
                   
                },
                messages: {
                 
                   ");
                WriteLiteral(@" tenVaccine: {
                        required: ""Vui lòng nhập Tên vaccine"",
                        minlength: ""Chiều dài phải lớn hơn 1 ký tự"",
                        maxlength: ""Chiều dài không vượt quá 50 ký tự""
                    },
                
                    
                },
                errorElement: 'div',
                errorLabelContainer: '.errorTxt',
                submitHandler: function (form) {
                }
            });
        }
        $('#btnAdd').click(function () {
            ResetForm();
            $('#trangThai').hide();
      
            $('#hiddenvalue').val(''); // Hidden id
            $('#modalVaccine').modal();
        });
        function Load_Danhsach_Vaccine() {
            $.ajax({
                url: 'Vaccine/DanhSach',
                type: 'GET',
                data: {
             

                },
                success: function (data) {
                    if (data.code == 200) {
                       ");
                WriteLiteral(@" let stt = 0;

                        $.each(data.vaccine, function (key, value) {

                             stt = stt + 1;

                            let tr = '<tr id=""' + value.idVaccine+ '"">';
                            tr += '<td>' + stt + '</td>';               
                            tr += '<td>' + value.tenVaccine + '</td>';
                          
                   
          
                            tr += '<td>'
                            tr += '<button class=""btn btn-sm"" name=""edit"" style=""color:green""><i class=""fa fa-info-circle""></i></button>';
                            tr += '<button class=""btn btn-sm"" name=""delete"" style=""color:red""><i class=""fa fa-trash""></i></button>';
                            tr += '</td>'
                            tr += '</tr>'
                            $('#table-body').append(tr);
                        });
                  
                    }
                }
            });
        };

        

       functi");
                WriteLiteral(@"on ThongBao(messenger) {
            $(""#notiMessenger"").empty();
            $(""#notiMessenger"").append(messenger);
            $(""#btnConfirm"").hide();
            $(""#notification"").modal();
        };

         $('#btnSubmit').click(function () {
            let hiddenvalue = $('#hiddenvalue').val();

            let tenVaccine = $('#tenVaccine').val().trim();
            let loVaccine =  null;//$('#loVaccine').val().trim();
           
            //let trangThai = $('input[id=""trangThai""]:checked').val();

            let formData1 = new FormData();

            formData1.append('tenVaccine', tenVaccine);
                        formData1.append('loVaccine', loVaccine);

         

            let formData2 = new FormData();
            formData2 = formData1;
            formData2.append('iDVaccine', hiddenvalue);
                ThongBao(hiddenvalue);
            //formData2.append('trangThai', trangThai);
           
          

            if ($(""#formVaccine"").valid()) ");
                WriteLiteral(@"{
                if (hiddenvalue.length == 0) {
                    //Thêm mới
                    $.ajax({
                        url: '/Vaccine/TaoMoi',
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
                                Load_Danhsach_Vaccine();
                            } else {
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
                        }
                    });
                }
      ");
                WriteLiteral(@"          else if (hiddenvalue.length != 0) {
                    //Chỉnh sửa
                    //alert(ngayBanHanh);
                    $.ajax({
                        url: '/Vaccine/ChinhSua',
                        type: 'PUT',
                        data: formData2,
                        contentType: false,
                        processData: false,
                        success: function (data) {
                            if (data.code == 200) {
                                $('#table-body').empty();
                                Load_Danhsach_Vaccine();
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            } else {
                                $('#btnClose').click();
                                ThongBao(data.msg);
                            }
                        }
                    })
                }
            }
        });

         $(document).on('click', ""butto");
                WriteLiteral(@"n[name='edit']"", function () {
            ResetForm();

            //$('#trangThai').show();
            let id = $(this).closest('tr').attr('id');
            $('#hiddenvalue').val(id);


            $.ajax({
                url: '/Vaccine/LayTheoID',
                type: 'GET',
                data: { id: id },
                success: function (data) {
                    let $radios = $('input:radio[name=trangThai]');
                    $('#loVaccine').val(data.vaccine.loVaccine);
                    $('#tenVaccine').val(data.vaccine.tenVaccine);
                
                    if (data.vaccine.trangThai === 0) {
                        $radios.filter('[value=0]').prop('checked', true);
                    }
                    else if (data.vaccine.trangThai === 1) {
                        $radios.filter('[value=1]').prop('checked', true);
                    }
                    $('#modalVaccine').modal();
                }
            });
  
         });
        $");
                WriteLiteral(@"(document).on('click', ""button[name='delete']"", function () {
            let id = $(this).closest('tr').attr('id');
            var noti = confirm(""Bạn có muốn xóa không?"");
            if (noti == true) {
                $.ajax({
                    url: 'Vaccine/XoaBo',
                    type: 'DELETE',
                    data: { id: id },
                    success: function (data) {
                        if (data.code == 200) {
                            $('#table-body').empty();
                            Load_Danhsach_Vaccine();
                            ThongBao(data.msg);
                        }
                        else ThongBao(data.msg);
                    }
                })
            } else {
                alert(""You pressed Cancel!"");
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyCovidDHH.Web.Models.Vaccine.TaoMoi> Html { get; private set; }
    }
}
#pragma warning restore 1591
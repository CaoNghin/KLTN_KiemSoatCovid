using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyCovidDHH.Web.Models.KhaiBaoCachLy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace QuanLyCovidDHH.Web.Controllers
{
    public class KhaiBaoCachLyController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public KhaiBaoCachLyController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index(string IDSinhVien)
        {
            ViewData["IDSinhVien"] = IDSinhVien;
            return View();
        }
        public JsonResult DanhSach( Guid? IDSinhVien,Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DoiTuongCachLy, string Ngay, string TrangThaiDuyet)
        {
            var danhsach = new List<DanhSach>();

            string url = $"{Common.Common.ApiUrl}/KhaiBaoCachLy?IDSinhVien={IDSinhVien}&IDKhoaHoc={IDKhoaHoc}&IDKhoa={IDKhoa}&IDTruong={IDTruong}&DoiTuongCachLy={DoiTuongCachLy}&Ngay={Ngay}&TrangThaiDuyet={TrangThaiDuyet}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var httpWebResponse = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = httpWebResponse.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)responseStream).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
                danhsach = JsonConvert.DeserializeObject<List<DanhSach>>(responseData);
            }
            return Json(new { code = 200, msg = "Success", khaibaocachly = danhsach });
        }
        // Tạo mới Bo Tri Phong HOc
        [HttpPost]
        public JsonResult TaoMoi(TaoMoi model)
        {


            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files\\KhaiBaoCachLy");
            string filePath1 = null;
            model.QuyetDinhCachLy = "";
            var thumuc = "";
            if (model.FileQuyetDinhCachLy != null)
            {
                filePath1 = Path.Combine(path, thumuc + model.FileQuyetDinhCachLy.FileName);

                model.QuyetDinhCachLy = thumuc + model.FileQuyetDinhCachLy.FileName;
            }
            


            try
            {
                string url = $"{Common.Common.ApiUrl}/KhaiBaoCachLy";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = JsonConvert.SerializeObject(model);
                    streamWrite.Write(json);
                }
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                if (model.FileQuyetDinhCachLy != null)
                {
                    using (FileStream fileStream = new FileStream(path: filePath1, FileMode.Create))
                    {
                        model.FileQuyetDinhCachLy.CopyTo(fileStream);
                    }
                }
              




                return Json(new { code = 200, msg = "Tạo mới thành công" });
            }
            catch (Exception ex) { return Json(new { code = 500, msg = "Tạo mới thất bại" + ex.Message }); }
        }
        [HttpPost]
        public JsonResult TaoMoi_Excel(TaoMoi model)
        {


            try
            {
                string url = $"{Common.Common.ApiUrl}/KhaiBaoCachLy/Excel";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = JsonConvert.SerializeObject(model);
                    streamWrite.Write(json);
                }
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

               

                return Json(new { code = 200, msg = "Tạo mới thành công" });
            }
            catch (Exception ex) { return Json(new { code = 500, msg = "Tạo mới thất bại" + ex.Message }); }
        }
        // Chỉnh sửa 
        [HttpGet]
        public JsonResult LayTheoID(Guid ID)
        {
            var sv = new ChinhSua();
            string url = $"{Common.Common.ApiUrl}/KhaiBaoCachLy/{ID}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var httpWebResponse = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = httpWebResponse.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
               sv = JsonConvert.DeserializeObject<ChinhSua>(responseData);
            }
            return Json(new { code = 200, msg = "Lấy ID thành công", khaibaocachly = sv });
        }

        [HttpPut]
        public IActionResult ChinhSua(ChinhSua model)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "files\\KhaiBaoCachLy");
            string filePath1 = null;
            model.QuyetDinhCachLy = "";
            var thumuc = "";
            if (model.FileQuyetDinhCachLy != null)
            {
                filePath1 = Path.Combine(path, thumuc + model.FileQuyetDinhCachLy.FileName);

                model.QuyetDinhCachLy = thumuc + model.FileQuyetDinhCachLy.FileName;
                using (FileStream fileStream = new FileStream(path: filePath1, FileMode.Create))
                {
                    model.FileQuyetDinhCachLy.CopyTo(fileStream);
                }
            }

           

            try
            {
                string url = $"{Common.Common.ApiUrl}/KhaiBaoCachLy";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";
                using (var streamWrite = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    var json = JsonConvert.SerializeObject(model);
                    streamWrite.Write(json);
                }
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();


                return Json(new { code = 200, msg = "Chỉnh sửa thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Chỉnh sửa thất bại" + ex.Message });
            }
        }


        // Xóa bỏ Phong HOc
        public JsonResult XoaBo(Guid ID)
        {
            try
            {
                bool ketqua = false;
                string url = $"{Common.Common.ApiUrl}/KhaiBaoCachLy/{ID}";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "DELETE";
                var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                {
                    string respsonseData;
                    Stream responseStream = httpWebResponse.GetResponseStream();
                    try
                    {
                        StreamReader streamReader = new StreamReader(responseStream);
                        try
                        {
                            respsonseData = streamReader.ReadToEnd();
                        }
                        finally
                        {
                            ((IDisposable)streamReader).Dispose();
                        }
                    }
                    finally
                    {
                        ((IDisposable)responseStream).Dispose();
                    }
                    ketqua = JsonConvert.DeserializeObject<bool>(respsonseData);
                }
                return Json(new { code = 200, msg = "Xóa bỏ thành công" });
            }
            catch (Exception ex)
            {
                return Json(new { code = 500, msg = "Xóa bỏ thất bại" + ex.Message });
            }
        }
    }
}

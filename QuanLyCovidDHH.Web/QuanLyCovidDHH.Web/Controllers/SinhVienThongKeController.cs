using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyCovidDHH.Web.Models.SinhVien;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace QuanLyCovidDHH.Web.Controllers
{
    public class SinhVienThongKeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DanhSach(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DaMacCovid,int TongMuiTiem, string LoaiNhom)
        {
            var danhsach = new List<DanhSach>();

            string url = $"{Common.Common.ApiUrl}/SinhVien/ThongKe?IDKhoaHoc={IDKhoaHoc}&IDKhoa={IDKhoa}&IDTruong={IDTruong}&DaMacCovid={DaMacCovid}&TongMuiTiem={TongMuiTiem}&LoaiNhom={LoaiNhom}";
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
            return Json(new { code = 200, msg = "Success", sinhvien = danhsach });
        }
        // Tạo mới Bo Tri Phong HOc
    
    }
}

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyCovidDHH.Web.Models.BenhAn;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace QuanLyCovidDHH.Web.Controllers
{
    public class BenhAnThongKeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DanhSach( Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NoiDieuTri, string TrangThaiDuyet,  int SoLuongBenhNen,string TuNgay, string DenNgay, string LoaiNhom)
        {
            var danhsach = new List<DanhSach>();

            string url = $"{Common.Common.ApiUrl}/BenhAn/ThongKe?IDSinhVien={IDSinhVien}&IDKhoaHoc={IDKhoaHoc}&IDKhoa={IDKhoa}&IDTruong={IDTruong}&NoiDieuTri={NoiDieuTri}&TrangThaiDuyet={TrangThaiDuyet}&SoLuongBenhNen={SoLuongBenhNen}&TuNgay={TuNgay}&DenNgay={DenNgay}&LoaiNhom={LoaiNhom}";
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
            return Json(new { code = 200, msg = "Success", benhan = danhsach });
        }
      
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyCovidDHH.Web.Models.KhoaHoc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Controllers
{
    public class KhoaHocController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult DanhSach(Guid? IDTruong, Guid? IDKhoa, int TuKhoa )
        {
            var danhsach = new List<DanhSach>();

            string url = $"{Common.Common.ApiUrl}/KhoaHoc?IDKhoa={IDKhoa}&IDTruong={IDTruong}&TuKhoa={TuKhoa}";
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
            return Json(new { code = 200, msg = "Success", khoahoc = danhsach });
        }
        // Tạo mới Bo Tri Phong HOc
        [HttpPost]
        public JsonResult TaoMoi(TaoMoi model)
        {


            try
            {
                string url = $"{Common.Common.ApiUrl}/KhoaHoc";
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

        // Chỉnh sửa Phong HOc
        [HttpGet]
        public JsonResult LayTheoID(Guid ID)
        {
            var k = new ChinhSua();
            string url = $"{Common.Common.ApiUrl}/KhoaHoc/{ID}";
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
               k = JsonConvert.DeserializeObject<ChinhSua>(responseData);
            }
            return Json(new { code = 200, msg = "Lấy ID thành công", khoahoc = k });
        }

        [HttpPut]
        public IActionResult ChinhSua(ChinhSua model)
        {

            try
            {
                string url = $"{Common.Common.ApiUrl}/KhoaHoc";
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
                string url = $"{Common.Common.ApiUrl}/KhoaHoc/{ID}";
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

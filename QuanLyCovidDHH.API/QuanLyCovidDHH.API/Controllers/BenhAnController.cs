using Microsoft.AspNetCore.Mvc;
using QuanLyCovidDHH.BAL.Interface;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLyCovidDHH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BenhAnController
    {
        private readonly IBenhAnService _benhAnService;
        private readonly IFileUploadService _fileUploadService;

        public BenhAnController(IBenhAnService benhAnService,
            IFileUploadService fileUploadService)
        {
            _benhAnService = benhAnService;
            _fileUploadService = fileUploadService;
        }

        // Danh sách  
        [HttpGet]
        public IEnumerable<BenhAnResponse> BenhAnDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuNgay, string DenNgay, string TrangThaiDieuTri, string TrangThaiDuyet)
        {
            return _benhAnService.BenhAnDanhSach(IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong,TuNgay,DenNgay,TrangThaiDieuTri,TrangThaiDuyet);
        }
    
        [HttpGet("ThongKe")]
        public IEnumerable<BenhAnResponse> BenhAnThongKe(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NoiDieuTri, string TrangThaiDuyet, int SoLuongBenhNen, string TuNgay, string DenNgay, string LoaiNhom)
        {
            return _benhAnService.BenhAnThongKe(IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong, NoiDieuTri, TrangThaiDuyet,SoLuongBenhNen, TuNgay, DenNgay, LoaiNhom);
        }
        // Lấy mã 
        [HttpGet("{IDBenhAn}")]
        public BenhAnResponse BenhAnLayID(Guid IDBenhAn)
        {
            return _benhAnService.BenhAnLayID(IDBenhAn);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int BenhAnChinhSua([FromBody] BenhAnRequest request)
        {
            if (request.BenhAnDinhKem != null)
            {
                string filePath1 = Path.Combine("\\files\\BenhAn", request.BenhAnDinhKem);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.BenhAnDinhKem;
                data1.NoiLuuTru = filePath1;
                data1.DoiTuongID = request.IDBenhAn;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_ChinhSua(data1);
            }

            // Truyền dữ liệu vào Database FileUpload
            return _benhAnService.BenhAnChinhSua(request);
        }

        // Tạo mới 
        [HttpPost]
        public int BenhAnTaoMoi(BenhAnRequest request)
        {
            request.IDBenhAn = Guid.NewGuid();
            string filePath1 = Path.Combine("\\files\\BenhAn", request.BenhAnDinhKem);


            // Truyền dữ liệu vào Database FileUpload
            FileUploadRequest data1 = new FileUploadRequest();

            data1.TenTep = request.BenhAnDinhKem;
            data1.NoiLuuTru = filePath1;
            data1.DoiTuongID = request.IDBenhAn;
            data1.STTTep = 1;


            _fileUploadService.FileUpload_TaoMoi(data1);


            return _benhAnService.BenhAnTaoMoi(request);
        }
        [HttpPost("Excel")]
        public int BenhAnTaoMoi_Excel(BenhAnRequest request)
        {
            request.IDBenhAn = Guid.NewGuid();

            return _benhAnService.BenhAnTaoMoi_Excel(request);
        }
        // Xóa bỏ 
        [HttpDelete("{IDBenhAn}")]
        public bool BenhAnXoaBo(Guid IDBenhAn)
        {
            return _benhAnService.BenhAnXoaBo(IDBenhAn);
        }
    }
}

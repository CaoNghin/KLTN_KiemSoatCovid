using Microsoft.AspNetCore.Mvc;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.BAL.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace QuanLyCovidDHH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietTiemController
    {
        private readonly IChiTietTiemService _chiTietTiemService;
        private readonly IFileUploadService _fileUploadService;

        public ChiTietTiemController(IChiTietTiemService chiTietTiemService,
            IFileUploadService fileUploadService)
        {
            _chiTietTiemService = chiTietTiemService;
            _fileUploadService = fileUploadService;
        }

        // Danh sách  
        [HttpGet]
        public IEnumerable<ChiTietTiemResponse> ChiTietTiemDanhSach(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet)
        {
            return _chiTietTiemService.ChiTietTiemDanhSach(IDVaccine, IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong,TrieuChungSauTiem,TrangThaiDuyet);
        }
        [HttpGet("ThongKe")]
        public IEnumerable<ChiTietTiemResponse> ChiTietTiemThongKe(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet, int MuiTiemThu, string TuNgay, string DenNgay, string LoaiNhom)
        {
            return _chiTietTiemService.ChiTietTiemThongKe(IDVaccine, IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong, TrieuChungSauTiem, TrangThaiDuyet,  MuiTiemThu, TuNgay,DenNgay, LoaiNhom);
        }

        // Lấy mã 
        [HttpGet("{IDChiTietTiem}")]
        public ChiTietTiemResponse ChiTietTiemLayID(Guid IDChiTietTiem)
        {
            return _chiTietTiemService.ChiTietTiemLayID(IDChiTietTiem);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int ChiTietTiemChinhSua([FromBody] ChiTietTiemRequest request)
        {
            if (request.ChiTietTiemDinhKem != null)
            {
                string filePath1 = Path.Combine("\\files\\ChiTietTiem", request.ChiTietTiemDinhKem);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.ChiTietTiemDinhKem;
                data1.NoiLuuTru = filePath1;
                data1.DoiTuongID = request.IDChiTietTiem;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_ChinhSua(data1);
            }

            // Truyền dữ liệu vào Database FileUpload
            return _chiTietTiemService.ChiTietTiemChinhSua(request);
        }

        // Tạo mới 
        [HttpPost]
        public int ChiTietTiemTaoMoi(ChiTietTiemRequest request)
        {
            request.IDChiTietTiem = Guid.NewGuid();
            string filePath1 = Path.Combine("\\files\\ChiTietTiem", request.ChiTietTiemDinhKem);


            // Truyền dữ liệu vào Database FileUpload
            FileUploadRequest data1 = new FileUploadRequest();

            data1.TenTep = request.ChiTietTiemDinhKem;
            data1.NoiLuuTru = filePath1;
            data1.DoiTuongID = request.IDChiTietTiem;
            data1.STTTep = 1;


            _fileUploadService.FileUpload_TaoMoi(data1);


            return _chiTietTiemService.ChiTietTiemTaoMoi(request);
        }
        [HttpPost("Excel")]
        public int ChiTietTiemTaoMoi_Excel(ChiTietTiemRequest request)
        {

            request.IDChiTietTiem = Guid.NewGuid();

            return _chiTietTiemService.ChiTietTiemTaoMoi_Excel(request);
        }

        // Xóa bỏ 
        [HttpDelete("{IDChiTietTiem}")]
        public bool ChiTietTiemXoaBo(Guid IDChiTietTiem)
        {
            return _chiTietTiemService.ChiTietTiemXoaBo(IDChiTietTiem);
        }
    }
}

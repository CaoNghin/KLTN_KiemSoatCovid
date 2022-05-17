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
    public class KhaiBaoXetNghiemController
    {
        private readonly IKhaiBaoXetNghiemService _khaiBaoXetNghiemService;
        private readonly IFileUploadService _fileUploadService;

        public KhaiBaoXetNghiemController(IKhaiBaoXetNghiemService khaiBaoXetNghiemService,
            IFileUploadService fileUploadService)
        {
            _khaiBaoXetNghiemService = khaiBaoXetNghiemService;
            _fileUploadService = fileUploadService;
        }

        // Danh sách  
        [HttpGet]
        public IEnumerable<KhaiBaoXetNghiemResponse> KhaiBaoXetNghiemDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string LoaiXetNghiem, string KetQuaXetNghiem, string Ngay, string TrangThaiDuyet)
        {
            return _khaiBaoXetNghiemService.KhaiBaoXetNghiemDanhSach(IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong, LoaiXetNghiem, KetQuaXetNghiem, Ngay, TrangThaiDuyet);
        }


        // Lấy mã 
        [HttpGet("{IDKhaiBaoXetNghiem}")]
        public KhaiBaoXetNghiemResponse KhaiBaoXetNghiemLayID(Guid IDKhaiBaoXetNghiem)
        {
            return _khaiBaoXetNghiemService.KhaiBaoXetNghiemLayID(IDKhaiBaoXetNghiem);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int KhaiBaoXetNghiemChinhSua([FromBody] KhaiBaoXetNghiemRequest request)
        {
            if (request.HinhAnhXetNghiem != null)
            {
                string filePath1 = Path.Combine("\\files\\KhaiBaoXetNghiem", request.HinhAnhXetNghiem);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.HinhAnhXetNghiem;
                data1.NoiLuuTru = filePath1;
                data1.DoiTuongID = request.IDKhaiBaoXetNghiem;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_ChinhSua(data1);
            }

            // Truyền dữ liệu vào Database FileUpload
            return _khaiBaoXetNghiemService.KhaiBaoXetNghiemChinhSua(request);
        }

        // Tạo mới 
        [HttpPost]
        public int KhaiBaoXetNghiemTaoMoi(KhaiBaoXetNghiemRequest request)
        {
            request.IDKhaiBaoXetNghiem = Guid.NewGuid();
            string filePath1 = Path.Combine("\\files\\KhaiBaoXetNghiem", request.HinhAnhXetNghiem);


            // Truyền dữ liệu vào Database FileUpload
            FileUploadRequest data1 = new FileUploadRequest();

            data1.TenTep = request.HinhAnhXetNghiem;
            data1.NoiLuuTru = filePath1;
            data1.DoiTuongID = request.IDKhaiBaoXetNghiem;
            data1.STTTep = 1;


            _fileUploadService.FileUpload_TaoMoi(data1);


            return _khaiBaoXetNghiemService.KhaiBaoXetNghiemTaoMoi(request);
        }

        // Xóa bỏ 
        [HttpDelete("{IDKhaiBaoXetNghiem}")]
        public bool KhaiBaoXetNghiemXoaBo(Guid IDKhaiBaoXetNghiem)
        {
            return _khaiBaoXetNghiemService.KhaiBaoXetNghiemXoaBo(IDKhaiBaoXetNghiem);
        }
    }
}

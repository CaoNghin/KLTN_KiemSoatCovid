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
    public class KhaiBaoCachLyController
    {
        private readonly IKhaiBaoCachLyService _khaiBaoCachLyService;
        private readonly IFileUploadService _fileUploadService;

        public KhaiBaoCachLyController(IKhaiBaoCachLyService khaiBaoCachLyService,
            IFileUploadService fileUploadService)
        {
            _khaiBaoCachLyService = khaiBaoCachLyService;
            _fileUploadService = fileUploadService;
        }

        // Danh sách  
        [HttpGet]
        public IEnumerable<KhaiBaoCachLyResponse> KhaiBaoCachLyDanhSach(Guid? IDSinhVien , Guid? IDKhoaHoc , Guid? IDKhoa , Guid? IDTruong, string DoiTuongCachLy, string Ngay, string TrangThaiDuyet)
        {
            return _khaiBaoCachLyService.KhaiBaoCachLyDanhSach(IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong,  DoiTuongCachLy,  Ngay,  TrangThaiDuyet);
        }

        // Lấy mã 
        [HttpGet("{IDKhaiBaoCachLy}")]
        public KhaiBaoCachLyResponse KhaiBaoCachLyLayID(Guid IDKhaiBaoCachLy)
        {
            return _khaiBaoCachLyService.KhaiBaoCachLyLayID(IDKhaiBaoCachLy);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int KhaiBaoCachLyChinhSua([FromBody] KhaiBaoCachLyRequest request)
        {
            if (request.QuyetDinhCachLy != null)
            {
                string filePath1 = Path.Combine("\\files\\KhaiBaoCachLy", request.QuyetDinhCachLy);
                FileUploadRequest data1 = new FileUploadRequest();
                data1.TenTep = request.QuyetDinhCachLy;
                data1.NoiLuuTru = filePath1;
                data1.DoiTuongID = request.IDKhaiBaoCachLy;
                data1.STTTep = 1;
                _fileUploadService.FileUpload_ChinhSua(data1);
            }

            // Truyền dữ liệu vào Database FileUpload
            return _khaiBaoCachLyService.KhaiBaoCachLyChinhSua(request);
        }

        // Tạo mới 
        [HttpPost]
        public int KhaiBaoCachLyTaoMoi(KhaiBaoCachLyRequest request)
        {
            request.IDKhaiBaoCachLy = Guid.NewGuid();
            string filePath1 = Path.Combine("\\files\\KhaiBaoCachLy", request.QuyetDinhCachLy);


            // Truyền dữ liệu vào Database FileUpload
            FileUploadRequest data1 = new FileUploadRequest();

            data1.TenTep = request.QuyetDinhCachLy;
            data1.NoiLuuTru = filePath1;
            data1.DoiTuongID = request.IDKhaiBaoCachLy;
            data1.STTTep = 1;


            _fileUploadService.FileUpload_TaoMoi(data1);


            return _khaiBaoCachLyService.KhaiBaoCachLyTaoMoi(request);
        }

        // Xóa bỏ 
        [HttpDelete("{IDKhaiBaoCachLy}")]
        public bool KhaiBaoCachLyXoaBo(Guid IDKhaiBaoCachLy)
        {
            return _khaiBaoCachLyService.KhaiBaoCachLyXoaBo(IDKhaiBaoCachLy);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.BAL.Interface;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoTheoDoiController
    {
        private readonly ISoTheoDoiService _SoTheoDoiService;
        public SoTheoDoiController(ISoTheoDoiService SoTheoDoiService)
        {
            _SoTheoDoiService = SoTheoDoiService;
        }
        // Danh sách  
        [HttpGet]
        public IEnumerable<SoTheoDoiResponse> SoTheoDoiDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NgayTheoDoi)
        {
            return _SoTheoDoiService.SoTheoDoiDanhSach(IDBenhAn, IDSinhVien, IDKhoaHoc, IDKhoa, IDTruong,NgayTheoDoi);
        }
        // Lấy mã 
        [HttpGet("{IDSoTheoDoi}")]
        public SoTheoDoiResponse SoTheoDoiLayID(Guid IDSoTheoDoi)
        {
            return _SoTheoDoiService.SoTheoDoiLayID(IDSoTheoDoi);
        }

        // Chỉnh sửa 
        [HttpPut]
        public int SoTheoDoiChinhSua([FromBody] SoTheoDoiRequest request)
        {
            return _SoTheoDoiService.SoTheoDoiChinhSua(request);
        }
        // Tạo mới 
        [HttpPost]
        public int SoTheoDoiTaoMoi(SoTheoDoiRequest request)
        {
            request.IDSoTheoDoi = Guid.NewGuid();
            return _SoTheoDoiService.SoTheoDoiTaoMoi(request);
        }

        // Xóa bỏ 
        [HttpDelete("{IDSoTheoDoi}")]
        public bool SoTheoDoiXoaBo(Guid IDSoTheoDoi)
        {
            return _SoTheoDoiService.SoTheoDoiXoaBo(IDSoTheoDoi);
        }
    }
}

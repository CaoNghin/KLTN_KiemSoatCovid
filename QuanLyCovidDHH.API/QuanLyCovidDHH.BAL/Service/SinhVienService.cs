using QuanLyCovidDHH.BAL.Interface;
using QuanLyCovidDHH.DAL.Interface;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Service
{
    public class SinhVienService : ISinhVienService
    {
        private readonly ISinhVienRepository _SinhVienRepository;
        public SinhVienService(ISinhVienRepository SinhVienRepository)
        {
            _SinhVienRepository = SinhVienRepository;
        }

        public List<SinhVienResponse> SinhVienDanhSach(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuKhoa)
        {
            return _SinhVienRepository.SinhVienDanhSach( IDKhoaHoc,  IDKhoa,  IDTruong,TuKhoa);
        }
        public List<SinhVienResponse> SinhVienThongKe(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DaMacCovid, int TongMuiTiem, string LoaiNhom)
        {
            return _SinhVienRepository.SinhVienThongKe(IDKhoaHoc, IDKhoa, IDTruong, DaMacCovid,TongMuiTiem,LoaiNhom);
        }
        public SinhVienResponse SinhVienLayID(Guid IDSinhVien)
        {
            return _SinhVienRepository.SinhVienLayID(IDSinhVien);
        }
        public SinhVienResponse SinhVienLayTenDangNhap(string TenDangNhap)
        {
            return _SinhVienRepository.SinhVienLayTenDangNhap(TenDangNhap);
        }

        public int SinhVienChinhSua(SinhVienRequest request)
        {
            return _SinhVienRepository.SinhVienChinhSua(request);
        }

        public int SinhVienTaoMoi(SinhVienRequest request)
        {
            return _SinhVienRepository.SinhVienTaoMoi(request);
        }
        public int SinhVienTaoMoi_Excel(SinhVienRequest request)
        {
            return _SinhVienRepository.SinhVienTaoMoi_Excel(request);
        }

        public bool SinhVienXoaBo(Guid ID)
        {
            return _SinhVienRepository.SinhVienXoaBo(ID);
        }
    }
}

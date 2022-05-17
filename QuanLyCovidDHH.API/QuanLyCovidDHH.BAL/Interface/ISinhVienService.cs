using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface ISinhVienService
    {
        List<SinhVienResponse> SinhVienDanhSach(Guid? IDKhoaHoc, Guid? IDKhoa,  Guid? IDTruong, string TuKhoa);
        List<SinhVienResponse> SinhVienThongKe(Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DaMacCovid, int TongMuiTiem, string LoaiNhom);
        SinhVienResponse SinhVienLayID(Guid IDSinhVien);
        SinhVienResponse SinhVienLayTenDangNhap(string TenDangNhap);
        int SinhVienChinhSua(SinhVienRequest request);
        int SinhVienTaoMoi(SinhVienRequest request);
        int SinhVienTaoMoi_Excel(SinhVienRequest request);
        bool SinhVienXoaBo(Guid ID);
    }
}

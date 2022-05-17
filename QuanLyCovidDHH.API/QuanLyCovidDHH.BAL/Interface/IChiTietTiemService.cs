using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IChiTietTiemService
    {
        IList<ChiTietTiemResponse> ChiTietTiemDanhSach(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet);
        IList<ChiTietTiemResponse> ChiTietTiemThongKe(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet, int MuiTiemThu, string TuNgay, string DenNgay, string LoaiNhom);
        ChiTietTiemResponse ChiTietTiemLayID(Guid IDIDChiTietTiem);
        int ChiTietTiemChinhSua(ChiTietTiemRequest request);
        int ChiTietTiemTaoMoi(ChiTietTiemRequest request);
        int ChiTietTiemTaoMoi_Excel(ChiTietTiemRequest request);
        bool ChiTietTiemXoaBo(Guid IDIDChiTietTiem);

    }
}

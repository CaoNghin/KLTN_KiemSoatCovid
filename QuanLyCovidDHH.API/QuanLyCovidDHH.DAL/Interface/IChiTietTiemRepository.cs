using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IChiTietTiemRepository
    {
        IList<ChiTietTiemResponse> ChiTietTiemDanhSach(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet);
        public IList<ChiTietTiemResponse> ChiTietTiemThongKe(Guid? IDVaccine, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TrieuChungSauTiem, string TrangThaiDuyet, int MuiTiemThu, string TuNgay, string DenNgay, string LoaiNhom);

        ChiTietTiemResponse ChiTietTiemLayID(Guid IDChiTietTiem);
       
        int ChiTietTiemChinhSua(ChiTietTiemRequest request);
        int ChiTietTiemTaoMoi(ChiTietTiemRequest request);
        int ChiTietTiemTaoMoi_Excel(ChiTietTiemRequest request);
        bool ChiTietTiemXoaBo(Guid IDChiTietTiem);
    }
}

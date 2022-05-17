using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IBenhAnRepository
    {
        IList<BenhAnResponse> BenhAnDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuNgay, string DenNgay, string TrangThaiDieuTri, string TrangThaiDuyet);
        IList<BenhAnResponse> BenhAnThongKe(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NoiDieuTri, string TrangThaiDuyet, int SoLuongBenhNen, string TuNgay, string DenNgay, string LoaiNhom);
        BenhAnResponse BenhAnLayID(Guid IDBenhAn);
        int BenhAnChinhSua(BenhAnRequest request);
        int BenhAnTaoMoi(BenhAnRequest request);
        int BenhAnTaoMoi_Excel(BenhAnRequest request);
        bool BenhAnXoaBo(Guid IDBenhAn);
    }
}

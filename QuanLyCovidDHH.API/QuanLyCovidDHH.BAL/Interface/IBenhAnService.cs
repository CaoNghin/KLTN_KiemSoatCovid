using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IBenhAnService
    {
        IList<BenhAnResponse> BenhAnDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string TuNgay, string DenNgay, string TrangThaiDieuTri, string TrangThaiDuyet);
        IList<BenhAnResponse> BenhAnThongKe(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NoiDieuTri, string TrangThaiDuyet, int SoLuongBenhNen, string TuNgay, string DenNgay, string LoaiNhom);

        BenhAnResponse BenhAnLayID(Guid IDIDBenhAn);
        int BenhAnChinhSua(BenhAnRequest request);
        int BenhAnTaoMoi(BenhAnRequest request);
        int BenhAnTaoMoi_Excel(BenhAnRequest request);
        bool BenhAnXoaBo(Guid IDIDBenhAn);

    }
}

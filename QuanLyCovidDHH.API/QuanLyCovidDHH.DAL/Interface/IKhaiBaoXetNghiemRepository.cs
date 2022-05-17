using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IKhaiBaoXetNghiemRepository
    {
        IList<KhaiBaoXetNghiemResponse> KhaiBaoXetNghiemDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string LoaiXetNghiem, string KetQuaXetNghiem, string Ngay, string TrangThaiDuyet);
        KhaiBaoXetNghiemResponse KhaiBaoXetNghiemLayID(Guid IDKhaiBaoXetNghiem);
        int KhaiBaoXetNghiemChinhSua(KhaiBaoXetNghiemRequest request);
        int KhaiBaoXetNghiemTaoMoi(KhaiBaoXetNghiemRequest request);
        bool KhaiBaoXetNghiemXoaBo(Guid IDKhaiBaoXetNghiem);
    }
}

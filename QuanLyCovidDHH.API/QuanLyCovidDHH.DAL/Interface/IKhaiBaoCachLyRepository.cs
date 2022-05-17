using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IKhaiBaoCachLyRepository
    {
        IList<KhaiBaoCachLyResponse> KhaiBaoCachLyDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DoiTuongCachLy, string Ngay, string TrangThaiDuyet);
        KhaiBaoCachLyResponse KhaiBaoCachLyLayID(Guid IDKhaiBaoCachLy);
        int KhaiBaoCachLyChinhSua(KhaiBaoCachLyRequest request);
        int KhaiBaoCachLyTaoMoi(KhaiBaoCachLyRequest request);
        bool KhaiBaoCachLyXoaBo(Guid IDKhaiBaoCachLy);
    }
}

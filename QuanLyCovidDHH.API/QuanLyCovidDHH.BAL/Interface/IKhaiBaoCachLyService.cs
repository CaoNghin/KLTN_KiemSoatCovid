using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IKhaiBaoCachLyService
    {
        IList<KhaiBaoCachLyResponse> KhaiBaoCachLyDanhSach(Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string DoiTuongCachLy, string Ngay, string TrangThaiDuyet);
        KhaiBaoCachLyResponse KhaiBaoCachLyLayID(Guid IDIDKhaiBaoCachLy);
        int KhaiBaoCachLyChinhSua(KhaiBaoCachLyRequest request);
        int KhaiBaoCachLyTaoMoi(KhaiBaoCachLyRequest request);
        bool KhaiBaoCachLyXoaBo(Guid IDIDKhaiBaoCachLy);

    }
}

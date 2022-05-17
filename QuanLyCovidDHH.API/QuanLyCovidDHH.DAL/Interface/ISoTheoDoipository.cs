using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface ISoTheoDoiRepository
    {
        IList<SoTheoDoiResponse> SoTheoDoiDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NgayTheoDoi);
        SoTheoDoiResponse SoTheoDoiLayID(Guid IDSoTheoDoi);
        int SoTheoDoiChinhSua(SoTheoDoiRequest request);
        int SoTheoDoiTaoMoi(SoTheoDoiRequest request);
        bool SoTheoDoiXoaBo(Guid IDSoTheoDoi);
    }
}

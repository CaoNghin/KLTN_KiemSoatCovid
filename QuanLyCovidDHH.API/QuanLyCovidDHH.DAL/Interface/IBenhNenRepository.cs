using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IBenhNenRepository
    {
        IList<BenhNenResponse> BenhNenDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong);
        BenhNenResponse BenhNenLayID(Guid IDBenhNen);
        int BenhNenChinhSua(BenhNenRequest request);
        int BenhNenTaoMoi(BenhNenRequest request);
        bool BenhNenXoaBo(Guid IDBenhNen);
    }
}

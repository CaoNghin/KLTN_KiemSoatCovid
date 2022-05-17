using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IBenhNenService
    {
        IList<BenhNenResponse> BenhNenDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong);
        BenhNenResponse BenhNenLayID(Guid IDIDBenhNen);
        int BenhNenChinhSua(BenhNenRequest request);
        int BenhNenTaoMoi(BenhNenRequest request);
        bool BenhNenXoaBo(Guid IDIDBenhNen);

    }
}

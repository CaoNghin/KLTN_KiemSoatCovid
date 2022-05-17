using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface ISoTheoDoiService
    {
        IList<SoTheoDoiResponse> SoTheoDoiDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NgayTheoDoi);
        SoTheoDoiResponse SoTheoDoiLayID(Guid IDIDSoTheoDoi);
        int SoTheoDoiChinhSua(SoTheoDoiRequest request);
        int SoTheoDoiTaoMoi(SoTheoDoiRequest request);
        bool SoTheoDoiXoaBo(Guid IDIDSoTheoDoi);

    }
}

using QuanLyCovidDHH.Domain.Response;
using QuanLyCovidDHH.Domain.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IHauCovidService
    {
        IList<HauCovidResponse> HauCovidDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong);
        HauCovidResponse HauCovidLayID(Guid IDIDHauCovid);
        int HauCovidChinhSua(HauCovidRequest request);
        int HauCovidTaoMoi(HauCovidRequest request);
        bool HauCovidXoaBo(Guid IDIDHauCovid);

    }
}

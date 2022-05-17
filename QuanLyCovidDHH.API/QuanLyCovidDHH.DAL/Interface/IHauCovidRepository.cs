using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IHauCovidRepository
    {
        IList<HauCovidResponse> HauCovidDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong);
        HauCovidResponse HauCovidLayID(Guid IDHauCovid);
        int HauCovidChinhSua(HauCovidRequest request);
        int HauCovidTaoMoi(HauCovidRequest request);
        bool HauCovidXoaBo(Guid IDHauCovid);
    }
}

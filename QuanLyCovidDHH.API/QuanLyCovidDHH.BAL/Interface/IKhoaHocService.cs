using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IKhoaHocService
    {
        List<KhoaHocResponse> KhoaHocDanhSach( Guid? IDKhoa,Guid? IDTruong, int TuKhoa);
        KhoaHocResponse KhoaHocLayID(Guid IDKhoaHoc);
        int KhoaHocChinhSua(KhoaHocRequest request);
        int KhoaHocTaoMoi(KhoaHocRequest request);
        bool KhoaHocXoaBo(Guid IDKhoaHoc);
    }
}

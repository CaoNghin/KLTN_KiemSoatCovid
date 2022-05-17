using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface IKhoaService
    {
        List<KhoaResponse> KhoaDanhSach( Guid? IDTruong, string TuKhoa);
        KhoaResponse KhoaLayID(Guid IDKhoa);
        int KhoaChinhSua(KhoaRequest request);
        int KhoaTaoMoi(KhoaRequest request);
        bool KhoaXoaBo(Guid IDKhoa);
    }
}

using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.BAL.Interface
{
    public interface ITruongService
    {
        List<TruongResponse> TruongDanhSach();
        TruongResponse TruongLayID(Guid IDTruong);
        int TruongChinhSua(TruongRequest request);
        int TruongTaoMoi(TruongRequest request);
        bool TruongXoaBo(Guid IDTruong);
    }
}

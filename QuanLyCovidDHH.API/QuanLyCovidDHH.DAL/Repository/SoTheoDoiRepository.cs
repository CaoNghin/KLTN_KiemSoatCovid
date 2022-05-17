using Dapper;
using QuanLyCovidDHH.DAL.Interface;
using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyCovidDHH.DAL.Repository
{
    public class SoTheoDoiRepository : DataBaseRepository, ISoTheoDoiRepository
    {
        // Danh sách 
        public IList<SoTheoDoiResponse> SoTheoDoiDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong, string NgayTheoDoi)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhAn", IDBenhAn);
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@NgayTheoDoi", NgayTheoDoi);
                IList<SoTheoDoiResponse> danhSach = SqlMapper.Query<SoTheoDoiResponse>(connect, "SPSoTheoDoi_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã 
        public SoTheoDoiResponse SoTheoDoiLayID(Guid IDSoTheoDoi)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDSoTheoDoi", IDSoTheoDoi);
            SoTheoDoiResponse laySoTheoDoi = SqlMapper.Query<SoTheoDoiResponse>(connect, "SPSoTheoDoi_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return laySoTheoDoi;
        }

        // Chỉnh sửa 
        public int SoTheoDoiChinhSua(SoTheoDoiRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSoTheoDoi", request.IDSoTheoDoi);
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@NgayTheoDoi", request.NgayTheoDoi);
                parameters.Add("@NongDoSpO2", request.NongDoSpO2);
                parameters.Add("@Sot", request.Sot);
                parameters.Add("@Ho", request.Ho);
                parameters.Add("@KhoTho", request.KhoTho);
                parameters.Add("@DauHong", request.DauHong);
                parameters.Add("@MatViGiac", request.MatViGiac);
                parameters.Add("@MatKhuuGiac", request.MatKhuuGiac);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPSoTheoDoi_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int SoTheoDoiTaoMoi(SoTheoDoiRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSoTheoDoi", request.IDSoTheoDoi);
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@NgayTheoDoi", request.NgayTheoDoi);
                parameters.Add("@NongDoSpO2", request.NongDoSpO2);
                parameters.Add("@Sot", request.Sot);
                parameters.Add("@Ho", request.Ho);
                parameters.Add("@KhoTho", request.KhoTho);
                parameters.Add("@DauHong", request.DauHong);
                parameters.Add("@MatViGiac", request.MatViGiac);
                parameters.Add("@MatKhuuGiac", request.MatKhuuGiac);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPSoTheoDoi_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SoTheoDoiXoaBo(Guid IDSoTheoDoi)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDSoTheoDoi", IDSoTheoDoi);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPSoTheoDoi_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

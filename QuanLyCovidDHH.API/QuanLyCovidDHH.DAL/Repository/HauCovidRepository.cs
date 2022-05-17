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
    public class HauCovidRepository : DataBaseRepository, IHauCovidRepository
    {
        // Danh sách 
        public IList<HauCovidResponse> HauCovidDanhSach(Guid? IDBenhAn, Guid? IDSinhVien, Guid? IDKhoaHoc, Guid? IDKhoa, Guid? IDTruong)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDBenhAn", IDBenhAn);
                parameters.Add("@IDSinhVien", IDSinhVien);
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                IList<HauCovidResponse> danhSach = SqlMapper.Query<HauCovidResponse>(connect, "SPHauCovid_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhSach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Lấy mã 
        public HauCovidResponse HauCovidLayID(Guid IDHauCovid)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDHauCovid", IDHauCovid);
            HauCovidResponse layHauCovid = SqlMapper.Query<HauCovidResponse>(connect, "SPHauCovid_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return layHauCovid;
        }

        // Chỉnh sửa 
        public int HauCovidChinhSua(HauCovidRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDHauCovid", request.IDHauCovid);
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@NgayTheoDoi", request.NgayTheoDoi);
                parameters.Add("@NongDoSpO2", request.NongDoSpO2);
                parameters.Add("@Sot", request.Sot);
                parameters.Add("@Ho", request.Ho);
                parameters.Add("@KhoTho", request.KhoTho);
                parameters.Add("@MetMoi", request.MetMoi);
                parameters.Add("@DaiCoKhop", request.DauCoKhop);
                parameters.Add("@RoiLoanTieuHoa", request.RoiLoanTieuHoa);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPHauCovid_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Tạo mới 
        public int HauCovidTaoMoi(HauCovidRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDHauCovid", request.IDHauCovid);
                parameters.Add("@IDBenhAn", request.IDBenhAn);
                parameters.Add("@NgayTheoDoi", request.NgayTheoDoi);
                parameters.Add("@NongDoSpO2", request.NongDoSpO2);
                parameters.Add("@Sot", request.Sot);
                parameters.Add("@Ho", request.Ho);
                parameters.Add("@KhoTho", request.KhoTho);
                parameters.Add("@MetMoi", request.MetMoi);
                parameters.Add("@DaiCoKhop", request.DauCoKhop);
                parameters.Add("@RoiLoanTieuHoa", request.RoiLoanTieuHoa);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPHauCovid_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool HauCovidXoaBo(Guid IDHauCovid)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDHauCovid", IDHauCovid);
                var result = SqlMapper.ExecuteScalar<bool>(connect, "SPHauCovid_Xoa", param: parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}

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
    public class KhoaRepository : DataBaseRepository, IKhoaRepository
    {
        public List<KhoaResponse> KhoaDanhSach(Guid? IDTruong, string TuKhoa)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@TuKhoa", TuKhoa);
                List<KhoaResponse> danhsach = SqlMapper.Query<KhoaResponse>(connect, "SPKhoa_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public KhoaResponse KhoaLayID(Guid IDKhoa)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDKhoa", IDKhoa);
            KhoaResponse getID = SqlMapper.Query<KhoaResponse>(connect, "SPKhoa_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int KhoaChinhSua(KhoaRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoa", request.IDKhoa);
                parameters.Add("@IDTruong", request.IDTruong);
                parameters.Add("@TenKhoa", request.TenKhoa);
                parameters.Add("@MaKhoa", request.MaKhoa);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhoa_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int KhoaTaoMoi(KhoaRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDTruong", request.IDTruong);
                parameters.Add("@TenKhoa", request.TenKhoa);
                parameters.Add("@MaKhoa", request.MaKhoa);

                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhoa_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KhoaXoaBo(Guid IDKhoa)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoa", IDKhoa);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPKhoa_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

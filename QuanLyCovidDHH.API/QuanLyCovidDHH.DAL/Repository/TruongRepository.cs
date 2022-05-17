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
    public class TruongRepository : DataBaseRepository, ITruongRepository
    {
        public List<TruongResponse> TruongDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                List<TruongResponse> danhsach = SqlMapper.Query<TruongResponse>(connect, "SPTruong_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TruongResponse TruongLayID(Guid IDTruong)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDTruong", IDTruong);
            TruongResponse getID = SqlMapper.Query<TruongResponse>(connect, "SPTruong_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int TruongChinhSua(TruongRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@IDTruong", request.IDTruong);
                parameters.Add("@TenTruong", request.TenTruong);
                parameters.Add("@MaTruong", request.MaTruong);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPTruong_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int TruongTaoMoi(TruongRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@TenTruong", request.TenTruong);
                parameters.Add("@MaTruong", request.MaTruong);

                var id = SqlMapper.ExecuteScalar<int>(connect, "SPTruong_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool TruongXoaBo(Guid IDTruong)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDTruong", IDTruong);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPTruong_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

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
    public class KhoaHocRepository : DataBaseRepository, IKhoaHocRepository
    {
        public List<KhoaHocResponse> KhoaHocDanhSach(Guid? IDKhoa, Guid? IDTruong, int TuKhoa)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@IDKhoa", IDKhoa);
                parameters.Add("@IDTruong", IDTruong);
                parameters.Add("@TuKhoa", TuKhoa);
                List<KhoaHocResponse> danhsach = SqlMapper.Query<KhoaHocResponse>(connect, "SPKhoaHoc_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public KhoaHocResponse KhoaHocLayID(Guid IDKhoaHoc)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDKhoaHoc", IDKhoaHoc);
            KhoaHocResponse getID = SqlMapper.Query<KhoaHocResponse>(connect, "SPKhoaHoc_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int KhoaHocChinhSua(KhoaHocRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoaHoc", request.IDKhoaHoc);
                parameters.Add("@IDKhoa", request.IDKhoa);
                parameters.Add("@KhoaHoc", request.KhoaHoc);
                parameters.Add("@NamTuyenSinh", request.NamTuyenSinh);
                parameters.Add("@MaKhoaHoc", request.MaKhoaHoc);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhoaHoc_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int KhoaHocTaoMoi(KhoaHocRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoa", request.IDKhoa);
                parameters.Add("@KhoaHoc", request.KhoaHoc);
                parameters.Add("@NamTuyenSinh", request.NamTuyenSinh);
                parameters.Add("@MaKhoaHoc", request.MaKhoaHoc);

                var id = SqlMapper.ExecuteScalar<int>(connect, "SPKhoaHoc_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool KhoaHocXoaBo(Guid IDKhoaHoc)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDKhoaHoc", IDKhoaHoc);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPKhoaHoc_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

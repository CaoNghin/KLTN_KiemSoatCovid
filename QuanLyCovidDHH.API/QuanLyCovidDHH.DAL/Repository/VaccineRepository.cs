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
    public class VaccineRepository : DataBaseRepository, IVaccineRepository
    {
        public List<VaccineResponse> VaccineDanhSach()
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                List<VaccineResponse> danhsach = SqlMapper.Query<VaccineResponse>(connect, "SPVaccine_DanhSach", param: parameters, commandType: CommandType.StoredProcedure).ToList();
                return danhsach;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VaccineResponse VaccineLayID(Guid IDVaccine)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@IDVaccine", IDVaccine);
            VaccineResponse getID = SqlMapper.Query<VaccineResponse>(connect, "SPVaccine_LayID", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

        public int VaccineChinhSua(VaccineRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@IDVaccine", request.IDVaccine);
                parameters.Add("@TenVaccine", request.TenVaccine);
                parameters.Add("@LoVaccine", request.LoVaccine);
                var id = SqlMapper.ExecuteScalar<int>(connect, "SPVaccine_ChinhSua", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int VaccineTaoMoi(VaccineRequest request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();

                parameters.Add("@TenVaccine", request.TenVaccine);
                parameters.Add("@LoVaccine", request.LoVaccine);

                var id = SqlMapper.ExecuteScalar<int>(connect, "SPVaccine_TaoMoi", param: parameters, commandType: CommandType.StoredProcedure);
                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public bool VaccineXoaBo(Guid IDVaccine)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@IDVaccine", IDVaccine);
                bool result = SqlMapper.ExecuteScalar<bool>(connect, "SPVaccine_Xoa", parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

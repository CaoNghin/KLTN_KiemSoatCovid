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
    public class RoleRepository : DataBaseRepository, IRoleRepository
    {
        
        public RoleResponse Role_Lay( string UserName,string RoleName)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@UserName", UserName);
            parameters.Add("@RoleName", RoleName);
            RoleResponse getID = SqlMapper.Query<RoleResponse>(connect, "SPRole_Lay", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return getID;
        }

     
    }
}

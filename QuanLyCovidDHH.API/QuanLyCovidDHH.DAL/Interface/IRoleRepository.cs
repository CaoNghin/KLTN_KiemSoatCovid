using QuanLyCovidDHH.Domain.Request;
using QuanLyCovidDHH.Domain.Response;
using System;
using System.Collections.Generic;

namespace QuanLyCovidDHH.DAL.Interface
{
    public interface IRoleRepository
    {
        RoleResponse Role_Lay(string UserName, string RoleName);
        
    }
}

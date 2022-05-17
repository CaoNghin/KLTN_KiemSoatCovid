using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuanLyCovidDHH.Web.Models.Role;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QuanLyCovidDHH.Web.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public async Task<IActionResult> Role_Lay(string UserName, string RoleName)
        {
            var r = new RResponse();
            
            string url = $"{Common.Common.ApiUrl}/Role?UserName={UserName}&RoleName={RoleName}";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Method = "GET";
            var httpWebResponse = httpWebRequest.GetResponse();
            {
                string responseData;
                Stream responseStream = httpWebResponse.GetResponseStream();
                try
                {
                    StreamReader streamReader = new StreamReader(responseStream);
                    try
                    {
                        responseData = streamReader.ReadToEnd();
                    }
                    finally
                    {
                        ((IDisposable)streamReader).Dispose();
                    }
                }
                finally
                {
                    ((IDisposable)responseStream).Dispose();
                }
               r = JsonConvert.DeserializeObject<RResponse>(responseData);
               if (r !=null )
                {
               
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    return RedirectToAction("Index", "HomeUser");

                }




            }

            
        }

       
        
    }
}

using System.Data;
using System.Data.SqlClient;

namespace QuanLyCovidDHH.DAL.Repository
{
    public class DataBaseRepository
    {
        protected IDbConnection connect;
        public DataBaseRepository()

        {

            string connectString = @"Data Source=HAINGHIN\MS_SQLEXPRESS;Initial Catalog=DB-QuanLyThongKeCovidDHH;Integrated Security=True";
            connect = new SqlConnection(connectString);
        }
    }
}

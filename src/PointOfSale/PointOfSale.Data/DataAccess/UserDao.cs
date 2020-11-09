using Dapper;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Params;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.DataAccess
{
    public class UserDao
    {
        private string _connectionstring = string.Empty;
        public UserDao(string connectionString)
        {
            _connectionstring = connectionString;
        }

        public LoginUser getLoginUser(LoginParam param)
        {            
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<LoginUser>
                    (@"SELECT * FROM LoginUser WHERE Username = @Username AND Password = @Password"
                    , new { Username = param.username, Password = param.password });
                return output;
            }

        }        

    }
}

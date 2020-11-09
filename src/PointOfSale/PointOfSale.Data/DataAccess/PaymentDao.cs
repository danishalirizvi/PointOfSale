using Dapper;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Data.DataAccess
{
    public class PaymentDao
    {
        private string _connectionstring = string.Empty;
        public PaymentDao(string connectionString)
        {
            _connectionstring = connectionString;
        }


        public PaymentMethod getPaymentMethod(PaymentMethod method)
        {

            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<PaymentMethod>
                    (@"SELECT * FROM PaymentMethod where lower(Name) = @Name and IsActive = 1 and IsBlocked = 0"
                    , new { Name = method.Name.ToLower() });
                return output;
            }
        }

        public void addPaymentMethod(PaymentMethod method)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.ExecuteScalar
                    (@"INSERT INTO PaymentMethod(Name, Description, IsActive, IsBlocked)
                                        VALUES(@Name, @Description, 1, 0)"
                    , new { Name = method.Name, Description = method.Description });
            }
        }

        public void deletePaymentMethod(int methodID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"DELETE FROM PaymentMethod WHERE PaymentMethodID = @PaymentMethodID"
                        , new { PaymentMethodID = methodID });
            }
        }

        public List<PaymentMethod> getAllPaymentMethods()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<PaymentMethod>
                    (@"SELECT * FROM PaymentMethod");
                return output?.ToList();
            }
        }
    }
}

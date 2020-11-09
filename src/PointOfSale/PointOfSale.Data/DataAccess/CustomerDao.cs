using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Data.Entities;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace PointOfSale.Data.DataAccess
{
    public class CustomerDao
    {
        private string _connectionstring = string.Empty;

        public CustomerDao(string connectionString)
        {
            _connectionstring = connectionString;
        }

        public void addCustomer(Customer customer)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO Customer (Name, DOB, PercentDiscount, Mobile, CNIC, Address, IsActive, IsBlocked) 
                    VALUES (@Name, @DOB, @PercentDiscount, @Mobile, @CNIC, @Address, 1, 0)";
                con.Query(query, new
                {
                    Name = customer.Name,
                    DOB = customer.DOB,
                    PercentDiscount = customer.PercentDiscount,
                    Mobile = customer.Mobile,
                    CNIC = customer.CNIC,
                    Address = customer.Address
                });
            }
        }

        public void updateCustomer(Customer customer)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Customer SET Name = @Name, CNIC = @CNIC, Mobile = @Mobile, PercentDiscount = @PercentDiscount, Address = @Address where CustomerID = @CustomerID"
                        , new
                        {
                            Name = customer.Name,
                            DOB = customer.DOB,
                            PercentDiscount = customer.PercentDiscount,
                            Mobile = customer.Mobile,
                            CNIC = customer.CNIC,
                            Address = customer.Address,
                            CustomerID = customer.CustomerID,

                        });
            }
        }

        public void receiveDue(int amount, int customerID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Query(@"UPDATE Customer SET [DueAmount] = [DueAmount] - @ReceivedAmount WHERE CustomerID = @CustomerID",
                            new { ReceivedAmount = amount, CustomerID = customerID });
            }
        }

        public List<Customer> getAllCustomers(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Customer>
                    (@"SELECT * FROM Customer where Name LIKE '%" + text + "%' and IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public List<SalesPerson> GetSalePersons()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<SalesPerson>
                    (@"SELECT * FROM SalesPerson where IsActive = 1");
                return output?.ToList();
            }
        }

        public void deleteCustomer(int customerID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Customer SET IsActive = 0 where CustomerID = @CustomerID"
                    , new { CustomerID = customerID });
            }
        }

        public List<Customer> getAllCustomers()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Customer>
                    (@"SELECT * FROM Customer where IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }


        public List<Customer> GetCustomers()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Customer>
                    (@"SELECT * FROM Customer where IsActive = 1");
                return output?.ToList();
            }
        }
    }
}

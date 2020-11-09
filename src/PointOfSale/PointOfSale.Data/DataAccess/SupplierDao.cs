using Dapper;
using PointOfSale.Data.Entities;
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

    public class SupplierDao
    {
        private string _connectionstring = string.Empty;
        public SupplierDao(string connectionString)
        {
            _connectionstring = connectionString;
        }

        public void addSupplier(Supplier supplier)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                string query = @"INSERT INTO Supplier
                    (Name,CNIC,CompanyName,PrimaryMobile,SecondaryMobile,Email,Address,IsActive,IsBlocked) VALUES
                    (@Name,@CNIC,@CompanyName,@PrimaryMobile,@SecondaryMobile,@Email,@Address, @IsActive, @IsBlocked)";

                con.ExecuteScalar(query, new
                {
                    Name = supplier.Name,
                    CNIC = supplier.CNIC,
                    CompanyName = supplier.CompanyName,
                    PrimaryMobile = supplier.PrimaryMobile,
                    SecondaryMobile = supplier.SecondaryMobile,
                    Email = supplier.Email,
                    Address = supplier.Address,
                    IsActive = supplier.IsActive,
                    IsBlocked = supplier.IsBlocked
                });
            }
        }

        public List<Supplier> getAllSuppliers()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Supplier>
                    (@"SELECT * FROM Supplier where IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public List<Supplier> getAllSuppliers(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Supplier>
                    (@"SELECT * FROM Supplier where Name LIKE '%" + text + "%' and IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public Supplier getSupplier(int supplierID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<Supplier>
                    (@"SELECT * FROM Supplier where SupplierID = @SupplierID"
                        , new { SupplierID = supplierID });
                return output;
            }
        }

        public void updateSupplier(Supplier supplier)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Supplier SET Name = @Name, CNIC = @CNIC, CompanyName = @CompanyName
                            , PrimaryMobile = @PrimaryMobile, SecondaryMobile = @SecondaryMobile, Email = @Email, Address = @Address where SupplierID = @SupplierID"
                        , new
                        {
                            Name = supplier.Name,
                            CNIC = supplier.CNIC,
                            CompanyName = supplier.CompanyName,
                            PrimaryMobile = supplier.PrimaryMobile,
                            SecondaryMobile = supplier.SecondaryMobile,
                            SupplierID = supplier.SupplierID,
                            Email = supplier.Email,
                            Address = supplier.Address
                        });
            }
        }

        public void deleteSupplier(int supplierID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Supplier SET IsActive = 0 where SupplierID = @SupplierID"
                    , new { SupplierID = supplierID });
            }
        }
    }
}

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
    public class ItemDao
    {
        private string _connectionstring = string.Empty;
        public ItemDao(string connectionString)
        {
            _connectionstring = connectionString;
        }

        public ProdType getProductType(string type)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<ProdType>
                    (@"SELECT * FROM ProductType WHERE lower(ProductType) = @ProductType and IsActive = 1 and IsBlocked = 0"
                    , new { ProductType = type.ToLower() });
                return output;
            }
        }

        public Product checkProductCode(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<Product>
                    (@"SELECT * FROM Product WHERE lower(ProductCode) = @ProductCode and IsActive = 1"
                    , new { ProductCode = text.ToLower() });
                return output;
            }
        }

        public Product checkProductName(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<Product>
                    (@"SELECT * FROM Product WHERE lower(ProductName) = @ProductName and IsActive = 1"
                    , new { ProductName = text.ToLower() });
                return output;
            }
        }

        public Product CheckProductDependency(string type)
        {
            {
                using (IDbConnection con = new SQLiteConnection(_connectionstring))
                {
                    var output = con.QueryFirstOrDefault<Product>
                        (@"SELECT * FROM Product WHERE lower(ProductType) = @ProductType and IsActive = 1"
                        , new { ProductType = type.ToLower() });
                    return output;
                }
            }
        }

        public void addProductType(ProdType type)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.ExecuteScalar
                    (@"INSERT INTO ProductType(ProductType, Description, IsActive, IsBlocked)
                                        VALUES(@ProductType, @Description, 1, 0)"
                    , new { ProductType = type.ProductType, Description = type.Description });
            }
        }

        public Product checkProductName(string text, int productID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<Product>
                    (@"SELECT * FROM Product WHERE lower(ProductName) = @ProductName and ProductID != @ProductID and IsActive = 1"
                    , new { ProductName = text.ToLower(), ProductID = productID });
                return output;
            }
        }

        public ProdType checkProductType(string currentName, string newName)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                if (currentName == newName)
                {
                    string query = "SELECT * FROM ProductType WHERE lower(ProductType) = @ProductType and ProductType != @ProductType1 and IsActive = 1";
                    var output = con.QueryFirstOrDefault<ProdType>
                   (query, new { ProductType = currentName.ToLower(), ProductType1 = newName });
                    return output;
                }
                else
                {
                    string query = "SELECT * FROM ProductType WHERE lower(ProductType) = @ProductType and IsActive = 1";
                    var output = con.QueryFirstOrDefault<ProdType>
                   (query, new { ProductType = newName.ToLower() });
                    return output;
                }
               
            }
        }

        public Product checkProductCode(string text, int productID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<Product>
                    (@"SELECT * FROM Product WHERE lower(ProductCode) = @ProductCode and ProductID != @ProductID and IsActive = 1"
                    , new { ProductCode = text.ToLower(), ProductID = productID });
                return output;
            }
        }

        public List<ProdType> getAllProductTypes()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<ProdType>
                    (@"SELECT * FROM ProductType where IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public List<ProdType> getAllProductTypes(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<ProdType>
                    (@"SELECT * FROM ProductType where ProductType LIKE '%" + text + "%' and IsActive = 1 and IsBlocked = 0"
                        );
                return output?.ToList();
            }
        }

        public void deleteProductType(string productType)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"DELETE FROM ProductType where ProductType = @ProductType"
                    , new { ProductType = productType });
            }
        }

        public void updateProductType(string productTypeOld, ProdType type)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE ProductType SET ProductType = @ProductType , Description = @Description WHERE ProductType = @ProductTypeOld",
                    new { ProductType = type.ProductType, Description = type.Description, ProductTypeOld = productTypeOld });

            }
        }
    }
}

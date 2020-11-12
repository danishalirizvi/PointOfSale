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
    public class ProductDAO
    {
        private string _connectionstring = string.Empty;
        public ProductDAO(string connectionString)
        {
            _connectionstring = connectionString;
        }


        public void addProduct(Product product)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.ExecuteScalar
                    (@"INSERT INTO Product (ProductName, ProductPrice, ProductRawPrice, ProductType, Stock, StockDate, ProductCode, UnitType, IsActive, Gift, ReOrderLevel) 
                                    VALUES (@ProductName, @ProductPrice, @ProductRawPrice, @ProductType, @Stock, @StockDate, @ProductCode, @UnitType, @IsActive, @Gift, @ReOrderLevel)"
                    , new
                    {
                        ProductName = product.ProductName,
                        ProductPrice = product.ProductPrice,
                        ProductRawPrice = product.ProductRawPrice,
                        ProductType = product.ProductType,
                        Stock = product.Stock,
                        StockDate = product.StockDate,
                        ProductCode = product.ProductCode,
                        UnitType = product.UnitType,
                        IsActive = product.IsActive,
                        Gift = product.Gift,
                        ReOrderLevel = product.ReOrderLevel
                    });
            }
        }

        public List<Product> GetReOrderItems()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                List<Product> data = new List<Product>();
                var output = con.Query<Product>(@"SELECT * from Product");
                if (output?.ToList().Count > 0)
                {
                    data = new List<Product>();
                    foreach (var item in output.ToList())
                    {
                        if (item.Stock <= item.ReOrderLevel)
                        {
                            data.Add(item);
                        }
                    }
                }
                return data.ToList();
            }
        }

        public void UpdateProduct(Product product)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.ExecuteScalar
                    (@"Update Product set ProductName=@ProductName, ProductType=@ProductType, ProductCode=@ProductCode, UnitType=@UnitType, IsActive=@IsActive, Gift=@Gift, ReOrderLevel=@ReOrderLevel, ProductRawPrice=@ProductRawPrice, ProductPrice=@ProductPrice where ProductID=@ProductID"
                    , new
                    {
                        ProductName = product.ProductName,
                        ProductType = product.ProductType,
                        ProductCode = product.ProductCode,
                        UnitType = product.UnitType,
                        IsActive = product.IsActive,
                        Gift = product.Gift,
                        ReOrderLevel = product.ReOrderLevel,
                        ProductRawPrice = product.ProductRawPrice,
                        ProductPrice = product.ProductPrice,
                        ProductID = product.ProductID
                    });
            }
        }

        public List<Product> getAllProduct()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Product>
                    (@"SELECT * FROM Product");
                return output?.ToList();
            }
        }

        public List<Product> getAllProducts(string txt_SrchProName)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Product>
                    (@"SELECT * FROM Product where ProductName LIKE '%" + txt_SrchProName + "%' and IsActive = 1");
                return output?.ToList();
            }
        }

        public void deleteProduct(int productID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"DELETE FROM PRODUCT where ProductID = @ProductID"
                    , new { ProductID = productID });
            }
        }

        public List<Product> getAllProducts()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Product>
                    (@"SELECT * FROM Product where IsActive = 1");
                return output?.ToList();
            }
        }
    }
}

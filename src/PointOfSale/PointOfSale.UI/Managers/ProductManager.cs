using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PointOfSale.UI.Managers
{
    public class ProductManager : BaseManager
    {
        ProductDAO productDao;
        ItemDao itemDao;
        PaymentDao paymentDao;

        public ProductManager()
        {
            productDao = new ProductDAO(ConnectionString);
            itemDao = new ItemDao(ConnectionString);
            paymentDao = new PaymentDao(ConnectionString);
        }

        public void SaveProduct(Product product)
        {
            productDao.addProduct(product);
        }

        public List<ProdType> GetProductTypes()
        {
            return itemDao.getAllProductTypes();
        }

        public bool CheckProductName(string text)
        {
            Product p = itemDao.checkProductName(text);
            if (p == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckProductCode(string text)
        {
            Product p = itemDao.checkProductCode(text);

            if (p == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Product> GetProducts()
        {
            return productDao.getAllProducts();
        }

        public List<PaymentMethod> GetPaymentMethod()
        {
            return paymentDao.getAllPaymentMethods();
        }

        public List<Product> GetProducts(string txt_SrchProName)
        {
            return productDao.getAllProducts(txt_SrchProName);
        }

        public void DeleteProduct(int productID)
        {
            productDao.deleteProduct(productID);
        }

        public bool CheckProductName(string text, int productID)
        {
            Product p = itemDao.checkProductName(text, productID);
            if (p == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckProductCode(string text, int productID)
        {
            Product p = itemDao.checkProductCode(text, productID);

            if (p == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateProduct(Product product)
        {
            productDao.UpdateProduct(product);
        }

        internal List<Product> GetAllProducts()
        {
            return productDao.getAllProduct();
        }
    }
}

using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI.Managers
{
    public class ItemManager
    {
        ItemDao itemDao = new ItemDao(LoadConnectionString());
        DataTable dt;

        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        public bool AddProductType(ProdType type)
        {
            ProdType t = itemDao.getProductType(type.ProductType);

            if (t == null)
            {
                itemDao.addProductType(type);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadProductTypesGrid(DataGridView typesDataGridView)
        {
            dt = new DataTable();
            List<ProdType> types = itemDao.getAllProductTypes();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);
            typesDataGridView.DataSource = dt;

            typesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            typesDataGridView.AllowUserToAddRows = false;
            typesDataGridView.Columns["IsActive"].Visible = false;
            typesDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public bool CheckProductDependency(string type)
        {
            Product p = itemDao.CheckProductDependency(type);
            if (p == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<ProdType> GetProductTypes(string text)
        {
            return itemDao.getAllProductTypes(text);
        }

        public void DeleteProductType(string productType)
        {
            itemDao.deleteProductType(productType);
        }

        public void UpdateProductType(string productTypeOld, ProdType type)
        {
            itemDao.updateProductType(productTypeOld, type);
        }

        public bool CheckProductType(string currentName, string newName)
        {
            ProdType p = itemDao.checkProductType(currentName, newName);
            if (p == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

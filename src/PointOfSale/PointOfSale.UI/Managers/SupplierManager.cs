using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using PointOfSale.UI.Helper;

namespace PointOfSale.UI.Managers
{
    public class SupplierManager : BaseManager
    {
        SupplierDao supplierDao;
        DataTable dt;

        public SupplierManager()
        {
            supplierDao = new SupplierDao(ConnectionString);
        }

        public bool addNewSupplier(Supplier supplier)
        {
            supplierDao.addSupplier(supplier);
            return true;
        }

        public void LoadSuppliersGrid(DataGridView supplierDataGridView)
        {
            dt = new DataTable();
            List<Supplier> types = supplierDao.getAllSuppliers();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            supplierDataGridView.DataSource = dt;

            //supplierDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            supplierDataGridView.AllowUserToAddRows = false;

            supplierDataGridView.Columns["IsActive"].Visible = false;
            supplierDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public void DeleteSupplier(int supplierID)
        {
            supplierDao.deleteSupplier(supplierID);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            supplierDao.updateSupplier(supplier);
        }

        public void LoadSuppliersGrid(DataGridView supplierDataGridView, string text)
        {
            dt = new DataTable();
            List<Supplier> types = supplierDao.getAllSuppliers(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            supplierDataGridView.DataSource = dt;

            //supplierDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            supplierDataGridView.AllowUserToAddRows = false;

            supplierDataGridView.Columns["IsActive"].Visible = false;
            supplierDataGridView.Columns["IsBlocked"].Visible = false;
        }
        
        public List<Supplier> GetSuppliers()
        {
            return supplierDao.getAllSuppliers();
        }
    }
}

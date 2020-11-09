using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Data.Entities;
using PointOfSale.Data.DataAccess;
using System.Windows.Forms;
using System.Data;
using PointOfSale.UI.Helper;

namespace PointOfSale.UI.Managers
{
    public class CustomerManager : BaseManager
    {
        CustomerDao customerDao;
        DataTable dt;

        public CustomerManager() {
            customerDao = new CustomerDao(ConnectionString);
        }
        public void AddCustomer(Customer customer)
        {
            customerDao.addCustomer(customer);
        }

        public void LoadCustomersGrid(DataGridView customerDataGridView)
        {
            dt = new DataTable();
            List<Customer> types = customerDao.getAllCustomers();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            customerDataGridView.DataSource = dt;

            //supplierDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            customerDataGridView.AllowUserToAddRows = false;

            customerDataGridView.Columns["IsActive"].Visible = false;
            customerDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public void DeleteSupplier(int customerID)
        {
            customerDao.deleteCustomer(customerID);
        }

        public void updateCustomer(Customer customer)
        {
            customerDao.updateCustomer(customer);
        }

        public void LoadCustomersGrid(DataGridView customerDataGridView, string text)
        {
            dt = new DataTable();
            List<Customer> types = customerDao.getAllCustomers(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            customerDataGridView.DataSource = dt;

            //supplierDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            customerDataGridView.AllowUserToAddRows = false;

            customerDataGridView.Columns["IsActive"].Visible = false;
            customerDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public List<Customer> GetCustomers()
        {
            return customerDao.GetCustomers();
        }

        public void ReceiveDue(int amount, int customerID)
        {
            customerDao.receiveDue(amount, customerID);
        }

        internal List<SalesPerson> GetSalePersons()
        {
            return customerDao.GetSalePersons();
        }
    }
}

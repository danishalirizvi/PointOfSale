using CrystalDecisions.CrystalReports.Engine;
using Dapper;
using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Params;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI.Reports.Sales.All
{
    public partial class SalesByCustomerReportForm : MetroFramework.Forms.MetroForm
    {
        InvoiceDao _invoiceDao;
        CustomerManager customerManager = new CustomerManager();
        public SalesByCustomerReportForm()
        {
            InitializeComponent();
            _invoiceDao = new InvoiceDao(LoadConnectionString());
        }

        private void onClick(object sender, EventArgs e)
        {
            if (customerPicker.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a Customer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReportParams param = new ReportParams();
                param.FromDate = fromDatePicker.Value;
                param.ToDate = toDatePicker.Value;
                param.CustomerID = Convert.ToInt32(customerPicker.SelectedValue.ToString());

                var data = _invoiceDao.GetInvoicesByCutomer(param);

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Sales\Customers\SalesByCustomerReport.rpt";
                //string reportPath = @"Reports\Sales\AllSalesReport.rpt";
                string reportFullPath = Path.Combine(appPath, reportPath);

                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(data);
                dt.Columns.Remove("CustomerID");
                ReportDocument rd = new ReportDocument();
                rd.Load(reportFullPath);

                rd.SetDataSource(dt);
                reportViewer.ReportSource = rd;
            }
        }

        public string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            List<Customer> customersList = customerManager.GetCustomers();
            Customer customer = new Customer()
            {
                CustomerID = 0,
                Name = "All Customers"
            };
            customersList.Add(customer);

            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(customersList);
            customerPicker.DataSource = dt;
            customerPicker.ValueMember = "CustomerID";
            customerPicker.DisplayMember = "Name";
            customerPicker.Text = "All Customers";

            //cmbCustomers.SelectedValueChanged += new EventHandler(cmbCustomerSelectionChanged);
        }
    }
}

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
    public partial class SalesBySalesPersonReportForm : MetroFramework.Forms.MetroForm
    {
        InvoiceDao _invoiceDao;
        EmployeeManager employeeManager = new EmployeeManager();
        public SalesBySalesPersonReportForm()
        {
            InitializeComponent();
            _invoiceDao = new InvoiceDao(LoadConnectionString());
        }

        private void onClick(object sender, EventArgs e)
        {
            if (salePersonPicker.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a Sales Person", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReportParams param = new ReportParams();
                param.FromDate = fromDatePicker.Value;
                param.ToDate = toDatePicker.Value;
                param.SalesPersonID = Convert.ToInt32(salePersonPicker.SelectedValue.ToString());

                var data = _invoiceDao.GetInvoicesBySalesPersons(param);

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Sales\SalesPersonReport\SalesBySalesPersonReport.rpt";
                //string reportPath = @"Reports\Sales\AllSalesReport.rpt";
                string reportFullPath = Path.Combine(appPath, reportPath);

                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(data);
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
            LoadSalesPersons();
        }

        private void LoadSalesPersons()
        {
            List<SalesPerson> salepersonsList = employeeManager.GetAllSalePersons();
            SalesPerson salePerson = new SalesPerson()
            {
                SalesPersonID = 0,
                Name = "All SalePersons"
            };
            salepersonsList.Add(salePerson);

            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(salepersonsList);
            salePersonPicker.DataSource = dt;
            salePersonPicker.ValueMember = "SalesPersonID";
            salePersonPicker.DisplayMember = "Name";
            salePersonPicker.Text = "All SalePersons";

            //cmbCustomers.SelectedValueChanged += new EventHandler(cmbCustomerSelectionChanged);
        }
    }
}

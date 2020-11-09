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
    public partial class ExpensByCategoryReportForm : MetroFramework.Forms.MetroForm
    {
        ExpenseDao expenseDao;
        public ExpensByCategoryReportForm()
        {
            InitializeComponent();
            expenseDao = new ExpenseDao(LoadConnectionString());
        }

        private void onClick(object sender, EventArgs e)
        {
            if (expensePicker.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select an Expense", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReportParams param = new ReportParams();
                param.FromDate = fromDatePicker.Value;
                param.ToDate = toDatePicker.Value;
                param.ExpenseName = expensePicker.SelectedValue.ToString();

                var data = expenseDao.getExpenseByCategory(param);

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Other\ExepnseByCategory\ExpenseByCategoryReport.rpt";


                //string reportPath = @"Reports\Sales\AllSalesReport.rpt";
                string reportFullPath = Path.Combine(appPath, reportPath);

                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(data);
                //dt.Columns.Remove("CustomerID");
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
            List<ExpenseCategory> categoryList = expenseDao.getAllExpenceCategories();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(categoryList);
            expensePicker.DataSource = dt;
            expensePicker.ValueMember = "ExpenseName";
            expensePicker.DisplayMember = "ExpenseName";
            expensePicker.SelectedIndex = -1;

            //cmbCustomers.SelectedValueChanged += new EventHandler(cmbCustomerSelectionChanged);
        }
    }
}

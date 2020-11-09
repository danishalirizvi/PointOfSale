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
    public partial class SalesByPercentDiscountReportForm : MetroFramework.Forms.MetroForm
    {
        InvoiceDao _invoiceDao;
        ProductManager productManager = new ProductManager();
        public SalesByPercentDiscountReportForm()
        {
            InitializeComponent();
            _invoiceDao = new InvoiceDao(LoadConnectionString());
        }

        private void onClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscountPercentage.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Discount Percentage", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Validators.isPostiveDecimalNumber(txtDiscountPercentage.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Enter Valid Discount Percentage", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(txtDiscountPercentage.Text.ToString()) > 100)
            {
                MetroFramework.MetroMessageBox.Show(this, "Discount Percentage must be less then 100", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReportParams param = new ReportParams();
                param.FromDate = fromDatePicker.Value;
                param.ToDate = toDatePicker.Value;
                param.DiscountPercentage = Convert.ToInt32(txtDiscountPercentage.Text.ToString());

                var data = _invoiceDao.GetInvoicesByDiscount(param);

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Sales\PercentDiscount\SalesByPercentDiscountReport.rpt";
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

    }
}

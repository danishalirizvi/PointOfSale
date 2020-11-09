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
    public partial class PaymentMethodReportForm : MetroFramework.Forms.MetroForm
    {
        InvoiceDao _invoiceDao;
        ProductManager productManager = new ProductManager();
        public PaymentMethodReportForm()
        {
            InitializeComponent();
            _invoiceDao = new InvoiceDao(LoadConnectionString());
        }

        private void onClick(object sender, EventArgs e)
        {
            if (cmbPaymentType.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select a Payment Method", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReportParams param = new ReportParams();
                param.FromDate = fromDatePicker.Value;
                param.ToDate = toDatePicker.Value;
                param.PaymentMethod = cmbPaymentType.Text.ToString();
                param.PaymentMethodID = Convert.ToInt32(cmbPaymentType.SelectedValue);

                var data = _invoiceDao.GetInvoicesByPaymentTypes(param);

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Sales\PaymentType\PaymentMethodReport.rpt";
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
            LoadPaymentMethods();
        }

        private void LoadPaymentMethods()
        {
            List<PaymentMethod> paymentMethods = productManager.GetPaymentMethod();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(paymentMethods);
            cmbPaymentType.DataSource = dt;
            cmbPaymentType.ValueMember = "PaymentMethodID";
            cmbPaymentType.DisplayMember = "Name";
            cmbPaymentType.SelectedIndex = -1;

        }
    }
}

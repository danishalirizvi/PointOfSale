using CrystalDecisions.CrystalReports.Engine;

using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Params;
using PointOfSale.UI.Helper;
using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PointOfSale.UI.Reports.Sales.All
{
    public partial class ReOrderReportForm : MetroFramework.Forms.MetroForm
    {
  
        ProductDAO productDao;
        public ReOrderReportForm()
        {
            InitializeComponent();
            productDao = new ProductDAO(LoadConnectionString());
        }

        private void LoadReport()
        {
            try
            {
                var data = productDao.GetReOrderItems();

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Other\ReOrderReport\ReOrderReport.rpt";     
                string reportFullPath = Path.Combine(appPath, reportPath);

                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(data);

                ReportDocument rd = new ReportDocument();
                rd.Load(reportFullPath);

                rd.SetDataSource(dt);
                reportViewer.ReportSource = rd;
            }
            catch (Exception ex)
            {
                
            }

        }

        public string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        private void ReOrderReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }
    }
}

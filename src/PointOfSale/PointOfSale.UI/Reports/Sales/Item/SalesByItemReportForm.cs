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
    public partial class SalesByItemReportForm : MetroFramework.Forms.MetroForm
    {
        InvoiceDao _invoiceDao;
        ProductManager productManager = new ProductManager();
        public SalesByItemReportForm()
        {
            InitializeComponent();
            _invoiceDao = new InvoiceDao(LoadConnectionString());
        }

        private void onClick(object sender, EventArgs e)
        {
            if (itemPicker.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Select an Item", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReportParams param = new ReportParams();
                param.FromDate = fromDatePicker.Value;
                param.ToDate = toDatePicker.Value;
                param.ProductID = Convert.ToInt32(itemPicker.SelectedValue.ToString());

                var data = _invoiceDao.GetInvoicesByItem(param);

                string appPath = Application.StartupPath;
                string reportPath = @"Reports\Sales\Item\SalesByItemReport.rpt";
                //string reportPath = @"Reports\Sales\AllSalesReport.rpt";
                string reportFullPath = Path.Combine(appPath, reportPath);

                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                DataTable dt = converter.ToDataTable(data);
                dt.Columns.Remove("ProductID");
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
            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> types = productManager.GetProducts();
            Product p = new Product() {
                ProductID = 0,
                ProductName = "All"
            };
            types.Add(p);
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(types);
            itemPicker.DataSource = dt;
            itemPicker.ValueMember = "ProductID";
            itemPicker.DisplayMember = "ProductName";
            itemPicker.Text = "All";

            //cmbProducts.SelectedValueChanged += new EventHandler(cmbProductSelectionChanged);
        }
    }
}

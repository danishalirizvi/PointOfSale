﻿using CrystalDecisions.CrystalReports.Engine;
using Dapper;
using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Params;
using PointOfSale.UI.Helper;
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
    public partial class SupplierReportForm : MetroFramework.Forms.MetroForm
    {
        SupplierDao supplierDao;
        public SupplierReportForm()
        {
            InitializeComponent();
            supplierDao = new SupplierDao(LoadConnectionString());
        }

        public string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        private void onLoad(object sender, EventArgs e)
        {
            var data = supplierDao.getAllSuppliers();

            string appPath = Application.StartupPath;
            string reportPath = @"Reports\Other\Supplier\SupplierReport.rpt";
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
}

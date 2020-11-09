using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using System.Data;
using PointOfSale.UI.Helper;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PointOfSale.UI.Managers
{
    public class InvoiceManager : BaseManager
    {
        InvoiceDao invoiceDao;
        DataTable dt;

        public InvoiceManager()
        {
            invoiceDao = new InvoiceDao(ConnectionString);
        }

        public bool isInvoiceAlreadyExist(string invoiceNumber)
        {
            return invoiceDao.IsInvoiceDuplicated(invoiceNumber);
        }

        public void SaveInvoice(Invoice invc)
        {
            invoiceDao.SaveInvoice(invc);
        }

        public List<Invoice> GetAllInvoices()
        {
            return invoiceDao.GetInvoicesWithItems();
        }
        public Invoice GetAllInvoiceByInvoiceID(object invoiceID)
        {
            return invoiceDao.GetInvoiceWithItemsByID(invoiceID);
        }

        public void LoadAllInvoices(MetroGrid invoiceDataGridView)
        {
            dt = new DataTable();
            List<Invoice> types = invoiceDao.GetInvoices();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            invoiceDataGridView.DataSource = dt;

            invoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            invoiceDataGridView.AllowUserToAddRows = false;

            invoiceDataGridView.Columns["invcCustomer"].Visible = false;
            invoiceDataGridView.Columns["IsActive"].Visible = false;
            invoiceDataGridView.Columns["Items"].Visible = false;
            invoiceDataGridView.Columns["Comment"].Visible = false;
            //invoiceDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public List<Invoice> LoadAllInvoices()
        {
            return invoiceDao.GetInvoices();
        }


        public void LoadInvoices(MetroGrid invoiceDataGridView, string input, string type)
        {
            dt = new DataTable();
            List<Invoice> types = invoiceDao.GetInvoices(input, type);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            invoiceDataGridView.DataSource = dt;

            invoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            invoiceDataGridView.AllowUserToAddRows = false;

            invoiceDataGridView.Columns["invcCustomer"].Visible = false;
            invoiceDataGridView.Columns["IsActive"].Visible = false;
            invoiceDataGridView.Columns["Items"].Visible = false;
            invoiceDataGridView.Columns["Comment"].Visible = false;
            //invoiceDataGridView.Columns["IsBlocked"].Visible = false;
        }

        internal void DeleteInvoice(int invoiceID)
        {
            invoiceDao.CancelInvoice(invoiceID);


        }

        internal void CancelPreviousInvoice(int refId)
        {
            invoiceDao.CancelInvoice(refId);
        }

        internal string GetLastRunningNumber(string invoiceType)
        {
            return invoiceDao.GetLastRunningNumber(invoiceType);
        }

        internal string GetMaxRunningNumberAssigned(string invoiceType) {
            return invoiceDao.GetMaxRunningNumberAssigned(invoiceType);
        }
        public void UpdateInvoiceRunningNumber(string invoiceType, string updatedRunningNumber)
        {
            invoiceDao.UpdateInvoiceRunningNumber(invoiceType, updatedRunningNumber);
        }
    }
}

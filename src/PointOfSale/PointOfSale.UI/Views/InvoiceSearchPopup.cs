using MetroFramework;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Enum;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public delegate void SelectedInvoice(int invoiceId);
    public partial class InvoiceSearchPopup : MetroFramework.Forms.MetroForm
    {
        InvoiceManager invoicemanager;
        public event SelectedInvoice selectedInvoice;
        public InvoiceSearchPopup()
        {
            InitializeComponent();
            invoicemanager = new InvoiceManager();
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<Invoice> types = invoicemanager.LoadAllInvoices()?
                .ToList()
                .Where(t => t.InvoiceStatus != InvoiceStatusEnum.Cancelled.ToString() && t.InvoiceType != "PurchaseInvoice")?
                .ToList();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            this.InvoiceDataGridView.DataSource = null;
            this.InvoiceDataGridView.DataSource = dt;
            this.InvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.InvoiceDataGridView.AllowUserToAddRows = false;
            this.InvoiceDataGridView.Columns["invcCustomer"].Visible = false;
            this.InvoiceDataGridView.Columns["IsActive"].Visible = false;
            this.InvoiceDataGridView.Columns["Items"].Visible = false;
            this.InvoiceDataGridView.Columns["Comment"].Visible = false;
        }

        private void retunButton_Click(object sender, EventArgs e)
        {
            if (this.InvoiceDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Nothing Selected");
                return;
            }
            else
            {
                int output;
                string invoiceID = this.InvoiceDataGridView.SelectedRows[0].Cells["InvoiceID"].Value.ToString();
                this.Close();
                int.TryParse(invoiceID, out output);
                if (output > 0)
                {
                    this.selectedInvoice(output);
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (InvoiceDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete This Invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {

                int invoiceID = Convert.ToInt32(this.InvoiceDataGridView.SelectedRows[0].Cells["InvoiceID"].Value.ToString());


                invoicemanager.DeleteInvoice(invoiceID);

                MetroMessageBox.Show(this, "Invoice Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DataTable dt = new DataTable();
                List<Invoice> types = invoicemanager.LoadAllInvoices()?
                    .ToList()
                    .Where(t => t.InvoiceStatus != InvoiceStatusEnum.Cancelled.ToString())?
                    .ToList();
                ListtoDataTableConverter converter = new ListtoDataTableConverter();
                dt = converter.ToDataTable(types);

                this.InvoiceDataGridView.DataSource = null;
                this.InvoiceDataGridView.DataSource = dt;
                this.InvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                this.InvoiceDataGridView.AllowUserToAddRows = false;
                this.InvoiceDataGridView.Columns["invcCustomer"].Visible = false;
                this.InvoiceDataGridView.Columns["IsActive"].Visible = false;
                this.InvoiceDataGridView.Columns["Items"].Visible = false;
                this.InvoiceDataGridView.Columns["Comment"].Visible = false;
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

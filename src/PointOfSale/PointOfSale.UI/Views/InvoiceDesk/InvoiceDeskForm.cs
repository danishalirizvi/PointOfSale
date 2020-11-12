using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using PointOfSale.UI.Views.InvoiceDesk;
using PointOfSale.UI.Views.InvoiceDesk.InvoiceDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using Telerik.WinControls.UI;
using Telerik.WinControls;

namespace PointOfSale.UI.Views
{
    public partial class InvoiceDeskForm : MetroFramework.Forms.MetroForm
    {
        InvoiceManager invoicemanager;

        InvoiceDataSet invoiceDataSet;
        InvoiceTableAdapter invoiceTableAdopter;
        InvoiceItemTableAdapter invoiceItemTableAdopter;


        List<Invoice> invoices;

        public InvoiceDeskForm()
        {
            InitializeComponent();
            invoicemanager = new InvoiceManager();

            invoiceDataSet = new InvoiceDataSet();
            invoiceTableAdopter = new InvoiceTableAdapter();
            invoiceItemTableAdopter = new InvoiceItemTableAdapter();

            invoices = new List<Invoice>();
        }

        private void InitializeDataGrid()
        {
            CreateBoundHierarchy();
            SetupFiltering(radGridView1.MasterTemplate, false);
        }

        private void CreateBoundHierarchy()
        {
            using (this.radGridView1.DeferRefresh())
            {
                this.radGridView1.MasterTemplate.Reset();
                this.radGridView1.AllowSearchRow = true;
                this.radGridView1.TableElement.RowHeight = 20;

                this.radGridView1.DataSource = invoiceDataSet.Invoice;
                this.radGridView1.MasterTemplate.Columns["InvoiceID"].HeaderText = "Invoice ID";
                this.radGridView1.MasterTemplate.Columns["InvoiceNumber"].HeaderText = "Invoice Number";
                this.radGridView1.MasterTemplate.Columns["InvoiceType"].HeaderText = "Invoice Type";
                this.radGridView1.MasterTemplate.Columns["InvoiceDate"].HeaderText = "Invoice Date";
                this.radGridView1.MasterTemplate.Columns["TotalToPay"].HeaderText = "Invoice Amount";
                this.radGridView1.MasterTemplate.Columns["PaymentMethod"].HeaderText = "Payment Method";
                this.radGridView1.MasterTemplate.Columns["InvoiceStatus"].HeaderText = "Status";
                this.radGridView1.MasterTemplate.Columns["ReferenceInvoiceNumber"].HeaderText = "Ref. Invoice Number";

                //this.radGridView1.MasterTemplate.Columns["InvoiceID"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["PaymentMethodID"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["InvoiceID"].IsVisible = false;
                this.radGridView1.MasterTemplate.Columns["ReferenceInvoiceID"].IsVisible = false;


                this.radGridView1.MasterTemplate.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                this.radGridView1.AutoGenerateColumns = false;
                this.radGridView1.AllowAddNewRow = false;
                this.radGridView1.AllowDeleteRow = false;
                this.radGridView1.AllowEditRow = false;

                GridViewTemplate template = new GridViewTemplate();
                template.DataSource = invoiceDataSet.InvoiceItem;

                this.radGridView1.Templates.Add(template);
                template.Columns["ProductName"].HeaderText = "Product Name";
                template.Columns["Quantity"].HeaderText = "Quantity";
                template.Columns["UnitPrice"].HeaderText = "Unit Price";

                template.Columns["InvoiceID"].IsVisible = false;

                //template.Columns.Move(8, 2);
                //template.Columns.Move(5, 3);
                //template.Columns.Move(6, 4);
                template.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                template.AllowEditRow = false;
                template.AllowAddNewRow = false;
                GridViewRelation relation = new GridViewRelation(radGridView1.MasterTemplate, template);
                relation.RelationName = "InvoiceItems";
                relation.ParentColumnNames.Add("InvoiceID");
                relation.ChildColumnNames.Add("InvoiceID");
                this.radGridView1.Relations.Add(relation);
            }
        }
        private void SetupFiltering(GridViewTemplate template, bool enableFiltering)
        {
            template.EnableFiltering = enableFiltering;

            for (int i = 0; i < template.Templates.Count; i++)
            {
                SetupFiltering(template.Templates[i], enableFiltering);
            }
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            ListtoDataTableConverter converter = new ListtoDataTableConverter();

            this.invoiceTableAdopter.Fill(this.invoiceDataSet.Invoice);
            this.invoiceItemTableAdopter.Fill(this.invoiceDataSet.InvoiceItem);
            InitializeDataGrid();
        }

        private void selectedTypeValueChanged(object sender, EventArgs e)
        {
            //invoicemanager.LoadInvoices(InvoiceDataGridView, typePicker.SelectedItem.ToString(), "InvoiceType");
        }

        private void nameTextChange(object sender, EventArgs e)
        {
            // invoicemanager.LoadInvoices(InvoiceDataGridView, customerField.Text, "Name");
        }

        private void numberTextChanged(object sender, EventArgs e)
        {
            // invoicemanager.LoadInvoices(InvoiceDataGridView, invoiceField.Text, "Number");
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            // invoicemanager.LoadInvoices(InvoiceDataGridView, datePicker.Text, "Date");
        }
    }
}

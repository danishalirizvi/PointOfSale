using PointOfSale.Data;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using PointOfSale.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class PurchaseInvoiceForm : MetroFramework.Forms.MetroForm
    {
        private List<Product> types { get; set; }
        private List<Supplier> supplier { get; set; }

        public SupplierManager supplierManager { get; set; }
        public ProductManager productManager { get; set; }
        public InvoiceManager invoiceManager { get; set; }
        public List<PurchaseInvoiceItemVm> invoiceItems { get; set; }

        public PurchaseInvoiceForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
            invoiceManager = new InvoiceManager();
            supplierManager = new SupplierManager();
            LoadCombos();
            HandleScreen(false);
            invoiceItems = new List<PurchaseInvoiceItemVm>();
        }

        private void HandleScreen(bool isEnabled)
        {
            btnClose.Enabled = true;
            btnNewInvoice.Enabled = true;
            dpInvoiceDate.Enabled = true;
            
            btnAddToCart.Enabled = isEnabled;
            btnCancelInvoice.Enabled = isEnabled;
            btnConfirmPayment.Enabled = isEnabled;
            txtUnitType.Enabled = isEnabled;
            txtUnitType.Clear();

            txtMobile.Clear();
            txtSupplierCompany.Clear();

            txt_TotalPay.Enabled = isEnabled;
            txt_TotalPay.Text = "0";
            txtSalePrice.Enabled = isEnabled;
            txtSalePrice.Text = "0";
            txtQuantity.Enabled = isEnabled;
            txtQuantity.Text = "0";
            txtPurchasePrice.Enabled = isEnabled;
            txtPurchasePrice.Text = "0";

            txtAvailableStock.Clear();
            txtAvailableStock.Text = "0";

            txtLastStockDate.Clear();
            txtSupplierCompany.Clear();

            txt_Note.Enabled = isEnabled;
            txt_Note.Clear();
            cmbProducts.Enabled = isEnabled;
            cmbProducts.SelectedIndex = -1;
            cmbSupplier.Enabled = isEnabled;
            cmbSupplier.SelectedIndex = -1;

            txtProductCode.Clear();
            if (!isEnabled) txtinvoiceNo.Clear();

            invoiceItems = new List<PurchaseInvoiceItemVm>();

            CartdataGridView.DataSource = null;

        }

        private void LoadCombos()
        {
            LoadProducts();
            LoadSupplier();
        }

        private void LoadSupplier()
        {
            supplier = supplierManager.GetSuppliers();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(supplier);
            cmbSupplier.DataSource = dt;
            cmbSupplier.ValueMember = "SupplierID";
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.SelectedIndex = -1;

            cmbSupplier.SelectedValueChanged += new EventHandler(cmbSupplierSelectionChanged);

        }

        private string GenerateInvoiceNum(bool isDeadLock)
        {
            string InvoiceNum;
            string runningNumber = GetPreviousRunningNumber(InvoiceTypeEnum.PurchaseInvoice.ToString());

            if (runningNumber == null)
            {
                // Only First Time System Running  
                //DS-xxxx-xxxx
                string invoicepart;
                if (isDeadLock)
                {
                    Random rnd = new Random();
                    invoicepart = rnd.Next(101, 999).ToString();
                    invoicepart = invoicepart.PadLeft(6, '0');
                }
                else
                {
                    invoicepart = "100".PadLeft(6, '0');
                }
                InvoiceNum = "PI" + "-" + invoicepart;
                return InvoiceNum;
            }
            else
            {
                int nextNumber;
                string[] chars = runningNumber.Split('-');
                string nbr = chars[1];
                int.TryParse(nbr, out nextNumber);
                string invoicepart = (nextNumber + 1).ToString().PadLeft(6, '0');
                InvoiceNum = "PI" + "-" + invoicepart;
                return InvoiceNum;
            }
        }

        private string GetPreviousRunningNumber(string v)
        {
            return invoiceManager.GetLastRunningNumber(v);
        }

        //private string GenerateInvoiceNum()
        //{
        //    string InvoiceNum;
        //    //DS-xxxx-xxxxs
        //    Random rnd = new Random();
        //    int invoicepart_1 = rnd.Next(1, 999);
        //    long invoicepart_3 = rnd.Next(1000, 999999);
        //    InvoiceNum = invoicepart_1 + "-" + invoicepart_3;
        //    return InvoiceNum;
        //}

        private void cmbSupplierSelectionChanged(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(cmbSupplier?.SelectedValue);
            Supplier selected = supplier.FirstOrDefault(t => t.SupplierID == supplierId);
            if (selected == null) return;

            txtQuantity.Clear();
            txtMobile.Clear();
            txtSupplierCompany.Clear();
            txtSupplierCompany.Text = selected.CompanyName;
            txtMobile.Text = selected.PrimaryMobile.ToString();
        }

        private void LoadProducts()
        {
            types = productManager.GetProducts();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(types);
            cmbProducts.DataSource = dt;
            cmbProducts.ValueMember = "ProductID";
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.SelectedIndex = -1;

            cmbProducts.SelectedValueChanged += new EventHandler(cmbProductSelectionChanged);
        }

        private void cmbProductSelectionChanged(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(cmbProducts?.SelectedValue);
            Product selected = types.FirstOrDefault(t => t.ProductID == productID);
            if (selected == null) return;

            txtQuantity.Clear();
            txtPurchasePrice.Clear();
            txtProductCode.Text = selected.ProductCode;
            txtAvailableStock.Text = selected.Stock.ToString();
            txtUnitType.Text = selected.UnitType;
            txtLastStockDate.Text = Validators.GetStandardDateTime(selected.StockDate);
            txtPurchasePrice.Text = selected.ProductRawPrice.ToString();
            txtSalePrice.Text = selected.ProductPrice.ToString();
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            string InvoiceNum;
            bool isInvoiceNumAlreadyExist = true;
            bool isDeadLock = false;

            while (isInvoiceNumAlreadyExist)
            {
                InvoiceNum = GenerateInvoiceNum(isDeadLock);
                isInvoiceNumAlreadyExist = invoiceManager.isInvoiceAlreadyExist(InvoiceNum);
                txtinvoiceNo.Text = InvoiceNum;
                isDeadLock = true;
            }

            HandleScreen(true);
        }

        private void btnCancelInvoice_Click(object sender, EventArgs e)
        {
            HandleScreen(false);
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                bool hasSomeProductSelectedAgain = false;

                foreach (DataGridViewRow row in CartdataGridView.Rows)
                {
                    if (Convert.ToInt16(row.Cells["ProductID"].Value) == Convert.ToInt16(cmbProducts.SelectedValue))
                    {

                        int gridItemQuantity = Convert.ToInt32(row.Cells["Quantity"].Value) + Convert.ToInt32(txtQuantity.Text);
                        decimal totalPrice = gridItemQuantity * Convert.ToDecimal(row.Cells["PurchasePrice"].Value);

                        row.Cells["Quantity"].Value = gridItemQuantity;
                        row.Cells["TotalPrice"].Value = totalPrice;
                        hasSomeProductSelectedAgain = true;

                        invoiceItems.FirstOrDefault(t => t.ProductID == Convert.ToInt32(row.Cells["ProductID"].Value)).Quantity = gridItemQuantity;
                        invoiceItems.FirstOrDefault(t => t.ProductID == Convert.ToInt32(row.Cells["ProductID"].Value)).TotalPrice = totalPrice;

                    }
                }

                if (hasSomeProductSelectedAgain == false)
                {
                    PurchaseInvoiceItemVm item = new PurchaseInvoiceItemVm()
                    {
                        ProductID = Convert.ToInt16(cmbProducts.SelectedValue),
                        SupplierID = Convert.ToInt16(cmbSupplier.SelectedValue),
                        SupplierName = cmbSupplier.Text,
                        Quantity = Convert.ToInt32(txtQuantity.Text.Trim()),
                        UnitType = txtUnitType.Text,
                        ProductCode = txtProductCode.Text,
                        ProductName = cmbProducts.Text,
                        PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text.Trim()),
                        SalePrice = Convert.ToDecimal(txtSalePrice.Text.Trim()),
                        TotalPrice = Convert.ToInt64(txtQuantity.Text.Trim()) * Convert.ToDecimal(txtPurchasePrice.Text.Trim())
                    };

                    //Array,Collection,List,DataTable,DataSet
                    invoiceItems.Add(item);
                    CartdataGridView.DataSource = null;
                    CartdataGridView.DataSource = invoiceItems;
                }

                decimal totalAmount = invoiceItems.Sum(x => x.TotalPrice);
                txt_TotalPay.Text = totalAmount.ToString();
            }
        }

        private bool IsValidated()
        {
            int tempQuantity;
            bool isNumeric = int.TryParse(txtQuantity.Text.Trim(), out tempQuantity);

            if (cmbProducts.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Item Name is Requred", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txtQuantity.Text.Trim() == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity is Requred", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else if (!Validators.isPostiveNumber(txtQuantity.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Add Minimum and Non-negitive Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else if (!Validators.isPostiveDecimalNumber(txtPurchasePrice.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Add Minimum and Non-negitive Purchase Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else if (!Validators.isPostiveDecimalNumber(txtSalePrice.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Add Minimum and Non-negitive Sale Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else
            {
                if (!isNumeric)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Quantity should be integer value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQuantity.Clear();
                    txtQuantity.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (!Validators.isPostiveDecimalNumber(txt_TotalPay.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please calcuate before submit !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TotalPay.Focus();
                return;
            }

            SaveInvoices();
            HandleScreen(false);
        }

        private void SaveInvoices()
        {
            Invoice invc = new Invoice();
            invc.Items = new List<InvoiceItem>();

            if (invoiceItems != null && invoiceItems.Any())
            {
                foreach (var item in invoiceItems)
                {
                    InvoiceItem invcItem = new InvoiceItem()
                    {
                        ProductCode = item.ProductCode,
                        ProductID = item.ProductID,
                        ProductName = item.ProductName,
                        IsActive = 1,
                        Quantity = item.Quantity,
                        UnitPrice = item.PurchasePrice,
                        TotalPrice = item.TotalPrice,
                        UnitType = item.UnitType,
                        SupplierID = item.SupplierID,
                        SalePrice = item.SalePrice
                    };

                    invc.Items.Add(invcItem);
                }

                invc.TotalToPay = invc.Items.Sum(t => t.TotalPrice);
                invc.InvoiceNumber = txtinvoiceNo.Text;
                invc.InvoiceType = InvoiceTypeEnum.PurchaseInvoice.ToString();
                invc.InvoiceDate = Validators.GetStandardDateTime(dpInvoiceDate.Value);

                invc.Comment = txt_Note.Text;

                invc.IsActive = 1;

                invoiceManager.SaveInvoice(invc);

                MetroFramework.MetroMessageBox.Show(this, "Invoice Saved Successfully !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HandleScreen(false);

                LoadCombos();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invoice List is empty !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void closebuttonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

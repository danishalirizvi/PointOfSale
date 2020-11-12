using PointOfSale.Data;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using PointOfSale.UI.Properties;
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
        private int NumberOfItemPerPage = 0;
        private int NumberOfItemsPrintedSoFar = 0;
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

            if (selected.Gift == 1)
            {
                txtSalePrice.ReadOnly = true;
                txtPurchasePrice.ReadOnly = true;

                txtSalePrice.Text = "0";
                txtPurchasePrice.Text = "0";
            }
            else
            {
                txtSalePrice.ReadOnly = false;
                txtPurchasePrice.ReadOnly = false;

                txtPurchasePrice.Text = selected.ProductRawPrice.ToString();
                txtSalePrice.Text = selected.ProductPrice.ToString();
            }
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
            btnNewInvoice.Enabled = false;
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
                    int productID = Convert.ToInt32(cmbProducts?.SelectedValue);
                    Product selected = types.FirstOrDefault(t => t.ProductID == productID);
                    bool isGiftItem = false;
                    if (selected != null)
                    {
                        isGiftItem = Convert.ToBoolean(selected.Gift);
                    }
                    PurchaseInvoiceItemVm item = new PurchaseInvoiceItemVm()
                    {
                        ProductID = Convert.ToInt16(cmbProducts.SelectedValue),
                        SupplierID = Convert.ToInt16(cmbSupplier.SelectedValue),
                        SupplierName = cmbSupplier.Text,
                        Quantity = Convert.ToInt32(txtQuantity.Text.Trim()),
                        UnitType = txtUnitType.Text,
                        ProductCode = txtProductCode.Text,
                        ProductName = cmbProducts.Text,
                        isGiftItem = isGiftItem,
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
            bool isGiftItem = false;
            int productID = Convert.ToInt32(cmbProducts?.SelectedValue);
            Product selected = types.FirstOrDefault(t => t.ProductID == productID);
            if (selected != null)
            {
                isGiftItem = Convert.ToBoolean(selected.Gift);
            }

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
            else if (!Validators.isPostiveDecimalNumber(txtPurchasePrice.Text.Trim())
                && !isGiftItem)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Add Minimum and Non-negitive Purchase Price", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuantity.Focus();
                return false;
            }
            else if (!Validators.isPostiveDecimalNumber(txtSalePrice.Text.Trim())
                && !isGiftItem)
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
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartdataGridView.CurrentCell.RowIndex;

            //Update Stock Level
            int productId = Convert.ToInt16(CartdataGridView.Rows[index].Cells["ProductID"].Value);
            invoiceItems.RemoveAt(index);

            CartdataGridView.DataSource = null;
            CartdataGridView.DataSource = invoiceItems;

            decimal totalAmount = invoiceItems.Sum(x => x.TotalPrice);
            txt_TotalPay.Text = totalAmount.ToString();
        }

        public bool isValidInvoiceWithGifts()
        {
            bool isInvoiceValid = false;
            if (invoiceItems != null && invoiceItems.Any())
            {
                isInvoiceValid = invoiceItems.Exists(t => t.isGiftItem == true);
                return isInvoiceValid;
            }
            return isInvoiceValid;
        }


        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            bool isOnlyGiftInvoice = isValidInvoiceWithGifts();

            if (!Validators.isPostiveDecimalNumber(txt_TotalPay.Text.Trim()) && (!isOnlyGiftInvoice))
            {
                MetroFramework.MetroMessageBox.Show(this, "No Item Added Yet!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TotalPay.Focus();
                return;
            }
            if (cmbSupplier.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Supplier not Added!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void CartdataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var hti = CartdataGridView.HitTest(e.X, e.Y);
                if (hti.RowIndex == -1) { return; }
                CartdataGridView.Rows[hti.RowIndex].Selected = true;
                contextMenuStrip1.Show(CartdataGridView, e.X, e.Y);
            }
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.MIV;
            e.Graphics.DrawImage(image, 5, -5, 815, 1162);

            // Create string to draw.
            String invoiceNo = txtinvoiceNo.Text.Trim();
            String TotalToPay = "  PKR";
            String InvoiceDateSet = dpInvoiceDate.Value.Date.ToShortDateString();
            String InvoiceTimeSet = DateTime.Now.ToLongTimeString();
            String InvoicePaymentDateSet = "";
            //String ClientCompany = txtc.Text.Trim();
            String ClientName = cmbSupplier.Text.Trim();
            String ClientMob = txtMobile.Text.Trim();
            String ClientAddress = txtSupplierCompany.Text.Trim();

            // Create font and brush.
            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.SlateGray);

            // Draw Rectangle Location (Original Copy)
            RectangleF drawRectinvoiceNo = new RectangleF(675, 70, 100, 18);
            RectangleF drawRectDueMoney = new RectangleF(675, 92, 100, 16);
            RectangleF drawRectInvoiceDateSet = new RectangleF(675, 112, 100, 16);
            RectangleF drawRectInvoiceTimeSet = new RectangleF(675, 132, 100, 16);
            RectangleF drawRectInvoicePaymentDateSet = new RectangleF(675, 152, 100, 16);
            RectangleF drawRectClientCompany = new RectangleF(130, 111, 415, 16);
            RectangleF drawRectClientName = new RectangleF(130, 131, 180, 16);
            RectangleF drawRectClientMob = new RectangleF(397, 131, 145, 16);
            RectangleF drawRectClientAddress = new RectangleF(130, 152, 415, 16);

            // Set format of string.
            StringFormat drawFormatFar = new StringFormat();
            drawFormatFar.Alignment = StringAlignment.Far;
            StringFormat drawFormatNear = new StringFormat();
            drawFormatNear.Alignment = StringAlignment.Near;

            // Draw string to screen (Original Copy)
            e.Graphics.DrawString(invoiceNo, new Font("Arial", 11, FontStyle.Bold), drawBrush, drawRectinvoiceNo, drawFormatFar);
            e.Graphics.DrawString(TotalToPay, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectDueMoney, drawFormatFar);
            e.Graphics.DrawString(InvoiceDateSet, drawFont, drawBrush, drawRectInvoiceDateSet, drawFormatFar);
            e.Graphics.DrawString(InvoiceTimeSet, drawFont, drawBrush, drawRectInvoiceTimeSet, drawFormatFar);
            e.Graphics.DrawString(InvoicePaymentDateSet, drawFont, drawBrush, drawRectInvoicePaymentDateSet, drawFormatFar);
            //e.Graphics.DrawString(ClientCompany, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientCompany, drawFormatNear);
            e.Graphics.DrawString(ClientName, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientName, drawFormatNear);
            e.Graphics.DrawString(ClientMob, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientMob, drawFormatNear);
            e.Graphics.DrawString(ClientAddress, drawFont, drawBrush, drawRectClientAddress, drawFormatNear);

            int count = 1;
            int yPos = 202;

            for (int i = NumberOfItemsPrintedSoFar; i < invoiceItems.Count; i++)
            {
                NumberOfItemPerPage++;
                if (NumberOfItemPerPage <= 8)
                {
                    NumberOfItemsPrintedSoFar++;
                    if (NumberOfItemsPrintedSoFar <= invoiceItems.Count)
                    {
                        // Create string to draw.
                        String SerialNumber = Convert.ToString(count++);
                        String InvItemName = invoiceItems[i].ProductName;
                        String InvItemInfo = invoiceItems[i].ProductCode;
                        String InvQuantity = invoiceItems[i].Quantity.ToString();
                        String InvUnit = invoiceItems[i].UnitType.ToString();
                        String InvUnitPrice = invoiceItems[i].PurchasePrice.ToString() + "  PKR";
                        String InvTotalPrice = invoiceItems[i].TotalPrice.ToString() + "  PKR";

                        // Create font and brush.
                        Font drawFontInv = new Font("Arial", 9);
                        SolidBrush drawBrushInv = new SolidBrush(Color.SlateGray);

                        // Draw Rectangle Location (Original Copy)
                        RectangleF drawRectSerialNumber = new RectangleF(40, yPos, 35, 16);
                        RectangleF drawRectInvItemName = new RectangleF(85, yPos, 345, 16);
                        RectangleF drawRectInvItemInfo = new RectangleF(85, yPos + 14, 345, 14);
                        RectangleF drawRectInvQuantity = new RectangleF(437, yPos, 58, 16);
                        RectangleF drawRectInvUnit = new RectangleF(495, yPos, 50, 16);
                        RectangleF drawRectInvUnitPrice = new RectangleF(550, yPos, 110, 16);
                        RectangleF drawRectInvTotalPrice = new RectangleF(668, yPos, 120, 16);

    
                        // Set format of string.
                        StringFormat drawFormatRight = new StringFormat();
                        drawFormatRight.Alignment = StringAlignment.Far;
                        StringFormat drawFormatLeft = new StringFormat();
                        drawFormatLeft.Alignment = StringAlignment.Near;
                        StringFormat drawFormatCenter = new StringFormat();
                        drawFormatCenter.Alignment = StringAlignment.Center;

                        // Draw string to screen (Original Copy)
                        e.Graphics.DrawString(SerialNumber, drawFontInv, drawBrushInv, drawRectSerialNumber, drawFormatLeft);
                        e.Graphics.DrawString(InvItemName, new Font("Arial", 9, FontStyle.Bold), drawBrushInv, drawRectInvItemName, drawFormatLeft);
                        e.Graphics.DrawString(InvItemInfo, new Font("Arial", 8, FontStyle.Regular), drawBrushInv, drawRectInvItemInfo, drawFormatLeft);
                        e.Graphics.DrawString(InvQuantity, drawFontInv, drawBrushInv, drawRectInvQuantity, drawFormatRight);
                        e.Graphics.DrawString(InvUnit, drawFontInv, drawBrushInv, drawRectInvUnit, drawFormatLeft);
                        e.Graphics.DrawString(InvUnitPrice, drawFontInv, drawBrushInv, drawRectInvUnitPrice, drawFormatCenter);
                        e.Graphics.DrawString(InvTotalPrice, drawFontInv, drawBrushInv, drawRectInvTotalPrice, drawFormatRight);
                        yPos += 30;

                        // Draw string to screen (Office Copy)
                        //e.Graphics.DrawString(SerialNumber, drawFontInv, drawBrushInv, drawRectSerialNumberTwo, drawFormatLeft);
                        //e.Graphics.DrawString(InvItemName, new Font("Arial", 9, FontStyle.Bold), drawBrushInv, drawRectInvItemNameTwo, drawFormatLeft);
                        //e.Graphics.DrawString(InvItemInfo, new Font("Arial", 8, FontStyle.Regular), drawBrushInv, drawRectInvItemInfoTwo, drawFormatLeft);
                        //e.Graphics.DrawString(InvQuantity, drawFontInv, drawBrushInv, drawRectInvQuantityTwo, drawFormatRight);
                        //e.Graphics.DrawString(InvUnit, drawFontInv, drawBrushInv, drawRectInvUnitTwo, drawFormatLeft);
                        //e.Graphics.DrawString(InvUnitPrice, drawFontInv, drawBrushInv, drawRectInvUnitPriceTwo, drawFormatCenter);
                        //e.Graphics.DrawString(InvTotalPrice, drawFontInv, drawBrushInv, drawRectInvTotalPriceTwo, drawFormatRight);
                        //yPosTwo += 30;

                    }
                    else
                    {
                        e.HasMorePages = false;
                    }
                }
                else
                {
                    NumberOfItemPerPage = 0;
                    e.HasMorePages = true;
                    return;
                }
            }

            // Create string to draw
            String TotalAmount = txt_TotalPay.Text.Trim() + "  PKR";
            String TotalPay = txt_TotalPay.Text.Trim() + "  PKR";
            String GrandTotalPay = txt_TotalPay.Text.Trim() + "  PKR";
            String InvoiceNote = txt_Note.Text.Trim();
            String InvoiceType = "";

            // Create font and brush.
            Font drawFontBottom = new Font("Arial", 10);
            SolidBrush drawBrushBottom = new SolidBrush(Color.SlateGray);

            // Draw Rectangle Location (Original Copy)
            RectangleF drawRectTotalAmount = new RectangleF(668, 447, 120, 17);
            //RectangleF drawRectsalesTax = new RectangleF(680, 935, 200, 50);
            RectangleF drawRectDiscount = new RectangleF(668, 467, 120, 17);
            RectangleF drawRectTotalPay = new RectangleF(668, 487, 121, 17);
            RectangleF drawRectReceivedMoney = new RectangleF(668, 507, 120, 17);
            RectangleF drawRectInvoiceNote = new RectangleF(75, 448, 465, 16);
            RectangleF drawRectInvoiceType = new RectangleF(420, 508, 123, 16);

            // Draw Rectangle Location (Office Copy)
            //RectangleF drawRectTotalAmountTwo = new RectangleF(668, 1029, 120, 17);
            ////RectangleF drawRectsalesTaxTwo = new RectangleF(680, 935, 200, 50);
            //RectangleF drawRectDiscountTwo = new RectangleF(668, 1049, 120, 17);
            //RectangleF drawRectTotalPayTwo = new RectangleF(668, 1069, 121, 17);
            //RectangleF drawRectReceivedMoneyTwo = new RectangleF(668, 1089, 120, 17);
            //RectangleF drawRectInvoiceNoteTwo = new RectangleF(75, 1030, 465, 16);
            //RectangleF drawRectInvoiceTypeTwo = new RectangleF(420, 1090, 123, 16);

            // Draw rectangle to screen.
            //Pen blackPen = new Pen(Color.Black);
            //e.Graphics.DrawRectangle(blackPen, 75, 1028, 465, 16);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Far;
            StringFormat drawFormatNote = new StringFormat();
            drawFormatNote.Alignment = StringAlignment.Near;
            StringFormat drawFormatType = new StringFormat();
            drawFormatType.Alignment = StringAlignment.Center;

            // Draw string to screen (Original Copy)
            e.Graphics.DrawString(TotalAmount, drawFontBottom, drawBrushBottom, drawRectTotalAmount, drawFormat);
            //e.Graphics.DrawString(salesTax, drawFontBottom, drawBrushBottom, drawRectsalesTax, drawFormat);
            //e.Graphics.DrawString(Discount, drawFontBottom, drawBrushBottom, drawRectDiscount, drawFormat);
            e.Graphics.DrawString(TotalPay, new Font("Arial", 10, FontStyle.Bold), drawBrushBottom, drawRectTotalPay, drawFormat);
            //e.Graphics.DrawString(ReceivedMoney, drawFontBottom, drawBrushBottom, drawRectReceivedMoney, drawFormat);
            e.Graphics.DrawString(InvoiceNote, new Font("Arial", 9, FontStyle.Regular), drawBrushBottom, drawRectInvoiceNote, drawFormatNote);
            e.Graphics.DrawString(InvoiceType, new Font("Arial", 9, FontStyle.Bold), drawBrushBottom, drawRectInvoiceType, drawFormatType);

            // Draw string to screen (Office Copy)
            //e.Graphics.DrawString(TotalAmount, drawFontBottom, drawBrushBottom, drawRectTotalAmountTwo, drawFormat);
            ////e.Graphics.DrawString(salesTax, drawFontBottom, drawBrushBottom, drawRectsalesTaxTwo, drawFormat);
            //e.Graphics.DrawString(Discount, drawFontBottom, drawBrushBottom, drawRectDiscountTwo, drawFormat);
            //e.Graphics.DrawString(TotalPay, new Font("Arial", 10, FontStyle.Bold), drawBrushBottom, drawRectTotalPayTwo, drawFormat);
            //e.Graphics.DrawString(ReceivedMoney, drawFontBottom, drawBrushBottom, drawRectReceivedMoneyTwo, drawFormat);
            //e.Graphics.DrawString(InvoiceNote, new Font("Arial", 9, FontStyle.Regular), drawBrushBottom, drawRectInvoiceNoteTwo, drawFormatNote);
            //e.Graphics.DrawString(InvoiceType, new Font("Arial", 9, FontStyle.Bold), drawBrushBottom, drawRectInvoiceTypeTwo, drawFormatType);

            //Reset the variable
            NumberOfItemPerPage = 0;
            NumberOfItemsPrintedSoFar = 0;
        }
    }
}

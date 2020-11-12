
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Managers;
using PointOfSale.UI.Helper;
using PointOfSale.UI.ViewModel;
using PointOfSale.Data;
using PointOfSale.Data.Enum;
using PointOfSale.UI.Properties;

namespace PointOfSale.UI.Views
{
    public partial class SaleInvoiceForm : MetroFramework.Forms.MetroForm
    {
        #region Properties and Cunstructors
        public ProductManager productManager { get; set; }
        public InvoiceManager invoiceManager { get; set; }
        private List<Product> types { get; set; }
        public List<Customer> customersList { get; set; }

        public List<SalesPerson> salePersonsList { get; set; }
        private int NumberOfItemPerPage = 0;
        private int NumberOfItemsPrintedSoFar = 0;
        public CustomerManager customerManager { get; set; }

        public InvoiceVm invoiceVm { get; set; }
        public Invoice invoice { get; set; }
        private List<PaymentMethod> paymentMethods { get; set; }
        public SaleInvoiceForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
            invoiceManager = new InvoiceManager();
            customerManager = new CustomerManager();
            LoadCombos();
            HandleScreen(false);
            invoiceVm = new InvoiceVm();
            invoiceVm.invoiceItems = new List<InvoiceItemVm>();
            invoice = new Invoice();
        }

        public void LoadInvoiceDetails(int invoiceID)
        {
            productManager = new ProductManager();
            invoiceManager = new InvoiceManager();
            customerManager = new CustomerManager();
            LoadCombos();
            HandleScreen(false);

            invoiceVm = new InvoiceVm();
            invoiceVm.invoiceItems = new List<InvoiceItemVm>();
            invoice = new Invoice();

            SetInvoiceNumber();
            FillInvoiceDetails(invoiceID);

            ///CalculateAndFill();

            //In case of update this will not work

            btnConfirmPayment.Enabled = false;

            //Will Enabled after calculate
            btnUpdateDueInvoice.Enabled = false;
        }

        private void FillInvoiceDetails(int invoiceID)
        {
            invoice = invoiceManager.GetAllInvoiceByInvoiceID(invoiceID);
            MapInvoiceItemGrid(invoice);
        }

        private void MapInvoiceItemGrid(Invoice selectedInvoice)
        {
            invoiceVm = new InvoiceVm()
            {
                CustomerID = selectedInvoice.invcCustomer?.CustomerID,
                ReferenceInvoiceID = selectedInvoice.InvoiceID,
                RefereneInvoiceNumber = selectedInvoice.InvoiceNumber
            };

            cmb_Type.SelectedValue = selectedInvoice.PaymentMethodID;
            invoiceVm.invoiceItems = new List<InvoiceItemVm>();
            foreach (var item in selectedInvoice.Items)
            {
                var product = types.FirstOrDefault(t => t.ProductID == item.ProductID);
                InvoiceItemVm vm = new InvoiceItemVm()
                {
                    ProductCode = product.ProductCode,
                    ProductID = item.ProductID,
                    ProductName = product.ProductName,
                    Quantity = item.Quantity,
                    TotalAmount = item.TotalPrice,
                    UnitPrice = item.UnitPrice,
                    UnitType = item.UnitType,
                    isGiftItem = Convert.ToBoolean(product.Gift)
                };

                invoiceVm.invoiceItems.Add(vm);
            }

            if (selectedInvoice.invcCustomer != null)
            {
                cmbCustomers.SelectedValue = selectedInvoice.invcCustomer.CustomerID;
                txtFixedDiscount.Text = selectedInvoice.invcCustomer.FixedDiscount.ToString();
                txt_TotalPay.Text = selectedInvoice.TotalToPay.ToString();

                txtTotalDiscountAmount.Text = selectedInvoice.invcCustomer.Discount.ToString();
                txtDiscountPercent.Text = selectedInvoice.invcCustomer.DiscountPercentage.ToString();
                txtCustomerDiscountPercangeAmnout.Text = selectedInvoice.invcCustomer.DiscountPercentageAmount.ToString();
                cmbSalesPersons.SelectedValue = selectedInvoice.invcCustomer.SalesPersonID;
                txt_ChangeAmount.Text = selectedInvoice.invcCustomer.ChangeAmount.ToString();
                txtDueAmount.Text = selectedInvoice.invcCustomer.DueAmount.ToString();
                txt_TotalAmount.Text = selectedInvoice.invcCustomer.TotalAmount.ToString();

                txt_ReceivedMoney.Text = selectedInvoice.invcCustomer.ReceivedAmount.ToString();
            }


            CartdataGridView.DataSource = null;
            CartdataGridView.DataSource = invoiceVm.invoiceItems;
        }

        #endregion Properties

        #region Combos 

        private void LoadCombos()
        {
            LoadProducts();
            LoadPaymentMethods();
            LoadCustomers();
            LoadSalePersons();
        }

        private void LoadSalePersons()
        {
            salePersonsList = customerManager.GetSalePersons();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(salePersonsList);
            cmbSalesPersons.DataSource = dt;
            cmbSalesPersons.ValueMember = "SalesPersonID";
            cmbSalesPersons.DisplayMember = "Name";
            cmbSalesPersons.SelectedIndex = -1;
        }

        private void LoadCustomers()
        {
            customersList = customerManager.GetCustomers();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(customersList);
            cmbCustomers.DataSource = dt;
            cmbCustomers.ValueMember = "CustomerID";
            cmbCustomers.DisplayMember = "Name";
            cmbCustomers.SelectedIndex = -1;
            cmbCustomers.SelectedValueChanged += new EventHandler(cmbCustomerSelectionChanged);
        }



        private void cmbCustomerSelectionChanged(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(cmbCustomers?.SelectedValue);
            Customer selected = customersList.FirstOrDefault(t => t.CustomerID == customerID);
            if (selected == null) return;

            txtAddress.Clear();
            txtMobile.Clear();

            txtAddress.Text = selected.Address;
            txtMobile.Text = selected.Mobile.ToString();
            txtDiscountPercent.Clear();
            txtDiscountPercent.Text = selected.PercentDiscount.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = CartdataGridView.CurrentCell.RowIndex;

            //Update Stock Level
            int productId = Convert.ToInt16(CartdataGridView.Rows[index].Cells["ProductID"].Value);
            invoiceVm.invoiceItems.RemoveAt(index);

            CalculateAndFill(true);

            CartdataGridView.DataSource = null;
            CartdataGridView.DataSource = invoiceVm.invoiceItems;

            //decimal totalAmount = invoiceVm.invoiceItems.Sum(x => x.TotalAmount);
            //txt_TotalAmount.Text = totalAmount.ToString();

            //txt_ReceivedMoney.Clear();
            ////cmbCustomers.SelectedIndex = -1;
            //cmbProducts.SelectedIndex = -1;
            //txt_ChangeAmount.Clear();
            //txt_Quantity.Clear();
            //cmbProductCode.SelectedIndex = -1;
            //txtUnitPrice.Clear();
            //txtAvailableStock.Clear();
            //txtUnitType.Clear();
            //txtDiscountPercent.Clear();
        }
        private void LoadPaymentMethods()
        {
            paymentMethods = productManager.GetPaymentMethod();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(paymentMethods);
            cmb_Type.DataSource = dt;
            cmb_Type.ValueMember = "PaymentMethodID";
            cmb_Type.DisplayMember = "Name";
            //cmb_Type.SelectedIndex = -1;
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

            var dtPrd = converter.ToDataTable(types);
            cmbProductCode.DataSource = dtPrd;
            cmbProductCode.ValueMember = "ProductCode";
            cmbProductCode.DisplayMember = "ProductCode";
            cmbProductCode.SelectedIndex = -1;
            cmbProductCode.SelectedValueChanged += new EventHandler(cmbProductCodeSelectionChanged);

            cmbProducts.SelectedValueChanged += new EventHandler(cmbProductSelectionChanged);
        }

        private void cmbProductCodeSelectionChanged(object sender, EventArgs e)
        {
            string productCode = Convert.ToString(cmbProductCode?.SelectedValue);
            Product selected = types.FirstOrDefault(t => t.ProductCode == productCode);
            if (selected == null) return;

            txt_Quantity.Clear();
            cmbProducts.Text = selected.ProductName;
            txtUnitPrice.Text = selected.ProductPrice.ToString();
            txtUnitType.Text = selected.UnitType;
            txtAvailableStock.Text = selected.Stock.ToString();
        }
        #endregion

        #region Events
        private void cmbProductSelectionChanged(object sender, EventArgs e)
        {
            int productID = Convert.ToInt32(cmbProducts?.SelectedValue);
            Product selected = types.FirstOrDefault(t => t.ProductID == productID);
            txt_Quantity.Clear();

            if (selected == null)
            {
                cmbProductCode.SelectedIndex = -1;
                txtUnitPrice.Clear();
                txtUnitType.Clear();
                txtAvailableStock.Clear();
                return;
            }

            cmbProductCode.Text = selected.ProductCode;
            txtUnitPrice.Text = selected.ProductPrice.ToString();
            txtUnitType.Text = selected.UnitType;
            txtAvailableStock.Text = selected.Stock.ToString();

        }

        private void lbl_Time_Click(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString("T");
        }
        #endregion Events

        #region Helping Methods
        private string GenerateInvoiceNum(bool isDeadLock)
        {
            string InvoiceNum;
            string runningNumber = GetPreviousRunningNumber(InvoiceTypeEnum.SaleInvoice.ToString());

            if (runningNumber == null)
            {
                // Only First Time System Running  
                //DS-xxxx-xxxx
                string invoicepart;
                invoicepart = "100".PadLeft(6, '0');
                InvoiceNum = "SI" + "-" + invoicepart;
                return InvoiceNum;
            }
            else if (isDeadLock)
            {
                runningNumber = invoiceManager.GetMaxRunningNumberAssigned(InvoiceTypeEnum.SaleInvoice.ToString());
                invoiceManager.UpdateInvoiceRunningNumber(InvoiceTypeEnum.SaleInvoice.ToString(), runningNumber);

                int nextNumber;
                string[] chars = runningNumber.Split('-');
                string nbr = chars[1];
                int.TryParse(nbr, out nextNumber);
                string invoicepart = (nextNumber + 100).ToString().PadLeft(6, '0');
                InvoiceNum = "SI" + "-" + invoicepart;
                return InvoiceNum;
            }
            else
            {
                int nextNumber;
                string[] chars = runningNumber.Split('-');
                string nbr = chars[1];
                int.TryParse(nbr, out nextNumber);
                string invoicepart = (nextNumber + 1).ToString().PadLeft(6, '0');
                InvoiceNum = "SI" + "-" + invoicepart;
                return InvoiceNum;
            }
        }

        private string GetPreviousRunningNumber(string v)
        {
            return invoiceManager.GetLastRunningNumber(v);
        }
        #endregion

        public void SetInvoiceNumber()
        {
            btnUpdateDueInvoice.Enabled = false;
            string InvoiceNum;
            bool isInvoiceNumAlreadyExist = true;
            bool isDeadLock = false;
            while (isInvoiceNumAlreadyExist)
            {
                InvoiceNum = GenerateInvoiceNum(isDeadLock);
                isInvoiceNumAlreadyExist = invoiceManager.isInvoiceAlreadyExist(InvoiceNum);
                txt_invoiceNo.Text = InvoiceNum;
                isDeadLock = true;
            }

            HandleScreen(true);
        }

        private void btnNewInvoice_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;

            string InvoiceNum;
            bool isInvoiceNumAlreadyExist = true;
            bool deadLock = false;
            cmb_Type.SelectedIndex = 0;

            while (isInvoiceNumAlreadyExist)
            {
                InvoiceNum = GenerateInvoiceNum(deadLock);
                isInvoiceNumAlreadyExist = invoiceManager.isInvoiceAlreadyExist(InvoiceNum);
                txt_invoiceNo.Text = InvoiceNum;
                deadLock = true;
            }

            HandleScreen(true);
            btnUpdateDueInvoice.Enabled = false;
            btnConfirmPayment.Enabled = false;
            txtDueAmount.Enabled = false;
            btnNewInvoice.Enabled = false;
        }

        private void HandleScreen(bool isEnabled)
        {

            btnClose.Enabled = true;
            btnNewInvoice.Enabled = true;
            dpInvoiceDate.Enabled = true;
            btnCalculateDue.Enabled = isEnabled;
            btnAllItems.Enabled = isEnabled;
            btnUpdateDueInvoice.Enabled = isEnabled;
            btnAddToCart.Enabled = isEnabled;
            btnCancelInvoice.Enabled = isEnabled;
            btnPrintOrder.Enabled = isEnabled;
            btnConfirmPayment.Enabled = isEnabled;

            txtAvailableStock.Clear();
            txtAvailableStock.Text = "0";

            txtUnitType.Clear();
            txtUnitType.Enabled = isEnabled;

            txt_TotalAmount.Text = "0";
            txt_TotalAmount.Enabled = isEnabled;

            txt_TotalPay.Text = "0";
            txt_TotalPay.Enabled = isEnabled;

            txtUnitPrice.Text = "0";
            txtUnitPrice.Enabled = isEnabled;

            txt_Quantity.Text = "0";
            txt_Quantity.Enabled = isEnabled;

            txtFixedDiscount.Text = "0";
            txtFixedDiscount.Enabled = isEnabled;

            txtDiscountPercent.Text = "0";
            txtDiscountPercent.Enabled = isEnabled;

            txtAvailableStock.Clear();

            txtTotalDiscountAmount.Clear();
            txtCustomerDiscountPercangeAmnout.Clear();

            cmbCustomers.SelectedIndex = -1;
            cmbCustomers.Enabled = isEnabled;

            txtMobile.Clear();
            txtMobile.Enabled = isEnabled;

            txtAddress.Clear();
            txtAddress.Enabled = isEnabled;

            txt_ChangeAmount.Clear();
            txt_ChangeAmount.Text = "0";

            txt_Note.Clear();
            txt_Note.Enabled = isEnabled;

            cmbProducts.SelectedIndex = -1;
            cmbProducts.Enabled = isEnabled;

            cmb_Type.SelectedIndex = 0;
            cmb_Type.Enabled = isEnabled;

            cmbSalesPersons.SelectedIndex = -1;
            cmbSalesPersons.Enabled = isEnabled;

            cmbProductCode.SelectedIndex = -1;
            cmbProductCode.Enabled = isEnabled;

            if (!isEnabled) txt_invoiceNo.Clear();

            invoiceVm = new InvoiceVm();

            CartdataGridView.DataSource = null;
            txtDueAmount.Clear();
            txtDueAmount.Enabled = isEnabled;

            txtAvailableStock.Clear();
            txtAvailableStock.Enabled = isEnabled;

            txtUnitPrice.Clear();
            txtUnitPrice.Enabled = isEnabled;

            txtUnitType.Clear();
            txtUnitType.Enabled = isEnabled;

            cmbProducts.SelectedIndex = -1;
            cmbProducts.Enabled = isEnabled;

            txt_ReceivedMoney.Text = "0";
            txt_ReceivedMoney.Enabled = isEnabled;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelInvoice_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = true;
            HandleScreen(false);
        }

        private void btnUpdateDueInvoice_Click(object sender, EventArgs e)
        {
            bool isOnlyGiftInvoice = isValidInvoiceWithGifts();


            if (invoiceVm.invoiceItems != null && invoiceVm.invoiceItems.Any())
            {
                CalculateValuesVm vm = CalculateAndFill(false);

                //Decimal Received, Due, Discount;
                //Discount = string.IsNullOrEmpty(txtFixedDiscount.Text) ? 0 : Convert.ToDecimal(txtFixedDiscount.Text);
                //Received = string.IsNullOrEmpty(txt_ReceivedMoney.Text) ? 0 : Convert.ToDecimal(txt_ReceivedMoney.Text);
                //Due = string.IsNullOrEmpty(txt_TotalPay.Text) ? 0 : Convert.ToDecimal(txt_TotalPay.Text) - (Received + Discount);

                if (vm.ChangeAmount < 0 && !isOnlyGiftInvoice)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please adjust with your full payment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ReceivedMoney.Focus();
                    return;
                }
                else if (!Validators.isPostiveDecimalNumber(txt_ReceivedMoney.Text.Trim()) && !isOnlyGiftInvoice)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter Non Negitive Receive Amount !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ReceivedMoney.Focus();
                    return;
                }
                else if (Convert.ToDecimal(txt_TotalPay.Text) < 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Adjust Discount !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (cmb_Type.SelectedIndex == -1)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please select payment mode !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ReceivedMoney.Focus();
                    return;
                }
                DeleteInvoice();

                // Need to check o        
                SaveInvoices();

                DisplayPrintPreview();

                invoiceVm = new InvoiceVm();
                invoiceVm.invoiceItems = new List<InvoiceItemVm>();

                HandleScreen(false);
                // Chaipi
                types = productManager.GetProducts();
                // LoadCombos();
                //UpdateInvoiceData();
                //MessageBox.Show("Hello");
                //btn_NewOrder.Enabled = false;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invoice List is empty !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void DeleteInvoice()
        {
            if (invoiceVm.ReferenceInvoiceID > 0)
            {
                invoiceManager.CancelPreviousInvoice(invoiceVm.ReferenceInvoiceID);
            }
        }

        private void btnAllItems_Click(object sender, EventArgs e)
        {
            OnlyShowItemForm form = new OnlyShowItemForm();
            form.ShowDialog();
        }

        private void btnCalculateDue_Click(object sender, EventArgs e)
        {
            CalculateValuesVm vm = CalculateAndFill(false);
            bool isOnlyGiftInvoice = isValidInvoiceWithGifts();

            if (vm == null) return;

            if (vm.ChangeAmount < 0 && cmb_Type.Text.ToString() != PaymentMethodEnum.Due.ToString()) { btnConfirmPayment.Enabled = false; }
            else btnConfirmPayment.Enabled = true;

            if (invoiceVm.ReferenceInvoiceID > 0)
            {
                btnConfirmPayment.Enabled = false;
                btnUpdateDueInvoice.Enabled = true;
            }

            //if (!Validators.isPostiveDecimalNumber(txt_ReceivedMoney.Text.Trim()) && !isOnlyGiftInvoice)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Please Enter Non Negitive Receive Amount !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txt_ReceivedMoney.Focus();
            //    return;
            //}

        }

        public CalculateValuesVm CalculateAndFill(bool isItemRemoved)
        {
            CalculateValuesVm vm = new CalculateValuesVm();
            if (invoiceVm.invoiceItems != null && invoiceVm.invoiceItems.Any())
            {
                decimal totalAmount = invoiceVm.invoiceItems.Sum(t => t.TotalAmount);
                txt_TotalAmount.Text = totalAmount.ToString();

                vm.PercentageDiscount = CalculateCustomerDiscount();
                vm.FixedDiscount = string.IsNullOrEmpty(txtFixedDiscount.Text) ? 0 : Convert.ToDecimal(txtFixedDiscount.Text);
                vm.TotalDiscount = vm.PercentageDiscount + vm.FixedDiscount;
                vm.ReceivedAmount = string.IsNullOrEmpty(txt_ReceivedMoney.Text) ? 0 : Convert.ToDecimal(txt_ReceivedMoney.Text);
                vm.TotalAmount = string.IsNullOrEmpty(txt_TotalAmount.Text) ? 0 : Convert.ToDecimal(txt_TotalAmount.Text);
                vm.TotalToPay = vm.TotalAmount - (vm.FixedDiscount + vm.PercentageDiscount);
                vm.ChangeAmount = vm.ReceivedAmount - vm.TotalToPay;

                txt_ChangeAmount.Text = vm.ChangeAmount.ToString();
                txtCustomerDiscountPercangeAmnout.Text = vm.PercentageDiscount.ToString();
                txt_TotalPay.Text = vm.TotalToPay.ToString();
                txtTotalDiscountAmount.Text = vm.TotalDiscount.ToString();
                if (vm.ReceivedAmount < vm.TotalToPay && cmb_Type.Text.ToString() == PaymentMethodEnum.Due.ToString())
                {
                    txtDueAmount.Text = (vm.TotalToPay - vm.ReceivedAmount).ToString();
                }

                return vm;
            }
            else if (isItemRemoved)
            {
                txt_ChangeAmount.Clear();
                txtCustomerDiscountPercangeAmnout.Clear();
                txt_TotalAmount.Clear();
                txt_TotalPay.Clear();
                txtDueAmount.Clear();
                txtDiscountPercent.Clear();
                txtFixedDiscount.Clear();
                txtTotalDiscountAmount.Clear();
                txt_ReceivedMoney.Clear();
                return null;
            }
            else return null;
            //else if(!Validators.isPostiveDecimalNumberOrZero(txt_ReceivedMoney.Text))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Invoice List is empty !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return null;
            //}
        }

        public Customer GetSelectedCustomer()
        {
            if (cmbCustomers.SelectedIndex != -1 && Convert.ToInt32(cmbCustomers.SelectedValue) > 0
                && customersList != null && customersList.Any())
            {
                return customersList.FirstOrDefault(t => t.CustomerID == Convert.ToInt32(cmbCustomers.SelectedValue));
            }
            return null;
        }

        private decimal CalculateCustomerDiscount()
        {
            try
            {
                decimal totalAmount = string.IsNullOrEmpty(txt_TotalAmount.Text) ? 0 : Convert.ToDecimal(txt_TotalAmount.Text);

                //Customer _customer = GetSelectedCustomer();
                //if (_customer != null)
                //{
                //    txtDiscountPercent.Text = _customer.PercentDiscount.ToString();
                //    return (totalAmount / 100) * _customer.PercentDiscount;
                //}

                decimal percent = string.IsNullOrEmpty(txtDiscountPercent.Text) ? 0 : Convert.ToDecimal(txtDiscountPercent.Text);
                return (totalAmount / 100) * percent;

            }
            catch (Exception)
            {

            }

            return 0;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {
                bool isGiftItem = false;
                int productID = Convert.ToInt32(cmbProducts?.SelectedValue);
                Product selected = types.FirstOrDefault(t => t.ProductID == productID);
                if (selected != null)
                {
                    isGiftItem = Convert.ToBoolean(selected.Gift);
                }
                bool hasSomeProductSelectedAgain = false;

                foreach (DataGridViewRow row in CartdataGridView.Rows)
                {
                    if (Convert.ToInt16(row.Cells["ProductID"].Value) == Convert.ToInt16(cmbProducts.SelectedValue))
                    {

                        int gridItemQuantity = Convert.ToInt32(row.Cells["Quantity"].Value) + Convert.ToInt32(txt_Quantity.Text);
                        decimal totalPrice = gridItemQuantity * Convert.ToDecimal(row.Cells["UnitPrice"].Value);

                        if (gridItemQuantity > Convert.ToInt32(txtAvailableStock.Text) && !isGiftItem)
                        {
                            MetroFramework.MetroMessageBox.Show(this, "This Quantity is not Available in the Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        row.Cells["Quantity"].Value = gridItemQuantity;
                        row.Cells["TotalAmount"].Value = totalPrice;
                        hasSomeProductSelectedAgain = true;

                        invoiceVm.invoiceItems.FirstOrDefault(t => t.ProductID == Convert.ToInt32(row.Cells["ProductID"].Value)).Quantity = gridItemQuantity;
                        invoiceVm.invoiceItems.FirstOrDefault(t => t.ProductID == Convert.ToInt32(row.Cells["ProductID"].Value)).TotalAmount = totalPrice;

                    }
                }

                if (hasSomeProductSelectedAgain == false)
                {
                    InvoiceItemVm item = new InvoiceItemVm()
                    {
                        ProductID = Convert.ToInt16(cmbProducts.SelectedValue),
                        Quantity = Convert.ToInt32(txt_Quantity.Text.Trim()),
                        UnitType = txtUnitType.Text,
                        ProductCode = cmbProductCode.Text,
                        ProductName = cmbProducts.Text,
                        UnitPrice = Convert.ToDecimal(txtUnitPrice.Text.Trim()),
                        TotalAmount = Convert.ToInt64(txt_Quantity.Text.Trim()) * Convert.ToDecimal(txtUnitPrice.Text.Trim()),
                        isGiftItem = isGiftItem
                    };

                    item.ProductRawPrice = types.FirstOrDefault(t => t.ProductID == item.ProductID).ProductRawPrice;


                    //Array,Collection,List,DataTable,DataSet
                    invoiceVm.CustomerID = Convert.ToInt32(cmbCustomers.SelectedValue);

                    invoiceVm.invoiceItems.Add(item);

                    CartdataGridView.DataSource = null;
                    CartdataGridView.DataSource = invoiceVm.invoiceItems;
                }


                decimal totalAmount = invoiceVm.invoiceItems.Sum(x => x.TotalAmount);
                txt_TotalAmount.Text = totalAmount.ToString();

            }
        }

        private bool IsValidated()
        {
            int tempQuantity;
            bool isGiftItem = false;
            int productID = Convert.ToInt32(cmbProducts?.SelectedValue);
            Product selected = types.FirstOrDefault(t => t.ProductID == productID);
            if (selected != null)
            {
                isGiftItem = Convert.ToBoolean(selected.Gift);
            }
            bool isNumeric = int.TryParse(txt_Quantity.Text.Trim(), out tempQuantity);

            if (cmbProducts.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Item Name is Requred", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbCustomers.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Customer Information is mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            else if (txt_Quantity.Text.Trim() == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Quantity is Requred", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Quantity.Focus();
                return false;
            }
            else if (!Validators.isPostiveNumber(txt_Quantity.Text.Trim()))
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Add Minimum and Non-negitive Quantity", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Quantity.Focus();
                return false;
            }

            else if (Convert.ToInt32(txt_Quantity.Text.Trim()) > Convert.ToInt32(txtAvailableStock.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "This Quantity is not Available in the Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Validators.isPostiveDecimalNumber(txtUnitPrice.Text.Trim()) && !isGiftItem)
            {
                MetroFramework.MetroMessageBox.Show(this, "This Unit Sale Price is not Available in the Stock", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (!isNumeric)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Quantity should be integer value", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Quantity.Clear();
                    txt_Quantity.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            CalculateValuesVm vm = CalculateAndFill(false);
            bool isOnlyGiftInvoice = isValidInvoiceWithGifts();

            if (cmb_Type.SelectedIndex == -1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please select payment mode !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ReceivedMoney.Focus();
                return;
            }
            else if (invoiceVm.ReferenceInvoiceID > 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please click update invoice to proceed as you are updating invoice !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ReceivedMoney.Focus();
                return;
            }
            else if (!Validators.isPostiveDecimalNumber(txt_ReceivedMoney.Text.Trim()) && cmb_Type.Text.ToString() != PaymentMethodEnum.Due.ToString() && !isOnlyGiftInvoice)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Enter Non Negitive Receive Amount !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ReceivedMoney.Focus();
                return;
            }
            if (Convert.ToDecimal(txt_TotalPay.Text) < 0)
            {
                MetroFramework.MetroMessageBox.Show(this, "Please Adjust Discount !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmb_Type.Text.ToString() != PaymentMethodEnum.Due.ToString() && !isOnlyGiftInvoice)
            {
                if (vm != null && vm.ReceivedAmount < vm.TotalToPay)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please adjust with your full payment", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ReceivedMoney.Focus();
                    return;
                }
                else if (vm != null && !Validators.isPostiveDecimalNumber(vm.ReceivedAmount.ToString()) && !isOnlyGiftInvoice)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please Enter Non Negitive Receive Amount !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ReceivedMoney.Focus();
                    return;
                }
            }

            bool isempty = SaveInvoices();

            if (isempty)
            {
                DisplayPrintPreview();
            }

            invoiceVm = new InvoiceVm();
            invoiceVm.invoiceItems = new List<InvoiceItemVm>();

            HandleScreen(false);
            // Chaipi
            types = productManager.GetProducts();
            //LoadCombos();
            btnSearch.Enabled = true;
        }

        public bool isValidInvoiceWithGifts()
        {
            bool isInvoiceValid = false;
            if (invoiceVm.invoiceItems != null && invoiceVm.invoiceItems.Any())
            {
                isInvoiceValid = invoiceVm.invoiceItems.Exists(t => t.isGiftItem == true);
                return isInvoiceValid;
            }
            return isInvoiceValid;
        }

        private void DisplayPrintPreview()
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private bool SaveInvoices()
        {
            Invoice invc = new Invoice();
            invc.Items = new List<InvoiceItem>();

            if (invoiceVm.invoiceItems != null && invoiceVm.invoiceItems.Any())
            {
                foreach (var item in invoiceVm.invoiceItems)
                {
                    InvoiceItem invcItem = new InvoiceItem()
                    {
                        ProductID = item.ProductID,
                        IsActive = 1,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                        TotalPrice = item.TotalAmount,
                        UnitType = item.UnitType,
                        SupplierID = null,
                        ProductName = item.ProductName,
                        ProductCode = item.ProductCode,
                        ProductRawPrice = item.ProductRawPrice
                    };

                    invc.Items.Add(invcItem);
                }

                if (invoiceVm.CustomerID > 0)
                {
                    invc.invcCustomer = new InvoiceCustomer()
                    {
                        CustomerID = Convert.ToInt32(cmbCustomers.SelectedValue),
                        ReceivedAmount = string.IsNullOrEmpty(txt_ReceivedMoney.Text) ? 0 : Convert.ToDecimal(txt_ReceivedMoney.Text),
                        TotalAmount = string.IsNullOrEmpty(txt_TotalAmount.Text) ? 0 : Convert.ToDecimal(txt_TotalAmount.Text),
                        Discount = string.IsNullOrEmpty(txtTotalDiscountAmount.Text) ? 0 : Convert.ToDecimal(txtTotalDiscountAmount.Text),
                        ChangeAmount = string.IsNullOrEmpty(txt_ChangeAmount.Text) ? 0 : Convert.ToDecimal(txt_ChangeAmount.Text),
                        DueAmount = string.IsNullOrEmpty(txtDueAmount.Text) ? 0 : Convert.ToDecimal(txtDueAmount.Text),

                        DiscountPercentage = string.IsNullOrEmpty(txtDiscountPercent.Text) ? 0 : Convert.ToDecimal(txtDiscountPercent.Text),
                        DiscountPercentageAmount = string.IsNullOrEmpty(txtCustomerDiscountPercangeAmnout.Text) ? 0 : Convert.ToDecimal(txtCustomerDiscountPercangeAmnout.Text),
                        FixedDiscount = string.IsNullOrEmpty(txtFixedDiscount.Text) ? 0 : Convert.ToDecimal(txtFixedDiscount.Text),
                        SalesPersonID = Convert.ToInt32(cmbSalesPersons.SelectedValue)
                    };
                }

                else invc.invcCustomer = null;

                invc.TotalToPay = string.IsNullOrEmpty(txt_TotalPay.Text) ? 0 : Convert.ToDecimal(txt_TotalPay.Text);
                invc.InvoiceNumber = txt_invoiceNo.Text;
                invc.InvoiceType = InvoiceTypeEnum.SaleInvoice.ToString();
                invc.Comment = txt_Note.Text;
                if (invoiceVm.ReferenceInvoiceID > 0)
                {
                    //invc.InvoiceStatus = "Cancelled";
                    invc.ReferenceInvoiceID = invoiceVm.ReferenceInvoiceID;
                    invc.ReferenceInvoiceNumber = invoiceVm.RefereneInvoiceNumber;
                }
                invc.InvoiceDate = Validators.GetStandardDateTime(dpInvoiceDate.Value);
                invc.PaymentMethodID = cmb_Type.SelectedIndex != -1 ? Convert.ToInt32(cmb_Type.SelectedValue) : 0;
                invc.IsActive = 1;

                invoiceManager.SaveInvoice(invc);

                MetroFramework.MetroMessageBox.Show(this, "Invoice Saved Successfully !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invoice List is empty !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void btnPrintOrder_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void SaleInvoiceForm_Load(object sender, EventArgs e)
        {
            cmb_Type.SelectedIndex = 0;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (InvoiceSearchPopup uu = new InvoiceSearchPopup())
                {
                    uu.selectedInvoice += selectedInvoice;
                    uu.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void selectedInvoice(int invoiceId)
        {
            LoadInvoiceDetails(invoiceId);
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

        private void cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDueAmount.Clear();
            btnConfirmPayment.Enabled = false;
            txt_ReceivedMoney.Text = "0";
            txt_ChangeAmount.Text = "0";
        }


        // ======================
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Resources.MIV;
            e.Graphics.DrawImage(image, 5, -5, 815, 1162);

            // Create string to draw.
            String invoiceNo = txt_invoiceNo.Text.Trim();
            String DueMoney = txtDueAmount.Text.Trim() + "  PKR";
            String InvoiceDateSet = dpInvoiceDate.Value.Date.ToShortDateString();
            String InvoiceTimeSet = DateTime.Now.ToLongTimeString();
            String InvoicePaymentDateSet = DateTime_PaymentDate.Value.Date.ToShortDateString();
            //String ClientCompany = txtc.Text.Trim();
            String ClientName = cmbCustomers.Text.Trim();
            String ClientMob = txtMobile.Text.Trim();
            String ClientAddress = txtAddress.Text.Trim();

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


            // Draw Rectangle Location (Office Copy)
            //RectangleF drawRectinvoiceNoTwo = new RectangleF(675, 652, 100, 18);
            //RectangleF drawRectDueMoneyTwo = new RectangleF(675, 674, 100, 16);
            //RectangleF drawRectInvoiceDateSetTwo = new RectangleF(675, 694, 100, 16);
            //RectangleF drawRectInvoiceTimeSetTwo = new RectangleF(675, 714, 100, 16);
            //RectangleF drawRectInvoicePaymentDateSetTwo = new RectangleF(675, 734, 100, 16);
            //RectangleF drawRectClientCompanyTwo = new RectangleF(130, 693, 415, 16);
            //RectangleF drawRectClientNameTwo = new RectangleF(130, 713, 180, 16);
            //RectangleF drawRectClientMobTwo = new RectangleF(397, 713, 145, 16);
            //RectangleF drawRectClientAddressTwo = new RectangleF(130, 734, 415, 16);

            // Draw rectangle to screen.
            //Pen blackPen = new Pen(Color.Black);
            //e.Graphics.DrawRectangle(blackPen, 130, 111, 415, 16);

            // Set format of string.
            StringFormat drawFormatFar = new StringFormat();
            drawFormatFar.Alignment = StringAlignment.Far;
            StringFormat drawFormatNear = new StringFormat();
            drawFormatNear.Alignment = StringAlignment.Near;

            // Draw string to screen (Original Copy)
            e.Graphics.DrawString(invoiceNo, new Font("Arial", 11, FontStyle.Bold), drawBrush, drawRectinvoiceNo, drawFormatFar);
            e.Graphics.DrawString(DueMoney, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectDueMoney, drawFormatFar);
            e.Graphics.DrawString(InvoiceDateSet, drawFont, drawBrush, drawRectInvoiceDateSet, drawFormatFar);
            e.Graphics.DrawString(InvoiceTimeSet, drawFont, drawBrush, drawRectInvoiceTimeSet, drawFormatFar);
            e.Graphics.DrawString(InvoicePaymentDateSet, drawFont, drawBrush, drawRectInvoicePaymentDateSet, drawFormatFar);
            //e.Graphics.DrawString(ClientCompany, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientCompany, drawFormatNear);
            e.Graphics.DrawString(ClientName, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientName, drawFormatNear);
            e.Graphics.DrawString(ClientMob, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientMob, drawFormatNear);
            e.Graphics.DrawString(ClientAddress, drawFont, drawBrush, drawRectClientAddress, drawFormatNear);

            // Draw string to screen (Office Copy)
            //e.Graphics.DrawString(invoiceNo, new Font("Arial", 11, FontStyle.Bold), drawBrush, drawRectinvoiceNoTwo, drawFormatFar);
            //e.Graphics.DrawString(DueMoney, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectDueMoneyTwo, drawFormatFar);
            //e.Graphics.DrawString(InvoiceDateSet, drawFont, drawBrush, drawRectInvoiceDateSetTwo, drawFormatFar);
            //e.Graphics.DrawString(InvoiceTimeSet, drawFont, drawBrush, drawRectInvoiceTimeSetTwo, drawFormatFar);
            //e.Graphics.DrawString(InvoicePaymentDateSet, drawFont, drawBrush, drawRectInvoicePaymentDateSetTwo, drawFormatFar);
            //// e.Graphics.DrawString(ClientCompany, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientCompanyTwo, drawFormatNear);
            //e.Graphics.DrawString(ClientName, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientNameTwo, drawFormatNear);
            //e.Graphics.DrawString(ClientMob, new Font("Arial", 10, FontStyle.Bold), drawBrush, drawRectClientMobTwo, drawFormatNear);
            //e.Graphics.DrawString(ClientAddress, drawFont, drawBrush, drawRectClientAddressTwo, drawFormatNear);

            int count = 1;
            int yPos = 202;
            int yPosTwo = 784;
            for (int i = NumberOfItemsPrintedSoFar; i < invoiceVm.invoiceItems.Count; i++)
            {
                NumberOfItemPerPage++;
                if (NumberOfItemPerPage <= 8)
                {
                    NumberOfItemsPrintedSoFar++;
                    if (NumberOfItemsPrintedSoFar <= invoiceVm.invoiceItems.Count)
                    {
                        // Create string to draw.
                        String SerialNumber = Convert.ToString(count++);
                        String InvItemName = invoiceVm.invoiceItems[i].ProductName;
                        String InvItemInfo = invoiceVm.invoiceItems[i].ProductCode;
                        String InvQuantity = invoiceVm.invoiceItems[i].Quantity.ToString();
                        String InvUnit = invoiceVm.invoiceItems[i].UnitType.ToString();
                        String InvUnitPrice = invoiceVm.invoiceItems[i].UnitPrice.ToString() + "  PKR";
                        String InvTotalPrice = invoiceVm.invoiceItems[i].TotalAmount.ToString() + "  PKR";

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

                        // Draw Rectangle Location (Office Copy)
                        //RectangleF drawRectSerialNumberTwo = new RectangleF(40, yPosTwo, 35, 16);
                        //RectangleF drawRectInvItemNameTwo = new RectangleF(85, yPosTwo, 345, 16);
                        //RectangleF drawRectInvItemInfoTwo = new RectangleF(85, yPosTwo + 14, 345, 14);
                        //RectangleF drawRectInvQuantityTwo = new RectangleF(437, yPosTwo, 58, 16);
                        //RectangleF drawRectInvUnitTwo = new RectangleF(495, yPosTwo, 50, 16);
                        //RectangleF drawRectInvUnitPriceTwo = new RectangleF(550, yPosTwo, 110, 16);
                        //RectangleF drawRectInvTotalPriceTwo = new RectangleF(668, yPosTwo, 120, 16);

                        // Draw rectangle to screen.
                        //Pen blackPen = new Pen(Color.Black);
                        //e.Graphics.DrawRectangle(blackPen, 437, yPos, 58, 16);

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
            String TotalAmount = txt_TotalAmount.Text.Trim() + "  PKR";
            String Discount = txtTotalDiscountAmount.Text.Trim() + "  PKR";
            String TotalPay = txt_TotalPay.Text.Trim() + "  PKR";
            String ReceivedMoney = txt_ReceivedMoney.Text.Trim() + "  PKR";
            String GrandTotalPay = txt_TotalPay.Text.Trim() + "  PKR";
            String InvoiceNote = txt_Note.Text.Trim();
            String InvoiceType = cmb_Type.Text.Trim();

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
            e.Graphics.DrawString(Discount, drawFontBottom, drawBrushBottom, drawRectDiscount, drawFormat);
            e.Graphics.DrawString(TotalPay, new Font("Arial", 10, FontStyle.Bold), drawBrushBottom, drawRectTotalPay, drawFormat);
            e.Graphics.DrawString(ReceivedMoney, drawFontBottom, drawBrushBottom, drawRectReceivedMoney, drawFormat);
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

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void txt_ReceivedMoney_TextChanged(object sender, EventArgs e)
        {
            CalculateValuesVm vm = CalculateAndFill(false);
            if (vm != null && vm.ChangeAmount < 0 && cmb_Type.Text != PaymentMethodEnum.Due.ToString())
            {
                btnConfirmPayment.Enabled = false;
            }
            else if (invoiceVm.ReferenceInvoiceID == 0)
            {
                btnConfirmPayment.Enabled = false;
            }
            else
            {
                btnConfirmPayment.Enabled = false;
            }
        }
    }
}

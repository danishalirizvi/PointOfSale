

namespace PointOfSale.UI.Views
{
    partial class SaleInvoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleInvoiceForm));
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txt_invoiceNo = new System.Windows.Forms.TextBox();
            this.txtUnitType = new System.Windows.Forms.TextBox();
            this.CartdataGridView = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_ChangeAmount = new System.Windows.Forms.TextBox();
            this.btnCalculateDue = new MetroFramework.Controls.MetroButton();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.dpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.DateTime_PaymentDate = new MetroFramework.Controls.MetroDateTime();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.txt_Note = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.txtFixedDiscount = new System.Windows.Forms.TextBox();
            this.txt_ReceivedMoney = new System.Windows.Forms.TextBox();
            this.txt_TotalPay = new System.Windows.Forms.TextBox();
            this.txt_TotalAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAvailableStock = new System.Windows.Forms.TextBox();
            this.lblAvailableStock = new MetroFramework.Controls.MetroLabel();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new MetroFramework.Controls.MetroLabel();
            this.lblMobile = new MetroFramework.Controls.MetroLabel();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblCustomer = new MetroFramework.Controls.MetroLabel();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.txtDueAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAllItems = new MetroFramework.Controls.MetroButton();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.btnPrintOrder = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.btnUpdateDueInvoice = new MetroFramework.Controls.MetroButton();
            this.btnConfirmPayment = new MetroFramework.Controls.MetroButton();
            this.btnCancelInvoice = new MetroFramework.Controls.MetroButton();
            this.btnNewInvoice = new MetroFramework.Controls.MetroButton();
            this.btnPrintPreview = new MetroFramework.Controls.MetroButton();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.txtCustomerDiscountPercangeAmnout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalDiscountAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSalesPersons = new System.Windows.Forms.ComboBox();
            this.lblSalesPerson = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.CartdataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProducts
            // 
            this.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(163, 153);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(250, 24);
            this.cmbProducts.TabIndex = 0;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Quantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(421, 155);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(99, 22);
            this.txt_Quantity.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(636, 155);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 22);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // txt_invoiceNo
            // 
            this.txt_invoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_invoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceNo.Location = new System.Drawing.Point(392, 29);
            this.txt_invoiceNo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_invoiceNo.Name = "txt_invoiceNo";
            this.txt_invoiceNo.ReadOnly = true;
            this.txt_invoiceNo.Size = new System.Drawing.Size(242, 38);
            this.txt_invoiceNo.TabIndex = 16;
            // 
            // txtUnitType
            // 
            this.txtUnitType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitType.Location = new System.Drawing.Point(744, 155);
            this.txtUnitType.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.ReadOnly = true;
            this.txtUnitType.Size = new System.Drawing.Size(100, 22);
            this.txtUnitType.TabIndex = 5;
            // 
            // CartdataGridView
            // 
            this.CartdataGridView.AllowUserToAddRows = false;
            this.CartdataGridView.AllowUserToDeleteRows = false;
            this.CartdataGridView.AllowUserToResizeRows = false;
            this.CartdataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CartdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartdataGridView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CartdataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.CartdataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.CartdataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CartdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.CartdataGridView.EnableHeadersVisualStyles = false;
            this.CartdataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CartdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartdataGridView.Location = new System.Drawing.Point(163, 184);
            this.CartdataGridView.MultiSelect = false;
            this.CartdataGridView.Name = "CartdataGridView";
            this.CartdataGridView.ReadOnly = true;
            this.CartdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.CartdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CartdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartdataGridView.Size = new System.Drawing.Size(1154, 297);
            this.CartdataGridView.TabIndex = 36;
            this.CartdataGridView.UseCustomBackColor = true;
            this.CartdataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CartdataGridView_MouseDown);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(304, 52);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 15);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "INVOICE NO :";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(163, 136);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(120, 15);
            this.metroLabel3.TabIndex = 51;
            this.metroLabel3.Text = "ITEM NAME / CODE :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(421, 136);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 15);
            this.metroLabel6.TabIndex = 51;
            this.metroLabel6.Text = "QUANTITY :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(744, 136);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 15);
            this.metroLabel8.TabIndex = 51;
            this.metroLabel8.Text = "UNIT :";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(636, 136);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(77, 15);
            this.metroLabel9.TabIndex = 51;
            this.metroLabel9.Text = "UNIT PRICE :";
            // 
            // txt_ChangeAmount
            // 
            this.txt_ChangeAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ChangeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChangeAmount.ForeColor = System.Drawing.Color.Red;
            this.txt_ChangeAmount.Location = new System.Drawing.Point(588, 601);
            this.txt_ChangeAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ChangeAmount.Multiline = true;
            this.txt_ChangeAmount.Name = "txt_ChangeAmount";
            this.txt_ChangeAmount.Size = new System.Drawing.Size(185, 30);
            this.txt_ChangeAmount.TabIndex = 20;
            this.txt_ChangeAmount.Text = "0";
            this.txt_ChangeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculateDue
            // 
            this.btnCalculateDue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalculateDue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculateDue.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCalculateDue.ForeColor = System.Drawing.Color.Black;
            this.btnCalculateDue.Location = new System.Drawing.Point(788, 601);
            this.btnCalculateDue.Name = "btnCalculateDue";
            this.btnCalculateDue.Size = new System.Drawing.Size(185, 83);
            this.btnCalculateDue.TabIndex = 55;
            this.btnCalculateDue.Text = "CALCULATE";
            this.btnCalculateDue.UseCustomForeColor = true;
            this.btnCalculateDue.UseSelectable = true;
            this.btnCalculateDue.Click += new System.EventHandler(this.btnCalculateDue_Click);
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(700, 52);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(92, 15);
            this.metroLabel17.TabIndex = 51;
            this.metroLabel17.Text = "INVOICE DATE :";
            // 
            // dpInvoiceDate
            // 
            this.dpInvoiceDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInvoiceDate.Location = new System.Drawing.Point(798, 29);
            this.dpInvoiceDate.Name = "dpInvoiceDate";
            this.dpInvoiceDate.Size = new System.Drawing.Size(242, 38);
            this.dpInvoiceDate.TabIndex = 64;
            // 
            // DateTime_PaymentDate
            // 
            this.DateTime_PaymentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTime_PaymentDate.Location = new System.Drawing.Point(642, 823);
            this.DateTime_PaymentDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.DateTime_PaymentDate.Name = "DateTime_PaymentDate";
            this.DateTime_PaymentDate.Size = new System.Drawing.Size(228, 29);
            this.DateTime_PaymentDate.TabIndex = 65;
            // 
            // cmb_Type
            // 
            this.cmb_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_Type.DisplayMember = "ID";
            this.cmb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Location = new System.Drawing.Point(1071, 505);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(246, 32);
            this.cmb_Type.TabIndex = 66;
            this.cmb_Type.ValueMember = "ID";
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Type_SelectedIndexChanged);
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_Note.CustomButton.Image = null;
            this.txt_Note.CustomButton.Location = new System.Drawing.Point(242, 2);
            this.txt_Note.CustomButton.Name = "";
            this.txt_Note.CustomButton.Size = new System.Drawing.Size(61, 61);
            this.txt_Note.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Note.CustomButton.TabIndex = 1;
            this.txt_Note.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Note.CustomButton.UseSelectable = true;
            this.txt_Note.CustomButton.Visible = false;
            this.txt_Note.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Note.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Note.Lines = new string[0];
            this.txt_Note.Location = new System.Drawing.Point(1011, 565);
            this.txt_Note.MaxLength = 32767;
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.PasswordChar = '\0';
            this.txt_Note.PromptText = "Enter Your Note";
            this.txt_Note.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Note.SelectedText = "";
            this.txt_Note.SelectionLength = 0;
            this.txt_Note.SelectionStart = 0;
            this.txt_Note.ShortcutsEnabled = true;
            this.txt_Note.Size = new System.Drawing.Size(306, 66);
            this.txt_Note.TabIndex = 67;
            this.txt_Note.UseSelectable = true;
            this.txt_Note.WaterMark = "Enter Your Note";
            this.txt_Note.WaterMarkColor = System.Drawing.Color.Silver;
            this.txt_Note.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(584, 578);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "CHANGE AMOUNT";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(478, 830);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "DUE DATE =";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(25, 158);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(99, 19);
            this.metroLabel12.TabIndex = 51;
            this.metroLabel12.Text = "SELECT ITEMS";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(1037, 543);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(280, 19);
            this.metroLabel13.TabIndex = 51;
            this.metroLabel13.Text = "ADDITIONAL NOTE ABOUT THIS INVOICE";
            // 
            // metroLabel14
            // 
            this.metroLabel14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel14.Location = new System.Drawing.Point(1098, 480);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(223, 25);
            this.metroLabel14.TabIndex = 51;
            this.metroLabel14.Text = "CHOOSE PAYMENT TYPE";
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.Black;
            this.lbl_Time.Location = new System.Drawing.Point(39, 60);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(71, 20);
            this.lbl_Time.TabIndex = 46;
            this.lbl_Time.Text = "00:00:00";
            this.lbl_Time.Click += new System.EventHandler(this.lbl_Time_Click);
            // 
            // txtFixedDiscount
            // 
            this.txtFixedDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFixedDiscount.Enabled = false;
            this.txtFixedDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFixedDiscount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtFixedDiscount.Location = new System.Drawing.Point(363, 602);
            this.txtFixedDiscount.Name = "txtFixedDiscount";
            this.txtFixedDiscount.Size = new System.Drawing.Size(185, 29);
            this.txtFixedDiscount.TabIndex = 75;
            this.txtFixedDiscount.Text = "0";
            this.txtFixedDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_ReceivedMoney
            // 
            this.txt_ReceivedMoney.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ReceivedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReceivedMoney.ForeColor = System.Drawing.Color.DarkGreen;
            this.txt_ReceivedMoney.Location = new System.Drawing.Point(588, 509);
            this.txt_ReceivedMoney.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReceivedMoney.Multiline = true;
            this.txt_ReceivedMoney.Name = "txt_ReceivedMoney";
            this.txt_ReceivedMoney.Size = new System.Drawing.Size(185, 30);
            this.txt_ReceivedMoney.TabIndex = 76;
            this.txt_ReceivedMoney.Text = "0";
            this.txt_ReceivedMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ReceivedMoney.TextChanged += new System.EventHandler(this.txt_ReceivedMoney_TextChanged);
            // 
            // txt_TotalPay
            // 
            this.txt_TotalPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TotalPay.Enabled = false;
            this.txt_TotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPay.Location = new System.Drawing.Point(163, 601);
            this.txt_TotalPay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TotalPay.Multiline = true;
            this.txt_TotalPay.Name = "txt_TotalPay";
            this.txt_TotalPay.ReadOnly = true;
            this.txt_TotalPay.Size = new System.Drawing.Size(185, 30);
            this.txt_TotalPay.TabIndex = 77;
            this.txt_TotalPay.Text = "0";
            this.txt_TotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TotalAmount
            // 
            this.txt_TotalAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TotalAmount.Enabled = false;
            this.txt_TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalAmount.ForeColor = System.Drawing.Color.DimGray;
            this.txt_TotalAmount.Location = new System.Drawing.Point(163, 509);
            this.txt_TotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TotalAmount.Name = "txt_TotalAmount";
            this.txt_TotalAmount.Size = new System.Drawing.Size(185, 29);
            this.txt_TotalAmount.TabIndex = 79;
            this.txt_TotalAmount.Text = "0";
            this.txt_TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(584, 486);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 70;
            this.label6.Text = "RECEIVED";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(359, 579);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "(-) DISCOUNT";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(164, 579);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 72;
            this.label3.Text = "TOTAL to PAY";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(164, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "TOTAL AMOUNT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtAvailableStock
            // 
            this.txtAvailableStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableStock.Location = new System.Drawing.Point(528, 155);
            this.txtAvailableStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvailableStock.Name = "txtAvailableStock";
            this.txtAvailableStock.ReadOnly = true;
            this.txtAvailableStock.Size = new System.Drawing.Size(100, 22);
            this.txtAvailableStock.TabIndex = 82;
            // 
            // lblAvailableStock
            // 
            this.lblAvailableStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvailableStock.AutoSize = true;
            this.lblAvailableStock.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAvailableStock.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAvailableStock.Location = new System.Drawing.Point(528, 136);
            this.lblAvailableStock.Name = "lblAvailableStock";
            this.lblAvailableStock.Size = new System.Drawing.Size(45, 15);
            this.lblAvailableStock.TabIndex = 83;
            this.lblAvailableStock.Text = "Stock :";
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.AutoSize = true;
            this.lblAddress.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAddress.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAddress.Location = new System.Drawing.Point(788, 94);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 15);
            this.lblAddress.TabIndex = 89;
            this.lblAddress.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(852, 87);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(216, 90);
            this.txtAddress.TabIndex = 88;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCustomerName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomerName.Location = new System.Drawing.Point(163, 94);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(103, 15);
            this.lblCustomerName.TabIndex = 86;
            this.lblCustomerName.Text = "Customer Name :";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMobile.AutoSize = true;
            this.lblMobile.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMobile.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMobile.Location = new System.Drawing.Point(530, 94);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 15);
            this.lblMobile.TabIndex = 87;
            this.lblMobile.Text = "MOB :";
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobile.Enabled = false;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(578, 87);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(4);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(198, 22);
            this.txtMobile.TabIndex = 85;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomer.Location = new System.Drawing.Point(51, 90);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(73, 19);
            this.lblCustomer.TabIndex = 90;
            this.lblCustomer.Text = "Customer";
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCustomers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCustomers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(273, 85);
            this.cmbCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(250, 24);
            this.cmbCustomers.TabIndex = 93;
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscountPercent.Enabled = false;
            this.txtDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercent.ForeColor = System.Drawing.Color.DarkRed;
            this.txtDiscountPercent.Location = new System.Drawing.Point(363, 508);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(185, 29);
            this.txtDiscountPercent.TabIndex = 94;
            this.txtDiscountPercent.Text = "0";
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(356, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 98;
            this.label4.Text = "(-) DISCOUNT (%)";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // txtDueAmount
            // 
            this.txtDueAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDueAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueAmount.ForeColor = System.Drawing.Color.Red;
            this.txtDueAmount.Location = new System.Drawing.Point(788, 509);
            this.txtDueAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDueAmount.Multiline = true;
            this.txtDueAmount.Name = "txtDueAmount";
            this.txtDueAmount.Size = new System.Drawing.Size(185, 30);
            this.txtDueAmount.TabIndex = 102;
            this.txtDueAmount.Text = "0";
            this.txtDueAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(784, 486);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 19);
            this.label9.TabIndex = 101;
            this.label9.Text = "DUE AMOUNT";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSearch.BackgroundImage = global::PointOfSale.UI.Properties.Resources.searchbutton;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(1219, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 41);
            this.btnSearch.TabIndex = 100;
            this.btnSearch.UseCustomBackColor = true;
            this.btnSearch.UseCustomForeColor = true;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::PointOfSale.UI.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.pictureBox2.Location = new System.Drawing.Point(130, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PointOfSale.UI.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.pictureBox1.Location = new System.Drawing.Point(130, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 91;
            this.pictureBox1.TabStop = false;
            // 
            // btnAllItems
            // 
            this.btnAllItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAllItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllItems.BackgroundImage = global::PointOfSale.UI.Properties.Resources.itemlist2;
            this.btnAllItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAllItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllItems.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAllItems.ForeColor = System.Drawing.Color.Black;
            this.btnAllItems.Location = new System.Drawing.Point(25, 487);
            this.btnAllItems.Name = "btnAllItems";
            this.btnAllItems.Size = new System.Drawing.Size(132, 95);
            this.btnAllItems.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnAllItems.TabIndex = 81;
            this.btnAllItems.Text = "ALL ITEMS";
            this.btnAllItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAllItems.UseSelectable = true;
            this.btnAllItems.Click += new System.EventHandler(this.btnAllItems_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddToCart.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddToCart.BackgroundImage = global::PointOfSale.UI.Properties.Resources.add_icon;
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToCart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.Location = new System.Drawing.Point(1075, 87);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(109, 90);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "ADD ITEM";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToCart.UseCustomBackColor = true;
            this.btnAddToCart.UseCustomForeColor = true;
            this.btnAddToCart.UseSelectable = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintOrder.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPrintOrder.BackgroundImage = global::PointOfSale.UI.Properties.Resources.Print;
            this.btnPrintOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrintOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintOrder.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrintOrder.ForeColor = System.Drawing.Color.White;
            this.btnPrintOrder.Location = new System.Drawing.Point(25, 386);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(132, 95);
            this.btnPrintOrder.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPrintOrder.TabIndex = 11;
            this.btnPrintOrder.Text = "PRINT BILL";
            this.btnPrintOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintOrder.UseCustomBackColor = true;
            this.btnPrintOrder.UseCustomForeColor = true;
            this.btnPrintOrder.UseSelectable = true;
            this.btnPrintOrder.Click += new System.EventHandler(this.btnPrintOrder_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.BackgroundImage = global::PointOfSale.UI.Properties.Resources.close_mini_one1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1271, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 41);
            this.btnClose.TabIndex = 63;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateDueInvoice
            // 
            this.btnUpdateDueInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateDueInvoice.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdateDueInvoice.BackgroundImage = global::PointOfSale.UI.Properties.Resources.update;
            this.btnUpdateDueInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdateDueInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateDueInvoice.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnUpdateDueInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateDueInvoice.Location = new System.Drawing.Point(1190, 87);
            this.btnUpdateDueInvoice.Name = "btnUpdateDueInvoice";
            this.btnUpdateDueInvoice.Size = new System.Drawing.Size(127, 90);
            this.btnUpdateDueInvoice.TabIndex = 58;
            this.btnUpdateDueInvoice.Text = "UPDATE INVOICE";
            this.btnUpdateDueInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateDueInvoice.UseCustomBackColor = true;
            this.btnUpdateDueInvoice.UseCustomForeColor = true;
            this.btnUpdateDueInvoice.UseSelectable = true;
            this.btnUpdateDueInvoice.Click += new System.EventHandler(this.btnUpdateDueInvoice_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirmPayment.BackColor = System.Drawing.Color.LawnGreen;
            this.btnConfirmPayment.BackgroundImage = global::PointOfSale.UI.Properties.Resources.invicon;
            this.btnConfirmPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPayment.Enabled = false;
            this.btnConfirmPayment.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmPayment.Location = new System.Drawing.Point(1132, 633);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(185, 94);
            this.btnConfirmPayment.TabIndex = 9;
            this.btnConfirmPayment.Text = "CONFIRM";
            this.btnConfirmPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmPayment.UseCustomBackColor = true;
            this.btnConfirmPayment.UseCustomForeColor = true;
            this.btnConfirmPayment.UseSelectable = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnCancelInvoice
            // 
            this.btnCancelInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelInvoice.BackColor = System.Drawing.Color.Red;
            this.btnCancelInvoice.BackgroundImage = global::PointOfSale.UI.Properties.Resources.Cancel_Icon;
            this.btnCancelInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancelInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelInvoice.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnCancelInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCancelInvoice.Location = new System.Drawing.Point(25, 285);
            this.btnCancelInvoice.Name = "btnCancelInvoice";
            this.btnCancelInvoice.Size = new System.Drawing.Size(131, 95);
            this.btnCancelInvoice.TabIndex = 14;
            this.btnCancelInvoice.Text = "CANCEL";
            this.btnCancelInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelInvoice.UseCustomBackColor = true;
            this.btnCancelInvoice.UseCustomForeColor = true;
            this.btnCancelInvoice.UseSelectable = true;
            this.btnCancelInvoice.Click += new System.EventHandler(this.btnCancelInvoice_Click);
            // 
            // btnNewInvoice
            // 
            this.btnNewInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewInvoice.BackColor = System.Drawing.Color.Turquoise;
            this.btnNewInvoice.BackgroundImage = global::PointOfSale.UI.Properties.Resources.inv;
            this.btnNewInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewInvoice.DisplayFocus = true;
            this.btnNewInvoice.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnNewInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnNewInvoice.Location = new System.Drawing.Point(25, 184);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(132, 95);
            this.btnNewInvoice.TabIndex = 7;
            this.btnNewInvoice.Text = "NEW INVOICE";
            this.btnNewInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewInvoice.UseSelectable = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrintPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrintPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.BackgroundImage")));
            this.btnPrintPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintPreview.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPrintPreview.ForeColor = System.Drawing.Color.Black;
            this.btnPrintPreview.Location = new System.Drawing.Point(24, 590);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(132, 95);
            this.btnPrintPreview.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnPrintPreview.TabIndex = 103;
            this.btnPrintPreview.Text = "PRINT PREVIEW";
            this.btnPrintPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintPreview.UseSelectable = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductCode.FormattingEnabled = true;
            this.cmbProductCode.Location = new System.Drawing.Point(284, 125);
            this.cmbProductCode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(129, 24);
            this.cmbProductCode.TabIndex = 104;
            // 
            // txtCustomerDiscountPercangeAmnout
            // 
            this.txtCustomerDiscountPercangeAmnout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerDiscountPercangeAmnout.Enabled = false;
            this.txtCustomerDiscountPercangeAmnout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerDiscountPercangeAmnout.ForeColor = System.Drawing.Color.DarkRed;
            this.txtCustomerDiscountPercangeAmnout.Location = new System.Drawing.Point(363, 543);
            this.txtCustomerDiscountPercangeAmnout.Name = "txtCustomerDiscountPercangeAmnout";
            this.txtCustomerDiscountPercangeAmnout.Size = new System.Drawing.Size(185, 29);
            this.txtCustomerDiscountPercangeAmnout.TabIndex = 105;
            this.txtCustomerDiscountPercangeAmnout.Text = "0";
            this.txtCustomerDiscountPercangeAmnout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(555, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 19);
            this.label2.TabIndex = 106;
            this.label2.Text = "%";
            // 
            // txtTotalDiscountAmount
            // 
            this.txtTotalDiscountAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalDiscountAmount.Enabled = false;
            this.txtTotalDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiscountAmount.ForeColor = System.Drawing.Color.DarkRed;
            this.txtTotalDiscountAmount.Location = new System.Drawing.Point(363, 655);
            this.txtTotalDiscountAmount.Name = "txtTotalDiscountAmount";
            this.txtTotalDiscountAmount.Size = new System.Drawing.Size(185, 29);
            this.txtTotalDiscountAmount.TabIndex = 108;
            this.txtTotalDiscountAmount.Text = "0";
            this.txtTotalDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(359, 633);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 19);
            this.label10.TabIndex = 107;
            this.label10.Text = "(-) TOTAL DISCOUNT";
            // 
            // cmbSalesPersons
            // 
            this.cmbSalesPersons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSalesPersons.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSalesPersons.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalesPersons.FormattingEnabled = true;
            this.cmbSalesPersons.Location = new System.Drawing.Point(298, 694);
            this.cmbSalesPersons.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSalesPersons.Name = "cmbSalesPersons";
            this.cmbSalesPersons.Size = new System.Drawing.Size(250, 24);
            this.cmbSalesPersons.TabIndex = 110;
            // 
            // lblSalesPerson
            // 
            this.lblSalesPerson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalesPerson.AutoSize = true;
            this.lblSalesPerson.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSalesPerson.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSalesPerson.Location = new System.Drawing.Point(188, 703);
            this.lblSalesPerson.Name = "lblSalesPerson";
            this.lblSalesPerson.Size = new System.Drawing.Size(82, 15);
            this.lblSalesPerson.TabIndex = 109;
            this.lblSalesPerson.Text = "Sales Person :";
            // 
            // SaleInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.ClientSize = new System.Drawing.Size(1344, 768);
            this.ControlBox = false;
            this.Controls.Add(this.cmbSalesPersons);
            this.Controls.Add(this.lblSalesPerson);
            this.Controls.Add(this.cmbProductCode);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.txtDueAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblAvailableStock);
            this.Controls.Add(this.txtAvailableStock);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtUnitType);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.btnAllItems);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txt_ReceivedMoney);
            this.Controls.Add(this.txt_TotalPay);
            this.Controls.Add(this.txt_TotalAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintOrder);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.DateTime_PaymentDate);
            this.Controls.Add(this.dpInvoiceDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateDueInvoice);
            this.Controls.Add(this.btnCalculateDue);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.btnCancelInvoice);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.txt_ChangeAmount);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_invoiceNo);
            this.Controls.Add(this.CartdataGridView);
            this.Controls.Add(this.txtTotalDiscountAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCustomerDiscountPercangeAmnout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFixedDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiscountPercent);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.metroLabel14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "SaleInvoiceForm";
            this.ShowIcon = false;
            this.Text = "Sale Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleInvoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CartdataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txt_invoiceNo;
        private System.Windows.Forms.TextBox txtUnitType;
        private MetroFramework.Controls.MetroButton btnNewInvoice;
        private MetroFramework.Controls.MetroButton btnCancelInvoice;
        private MetroFramework.Controls.MetroButton btnPrintOrder;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private MetroFramework.Controls.MetroGrid CartdataGridView;
        private MetroFramework.Controls.MetroButton btnConfirmPayment;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.TextBox txt_ChangeAmount;
        private MetroFramework.Controls.MetroButton btnCalculateDue;
        private MetroFramework.Controls.MetroButton btnUpdateDueInvoice;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.DateTimePicker dpInvoiceDate;
        private MetroFramework.Controls.MetroDateTime DateTime_PaymentDate;
        private System.Windows.Forms.ComboBox cmb_Type;
       
        private MetroFramework.Controls.MetroTextBox txt_Note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.TextBox txtFixedDiscount;
        private System.Windows.Forms.TextBox txt_ReceivedMoney;
        private System.Windows.Forms.TextBox txt_TotalPay;
        private System.Windows.Forms.TextBox txt_TotalAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnAllItems;
        private System.Windows.Forms.TextBox txtAvailableStock;
        private MetroFramework.Controls.MetroLabel lblAvailableStock;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private MetroFramework.Controls.MetroLabel lblCustomerName;
        private MetroFramework.Controls.MetroLabel lblMobile;
        private System.Windows.Forms.TextBox txtMobile;
        private MetroFramework.Controls.MetroLabel lblCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton btnSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox txtDueAmount;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroButton btnPrintPreview;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.TextBox txtCustomerDiscountPercangeAmnout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalDiscountAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSalesPersons;
        private MetroFramework.Controls.MetroLabel lblSalesPerson;
    }
}


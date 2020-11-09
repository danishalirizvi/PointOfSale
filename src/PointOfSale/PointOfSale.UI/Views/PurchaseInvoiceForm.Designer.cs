namespace PointOfSale.UI.Views
{
    partial class PurchaseInvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateTime_PaymentDate = new MetroFramework.Controls.MetroDateTime();
            this.dpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtinvoiceNo = new System.Windows.Forms.TextBox();
            this.CartdataGridView = new MetroFramework.Controls.MetroGrid();
            this.btnCancelInvoice = new MetroFramework.Controls.MetroButton();
            this.btnNewInvoice = new MetroFramework.Controls.MetroButton();
            this.txt_TotalPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Note = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.btnConfirmPayment = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtAvailableStock = new System.Windows.Forms.TextBox();
            this.lblAvailableStock = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLastStockDate = new MetroFramework.Controls.MetroLabel();
            this.btnAddToCart = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtLastStockDate = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new MetroFramework.Controls.MetroLabel();
            this.lblMobile = new MetroFramework.Controls.MetroLabel();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSalePrice = new MetroFramework.Controls.MetroLabel();
            this.txtSupplierCompany = new System.Windows.Forms.TextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblSuplierCompany = new MetroFramework.Controls.MetroLabel();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtUnitType = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CartdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTime_PaymentDate
            // 
            this.DateTime_PaymentDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTime_PaymentDate.Location = new System.Drawing.Point(624, 958);
            this.DateTime_PaymentDate.MinimumSize = new System.Drawing.Size(4, 29);
            this.DateTime_PaymentDate.Name = "DateTime_PaymentDate";
            this.DateTime_PaymentDate.Size = new System.Drawing.Size(265, 29);
            this.DateTime_PaymentDate.TabIndex = 119;
            // 
            // dpInvoiceDate
            // 
            this.dpInvoiceDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dpInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpInvoiceDate.Location = new System.Drawing.Point(787, 36);
            this.dpInvoiceDate.Name = "dpInvoiceDate";
            this.dpInvoiceDate.Size = new System.Drawing.Size(282, 38);
            this.dpInvoiceDate.TabIndex = 118;
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel17.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel17.Location = new System.Drawing.Point(689, 59);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(92, 15);
            this.metroLabel17.TabIndex = 112;
            this.metroLabel17.Text = "INVOICE DATE :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(261, 59);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 15);
            this.metroLabel1.TabIndex = 102;
            this.metroLabel1.Text = "INVOICE NO :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(176, 966);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 92;
            this.label8.Text = "DUE DATE =";
            // 
            // txtinvoiceNo
            // 
            this.txtinvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtinvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoiceNo.Location = new System.Drawing.Point(350, 36);
            this.txtinvoiceNo.Margin = new System.Windows.Forms.Padding(5);
            this.txtinvoiceNo.Name = "txtinvoiceNo";
            this.txtinvoiceNo.ReadOnly = true;
            this.txtinvoiceNo.Size = new System.Drawing.Size(282, 38);
            this.txtinvoiceNo.TabIndex = 103;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.CartdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CartdataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.CartdataGridView.EnableHeadersVisualStyles = false;
            this.CartdataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CartdataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CartdataGridView.Location = new System.Drawing.Point(161, 216);
            this.CartdataGridView.MultiSelect = false;
            this.CartdataGridView.Name = "CartdataGridView";
            this.CartdataGridView.ReadOnly = true;
            this.CartdataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CartdataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.CartdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CartdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartdataGridView.Size = new System.Drawing.Size(1139, 366);
            this.CartdataGridView.TabIndex = 105;
            this.CartdataGridView.UseCustomBackColor = true;
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
            this.btnCancelInvoice.Location = new System.Drawing.Point(9, 333);
            this.btnCancelInvoice.Name = "btnCancelInvoice";
            this.btnCancelInvoice.Size = new System.Drawing.Size(145, 110);
            this.btnCancelInvoice.TabIndex = 101;
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
            this.btnNewInvoice.Location = new System.Drawing.Point(9, 216);
            this.btnNewInvoice.Name = "btnNewInvoice";
            this.btnNewInvoice.Size = new System.Drawing.Size(145, 110);
            this.btnNewInvoice.TabIndex = 98;
            this.btnNewInvoice.Text = "NEW INVOICE";
            this.btnNewInvoice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewInvoice.UseSelectable = true;
            this.btnNewInvoice.Click += new System.EventHandler(this.btnNewInvoice_Click);
            // 
            // txt_TotalPay
            // 
            this.txt_TotalPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TotalPay.Enabled = false;
            this.txt_TotalPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalPay.Location = new System.Drawing.Point(880, 695);
            this.txt_TotalPay.Margin = new System.Windows.Forms.Padding(5);
            this.txt_TotalPay.Multiline = true;
            this.txt_TotalPay.Name = "txt_TotalPay";
            this.txt_TotalPay.Size = new System.Drawing.Size(250, 33);
            this.txt_TotalPay.TabIndex = 157;
            this.txt_TotalPay.Text = "0";
            this.txt_TotalPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(994, 669);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 152;
            this.label3.Text = "TOTAL to PAY";
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txt_Note.CustomButton.Image = null;
            this.txt_Note.CustomButton.Location = new System.Drawing.Point(408, 1);
            this.txt_Note.CustomButton.Name = "";
            this.txt_Note.CustomButton.Size = new System.Drawing.Size(119, 119);
            this.txt_Note.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Note.CustomButton.TabIndex = 1;
            this.txt_Note.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Note.CustomButton.UseSelectable = true;
            this.txt_Note.CustomButton.Visible = false;
            this.txt_Note.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_Note.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Note.Lines = new string[0];
            this.txt_Note.Location = new System.Drawing.Point(161, 614);
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
            this.txt_Note.Size = new System.Drawing.Size(528, 121);
            this.txt_Note.TabIndex = 149;
            this.txt_Note.UseSelectable = true;
            this.txt_Note.WaterMark = "Enter Your Note";
            this.txt_Note.WaterMarkColor = System.Drawing.Color.Silver;
            this.txt_Note.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(161, 589);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(280, 19);
            this.metroLabel13.TabIndex = 145;
            this.metroLabel13.Text = "ADDITIONAL NOTE ABOUT THIS INVOICE";
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
            this.btnConfirmPayment.Location = new System.Drawing.Point(1142, 588);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(157, 140);
            this.btnConfirmPayment.TabIndex = 143;
            this.btnConfirmPayment.Text = "CONFIRM";
            this.btnConfirmPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfirmPayment.UseCustomBackColor = true;
            this.btnConfirmPayment.UseCustomForeColor = true;
            this.btnConfirmPayment.UseSelectable = true;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
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
            this.btnClose.Location = new System.Drawing.Point(1246, 27);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 47);
            this.btnClose.TabIndex = 165;
            this.btnClose.UseCustomBackColor = true;
            this.btnClose.UseCustomForeColor = true;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.closebuttonClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(41, 122);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 19);
            this.metroLabel4.TabIndex = 187;
            this.metroLabel4.Text = "SUPPLIER ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(449, 157);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 15);
            this.metroLabel5.TabIndex = 197;
            this.metroLabel5.Text = "ITEM CODE :";
            // 
            // txtAvailableStock
            // 
            this.txtAvailableStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAvailableStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableStock.Location = new System.Drawing.Point(1016, 117);
            this.txtAvailableStock.Margin = new System.Windows.Forms.Padding(5);
            this.txtAvailableStock.Multiline = true;
            this.txtAvailableStock.Name = "txtAvailableStock";
            this.txtAvailableStock.ReadOnly = true;
            this.txtAvailableStock.Size = new System.Drawing.Size(127, 24);
            this.txtAvailableStock.TabIndex = 191;
            // 
            // lblAvailableStock
            // 
            this.lblAvailableStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvailableStock.AutoSize = true;
            this.lblAvailableStock.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblAvailableStock.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAvailableStock.Location = new System.Drawing.Point(1016, 97);
            this.lblAvailableStock.Name = "lblAvailableStock";
            this.lblAvailableStock.Size = new System.Drawing.Size(98, 15);
            this.lblAvailableStock.TabIndex = 188;
            this.lblAvailableStock.Text = "Available Stock :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::PointOfSale.UI.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.pictureBox1.Location = new System.Drawing.Point(123, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 196;
            this.pictureBox1.TabStop = false;
            // 
            // lblLastStockDate
            // 
            this.lblLastStockDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLastStockDate.AutoSize = true;
            this.lblLastStockDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLastStockDate.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLastStockDate.Location = new System.Drawing.Point(884, 95);
            this.lblLastStockDate.Name = "lblLastStockDate";
            this.lblLastStockDate.Size = new System.Drawing.Size(100, 15);
            this.lblLastStockDate.TabIndex = 190;
            this.lblLastStockDate.Text = "Last Stock Date :";
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
            this.btnAddToCart.Location = new System.Drawing.Point(1157, 97);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(143, 104);
            this.btnAddToCart.TabIndex = 174;
            this.btnAddToCart.Text = "ADD ITEM";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddToCart.UseCustomBackColor = true;
            this.btnAddToCart.UseCustomForeColor = true;
            this.btnAddToCart.UseSelectable = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(161, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 15);
            this.metroLabel2.TabIndex = 194;
            this.metroLabel2.Text = "NAME :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::PointOfSale.UI.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_arrow_right;
            this.pictureBox2.Location = new System.Drawing.Point(122, 172);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 195;
            this.pictureBox2.TabStop = false;
            // 
            // txtLastStockDate
            // 
            this.txtLastStockDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastStockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastStockDate.Location = new System.Drawing.Point(883, 117);
            this.txtLastStockDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastStockDate.Multiline = true;
            this.txtLastStockDate.Name = "txtLastStockDate";
            this.txtLastStockDate.ReadOnly = true;
            this.txtLastStockDate.Size = new System.Drawing.Size(127, 24);
            this.txtLastStockDate.TabIndex = 189;
            // 
            // txtMobile
            // 
            this.txtMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobile.Enabled = false;
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(536, 117);
            this.txtMobile.Margin = new System.Windows.Forms.Padding(5);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(130, 24);
            this.txtMobile.TabIndex = 192;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPurchasePrice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPurchasePrice.Location = new System.Drawing.Point(879, 157);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(109, 15);
            this.lblPurchasePrice.TabIndex = 183;
            this.lblPurchasePrice.Text = "PURCHASE PRICE :";
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMobile.AutoSize = true;
            this.lblMobile.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblMobile.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMobile.Location = new System.Drawing.Point(536, 97);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(51, 15);
            this.lblMobile.TabIndex = 193;
            this.lblMobile.Text = "Mobile :";
            // 
            // cmbProducts
            // 
            this.cmbProducts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProducts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProducts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(160, 177);
            this.cmbProducts.Margin = new System.Windows.Forms.Padding(5);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(279, 24);
            this.cmbProducts.TabIndex = 171;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchasePrice.Location = new System.Drawing.Point(879, 179);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(127, 22);
            this.txtPurchasePrice.TabIndex = 182;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(161, 117);
            this.cmbSupplier.Margin = new System.Windows.Forms.Padding(5);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(200, 24);
            this.cmbSupplier.TabIndex = 184;
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSalePrice.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSalePrice.Location = new System.Drawing.Point(1016, 157);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(75, 15);
            this.lblSalePrice.TabIndex = 177;
            this.lblSalePrice.Text = "SALE PRICE :";
            // 
            // txtSupplierCompany
            // 
            this.txtSupplierCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSupplierCompany.Enabled = false;
            this.txtSupplierCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierCompany.Location = new System.Drawing.Point(371, 117);
            this.txtSupplierCompany.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupplierCompany.Multiline = true;
            this.txtSupplierCompany.Name = "txtSupplierCompany";
            this.txtSupplierCompany.ReadOnly = true;
            this.txtSupplierCompany.Size = new System.Drawing.Size(155, 24);
            this.txtSupplierCompany.TabIndex = 186;
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel12.Location = new System.Drawing.Point(17, 182);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(99, 19);
            this.metroLabel12.TabIndex = 178;
            this.metroLabel12.Text = "SELECT ITEMS";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(160, 157);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 15);
            this.metroLabel3.TabIndex = 179;
            this.metroLabel3.Text = "ITEM NAME:";
            // 
            // lblSuplierCompany
            // 
            this.lblSuplierCompany.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuplierCompany.AutoSize = true;
            this.lblSuplierCompany.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblSuplierCompany.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSuplierCompany.Location = new System.Drawing.Point(371, 97);
            this.lblSuplierCompany.Name = "lblSuplierCompany";
            this.lblSuplierCompany.Size = new System.Drawing.Size(70, 15);
            this.lblSuplierCompany.TabIndex = 185;
            this.lblSuplierCompany.Text = "COMPANY :";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductCode.Location = new System.Drawing.Point(449, 179);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(5);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(134, 22);
            this.txtProductCode.TabIndex = 181;
            // 
            // txtUnitType
            // 
            this.txtUnitType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnitType.Enabled = false;
            this.txtUnitType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitType.Location = new System.Drawing.Point(593, 179);
            this.txtUnitType.Margin = new System.Windows.Forms.Padding(5);
            this.txtUnitType.Name = "txtUnitType";
            this.txtUnitType.ReadOnly = true;
            this.txtUnitType.Size = new System.Drawing.Size(134, 22);
            this.txtUnitType.TabIndex = 175;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalePrice.Location = new System.Drawing.Point(1016, 179);
            this.txtSalePrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(127, 22);
            this.txtSalePrice.TabIndex = 173;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(593, 157);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(42, 15);
            this.metroLabel8.TabIndex = 176;
            this.metroLabel8.Text = "UNIT :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(737, 157);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(73, 15);
            this.metroLabel6.TabIndex = 180;
            this.metroLabel6.Text = "QUANTITY :";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(737, 179);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 22);
            this.txtQuantity.TabIndex = 172;
            // 
            // PurchaseInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackLocation = MetroFramework.Forms.BackLocation.BottomLeft;
            this.ClientSize = new System.Drawing.Size(1314, 770);
            this.ControlBox = false;
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtAvailableStock);
            this.Controls.Add(this.lblAvailableStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLastStockDate);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtLastStockDate);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.txtSupplierCompany);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblSuplierCompany);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtUnitType);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txt_TotalPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.DateTime_PaymentDate);
            this.Controls.Add(this.dpInvoiceDate);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnCancelInvoice);
            this.Controls.Add(this.btnNewInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtinvoiceNo);
            this.Controls.Add(this.CartdataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "PurchaseInvoiceForm";
            this.ShowIcon = false;
            this.Text = "Purchase Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.CartdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime DateTime_PaymentDate;
        private System.Windows.Forms.DateTimePicker dpInvoiceDate;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCancelInvoice;
        private MetroFramework.Controls.MetroButton btnNewInvoice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinvoiceNo;
        private MetroFramework.Controls.MetroGrid CartdataGridView;
        private System.Windows.Forms.TextBox txt_TotalPay;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox txt_Note;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton btnConfirmPayment;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.TextBox txtAvailableStock;
        private MetroFramework.Controls.MetroLabel lblAvailableStock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel lblLastStockDate;
        private MetroFramework.Controls.MetroButton btnAddToCart;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtLastStockDate;
        private System.Windows.Forms.TextBox txtMobile;
        private MetroFramework.Controls.MetroLabel lblPurchasePrice;
        private MetroFramework.Controls.MetroLabel lblMobile;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private MetroFramework.Controls.MetroLabel lblSalePrice;
        private System.Windows.Forms.TextBox txtSupplierCompany;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblSuplierCompany;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtUnitType;
        private System.Windows.Forms.TextBox txtSalePrice;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtQuantity;
    }
}
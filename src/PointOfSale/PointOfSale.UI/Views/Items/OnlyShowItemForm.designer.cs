namespace PointOfSale.UI.Views
{
    partial class OnlyShowItemForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlyShowItemForm));
            this.txt_SrchProName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.txtProductCode = new MetroFramework.Controls.MetroTextBox();
            this.lblProductCode = new MetroFramework.Controls.MetroLabel();
            this.productTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.chk_Active = new System.Windows.Forms.CheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txt_ItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.ProductLabel = new MetroFramework.Controls.MetroLabel();
            this.cmbProductTypes = new MetroFramework.Controls.MetroComboBox();
            this.cmbUnitType = new MetroFramework.Controls.MetroComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.rawPriceTotallbl = new MetroFramework.Controls.MetroLabel();
            this.priceTotaallbl = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.chk_Gift = new System.Windows.Forms.CheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtReorder = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtSalePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPurchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SrchProName
            // 
            // 
            // 
            // 
            this.txt_SrchProName.CustomButton.Image = null;
            this.txt_SrchProName.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txt_SrchProName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SrchProName.CustomButton.Name = "";
            this.txt_SrchProName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_SrchProName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_SrchProName.CustomButton.TabIndex = 1;
            this.txt_SrchProName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_SrchProName.CustomButton.UseSelectable = true;
            this.txt_SrchProName.CustomButton.Visible = false;
            this.txt_SrchProName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_SrchProName.Lines = new string[0];
            this.txt_SrchProName.Location = new System.Drawing.Point(756, 33);
            this.txt_SrchProName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SrchProName.MaxLength = 32767;
            this.txt_SrchProName.Name = "txt_SrchProName";
            this.txt_SrchProName.PasswordChar = '\0';
            this.txt_SrchProName.PromptText = "Type your keyword here...";
            this.txt_SrchProName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_SrchProName.SelectedText = "";
            this.txt_SrchProName.SelectionLength = 0;
            this.txt_SrchProName.SelectionStart = 0;
            this.txt_SrchProName.ShortcutsEnabled = true;
            this.txt_SrchProName.Size = new System.Drawing.Size(250, 25);
            this.txt_SrchProName.TabIndex = 2;
            this.txt_SrchProName.UseSelectable = true;
            this.txt_SrchProName.WaterMark = "Type your keyword here...";
            this.txt_SrchProName.WaterMarkColor = System.Drawing.Color.Silver;
            this.txt_SrchProName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SrchProName.TextChanged += new System.EventHandler(this.txt_SrchProName_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(553, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(197, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search with Item Name / Code :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.ForestGreen;
            this.metroLabel5.Location = new System.Drawing.Point(18, 60);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(294, 15);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "NOTE : View all item details from the section below.";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // productsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.productsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.productsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.productsDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGridView.Location = new System.Drawing.Point(18, 216);
            this.productsDataGridView.MultiSelect = false;
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.productsDataGridView.RowHeadersVisible = false;
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(988, 391);
            this.productsDataGridView.TabIndex = 17;
            this.productsDataGridView.SelectionChanged += new System.EventHandler(this.productsDataGridView_SelectionChanged);
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.CustomButton.Image = null;
            this.txtProductCode.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.txtProductCode.CustomButton.Name = "";
            this.txtProductCode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProductCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductCode.CustomButton.TabIndex = 1;
            this.txtProductCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductCode.CustomButton.UseSelectable = true;
            this.txtProductCode.CustomButton.Visible = false;
            this.txtProductCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtProductCode.Lines = new string[0];
            this.txtProductCode.Location = new System.Drawing.Point(178, 181);
            this.txtProductCode.MaxLength = 32767;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.PromptText = "Product Code ...";
            this.txtProductCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.SelectionLength = 0;
            this.txtProductCode.SelectionStart = 0;
            this.txtProductCode.ShortcutsEnabled = true;
            this.txtProductCode.Size = new System.Drawing.Size(123, 30);
            this.txtProductCode.TabIndex = 51;
            this.txtProductCode.UseSelectable = true;
            this.txtProductCode.WaterMark = "Product Code ...";
            this.txtProductCode.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtProductCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProductCode.Location = new System.Drawing.Point(47, 186);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(125, 25);
            this.lblProductCode.TabIndex = 50;
            this.lblProductCode.Text = "Product Code :";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.productTypeLabel.Location = new System.Drawing.Point(53, 145);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.productTypeLabel.TabIndex = 48;
            this.productTypeLabel.Text = "Product Type :";
            // 
            // chk_Active
            // 
            this.chk_Active.AutoSize = true;
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Active.ForeColor = System.Drawing.Color.DarkGreen;
            this.chk_Active.Location = new System.Drawing.Point(419, 184);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(72, 22);
            this.chk_Active.TabIndex = 44;
            this.chk_Active.Text = "Active";
            this.chk_Active.UseVisualStyleBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(338, 145);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 25);
            this.metroLabel9.TabIndex = 45;
            this.metroLabel9.Text = "Unit Type :";
            // 
            // txt_ItemName
            // 
            // 
            // 
            // 
            this.txt_ItemName.CustomButton.Image = null;
            this.txt_ItemName.CustomButton.Location = new System.Drawing.Point(330, 2);
            this.txt_ItemName.CustomButton.Name = "";
            this.txt_ItemName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_ItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ItemName.CustomButton.TabIndex = 1;
            this.txt_ItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ItemName.CustomButton.UseSelectable = true;
            this.txt_ItemName.CustomButton.Visible = false;
            this.txt_ItemName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_ItemName.Lines = new string[0];
            this.txt_ItemName.Location = new System.Drawing.Point(178, 104);
            this.txt_ItemName.MaxLength = 32767;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.PasswordChar = '\0';
            this.txt_ItemName.PromptText = "Type item name or code...";
            this.txt_ItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ItemName.SelectedText = "";
            this.txt_ItemName.SelectionLength = 0;
            this.txt_ItemName.SelectionStart = 0;
            this.txt_ItemName.ShortcutsEnabled = true;
            this.txt_ItemName.Size = new System.Drawing.Size(358, 30);
            this.txt_ItemName.TabIndex = 42;
            this.txt_ItemName.UseSelectable = true;
            this.txt_ItemName.WaterMark = "Type item name or code...";
            this.txt_ItemName.WaterMarkColor = System.Drawing.Color.Silver;
            this.txt_ItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(309, 181);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(104, 25);
            this.metroLabel10.TabIndex = 46;
            this.metroLabel10.Text = "Item Status :";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductLabel.Location = new System.Drawing.Point(41, 109);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(131, 25);
            this.ProductLabel.TabIndex = 47;
            this.ProductLabel.Text = "Product Name :";
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.FormattingEnabled = true;
            this.cmbProductTypes.ItemHeight = 23;
            this.cmbProductTypes.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbProductTypes.Location = new System.Drawing.Point(178, 141);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.PromptText = "Select Product Type";
            this.cmbProductTypes.Size = new System.Drawing.Size(154, 29);
            this.cmbProductTypes.TabIndex = 53;
            this.cmbProductTypes.UseSelectable = true;
            // 
            // cmbUnitType
            // 
            this.cmbUnitType.FormattingEnabled = true;
            this.cmbUnitType.ItemHeight = 23;
            this.cmbUnitType.Items.AddRange(new object[] {
            "Pcs",
            "Kg",
            "Box",
            "Cm",
            "Gram",
            "Inches",
            "Litres",
            "Meter",
            "Pound",
            "Set",
            "Sq.M",
            "Ton",
            "Mm",
            "Bag",
            "Feet"});
            this.cmbUnitType.Location = new System.Drawing.Point(435, 141);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.PromptText = "Select Unit";
            this.cmbUnitType.Size = new System.Drawing.Size(101, 29);
            this.cmbUnitType.TabIndex = 54;
            this.cmbUnitType.UseSelectable = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(777, 60);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(229, 37);
            this.bindingNavigator1.TabIndex = 55;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.OrangeRed;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(104, 34);
            this.toolStripButton1.Text = "DELETE";
            this.toolStripButton1.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripButton2.Image = global::PointOfSale.UI.Properties.Resources.check;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(113, 34);
            this.toolStripButton2.Text = "UPDATE";
            this.toolStripButton2.Click += new System.EventHandler(this.expenseBindingNavigatorSaveItem_Click);
            // 
            // rawPriceTotallbl
            // 
            this.rawPriceTotallbl.AutoSize = true;
            this.rawPriceTotallbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.rawPriceTotallbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.rawPriceTotallbl.Location = new System.Drawing.Point(766, 188);
            this.rawPriceTotallbl.Name = "rawPriceTotallbl";
            this.rawPriceTotallbl.Size = new System.Drawing.Size(119, 25);
            this.rawPriceTotallbl.TabIndex = 56;
            this.rawPriceTotallbl.Text = "RawPriceTotal";
            // 
            // priceTotaallbl
            // 
            this.priceTotaallbl.AutoSize = true;
            this.priceTotaallbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.priceTotaallbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.priceTotaallbl.Location = new System.Drawing.Point(898, 188);
            this.priceTotaallbl.Name = "priceTotaallbl";
            this.priceTotaallbl.Size = new System.Drawing.Size(86, 25);
            this.priceTotaallbl.TabIndex = 57;
            this.priceTotaallbl.Text = "PriceTotal";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(693, 188);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 25);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "Total";
            // 
            // chk_Gift
            // 
            this.chk_Gift.AutoSize = true;
            this.chk_Gift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Gift.ForeColor = System.Drawing.Color.DarkGreen;
            this.chk_Gift.Location = new System.Drawing.Point(588, 184);
            this.chk_Gift.Name = "chk_Gift";
            this.chk_Gift.Size = new System.Drawing.Size(72, 22);
            this.chk_Gift.TabIndex = 60;
            this.chk_Gift.Text = "Active";
            this.chk_Gift.UseVisualStyleBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(497, 181);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(85, 25);
            this.metroLabel3.TabIndex = 61;
            this.metroLabel3.Text = "Gift Item :";
            // 
            // txtReorder
            // 
            // 
            // 
            // 
            this.txtReorder.CustomButton.Image = null;
            this.txtReorder.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtReorder.CustomButton.Name = "";
            this.txtReorder.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtReorder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReorder.CustomButton.TabIndex = 1;
            this.txtReorder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReorder.CustomButton.UseSelectable = true;
            this.txtReorder.CustomButton.Visible = false;
            this.txtReorder.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtReorder.Lines = new string[0];
            this.txtReorder.Location = new System.Drawing.Point(542, 141);
            this.txtReorder.MaxLength = 32767;
            this.txtReorder.Name = "txtReorder";
            this.txtReorder.PasswordChar = '\0';
            this.txtReorder.PromptText = "ReOrder Quantity...";
            this.txtReorder.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReorder.SelectedText = "";
            this.txtReorder.SelectionLength = 0;
            this.txtReorder.SelectionStart = 0;
            this.txtReorder.ShortcutsEnabled = true;
            this.txtReorder.Size = new System.Drawing.Size(150, 30);
            this.txtReorder.TabIndex = 63;
            this.txtReorder.UseSelectable = true;
            this.txtReorder.WaterMark = "ReOrder Quantity...";
            this.txtReorder.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtReorder.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(542, 113);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(128, 25);
            this.metroLabel4.TabIndex = 62;
            this.metroLabel4.Text = "ReOrder Level :";
            // 
            // txtSalePrice
            // 
            // 
            // 
            // 
            this.txtSalePrice.CustomButton.Image = null;
            this.txtSalePrice.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtSalePrice.CustomButton.Name = "";
            this.txtSalePrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSalePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalePrice.CustomButton.TabIndex = 1;
            this.txtSalePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalePrice.CustomButton.UseSelectable = true;
            this.txtSalePrice.CustomButton.Visible = false;
            this.txtSalePrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSalePrice.Lines = new string[0];
            this.txtSalePrice.Location = new System.Drawing.Point(698, 141);
            this.txtSalePrice.MaxLength = 32767;
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.PasswordChar = '\0';
            this.txtSalePrice.PromptText = "Unit Sale Price...";
            this.txtSalePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalePrice.SelectedText = "";
            this.txtSalePrice.SelectionLength = 0;
            this.txtSalePrice.SelectionStart = 0;
            this.txtSalePrice.ShortcutsEnabled = true;
            this.txtSalePrice.Size = new System.Drawing.Size(150, 30);
            this.txtSalePrice.TabIndex = 65;
            this.txtSalePrice.UseSelectable = true;
            this.txtSalePrice.WaterMark = "Unit Sale Price...";
            this.txtSalePrice.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtSalePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(698, 112);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(94, 25);
            this.metroLabel6.TabIndex = 64;
            this.metroLabel6.Text = "Sale Price :";
            // 
            // txtPurchasePrice
            // 
            // 
            // 
            // 
            this.txtPurchasePrice.CustomButton.Image = null;
            this.txtPurchasePrice.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtPurchasePrice.CustomButton.Name = "";
            this.txtPurchasePrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtPurchasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPurchasePrice.CustomButton.TabIndex = 1;
            this.txtPurchasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPurchasePrice.CustomButton.UseSelectable = true;
            this.txtPurchasePrice.CustomButton.Visible = false;
            this.txtPurchasePrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPurchasePrice.Lines = new string[0];
            this.txtPurchasePrice.Location = new System.Drawing.Point(854, 140);
            this.txtPurchasePrice.MaxLength = 32767;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PasswordChar = '\0';
            this.txtPurchasePrice.PromptText = "Unit Purchase Price...";
            this.txtPurchasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.SelectionLength = 0;
            this.txtPurchasePrice.SelectionStart = 0;
            this.txtPurchasePrice.ShortcutsEnabled = true;
            this.txtPurchasePrice.Size = new System.Drawing.Size(150, 30);
            this.txtPurchasePrice.TabIndex = 67;
            this.txtPurchasePrice.UseSelectable = true;
            this.txtPurchasePrice.WaterMark = "Unit Purchase Price...";
            this.txtPurchasePrice.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtPurchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(854, 111);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(132, 25);
            this.metroLabel7.TabIndex = 66;
            this.metroLabel7.Text = "Purchase Price :";
            // 
            // OnlyShowItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 626);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtReorder);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.chk_Gift);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.priceTotaallbl);
            this.Controls.Add(this.rawPriceTotallbl);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.cmbUnitType);
            this.Controls.Add(this.cmbProductTypes);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.productTypeLabel);
            this.Controls.Add(this.chk_Active);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txt_SrchProName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "OnlyShowItemForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.ShowIcon = false;
            this.Text = "All Item Details";
            this.Load += new System.EventHandler(this.OnlyShowItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_SrchProName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private MetroFramework.Controls.MetroTextBox txtProductCode;
        private MetroFramework.Controls.MetroLabel lblProductCode;
        private MetroFramework.Controls.MetroLabel productTypeLabel;
        private System.Windows.Forms.CheckBox chk_Active;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txt_ItemName;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel ProductLabel;
        private MetroFramework.Controls.MetroComboBox cmbProductTypes;
        private MetroFramework.Controls.MetroComboBox cmbUnitType;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private MetroFramework.Controls.MetroLabel rawPriceTotallbl;
        private MetroFramework.Controls.MetroLabel priceTotaallbl;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.CheckBox chk_Gift;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtReorder;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtSalePrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPurchasePrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
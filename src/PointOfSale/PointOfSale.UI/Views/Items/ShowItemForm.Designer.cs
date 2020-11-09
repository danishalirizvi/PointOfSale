
namespace PointOfSale.UI.Views
{
    partial class ShowItemForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label productPriceLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label stockDateLabel;
            System.Windows.Forms.Label productRawPriceLabel;
            System.Windows.Forms.Label companyLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowItemForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
     
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
             
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.proValueTextBox = new System.Windows.Forms.TextBox();
            this.stockDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productRawPriceTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            iDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            productPriceLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            stockDateLabel = new System.Windows.Forms.Label();
            productRawPriceLabel = new System.Windows.Forms.Label();
            companyLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
 
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.Color.Black;
            iDLabel.Location = new System.Drawing.Point(114, 140);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(31, 18);
            iDLabel.TabIndex = 34;
            iDLabel.Text = "ID :";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productNameLabel.ForeColor = System.Drawing.Color.Black;
            productNameLabel.Location = new System.Drawing.Point(55, 172);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(90, 18);
            productNameLabel.TabIndex = 38;
            productNameLabel.Text = "Item Name :";
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productPriceLabel.ForeColor = System.Drawing.Color.Black;
            productPriceLabel.Location = new System.Drawing.Point(59, 204);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new System.Drawing.Size(86, 18);
            productPriceLabel.TabIndex = 40;
            productPriceLabel.Text = "Unit Price :";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.ForeColor = System.Drawing.Color.Black;
            stockLabel.Location = new System.Drawing.Point(30, 239);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(115, 18);
            stockLabel.TabIndex = 44;
            stockLabel.Text = "Current Stock :";
            // 
            // stockDateLabel
            // 
            stockDateLabel.AutoSize = true;
            stockDateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockDateLabel.ForeColor = System.Drawing.Color.Black;
            stockDateLabel.Location = new System.Drawing.Point(18, 306);
            stockDateLabel.Name = "stockDateLabel";
            stockDateLabel.Size = new System.Drawing.Size(127, 18);
            stockDateLabel.TabIndex = 48;
            stockDateLabel.Text = "Last Stock Date :";
            // 
            // productRawPriceLabel
            // 
            productRawPriceLabel.AutoSize = true;
            productRawPriceLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            productRawPriceLabel.ForeColor = System.Drawing.Color.Black;
            productRawPriceLabel.Location = new System.Drawing.Point(25, 335);
            productRawPriceLabel.Name = "productRawPriceLabel";
            productRawPriceLabel.Size = new System.Drawing.Size(120, 18);
            productRawPriceLabel.TabIndex = 50;
            productRawPriceLabel.Text = "Unit Raw Price :";
            // 
            // companyLabel
            // 
            companyLabel.AutoSize = true;
            companyLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            companyLabel.ForeColor = System.Drawing.Color.Black;
            companyLabel.Location = new System.Drawing.Point(69, 367);
            companyLabel.Name = "companyLabel";
            companyLabel.Size = new System.Drawing.Size(76, 18);
            companyLabel.TabIndex = 52;
            companyLabel.Text = "Supplier :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(62, 271);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(83, 18);
            label1.TabIndex = 44;
            label1.Text = "Unit Type :";
            // 
            // productDatabaseDataSet
 
            // 
            // productsBindingSource
 
            // 
            // productsTableAdapter
            // 
        
            // 
            // tableAdapterManager
            // 
            
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = null;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = null;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(151, 89);
            this.productsBindingNavigator.MoveFirstItem = null;
            this.productsBindingNavigator.MoveLastItem = null;
            this.productsBindingNavigator.MoveNextItem = null;
            this.productsBindingNavigator.MovePreviousItem = null;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = null;
            this.productsBindingNavigator.Size = new System.Drawing.Size(188, 32);
            this.productsBindingNavigator.TabIndex = 34;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(97, 29);
            this.bindingNavigatorDeleteItem.Text = "DELETE";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.BackColor = System.Drawing.Color.Transparent;
            this.productsBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.Green;
            this.productsBindingNavigatorSaveItem.Image = global::PointOfSale.UI.Properties.Resources.check;
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(79, 29);
            this.productsBindingNavigatorSaveItem.Text = "SAVE";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click_3);
            // 
            // productsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.productsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
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
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.productsDataGridView.DataSource = this.productsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.productsDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.productsDataGridView.Location = new System.Drawing.Point(400, 89);
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
            this.productsDataGridView.Size = new System.Drawing.Size(757, 492);
            this.productsDataGridView.TabIndex = 34;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 102;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsActive";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Status";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 53;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductPrice";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ProValue";
            this.dataGridViewTextBoxColumn6.HeaderText = "Unit Type";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 92;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn5.HeaderText = "Current Stock";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 119;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StockDate";
            this.dataGridViewTextBoxColumn7.HeaderText = "Last Stock Date";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 131;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductRawPrice";
            this.dataGridViewTextBoxColumn8.HeaderText = "Unit Raw Price";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 127;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Company";
            this.dataGridViewTextBoxColumn9.HeaderText = "Supplier";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 87;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iDTextBox.Location = new System.Drawing.Point(151, 136);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(240, 26);
            this.iDTextBox.TabIndex = 35;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.Location = new System.Drawing.Point(151, 168);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(240, 26);
            this.productNameTextBox.TabIndex = 39;
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductPrice", true));
            this.productPriceTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceTextBox.Location = new System.Drawing.Point(151, 200);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(240, 26);
            this.productPriceTextBox.TabIndex = 41;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productsBindingSource, "IsActive", true));
            this.isActiveCheckBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isActiveCheckBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.isActiveCheckBox.Location = new System.Drawing.Point(308, 269);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(83, 24);
            this.isActiveCheckBox.TabIndex = 43;
            this.isActiveCheckBox.Text = "Active";
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Stock", true));
            this.stockTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockTextBox.Location = new System.Drawing.Point(151, 235);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(240, 26);
            this.stockTextBox.TabIndex = 45;
            // 
            // proValueTextBox
            // 
            this.proValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProValue", true));
            this.proValueTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proValueTextBox.Location = new System.Drawing.Point(151, 267);
            this.proValueTextBox.Name = "proValueTextBox";
            this.proValueTextBox.Size = new System.Drawing.Size(133, 26);
            this.proValueTextBox.TabIndex = 47;
            // 
            // stockDateDateTimePicker
            // 
            this.stockDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productsBindingSource, "StockDate", true));
            this.stockDateDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDateDateTimePicker.Location = new System.Drawing.Point(151, 299);
            this.stockDateDateTimePicker.Name = "stockDateDateTimePicker";
            this.stockDateDateTimePicker.Size = new System.Drawing.Size(240, 26);
            this.stockDateDateTimePicker.TabIndex = 49;
            // 
            // productRawPriceTextBox
            // 
            this.productRawPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductRawPrice", true));
            this.productRawPriceTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productRawPriceTextBox.Location = new System.Drawing.Point(151, 331);
            this.productRawPriceTextBox.Name = "productRawPriceTextBox";
            this.productRawPriceTextBox.Size = new System.Drawing.Size(240, 26);
            this.productRawPriceTextBox.TabIndex = 51;
            // 
            // companyTextBox
            // 
            this.companyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Company", true));
            this.companyTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTextBox.Location = new System.Drawing.Point(151, 363);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(240, 26);
            this.companyTextBox.TabIndex = 53;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.ForeColor = System.Drawing.Color.ForestGreen;
            this.metroLabel5.Location = new System.Drawing.Point(18, 58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(591, 15);
            this.metroLabel5.TabIndex = 58;
            this.metroLabel5.Text = "NOTE :  Manage item details from the section below and press the SAVE button afte" +
    "r editing information!";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // ShowItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 600);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(productPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(label1);
            this.Controls.Add(stockLabel);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.proValueTextBox);
            this.Controls.Add(stockDateLabel);
            this.Controls.Add(this.stockDateDateTimePicker);
            this.Controls.Add(productRawPriceLabel);
            this.Controls.Add(this.productRawPriceTextBox);
            this.Controls.Add(companyLabel);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.productsDataGridView);
            this.Controls.Add(this.productsBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowItemForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.ShowIcon = false;
            this.Text = "Manage Items Details";
            this.Load += new System.EventHandler(this.ShowItemForm_Load);
 
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
        private System.Windows.Forms.BindingSource productsBindingSource;
 
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.TextBox proValueTextBox;
        private System.Windows.Forms.DateTimePicker stockDateDateTimePicker;
        private System.Windows.Forms.TextBox productRawPriceTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;


    }
}
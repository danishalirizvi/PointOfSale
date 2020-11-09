﻿namespace PointOfSale.UI.Views
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
            this.txt_SrchProName.Location = new System.Drawing.Point(756, 48);
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
            this.metroLabel1.Location = new System.Drawing.Point(553, 54);
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
            this.productsDataGridView.Location = new System.Drawing.Point(18, 201);
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
            this.txtProductCode.Location = new System.Drawing.Point(189, 160);
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
            this.lblProductCode.Location = new System.Drawing.Point(58, 165);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(125, 25);
            this.lblProductCode.TabIndex = 50;
            this.lblProductCode.Text = "Product Code :";
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.productTypeLabel.Location = new System.Drawing.Point(64, 129);
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
            this.chk_Active.Location = new System.Drawing.Point(430, 168);
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
            this.metroLabel9.Location = new System.Drawing.Point(349, 129);
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
            this.txt_ItemName.Location = new System.Drawing.Point(189, 88);
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
            this.metroLabel10.Location = new System.Drawing.Point(320, 165);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(104, 25);
            this.metroLabel10.TabIndex = 46;
            this.metroLabel10.Text = "Item Status :";
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductLabel.Location = new System.Drawing.Point(52, 93);
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
            this.cmbProductTypes.Location = new System.Drawing.Point(189, 125);
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
            this.cmbUnitType.Location = new System.Drawing.Point(446, 125);
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
            this.bindingNavigator1.Location = new System.Drawing.Point(746, 153);
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
            // OnlyShowItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 611);
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
    }
}
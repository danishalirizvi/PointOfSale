
namespace PointOfSale.UI.Views
{
    partial class AddItemForm
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
            this.ProductLabel = new MetroFramework.Controls.MetroLabel();
            this.txt_ItemName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.chk_Active = new System.Windows.Forms.CheckBox();
            this.AddItemDateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.lblProductCode = new MetroFramework.Controls.MetroLabel();
            this.cmbUnitType = new MetroFramework.Controls.MetroComboBox();
            this.cmbProductTypes = new MetroFramework.Controls.MetroComboBox();
            this.txtProductCode = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductLabel
            // 
            this.ProductLabel.AutoSize = true;
            this.ProductLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ProductLabel.Location = new System.Drawing.Point(189, 146);
            this.ProductLabel.Name = "ProductLabel";
            this.ProductLabel.Size = new System.Drawing.Size(131, 25);
            this.ProductLabel.TabIndex = 16;
            this.ProductLabel.Text = "Product Name :";
            // 
            // txt_ItemName
            // 
            // 
            // 
            // 
            this.txt_ItemName.CustomButton.Image = null;
            this.txt_ItemName.CustomButton.Location = new System.Drawing.Point(359, 2);
            this.txt_ItemName.CustomButton.Name = "";
            this.txt_ItemName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_ItemName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_ItemName.CustomButton.TabIndex = 1;
            this.txt_ItemName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_ItemName.CustomButton.UseSelectable = true;
            this.txt_ItemName.CustomButton.Visible = false;
            this.txt_ItemName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_ItemName.Lines = new string[0];
            this.txt_ItemName.Location = new System.Drawing.Point(326, 141);
            this.txt_ItemName.MaxLength = 32767;
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.PasswordChar = '\0';
            this.txt_ItemName.PromptText = "Type item Name...";
            this.txt_ItemName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_ItemName.SelectedText = "";
            this.txt_ItemName.SelectionLength = 0;
            this.txt_ItemName.SelectionStart = 0;
            this.txt_ItemName.ShortcutsEnabled = true;
            this.txt_ItemName.Size = new System.Drawing.Size(387, 30);
            this.txt_ItemName.TabIndex = 0;
            this.txt_ItemName.UseSelectable = true;
            this.txt_ItemName.WaterMark = "Type item Name...";
            this.txt_ItemName.WaterMarkColor = System.Drawing.Color.Silver;
            this.txt_ItemName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(229, 181);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 25);
            this.metroLabel9.TabIndex = 12;
            this.metroLabel9.Text = "Unit Type :";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addButton.Location = new System.Drawing.Point(407, 283);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(150, 50);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "ADD ITEM";
            this.addButton.UseCustomBackColor = true;
            this.addButton.UseCustomForeColor = true;
            this.addButton.UseSelectable = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.Location = new System.Drawing.Point(563, 283);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(150, 50);
            this.metroButton2.TabIndex = 11;
            this.metroButton2.Text = "ALL ITEMS";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // chk_Active
            // 
            this.chk_Active.AutoSize = true;
            this.chk_Active.Checked = true;
            this.chk_Active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Active.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Active.ForeColor = System.Drawing.Color.DarkGreen;
            this.chk_Active.Location = new System.Drawing.Point(476, 248);
            this.chk_Active.Name = "chk_Active";
            this.chk_Active.Size = new System.Drawing.Size(72, 22);
            this.chk_Active.TabIndex = 5;
            this.chk_Active.Text = "Active";
            this.chk_Active.UseVisualStyleBackColor = true;
            // 
            // AddItemDateTimePicker
            // 
            this.AddItemDateTimePicker.Location = new System.Drawing.Point(326, 106);
            this.AddItemDateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.AddItemDateTimePicker.Name = "AddItemDateTimePicker";
            this.AddItemDateTimePicker.Size = new System.Drawing.Size(237, 29);
            this.AddItemDateTimePicker.TabIndex = 18;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(264, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 25);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "Date :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(366, 248);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(104, 25);
            this.metroLabel10.TabIndex = 13;
            this.metroLabel10.Text = "Item Status :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(238, 15);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "NOTE :  Add item from the section below!";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PointOfSale.UI.Properties.Resources.ds_8;
            this.pictureBox2.Location = new System.Drawing.Point(31, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 146);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.productTypeLabel.Location = new System.Drawing.Point(351, 217);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(119, 25);
            this.productTypeLabel.TabIndex = 38;
            this.productTypeLabel.Text = "Product Type :";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblProductCode.Location = new System.Drawing.Point(432, 181);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(125, 25);
            this.lblProductCode.TabIndex = 40;
            this.lblProductCode.Text = "Product Code :";
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
            this.cmbUnitType.Location = new System.Drawing.Point(326, 177);
            this.cmbUnitType.Name = "cmbUnitType";
            this.cmbUnitType.PromptText = "Select Unit";
            this.cmbUnitType.Size = new System.Drawing.Size(100, 29);
            this.cmbUnitType.TabIndex = 56;
            this.cmbUnitType.UseSelectable = true;
            // 
            // cmbProductTypes
            // 
            this.cmbProductTypes.FormattingEnabled = true;
            this.cmbProductTypes.ItemHeight = 23;
            this.cmbProductTypes.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbProductTypes.Location = new System.Drawing.Point(476, 213);
            this.cmbProductTypes.Name = "cmbProductTypes";
            this.cmbProductTypes.PromptText = "Select Product Type";
            this.cmbProductTypes.Size = new System.Drawing.Size(150, 29);
            this.cmbProductTypes.TabIndex = 55;
            this.cmbProductTypes.UseSelectable = true;
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.CustomButton.Image = null;
            this.txtProductCode.CustomButton.Location = new System.Drawing.Point(122, 2);
            this.txtProductCode.CustomButton.Name = "";
            this.txtProductCode.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtProductCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductCode.CustomButton.TabIndex = 1;
            this.txtProductCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductCode.CustomButton.UseSelectable = true;
            this.txtProductCode.CustomButton.Visible = false;
            this.txtProductCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtProductCode.Lines = new string[0];
            this.txtProductCode.Location = new System.Drawing.Point(563, 176);
            this.txtProductCode.MaxLength = 32767;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.PromptText = "Product Code...";
            this.txtProductCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.SelectionLength = 0;
            this.txtProductCode.SelectionStart = 0;
            this.txtProductCode.ShortcutsEnabled = true;
            this.txtProductCode.Size = new System.Drawing.Size(150, 30);
            this.txtProductCode.TabIndex = 57;
            this.txtProductCode.UseSelectable = true;
            this.txtProductCode.WaterMark = "Product Code...";
            this.txtProductCode.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtProductCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 349);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.cmbUnitType);
            this.Controls.Add(this.cmbProductTypes);
            this.Controls.Add(this.lblProductCode);
            this.Controls.Add(this.productTypeLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddItemDateTimePicker);
            this.Controls.Add(this.chk_Active);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.ProductLabel);
            this.Controls.Add(this.metroLabel4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddItemForm";
            this.Text = "Add Product Item Form";
            this.Load += new System.EventHandler(this.On_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel ProductLabel;
        private MetroFramework.Controls.MetroTextBox txt_ItemName;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton addButton;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.CheckBox chk_Active;
        private MetroFramework.Controls.MetroDateTime AddItemDateTimePicker;
 
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel productTypeLabel;
        private MetroFramework.Controls.MetroLabel lblProductCode;
        private MetroFramework.Controls.MetroComboBox cmbUnitType;
        private MetroFramework.Controls.MetroComboBox cmbProductTypes;
        private MetroFramework.Controls.MetroTextBox txtProductCode;
    }
}
namespace PointOfSale.UI.Views
{
    partial class ManageProductTypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProductTypesForm));
            this.typesDataGridView = new System.Windows.Forms.DataGridView();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.searchField = new MetroFramework.Controls.MetroTextBox();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.typelbl = new MetroFramework.Controls.MetroLabel();
            this.txttypeupdate = new MetroFramework.Controls.MetroTextBox();
            this.txtDescription = new MetroFramework.Controls.MetroTextBox();
            this.descriptionLbl = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // typesDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.typesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.typesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.typesDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.typesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.typesDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.typesDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.typesDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.typesDataGridView.Location = new System.Drawing.Point(211, 174);
            this.typesDataGridView.MultiSelect = false;
            this.typesDataGridView.Name = "typesDataGridView";
            this.typesDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.typesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.typesDataGridView.RowHeadersVisible = false;
            this.typesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.typesDataGridView.Size = new System.Drawing.Size(430, 336);
            this.typesDataGridView.TabIndex = 34;
            this.typesDataGridView.SelectionChanged += new System.EventHandler(this.typesDataGridView_SelectionChanged);
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(18, 58);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(602, 15);
            this.subHeadingLabel.TabIndex = 58;
            this.subHeadingLabel.Text = "NOTE :  Manage product types from the section below and press the SAVE button aft" +
    "er editing information!";
            this.subHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // expenseBindingNavigator
            // 
            this.expenseBindingNavigator.AddNewItem = null;
            this.expenseBindingNavigator.CountItem = null;
            this.expenseBindingNavigator.DeleteItem = null;
            this.expenseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.expenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.toolStripButton3});
            this.expenseBindingNavigator.Location = new System.Drawing.Point(18, 99);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(229, 37);
            this.expenseBindingNavigator.TabIndex = 64;
            this.expenseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(104, 34);
            this.bindingNavigatorDeleteItem.Text = "DELETE";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // searchField
            // 
            // 
            // 
            // 
            this.searchField.CustomButton.Image = null;
            this.searchField.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.searchField.CustomButton.Name = "";
            this.searchField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchField.CustomButton.TabIndex = 1;
            this.searchField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchField.CustomButton.UseSelectable = true;
            this.searchField.CustomButton.Visible = false;
            this.searchField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchField.Lines = new string[0];
            this.searchField.Location = new System.Drawing.Point(448, 139);
            this.searchField.MaxLength = 32767;
            this.searchField.Name = "searchField";
            this.searchField.PasswordChar = '\0';
            this.searchField.PromptText = "Product Type...";
            this.searchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchField.SelectedText = "";
            this.searchField.SelectionLength = 0;
            this.searchField.SelectionStart = 0;
            this.searchField.ShortcutsEnabled = true;
            this.searchField.Size = new System.Drawing.Size(193, 29);
            this.searchField.TabIndex = 72;
            this.searchField.UseSelectable = true;
            this.searchField.WaterMark = "Product Type...";
            this.searchField.WaterMarkColor = System.Drawing.Color.Silver;
            this.searchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.searchLabel.Location = new System.Drawing.Point(471, 111);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(170, 25);
            this.searchLabel.TabIndex = 71;
            this.searchLabel.Text = "SearchProduct Type :";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripButton3.Image = global::PointOfSale.UI.Properties.Resources.check;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(113, 34);
            this.toolStripButton3.Text = "UPDATE";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // typelbl
            // 
            this.typelbl.AutoSize = true;
            this.typelbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.typelbl.Location = new System.Drawing.Point(18, 210);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(119, 25);
            this.typelbl.TabIndex = 73;
            this.typelbl.Text = "Product Type :";
            // 
            // txttypeupdate
            // 
            // 
            // 
            // 
            this.txttypeupdate.CustomButton.Image = null;
            this.txttypeupdate.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txttypeupdate.CustomButton.Name = "";
            this.txttypeupdate.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txttypeupdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttypeupdate.CustomButton.TabIndex = 1;
            this.txttypeupdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttypeupdate.CustomButton.UseSelectable = true;
            this.txttypeupdate.CustomButton.Visible = false;
            this.txttypeupdate.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txttypeupdate.Lines = new string[0];
            this.txttypeupdate.Location = new System.Drawing.Point(18, 238);
            this.txttypeupdate.MaxLength = 32767;
            this.txttypeupdate.Name = "txttypeupdate";
            this.txttypeupdate.PasswordChar = '\0';
            this.txttypeupdate.PromptText = "Product Type...";
            this.txttypeupdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttypeupdate.SelectedText = "";
            this.txttypeupdate.SelectionLength = 0;
            this.txttypeupdate.SelectionStart = 0;
            this.txttypeupdate.ShortcutsEnabled = true;
            this.txttypeupdate.Size = new System.Drawing.Size(187, 29);
            this.txttypeupdate.TabIndex = 74;
            this.txttypeupdate.UseSelectable = true;
            this.txttypeupdate.WaterMark = "Product Type...";
            this.txttypeupdate.WaterMarkColor = System.Drawing.Color.Silver;
            this.txttypeupdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDescription
            // 
            // 
            // 
            // 
            this.txtDescription.CustomButton.Image = null;
            this.txtDescription.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtDescription.CustomButton.Name = "";
            this.txtDescription.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.txtDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescription.CustomButton.TabIndex = 1;
            this.txtDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescription.CustomButton.UseSelectable = true;
            this.txtDescription.CustomButton.Visible = false;
            this.txtDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDescription.Lines = new string[0];
            this.txtDescription.Location = new System.Drawing.Point(18, 298);
            this.txtDescription.MaxLength = 32767;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PromptText = "Description...";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescription.SelectedText = "";
            this.txtDescription.SelectionLength = 0;
            this.txtDescription.SelectionStart = 0;
            this.txtDescription.ShortcutsEnabled = true;
            this.txtDescription.Size = new System.Drawing.Size(187, 109);
            this.txtDescription.TabIndex = 76;
            this.txtDescription.UseSelectable = true;
            this.txtDescription.WaterMark = "Description...";
            this.txtDescription.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // descriptionLbl
            // 
            this.descriptionLbl.AutoSize = true;
            this.descriptionLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.descriptionLbl.Location = new System.Drawing.Point(18, 270);
            this.descriptionLbl.Name = "descriptionLbl";
            this.descriptionLbl.Size = new System.Drawing.Size(106, 25);
            this.descriptionLbl.TabIndex = 75;
            this.descriptionLbl.Text = "Description :";
            // 
            // ManageProductTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 529);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.descriptionLbl);
            this.Controls.Add(this.txttypeupdate);
            this.Controls.Add(this.typelbl);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.expenseBindingNavigator);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.typesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageProductTypesForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.ShowIcon = false;
            this.Text = "Manage Product Types";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView typesDataGridView;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private MetroFramework.Controls.MetroTextBox searchField;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private MetroFramework.Controls.MetroLabel typelbl;
        private MetroFramework.Controls.MetroTextBox txttypeupdate;
        private MetroFramework.Controls.MetroTextBox txtDescription;
        private MetroFramework.Controls.MetroLabel descriptionLbl;
    }
}
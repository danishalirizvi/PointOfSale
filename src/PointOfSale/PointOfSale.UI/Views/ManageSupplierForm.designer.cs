namespace PointOfSale.UI.Views
{
    partial class ManageSupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSupplierForm));
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.subheadingLabel = new MetroFramework.Controls.MetroLabel();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            this.addressLabel = new MetroFramework.Controls.MetroLabel();
            this.addressField = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.emailField = new MetroFramework.Controls.MetroTextBox();
            this.secondaryLabel = new MetroFramework.Controls.MetroLabel();
            this.companyLabel = new MetroFramework.Controls.MetroLabel();
            this.primaryLabel = new MetroFramework.Controls.MetroLabel();
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.cnicLabel = new MetroFramework.Controls.MetroLabel();
            this.cnicField = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.secondaryField = new MetroFramework.Controls.MetroTextBox();
            this.companyField = new MetroFramework.Controls.MetroTextBox();
            this.primaryField = new MetroFramework.Controls.MetroTextBox();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.expenseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchField = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // supplierDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.supplierDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.supplierDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.supplierDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supplierDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.supplierDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.supplierDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.supplierDataGridView.Location = new System.Drawing.Point(389, 107);
            this.supplierDataGridView.MultiSelect = false;
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.RowHeadersVisible = false;
            this.supplierDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierDataGridView.Size = new System.Drawing.Size(763, 469);
            this.supplierDataGridView.TabIndex = 13;
            this.supplierDataGridView.SelectionChanged += new System.EventHandler(this.onSelectionChange);
            // 
            // subheadingLabel
            // 
            this.subheadingLabel.AutoSize = true;
            this.subheadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subheadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subheadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subheadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subheadingLabel.Name = "subheadingLabel";
            this.subheadingLabel.Size = new System.Drawing.Size(542, 15);
            this.subheadingLabel.TabIndex = 18;
            this.subheadingLabel.Text = "NOTE : Manage supplier details from the section below and press SAVE after editin" +
    "g information!";
            this.subheadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subheadingLabel.UseCustomForeColor = true;
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.addressLabel);
            this.InputPanel.Controls.Add(this.addressField);
            this.InputPanel.Controls.Add(this.emailLabel);
            this.InputPanel.Controls.Add(this.emailField);
            this.InputPanel.Controls.Add(this.secondaryLabel);
            this.InputPanel.Controls.Add(this.companyLabel);
            this.InputPanel.Controls.Add(this.primaryLabel);
            this.InputPanel.Controls.Add(this.nameField);
            this.InputPanel.Controls.Add(this.cnicLabel);
            this.InputPanel.Controls.Add(this.cnicField);
            this.InputPanel.Controls.Add(this.nameLabel);
            this.InputPanel.Controls.Add(this.secondaryField);
            this.InputPanel.Controls.Add(this.companyField);
            this.InputPanel.Controls.Add(this.primaryField);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(45, 150);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(307, 427);
            this.InputPanel.TabIndex = 28;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.addressLabel.Location = new System.Drawing.Point(19, 364);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(93, 25);
            this.addressLabel.TabIndex = 81;
            this.addressLabel.Text = "ADDRESS :";
            // 
            // addressField
            // 
            // 
            // 
            // 
            this.addressField.CustomButton.Image = null;
            this.addressField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.addressField.CustomButton.Name = "";
            this.addressField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.addressField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.addressField.CustomButton.TabIndex = 1;
            this.addressField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.addressField.CustomButton.UseSelectable = true;
            this.addressField.CustomButton.Visible = false;
            this.addressField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.addressField.Lines = new string[0];
            this.addressField.Location = new System.Drawing.Point(19, 392);
            this.addressField.MaxLength = 32767;
            this.addressField.Name = "addressField";
            this.addressField.PasswordChar = '\0';
            this.addressField.PromptText = "Product Type...";
            this.addressField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressField.SelectedText = "";
            this.addressField.SelectionLength = 0;
            this.addressField.SelectionStart = 0;
            this.addressField.ShortcutsEnabled = true;
            this.addressField.Size = new System.Drawing.Size(271, 29);
            this.addressField.TabIndex = 82;
            this.addressField.UseSelectable = true;
            this.addressField.WaterMark = "Product Type...";
            this.addressField.WaterMarkColor = System.Drawing.Color.Silver;
            this.addressField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.emailLabel.Location = new System.Drawing.Point(19, 304);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(68, 25);
            this.emailLabel.TabIndex = 79;
            this.emailLabel.Text = "EMAIL :";
            // 
            // emailField
            // 
            // 
            // 
            // 
            this.emailField.CustomButton.Image = null;
            this.emailField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.emailField.CustomButton.Name = "";
            this.emailField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.emailField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailField.CustomButton.TabIndex = 1;
            this.emailField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailField.CustomButton.UseSelectable = true;
            this.emailField.CustomButton.Visible = false;
            this.emailField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.emailField.Lines = new string[0];
            this.emailField.Location = new System.Drawing.Point(19, 332);
            this.emailField.MaxLength = 32767;
            this.emailField.Name = "emailField";
            this.emailField.PasswordChar = '\0';
            this.emailField.PromptText = "Product Type...";
            this.emailField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailField.SelectedText = "";
            this.emailField.SelectionLength = 0;
            this.emailField.SelectionStart = 0;
            this.emailField.ShortcutsEnabled = true;
            this.emailField.Size = new System.Drawing.Size(271, 29);
            this.emailField.TabIndex = 80;
            this.emailField.UseSelectable = true;
            this.emailField.WaterMark = "Product Type...";
            this.emailField.WaterMarkColor = System.Drawing.Color.Silver;
            this.emailField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // secondaryLabel
            // 
            this.secondaryLabel.AutoSize = true;
            this.secondaryLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.secondaryLabel.Location = new System.Drawing.Point(19, 244);
            this.secondaryLabel.Name = "secondaryLabel";
            this.secondaryLabel.Size = new System.Drawing.Size(187, 25);
            this.secondaryLabel.TabIndex = 77;
            this.secondaryLabel.Text = "SECONDARY MOBILE#";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.companyLabel.Location = new System.Drawing.Point(19, 124);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(103, 25);
            this.companyLabel.TabIndex = 73;
            this.companyLabel.Text = "COMPANY :";
            // 
            // primaryLabel
            // 
            this.primaryLabel.AutoSize = true;
            this.primaryLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.primaryLabel.Location = new System.Drawing.Point(19, 184);
            this.primaryLabel.Name = "primaryLabel";
            this.primaryLabel.Size = new System.Drawing.Size(158, 25);
            this.primaryLabel.TabIndex = 75;
            this.primaryLabel.Text = "PRIMARY MOBILE#";
            // 
            // nameField
            // 
            // 
            // 
            // 
            this.nameField.CustomButton.Image = null;
            this.nameField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.nameField.CustomButton.Name = "";
            this.nameField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.nameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameField.CustomButton.TabIndex = 1;
            this.nameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameField.CustomButton.UseSelectable = true;
            this.nameField.CustomButton.Visible = false;
            this.nameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameField.Lines = new string[0];
            this.nameField.Location = new System.Drawing.Point(19, 32);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.PromptText = "Product Type...";
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.SelectionLength = 0;
            this.nameField.SelectionStart = 0;
            this.nameField.ShortcutsEnabled = true;
            this.nameField.Size = new System.Drawing.Size(271, 29);
            this.nameField.TabIndex = 70;
            this.nameField.UseSelectable = true;
            this.nameField.WaterMark = "Product Type...";
            this.nameField.WaterMarkColor = System.Drawing.Color.Silver;
            this.nameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cnicLabel
            // 
            this.cnicLabel.AutoSize = true;
            this.cnicLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cnicLabel.Location = new System.Drawing.Point(19, 64);
            this.cnicLabel.Name = "cnicLabel";
            this.cnicLabel.Size = new System.Drawing.Size(60, 25);
            this.cnicLabel.TabIndex = 71;
            this.cnicLabel.Text = "CNIC :";
            // 
            // cnicField
            // 
            // 
            // 
            // 
            this.cnicField.CustomButton.Image = null;
            this.cnicField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.cnicField.CustomButton.Name = "";
            this.cnicField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.cnicField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.cnicField.CustomButton.TabIndex = 1;
            this.cnicField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cnicField.CustomButton.UseSelectable = true;
            this.cnicField.CustomButton.Visible = false;
            this.cnicField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.cnicField.Lines = new string[0];
            this.cnicField.Location = new System.Drawing.Point(19, 92);
            this.cnicField.MaxLength = 32767;
            this.cnicField.Name = "cnicField";
            this.cnicField.PasswordChar = '\0';
            this.cnicField.PromptText = "Product Type...";
            this.cnicField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cnicField.SelectedText = "";
            this.cnicField.SelectionLength = 0;
            this.cnicField.SelectionStart = 0;
            this.cnicField.ShortcutsEnabled = true;
            this.cnicField.Size = new System.Drawing.Size(271, 29);
            this.cnicField.TabIndex = 72;
            this.cnicField.UseSelectable = true;
            this.cnicField.WaterMark = "Product Type...";
            this.cnicField.WaterMarkColor = System.Drawing.Color.Silver;
            this.cnicField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(20, 4);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(67, 25);
            this.nameLabel.TabIndex = 69;
            this.nameLabel.Text = "Name :";
            // 
            // secondaryField
            // 
            // 
            // 
            // 
            this.secondaryField.CustomButton.Image = null;
            this.secondaryField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.secondaryField.CustomButton.Name = "";
            this.secondaryField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.secondaryField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secondaryField.CustomButton.TabIndex = 1;
            this.secondaryField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secondaryField.CustomButton.UseSelectable = true;
            this.secondaryField.CustomButton.Visible = false;
            this.secondaryField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.secondaryField.Lines = new string[0];
            this.secondaryField.Location = new System.Drawing.Point(19, 272);
            this.secondaryField.MaxLength = 32767;
            this.secondaryField.Name = "secondaryField";
            this.secondaryField.PasswordChar = '\0';
            this.secondaryField.PromptText = "Product Type...";
            this.secondaryField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secondaryField.SelectedText = "";
            this.secondaryField.SelectionLength = 0;
            this.secondaryField.SelectionStart = 0;
            this.secondaryField.ShortcutsEnabled = true;
            this.secondaryField.Size = new System.Drawing.Size(271, 29);
            this.secondaryField.TabIndex = 78;
            this.secondaryField.UseSelectable = true;
            this.secondaryField.WaterMark = "Product Type...";
            this.secondaryField.WaterMarkColor = System.Drawing.Color.Silver;
            this.secondaryField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // companyField
            // 
            // 
            // 
            // 
            this.companyField.CustomButton.Image = null;
            this.companyField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.companyField.CustomButton.Name = "";
            this.companyField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.companyField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.companyField.CustomButton.TabIndex = 1;
            this.companyField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.companyField.CustomButton.UseSelectable = true;
            this.companyField.CustomButton.Visible = false;
            this.companyField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.companyField.Lines = new string[0];
            this.companyField.Location = new System.Drawing.Point(19, 152);
            this.companyField.MaxLength = 32767;
            this.companyField.Name = "companyField";
            this.companyField.PasswordChar = '\0';
            this.companyField.PromptText = "Product Type...";
            this.companyField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.companyField.SelectedText = "";
            this.companyField.SelectionLength = 0;
            this.companyField.SelectionStart = 0;
            this.companyField.ShortcutsEnabled = true;
            this.companyField.Size = new System.Drawing.Size(271, 29);
            this.companyField.TabIndex = 74;
            this.companyField.UseSelectable = true;
            this.companyField.WaterMark = "Product Type...";
            this.companyField.WaterMarkColor = System.Drawing.Color.Silver;
            this.companyField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // primaryField
            // 
            // 
            // 
            // 
            this.primaryField.CustomButton.Image = null;
            this.primaryField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.primaryField.CustomButton.Name = "";
            this.primaryField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.primaryField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.primaryField.CustomButton.TabIndex = 1;
            this.primaryField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.primaryField.CustomButton.UseSelectable = true;
            this.primaryField.CustomButton.Visible = false;
            this.primaryField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.primaryField.Lines = new string[0];
            this.primaryField.Location = new System.Drawing.Point(19, 212);
            this.primaryField.MaxLength = 32767;
            this.primaryField.Name = "primaryField";
            this.primaryField.PasswordChar = '\0';
            this.primaryField.PromptText = "Product Type...";
            this.primaryField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.primaryField.SelectedText = "";
            this.primaryField.SelectionLength = 0;
            this.primaryField.SelectionStart = 0;
            this.primaryField.ShortcutsEnabled = true;
            this.primaryField.Size = new System.Drawing.Size(271, 29);
            this.primaryField.TabIndex = 76;
            this.primaryField.UseSelectable = true;
            this.primaryField.WaterMark = "Product Type...";
            this.primaryField.WaterMarkColor = System.Drawing.Color.Silver;
            this.primaryField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // expenseBindingNavigator
            // 
            this.expenseBindingNavigator.AddNewItem = null;
            this.expenseBindingNavigator.CountItem = null;
            this.expenseBindingNavigator.DeleteItem = null;
            this.expenseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.expenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.expenseBindingNavigatorSaveItem});
            this.expenseBindingNavigator.Location = new System.Drawing.Point(126, 107);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(229, 37);
            this.expenseBindingNavigator.TabIndex = 38;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.deleteButtonClicked);
            // 
            // expenseBindingNavigatorSaveItem
            // 
            this.expenseBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.ForestGreen;
            this.expenseBindingNavigatorSaveItem.Image = global::PointOfSale.UI.Properties.Resources.check;
            this.expenseBindingNavigatorSaveItem.Name = "expenseBindingNavigatorSaveItem";
            this.expenseBindingNavigatorSaveItem.Size = new System.Drawing.Size(113, 34);
            this.expenseBindingNavigatorSaveItem.Text = "UPDATE";
            this.expenseBindingNavigatorSaveItem.Click += new System.EventHandler(this.updateButtonClicked);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.searchLabel.Location = new System.Drawing.Point(919, 44);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 25);
            this.searchLabel.TabIndex = 83;
            this.searchLabel.Text = "SEARCH :";
            // 
            // searchField
            // 
            // 
            // 
            // 
            this.searchField.CustomButton.Image = null;
            this.searchField.CustomButton.Location = new System.Drawing.Point(205, 1);
            this.searchField.CustomButton.Name = "";
            this.searchField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchField.CustomButton.TabIndex = 1;
            this.searchField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchField.CustomButton.UseSelectable = true;
            this.searchField.CustomButton.Visible = false;
            this.searchField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchField.Lines = new string[0];
            this.searchField.Location = new System.Drawing.Point(919, 72);
            this.searchField.MaxLength = 32767;
            this.searchField.Name = "searchField";
            this.searchField.PasswordChar = '\0';
            this.searchField.PromptText = "Product Type...";
            this.searchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchField.SelectedText = "";
            this.searchField.SelectionLength = 0;
            this.searchField.SelectionStart = 0;
            this.searchField.ShortcutsEnabled = true;
            this.searchField.Size = new System.Drawing.Size(233, 29);
            this.searchField.TabIndex = 84;
            this.searchField.UseSelectable = true;
            this.searchField.WaterMark = "Product Type...";
            this.searchField.WaterMarkColor = System.Drawing.Color.Silver;
            this.searchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // ManageSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 600);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.expenseBindingNavigator);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.subheadingLabel);
            this.Controls.Add(this.supplierDataGridView);
            this.Name = "ManageSupplierForm";
            this.Text = "Manage Supplier";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private MetroFramework.Controls.MetroLabel subheadingLabel;
        private MetroFramework.Controls.MetroPanel InputPanel;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton expenseBindingNavigatorSaveItem;
        private MetroFramework.Controls.MetroTextBox nameField;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox cnicField;
        private MetroFramework.Controls.MetroLabel cnicLabel;
        private MetroFramework.Controls.MetroTextBox companyField;
        private MetroFramework.Controls.MetroLabel companyLabel;
        private MetroFramework.Controls.MetroTextBox primaryField;
        private MetroFramework.Controls.MetroLabel primaryLabel;
        private MetroFramework.Controls.MetroTextBox secondaryField;
        private MetroFramework.Controls.MetroLabel secondaryLabel;
        private MetroFramework.Controls.MetroTextBox emailField;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox addressField;
        private MetroFramework.Controls.MetroLabel addressLabel;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroTextBox searchField;
    }
}
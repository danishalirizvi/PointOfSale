namespace PointOfSale.UI.Views
{
    partial class ManageCustomerForm
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
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.subheadingLabel = new MetroFramework.Controls.MetroLabel();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            this.cnicLabel = new MetroFramework.Controls.MetroLabel();
            this.cnicField = new MetroFramework.Controls.MetroTextBox();
            this.dobDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.addressLabel = new MetroFramework.Controls.MetroLabel();
            this.dobLabel = new MetroFramework.Controls.MetroLabel();
            this.addressField = new MetroFramework.Controls.MetroTextBox();
            this.primaryLabel = new MetroFramework.Controls.MetroLabel();
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.primaryField = new MetroFramework.Controls.MetroTextBox();
            this.dueLabel = new MetroFramework.Controls.MetroLabel();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.expenseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchField = new MetroFramework.Controls.MetroTextBox();
            this.txtCurrentDue = new MetroFramework.Controls.MetroTextBox();
            this.txtDueReceived = new MetroFramework.Controls.MetroTextBox();
            this.duePaidLBL = new MetroFramework.Controls.MetroLabel();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.fixedLabel = new MetroFramework.Controls.MetroLabel();
            this.percentField = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customerDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerDataGridView.Location = new System.Drawing.Point(389, 107);
            this.customerDataGridView.MultiSelect = false;
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.ReadOnly = true;
            this.customerDataGridView.RowHeadersVisible = false;
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(763, 471);
            this.customerDataGridView.TabIndex = 13;
            this.customerDataGridView.SelectionChanged += new System.EventHandler(this.onSelectionChange);
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
            this.InputPanel.Controls.Add(this.cnicLabel);
            this.InputPanel.Controls.Add(this.cnicField);
            this.InputPanel.Controls.Add(this.dobDatePicker);
            this.InputPanel.Controls.Add(this.addressLabel);
            this.InputPanel.Controls.Add(this.dobLabel);
            this.InputPanel.Controls.Add(this.addressField);
            this.InputPanel.Controls.Add(this.fixedLabel);
            this.InputPanel.Controls.Add(this.primaryLabel);
            this.InputPanel.Controls.Add(this.nameField);
            this.InputPanel.Controls.Add(this.nameLabel);
            this.InputPanel.Controls.Add(this.percentField);
            this.InputPanel.Controls.Add(this.primaryField);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(45, 196);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(307, 419);
            this.InputPanel.TabIndex = 28;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // cnicLabel
            // 
            this.cnicLabel.AutoSize = true;
            this.cnicLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.cnicLabel.Location = new System.Drawing.Point(20, 124);
            this.cnicLabel.Name = "cnicLabel";
            this.cnicLabel.Size = new System.Drawing.Size(60, 25);
            this.cnicLabel.TabIndex = 85;
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
            this.cnicField.Location = new System.Drawing.Point(20, 152);
            this.cnicField.MaxLength = 32767;
            this.cnicField.Name = "cnicField";
            this.cnicField.PasswordChar = '\0';
            this.cnicField.PromptText = "CNIC...";
            this.cnicField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cnicField.SelectedText = "";
            this.cnicField.SelectionLength = 0;
            this.cnicField.SelectionStart = 0;
            this.cnicField.ShortcutsEnabled = true;
            this.cnicField.Size = new System.Drawing.Size(271, 29);
            this.cnicField.TabIndex = 86;
            this.cnicField.UseSelectable = true;
            this.cnicField.WaterMark = "CNIC...";
            this.cnicField.WaterMarkColor = System.Drawing.Color.Silver;
            this.cnicField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDatePicker.Location = new System.Drawing.Point(20, 92);
            this.dobDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(271, 29);
            this.dobDatePicker.TabIndex = 84;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.addressLabel.Location = new System.Drawing.Point(20, 184);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(93, 25);
            this.addressLabel.TabIndex = 81;
            this.addressLabel.Text = "ADDRESS :";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dobLabel.Location = new System.Drawing.Point(20, 64);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(57, 25);
            this.dobLabel.TabIndex = 83;
            this.dobLabel.Text = "DOB :";
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
            this.addressField.Location = new System.Drawing.Point(20, 212);
            this.addressField.MaxLength = 32767;
            this.addressField.Name = "addressField";
            this.addressField.PasswordChar = '\0';
            this.addressField.PromptText = "Address...";
            this.addressField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.addressField.SelectedText = "";
            this.addressField.SelectionLength = 0;
            this.addressField.SelectionStart = 0;
            this.addressField.ShortcutsEnabled = true;
            this.addressField.Size = new System.Drawing.Size(271, 29);
            this.addressField.TabIndex = 82;
            this.addressField.UseSelectable = true;
            this.addressField.WaterMark = "Address...";
            this.addressField.WaterMarkColor = System.Drawing.Color.Silver;
            this.addressField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // primaryLabel
            // 
            this.primaryLabel.AutoSize = true;
            this.primaryLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.primaryLabel.Location = new System.Drawing.Point(20, 244);
            this.primaryLabel.Name = "primaryLabel";
            this.primaryLabel.Size = new System.Drawing.Size(83, 25);
            this.primaryLabel.TabIndex = 75;
            this.primaryLabel.Text = "MOBILE#";
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
            this.nameField.Location = new System.Drawing.Point(20, 32);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.PromptText = "Name...";
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.SelectionLength = 0;
            this.nameField.SelectionStart = 0;
            this.nameField.ShortcutsEnabled = true;
            this.nameField.Size = new System.Drawing.Size(271, 29);
            this.nameField.TabIndex = 70;
            this.nameField.UseSelectable = true;
            this.nameField.WaterMark = "Name...";
            this.nameField.WaterMarkColor = System.Drawing.Color.Silver;
            this.nameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.primaryField.Location = new System.Drawing.Point(20, 272);
            this.primaryField.MaxLength = 32767;
            this.primaryField.Name = "primaryField";
            this.primaryField.PasswordChar = '\0';
            this.primaryField.PromptText = "Mobile...";
            this.primaryField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.primaryField.SelectedText = "";
            this.primaryField.SelectionLength = 0;
            this.primaryField.SelectionStart = 0;
            this.primaryField.ShortcutsEnabled = true;
            this.primaryField.Size = new System.Drawing.Size(271, 29);
            this.primaryField.TabIndex = 76;
            this.primaryField.UseSelectable = true;
            this.primaryField.WaterMark = "Mobile...";
            this.primaryField.WaterMarkColor = System.Drawing.Color.Silver;
            this.primaryField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dueLabel
            // 
            this.dueLabel.AutoSize = true;
            this.dueLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dueLabel.Location = new System.Drawing.Point(454, 590);
            this.dueLabel.Name = "dueLabel";
            this.dueLabel.Size = new System.Drawing.Size(128, 25);
            this.dueLabel.TabIndex = 73;
            this.dueLabel.Text = "DUE AMOUNT:";
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
            this.expenseBindingNavigator.Location = new System.Drawing.Point(138, 156);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(213, 37);
            this.expenseBindingNavigator.TabIndex = 38;
            this.expenseBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(88, 34);
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
            // txtCurrentDue
            // 
            // 
            // 
            // 
            this.txtCurrentDue.CustomButton.Image = null;
            this.txtCurrentDue.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.txtCurrentDue.CustomButton.Name = "";
            this.txtCurrentDue.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCurrentDue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCurrentDue.CustomButton.TabIndex = 1;
            this.txtCurrentDue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCurrentDue.CustomButton.UseSelectable = true;
            this.txtCurrentDue.CustomButton.Visible = false;
            this.txtCurrentDue.Enabled = false;
            this.txtCurrentDue.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCurrentDue.Lines = new string[0];
            this.txtCurrentDue.Location = new System.Drawing.Point(454, 618);
            this.txtCurrentDue.MaxLength = 32767;
            this.txtCurrentDue.Name = "txtCurrentDue";
            this.txtCurrentDue.PasswordChar = '\0';
            this.txtCurrentDue.PromptText = "Due Amount...";
            this.txtCurrentDue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCurrentDue.SelectedText = "";
            this.txtCurrentDue.SelectionLength = 0;
            this.txtCurrentDue.SelectionStart = 0;
            this.txtCurrentDue.ShortcutsEnabled = true;
            this.txtCurrentDue.Size = new System.Drawing.Size(124, 29);
            this.txtCurrentDue.TabIndex = 89;
            this.txtCurrentDue.UseSelectable = true;
            this.txtCurrentDue.WaterMark = "Due Amount...";
            this.txtCurrentDue.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtCurrentDue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDueReceived
            // 
            // 
            // 
            // 
            this.txtDueReceived.CustomButton.Image = null;
            this.txtDueReceived.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtDueReceived.CustomButton.Name = "";
            this.txtDueReceived.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDueReceived.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDueReceived.CustomButton.TabIndex = 1;
            this.txtDueReceived.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDueReceived.CustomButton.UseSelectable = true;
            this.txtDueReceived.CustomButton.Visible = false;
            this.txtDueReceived.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDueReceived.Lines = new string[0];
            this.txtDueReceived.Location = new System.Drawing.Point(615, 618);
            this.txtDueReceived.MaxLength = 32767;
            this.txtDueReceived.Name = "txtDueReceived";
            this.txtDueReceived.PasswordChar = '\0';
            this.txtDueReceived.PromptText = "Due Amount Received...";
            this.txtDueReceived.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDueReceived.SelectedText = "";
            this.txtDueReceived.SelectionLength = 0;
            this.txtDueReceived.SelectionStart = 0;
            this.txtDueReceived.ShortcutsEnabled = true;
            this.txtDueReceived.Size = new System.Drawing.Size(169, 29);
            this.txtDueReceived.TabIndex = 91;
            this.txtDueReceived.UseSelectable = true;
            this.txtDueReceived.WaterMark = "Due Amount Received...";
            this.txtDueReceived.WaterMarkColor = System.Drawing.Color.Silver;
            this.txtDueReceived.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // duePaidLBL
            // 
            this.duePaidLBL.AutoSize = true;
            this.duePaidLBL.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.duePaidLBL.Location = new System.Drawing.Point(615, 590);
            this.duePaidLBL.Name = "duePaidLBL";
            this.duePaidLBL.Size = new System.Drawing.Size(89, 25);
            this.duePaidLBL.TabIndex = 90;
            this.duePaidLBL.Text = "DUE PAID:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(811, 610);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(273, 37);
            this.bindingNavigator1.TabIndex = 92;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.Color.ForestGreen;
            this.toolStripButton2.Image = global::PointOfSale.UI.Properties.Resources.check;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(261, 34);
            this.toolStripButton2.Text = "UPDATE DUE AMOUNT";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // fixedLabel
            // 
            this.fixedLabel.AutoSize = true;
            this.fixedLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.fixedLabel.Location = new System.Drawing.Point(20, 304);
            this.fixedLabel.Name = "fixedLabel";
            this.fixedLabel.Size = new System.Drawing.Size(153, 25);
            this.fixedLabel.TabIndex = 79;
            this.fixedLabel.Text = "FIXED DISCOUNT :";
            // 
            // percentField
            // 
            // 
            // 
            // 
            this.percentField.CustomButton.Image = null;
            this.percentField.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.percentField.CustomButton.Name = "";
            this.percentField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.percentField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.percentField.CustomButton.TabIndex = 1;
            this.percentField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.percentField.CustomButton.UseSelectable = true;
            this.percentField.CustomButton.Visible = false;
            this.percentField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.percentField.Lines = new string[0];
            this.percentField.Location = new System.Drawing.Point(20, 332);
            this.percentField.MaxLength = 32767;
            this.percentField.Name = "percentField";
            this.percentField.PasswordChar = '\0';
            this.percentField.PromptText = "Percent Discount...";
            this.percentField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.percentField.SelectedText = "";
            this.percentField.SelectionLength = 0;
            this.percentField.SelectionStart = 0;
            this.percentField.ShortcutsEnabled = true;
            this.percentField.Size = new System.Drawing.Size(271, 29);
            this.percentField.TabIndex = 74;
            this.percentField.UseSelectable = true;
            this.percentField.WaterMark = "Percent Discount...";
            this.percentField.WaterMarkColor = System.Drawing.Color.Silver;
            this.percentField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ManageCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 666);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.txtDueReceived);
            this.Controls.Add(this.duePaidLBL);
            this.Controls.Add(this.txtCurrentDue);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.expenseBindingNavigator);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.subheadingLabel);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.dueLabel);
            this.Name = "ManageCustomerForm";
            this.Text = "Manage Supplier";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView customerDataGridView;
        private MetroFramework.Controls.MetroLabel subheadingLabel;
        private MetroFramework.Controls.MetroPanel InputPanel;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton expenseBindingNavigatorSaveItem;
        private MetroFramework.Controls.MetroTextBox nameField;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel dueLabel;
        private MetroFramework.Controls.MetroTextBox primaryField;
        private MetroFramework.Controls.MetroLabel primaryLabel;
        private MetroFramework.Controls.MetroTextBox addressField;
        private MetroFramework.Controls.MetroLabel addressLabel;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroTextBox searchField;
        private MetroFramework.Controls.MetroDateTime dobDatePicker;
        private MetroFramework.Controls.MetroLabel dobLabel;
        private MetroFramework.Controls.MetroLabel cnicLabel;
        private MetroFramework.Controls.MetroTextBox cnicField;
        private MetroFramework.Controls.MetroTextBox txtCurrentDue;
        private MetroFramework.Controls.MetroTextBox txtDueReceived;
        private MetroFramework.Controls.MetroLabel duePaidLBL;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private MetroFramework.Controls.MetroLabel fixedLabel;
        private MetroFramework.Controls.MetroTextBox percentField;
    }
}
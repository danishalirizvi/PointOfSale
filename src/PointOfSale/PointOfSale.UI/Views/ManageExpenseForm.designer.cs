namespace PointOfSale.UI.Views
{
    partial class ManageExpenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExpenseForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.expenseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.expenseDataGridView = new System.Windows.Forms.DataGridView();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.amountLabel = new MetroFramework.Controls.MetroLabel();
            this.amountField = new MetroFramework.Controls.MetroTextBox();
            this.commentsLabel = new MetroFramework.Controls.MetroLabel();
            this.commentsField = new MetroFramework.Controls.MetroTextBox();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchField = new MetroFramework.Controls.MetroTextBox();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.datePicker = new MetroFramework.Controls.MetroDateTime();
            this.expensePicker = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(500, 15);
            this.subHeadingLabel.TabIndex = 36;
            this.subHeadingLabel.Text = "Note : Manage expense details from the section below and press SAVE after editing" +
    " data!";
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
            this.expenseBindingNavigatorSaveItem});
            this.expenseBindingNavigator.Location = new System.Drawing.Point(143, 86);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(229, 37);
            this.expenseBindingNavigator.TabIndex = 37;
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
            // expenseDataGridView
            // 
            this.expenseDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expenseDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.expenseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expenseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expenseDataGridView.ColumnHeadersHeight = 40;
            this.expenseDataGridView.Location = new System.Drawing.Point(386, 86);
            this.expenseDataGridView.MultiSelect = false;
            this.expenseDataGridView.Name = "expenseDataGridView";
            this.expenseDataGridView.ReadOnly = true;
            this.expenseDataGridView.RowHeadersVisible = false;
            this.expenseDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.expenseDataGridView.Size = new System.Drawing.Size(615, 491);
            this.expenseDataGridView.TabIndex = 37;
            this.expenseDataGridView.SelectionChanged += new System.EventHandler(this.onSelectionChange);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(42, 139);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 25);
            this.nameLabel.TabIndex = 52;
            this.nameLabel.Text = "CATEGORY :";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.amountLabel.Location = new System.Drawing.Point(52, 174);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(95, 25);
            this.amountLabel.TabIndex = 56;
            this.amountLabel.Text = "AMOUNT :";
            // 
            // amountField
            // 
            // 
            // 
            // 
            this.amountField.CustomButton.Image = null;
            this.amountField.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.amountField.CustomButton.Name = "";
            this.amountField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.amountField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountField.CustomButton.TabIndex = 1;
            this.amountField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountField.CustomButton.UseSelectable = true;
            this.amountField.CustomButton.Visible = false;
            this.amountField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.amountField.Lines = new string[0];
            this.amountField.Location = new System.Drawing.Point(153, 170);
            this.amountField.MaxLength = 32767;
            this.amountField.Name = "amountField";
            this.amountField.PasswordChar = '\0';
            this.amountField.PromptText = "Amount...";
            this.amountField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountField.SelectedText = "";
            this.amountField.SelectionLength = 0;
            this.amountField.SelectionStart = 0;
            this.amountField.ShortcutsEnabled = true;
            this.amountField.Size = new System.Drawing.Size(217, 29);
            this.amountField.TabIndex = 55;
            this.amountField.UseSelectable = true;
            this.amountField.WaterMark = "Amount...";
            this.amountField.WaterMarkColor = System.Drawing.Color.Silver;
            this.amountField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.commentsLabel.Location = new System.Drawing.Point(36, 244);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(111, 25);
            this.commentsLabel.TabIndex = 58;
            this.commentsLabel.Text = "COMMENTS:";
            // 
            // commentsField
            // 
            // 
            // 
            // 
            this.commentsField.CustomButton.Image = null;
            this.commentsField.CustomButton.Location = new System.Drawing.Point(91, 2);
            this.commentsField.CustomButton.Name = "";
            this.commentsField.CustomButton.Size = new System.Drawing.Size(123, 123);
            this.commentsField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.commentsField.CustomButton.TabIndex = 1;
            this.commentsField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.commentsField.CustomButton.UseSelectable = true;
            this.commentsField.CustomButton.Visible = false;
            this.commentsField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.commentsField.Lines = new string[0];
            this.commentsField.Location = new System.Drawing.Point(153, 240);
            this.commentsField.MaxLength = 32767;
            this.commentsField.Multiline = true;
            this.commentsField.Name = "commentsField";
            this.commentsField.PasswordChar = '\0';
            this.commentsField.PromptText = "Comments...";
            this.commentsField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commentsField.SelectedText = "";
            this.commentsField.SelectionLength = 0;
            this.commentsField.SelectionStart = 0;
            this.commentsField.ShortcutsEnabled = true;
            this.commentsField.Size = new System.Drawing.Size(217, 128);
            this.commentsField.TabIndex = 57;
            this.commentsField.UseSelectable = true;
            this.commentsField.WaterMark = "Comments...";
            this.commentsField.WaterMarkColor = System.Drawing.Color.Silver;
            this.commentsField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.searchLabel.Location = new System.Drawing.Point(781, 23);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 25);
            this.searchLabel.TabIndex = 60;
            this.searchLabel.Text = "SEARCH :";
            // 
            // searchField
            // 
            // 
            // 
            // 
            this.searchField.CustomButton.Image = null;
            this.searchField.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.searchField.CustomButton.Name = "";
            this.searchField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchField.CustomButton.TabIndex = 1;
            this.searchField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchField.CustomButton.UseSelectable = true;
            this.searchField.CustomButton.Visible = false;
            this.searchField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchField.Lines = new string[0];
            this.searchField.Location = new System.Drawing.Point(781, 51);
            this.searchField.MaxLength = 32767;
            this.searchField.Name = "searchField";
            this.searchField.PasswordChar = '\0';
            this.searchField.PromptText = "Search Text(Expense Category)...";
            this.searchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchField.SelectedText = "";
            this.searchField.SelectionLength = 0;
            this.searchField.SelectionStart = 0;
            this.searchField.ShortcutsEnabled = true;
            this.searchField.Size = new System.Drawing.Size(217, 29);
            this.searchField.TabIndex = 59;
            this.searchField.UseSelectable = true;
            this.searchField.WaterMark = "Search Text(Expense Category)...";
            this.searchField.WaterMarkColor = System.Drawing.Color.Silver;
            this.searchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dateLabel.Location = new System.Drawing.Point(87, 209);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(60, 25);
            this.dateLabel.TabIndex = 61;
            this.dateLabel.Text = "DATE :";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(153, 205);
            this.datePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(217, 29);
            this.datePicker.TabIndex = 62;
            // 
            // expensePicker
            // 
            this.expensePicker.FormattingEnabled = true;
            this.expensePicker.ItemHeight = 23;
            this.expensePicker.Location = new System.Drawing.Point(153, 135);
            this.expensePicker.Name = "expensePicker";
            this.expensePicker.PromptText = "Select Category...";
            this.expensePicker.Size = new System.Drawing.Size(217, 29);
            this.expensePicker.TabIndex = 63;
            this.expensePicker.UseSelectable = true;
            // 
            // ManageExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.expensePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.commentsLabel);
            this.Controls.Add(this.commentsField);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.expenseDataGridView);
            this.Controls.Add(this.expenseBindingNavigator);
            this.Controls.Add(this.subHeadingLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ManageExpenseForm";
            this.Text = "Manage Expense";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton expenseBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView expenseDataGridView;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel amountLabel;
        private MetroFramework.Controls.MetroTextBox amountField;
        private MetroFramework.Controls.MetroLabel commentsLabel;
        private MetroFramework.Controls.MetroTextBox commentsField;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroTextBox searchField;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private MetroFramework.Controls.MetroDateTime datePicker;
        private MetroFramework.Controls.MetroComboBox expensePicker;
    }
}
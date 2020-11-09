

namespace PointOfSale.UI.Views
{
    partial class ManageLoginUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLoginUserForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.addUserButton = new MetroFramework.Controls.MetroButton();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.confirmLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.usernameField = new MetroFramework.Controls.MetroTextBox();
            this.confirmField = new MetroFramework.Controls.MetroTextBox();
            this.passwordField = new MetroFramework.Controls.MetroTextBox();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            this.clearButton = new MetroFramework.Controls.MetroButton();
            this.adminCheck = new MetroFramework.Controls.MetroCheckBox();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.expenseBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchField = new MetroFramework.Controls.MetroTextBox();
            this.loginUserDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addUserButton.Location = new System.Drawing.Point(374, 115);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(106, 33);
            this.addUserButton.TabIndex = 4;
            this.addUserButton.Text = "ADD USER";
            this.addUserButton.UseCustomBackColor = true;
            this.addUserButton.UseCustomForeColor = true;
            this.addUserButton.UseSelectable = true;
            this.addUserButton.Click += new System.EventHandler(this.addButtonClick);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.usernameLabel.Location = new System.Drawing.Point(64, 12);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(98, 25);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username :";
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.confirmLabel.Location = new System.Drawing.Point(5, 84);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(157, 25);
            this.confirmLabel.TabIndex = 6;
            this.confirmLabel.Text = "Confirm Password :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.passwordLabel.Location = new System.Drawing.Point(71, 48);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 25);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Password :";
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(264, 15);
            this.subHeadingLabel.TabIndex = 16;
            this.subHeadingLabel.Text = "NOTE: Add Login User from the section below.";
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PointOfSale.UI.Properties.Resources.Employee;
            this.pictureBox.Location = new System.Drawing.Point(374, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(106, 102);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // usernameField
            // 
            // 
            // 
            // 
            this.usernameField.CustomButton.Image = null;
            this.usernameField.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.usernameField.CustomButton.Name = "";
            this.usernameField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.usernameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.usernameField.CustomButton.TabIndex = 1;
            this.usernameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.usernameField.CustomButton.UseSelectable = true;
            this.usernameField.CustomButton.Visible = false;
            this.usernameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.usernameField.Lines = new string[0];
            this.usernameField.Location = new System.Drawing.Point(168, 7);
            this.usernameField.MaxLength = 32767;
            this.usernameField.Name = "usernameField";
            this.usernameField.PasswordChar = '\0';
            this.usernameField.PromptText = "Username...";
            this.usernameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameField.SelectedText = "";
            this.usernameField.SelectionLength = 0;
            this.usernameField.SelectionStart = 0;
            this.usernameField.ShortcutsEnabled = true;
            this.usernameField.Size = new System.Drawing.Size(200, 30);
            this.usernameField.TabIndex = 18;
            this.usernameField.UseSelectable = true;
            this.usernameField.WaterMark = "Username...";
            this.usernameField.WaterMarkColor = System.Drawing.Color.Silver;
            this.usernameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // confirmField
            // 
            // 
            // 
            // 
            this.confirmField.CustomButton.Image = null;
            this.confirmField.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.confirmField.CustomButton.Name = "";
            this.confirmField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.confirmField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.confirmField.CustomButton.TabIndex = 1;
            this.confirmField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.confirmField.CustomButton.UseSelectable = true;
            this.confirmField.CustomButton.Visible = false;
            this.confirmField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.confirmField.Lines = new string[0];
            this.confirmField.Location = new System.Drawing.Point(168, 79);
            this.confirmField.MaxLength = 32767;
            this.confirmField.Name = "confirmField";
            this.confirmField.PasswordChar = '*';
            this.confirmField.PromptText = "Repeat Password...";
            this.confirmField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmField.SelectedText = "";
            this.confirmField.SelectionLength = 0;
            this.confirmField.SelectionStart = 0;
            this.confirmField.ShortcutsEnabled = true;
            this.confirmField.Size = new System.Drawing.Size(200, 30);
            this.confirmField.TabIndex = 3;
            this.confirmField.UseSelectable = true;
            this.confirmField.WaterMark = "Repeat Password...";
            this.confirmField.WaterMarkColor = System.Drawing.Color.Silver;
            this.confirmField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // passwordField
            // 
            // 
            // 
            // 
            this.passwordField.CustomButton.Image = null;
            this.passwordField.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.passwordField.CustomButton.Name = "";
            this.passwordField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.passwordField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordField.CustomButton.TabIndex = 1;
            this.passwordField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordField.CustomButton.UseSelectable = true;
            this.passwordField.CustomButton.Visible = false;
            this.passwordField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passwordField.Lines = new string[0];
            this.passwordField.Location = new System.Drawing.Point(168, 43);
            this.passwordField.MaxLength = 32767;
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.PromptText = "Password...";
            this.passwordField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordField.SelectedText = "";
            this.passwordField.SelectionLength = 0;
            this.passwordField.SelectionStart = 0;
            this.passwordField.ShortcutsEnabled = true;
            this.passwordField.Size = new System.Drawing.Size(200, 30);
            this.passwordField.TabIndex = 2;
            this.passwordField.UseSelectable = true;
            this.passwordField.WaterMark = "Password...";
            this.passwordField.WaterMarkColor = System.Drawing.Color.Silver;
            this.passwordField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.clearButton);
            this.InputPanel.Controls.Add(this.adminCheck);
            this.InputPanel.Controls.Add(this.usernameField);
            this.InputPanel.Controls.Add(this.pictureBox);
            this.InputPanel.Controls.Add(this.passwordLabel);
            this.InputPanel.Controls.Add(this.confirmLabel);
            this.InputPanel.Controls.Add(this.usernameLabel);
            this.InputPanel.Controls.Add(this.confirmField);
            this.InputPanel.Controls.Add(this.passwordField);
            this.InputPanel.Controls.Add(this.addUserButton);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(23, 136);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(487, 156);
            this.InputPanel.TabIndex = 19;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.clearButton.Location = new System.Drawing.Point(262, 115);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 33);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "CLEAR!";
            this.clearButton.UseCustomBackColor = true;
            this.clearButton.UseCustomForeColor = true;
            this.clearButton.UseSelectable = true;
            this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // adminCheck
            // 
            this.adminCheck.AutoSize = true;
            this.adminCheck.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.adminCheck.Location = new System.Drawing.Point(168, 115);
            this.adminCheck.Name = "adminCheck";
            this.adminCheck.Size = new System.Drawing.Size(76, 15);
            this.adminCheck.TabIndex = 19;
            this.adminCheck.Text = "Is Admin?";
            this.adminCheck.UseSelectable = true;
            // 
            // expenseBindingNavigator
            // 
            this.expenseBindingNavigator.AddNewItem = null;
            this.expenseBindingNavigator.CountItem = null;
            this.expenseBindingNavigator.DeleteItem = null;
            this.expenseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.expenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expenseBindingNavigatorSaveItem,
            this.bindingNavigatorDeleteItem});
            this.expenseBindingNavigator.Location = new System.Drawing.Point(533, 49);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(229, 37);
            this.expenseBindingNavigator.TabIndex = 39;
            this.expenseBindingNavigator.Text = "bindingNavigator1";
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
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.searchLabel.Location = new System.Drawing.Point(765, 29);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 25);
            this.searchLabel.TabIndex = 86;
            this.searchLabel.Text = "SEARCH :";
            // 
            // searchField
            // 
            // 
            // 
            // 
            this.searchField.CustomButton.Image = null;
            this.searchField.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.searchField.CustomButton.Name = "";
            this.searchField.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchField.CustomButton.TabIndex = 1;
            this.searchField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchField.CustomButton.UseSelectable = true;
            this.searchField.CustomButton.Visible = false;
            this.searchField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.searchField.Lines = new string[0];
            this.searchField.Location = new System.Drawing.Point(765, 57);
            this.searchField.MaxLength = 32767;
            this.searchField.Name = "searchField";
            this.searchField.PasswordChar = '\0';
            this.searchField.PromptText = "Username...";
            this.searchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchField.SelectedText = "";
            this.searchField.SelectionLength = 0;
            this.searchField.SelectionStart = 0;
            this.searchField.ShortcutsEnabled = true;
            this.searchField.Size = new System.Drawing.Size(202, 29);
            this.searchField.TabIndex = 87;
            this.searchField.UseSelectable = true;
            this.searchField.WaterMark = "Username...";
            this.searchField.WaterMarkColor = System.Drawing.Color.Silver;
            this.searchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // loginUserDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.loginUserDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.loginUserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.loginUserDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.loginUserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.loginUserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.loginUserDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.loginUserDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.loginUserDataGridView.Location = new System.Drawing.Point(533, 89);
            this.loginUserDataGridView.MultiSelect = false;
            this.loginUserDataGridView.Name = "loginUserDataGridView";
            this.loginUserDataGridView.ReadOnly = true;
            this.loginUserDataGridView.RowHeadersVisible = false;
            this.loginUserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.loginUserDataGridView.Size = new System.Drawing.Size(434, 266);
            this.loginUserDataGridView.TabIndex = 85;
            this.loginUserDataGridView.SelectionChanged += new System.EventHandler(this.onSelectionChange);
            // 
            // ManageLoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 373);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.loginUserDataGridView);
            this.Controls.Add(this.expenseBindingNavigator);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.subHeadingLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ManageLoginUserForm";
            this.Text = "Manage Login User";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton addUserButton;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel confirmLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroTextBox usernameField;
        private MetroFramework.Controls.MetroTextBox confirmField;
        private MetroFramework.Controls.MetroTextBox passwordField;
        private MetroFramework.Controls.MetroPanel InputPanel;
        private MetroFramework.Controls.MetroCheckBox adminCheck;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton expenseBindingNavigatorSaveItem;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroTextBox searchField;
        private System.Windows.Forms.DataGridView loginUserDataGridView;
        private MetroFramework.Controls.MetroButton clearButton;
    }
}
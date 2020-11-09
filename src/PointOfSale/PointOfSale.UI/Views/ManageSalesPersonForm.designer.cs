namespace PointOfSale.UI.Views
{
    partial class ManageSalesPersonForm
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label primaryLabel;
            System.Windows.Forms.Label cnicLabel;
            System.Windows.Forms.Label searchLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageSalesPersonForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.employeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameField = new System.Windows.Forms.TextBox();
            this.mobileField = new System.Windows.Forms.TextBox();
            this.cnicField = new System.Windows.Forms.TextBox();
            this.salesPersonDataGridView = new System.Windows.Forms.DataGridView();
            this.subheadingLabel = new MetroFramework.Controls.MetroLabel();
            this.searchField = new System.Windows.Forms.TextBox();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            nameLabel = new System.Windows.Forms.Label();
            primaryLabel = new System.Windows.Forms.Label();
            cnicLabel = new System.Windows.Forms.Label();
            searchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).BeginInit();
            this.employeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonDataGridView)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(43, 12);
            nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 18);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name :";
            // 
            // primaryLabel
            // 
            primaryLabel.AutoSize = true;
            primaryLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            primaryLabel.Location = new System.Drawing.Point(27, 80);
            primaryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            primaryLabel.Name = "primaryLabel";
            primaryLabel.Size = new System.Drawing.Size(72, 18);
            primaryLabel.TabIndex = 9;
            primaryLabel.Text = "Mobile# :";
            // 
            // cnicLabel
            // 
            cnicLabel.AutoSize = true;
            cnicLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cnicLabel.Location = new System.Drawing.Point(46, 46);
            cnicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cnicLabel.Name = "cnicLabel";
            cnicLabel.Size = new System.Drawing.Size(53, 18);
            cnicLabel.TabIndex = 13;
            cnicLabel.Text = "CNIC :";
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            searchLabel.Location = new System.Drawing.Point(620, 107);
            searchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new System.Drawing.Size(130, 18);
            searchLabel.TabIndex = 71;
            searchLabel.Text = "Search by Name :";
            // 
            // employeeBindingNavigator
            // 
            this.employeeBindingNavigator.AddNewItem = null;
            this.employeeBindingNavigator.CountItem = null;
            this.employeeBindingNavigator.DeleteItem = null;
            this.employeeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.employeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem,
            this.employeeBindingNavigatorSaveItem});
            this.employeeBindingNavigator.Location = new System.Drawing.Point(7, 96);
            this.employeeBindingNavigator.MoveFirstItem = null;
            this.employeeBindingNavigator.MoveLastItem = null;
            this.employeeBindingNavigator.MoveNextItem = null;
            this.employeeBindingNavigator.MovePreviousItem = null;
            this.employeeBindingNavigator.Name = "employeeBindingNavigator";
            this.employeeBindingNavigator.PositionItem = null;
            this.employeeBindingNavigator.Size = new System.Drawing.Size(229, 37);
            this.employeeBindingNavigator.TabIndex = 0;
            this.employeeBindingNavigator.Text = "bindingNavigator1";
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
            // employeeBindingNavigatorSaveItem
            // 
            this.employeeBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeBindingNavigatorSaveItem.ForeColor = System.Drawing.Color.ForestGreen;
            this.employeeBindingNavigatorSaveItem.Image = global::PointOfSale.UI.Properties.Resources.check;
            this.employeeBindingNavigatorSaveItem.Name = "employeeBindingNavigatorSaveItem";
            this.employeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(113, 34);
            this.employeeBindingNavigatorSaveItem.Text = "UPDATE";
            this.employeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.updateButoonClick);
            // 
            // nameField
            // 
            this.nameField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameField.Location = new System.Drawing.Point(107, 4);
            this.nameField.Margin = new System.Windows.Forms.Padding(4);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(219, 26);
            this.nameField.TabIndex = 4;
            // 
            // mobileField
            // 
            this.mobileField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileField.Location = new System.Drawing.Point(107, 72);
            this.mobileField.Margin = new System.Windows.Forms.Padding(4);
            this.mobileField.Name = "mobileField";
            this.mobileField.Size = new System.Drawing.Size(219, 26);
            this.mobileField.TabIndex = 10;
            // 
            // cnicField
            // 
            this.cnicField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnicField.Location = new System.Drawing.Point(107, 38);
            this.cnicField.Margin = new System.Windows.Forms.Padding(4);
            this.cnicField.Name = "cnicField";
            this.cnicField.Size = new System.Drawing.Size(219, 26);
            this.cnicField.TabIndex = 14;
            // 
            // salesPersonDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.salesPersonDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.salesPersonDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.salesPersonDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salesPersonDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.salesPersonDataGridView.ColumnHeadersHeight = 35;
            this.salesPersonDataGridView.Location = new System.Drawing.Point(356, 133);
            this.salesPersonDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.salesPersonDataGridView.MultiSelect = false;
            this.salesPersonDataGridView.Name = "salesPersonDataGridView";
            this.salesPersonDataGridView.ReadOnly = true;
            this.salesPersonDataGridView.RowHeadersVisible = false;
            this.salesPersonDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesPersonDataGridView.Size = new System.Drawing.Size(622, 270);
            this.salesPersonDataGridView.TabIndex = 27;
            this.salesPersonDataGridView.SelectionChanged += new System.EventHandler(this.onSelectionChange);
            // 
            // subheadingLabel
            // 
            this.subheadingLabel.AutoSize = true;
            this.subheadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subheadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subheadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subheadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subheadingLabel.Name = "subheadingLabel";
            this.subheadingLabel.Size = new System.Drawing.Size(572, 15);
            this.subheadingLabel.TabIndex = 64;
            this.subheadingLabel.Text = "Note : Manage employee details from the section below and press SAVE after editin" +
    "g any information!";
            this.subheadingLabel.UseCustomForeColor = true;
            // 
            // searchField
            // 
            this.searchField.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.Location = new System.Drawing.Point(758, 99);
            this.searchField.Margin = new System.Windows.Forms.Padding(4);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(220, 26);
            this.searchField.TabIndex = 72;
            this.searchField.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(nameLabel);
            this.InputPanel.Controls.Add(this.nameField);
            this.InputPanel.Controls.Add(primaryLabel);
            this.InputPanel.Controls.Add(this.mobileField);
            this.InputPanel.Controls.Add(cnicLabel);
            this.InputPanel.Controls.Add(this.cnicField);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(7, 133);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(342, 270);
            this.InputPanel.TabIndex = 73;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // ManageSalesPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 419);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(searchLabel);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.subheadingLabel);
            this.Controls.Add(this.salesPersonDataGridView);
            this.Controls.Add(this.employeeBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageSalesPersonForm";
            this.Text = "Manage Employee";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingNavigator)).EndInit();
            this.employeeBindingNavigator.ResumeLayout(false);
            this.employeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesPersonDataGridView)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator employeeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton employeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox mobileField;
        private System.Windows.Forms.TextBox cnicField;
        private System.Windows.Forms.DataGridView salesPersonDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private MetroFramework.Controls.MetroLabel subheadingLabel;
        private System.Windows.Forms.TextBox searchField;
        private MetroFramework.Controls.MetroPanel InputPanel;
    }
}
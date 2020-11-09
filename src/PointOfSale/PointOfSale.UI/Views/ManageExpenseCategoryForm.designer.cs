namespace PointOfSale.UI.Views
{
    partial class ManageExpenseCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageExpenseCategoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoryDataGridView = new System.Windows.Forms.DataGridView();
            this.searchLabel = new MetroFramework.Controls.MetroLabel();
            this.searchField = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).BeginInit();
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
            this.bindingNavigatorDeleteItem});
            this.expenseBindingNavigator.Location = new System.Drawing.Point(23, 97);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(116, 37);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.deleteButtonClicked);
            // 
            // categoryDataGridView
            // 
            this.categoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categoryDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.categoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categoryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoryDataGridView.ColumnHeadersHeight = 40;
            this.categoryDataGridView.Location = new System.Drawing.Point(23, 137);
            this.categoryDataGridView.Name = "categoryDataGridView";
            this.categoryDataGridView.RowHeadersVisible = false;
            this.categoryDataGridView.Size = new System.Drawing.Size(515, 329);
            this.categoryDataGridView.TabIndex = 37;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.searchLabel.Location = new System.Drawing.Point(321, 77);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 25);
            this.searchLabel.TabIndex = 54;
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
            this.searchField.Location = new System.Drawing.Point(321, 105);
            this.searchField.MaxLength = 32767;
            this.searchField.Name = "searchField";
            this.searchField.PasswordChar = '\0';
            this.searchField.PromptText = "Search Text(Expense Name)...";
            this.searchField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchField.SelectedText = "";
            this.searchField.SelectionLength = 0;
            this.searchField.SelectionStart = 0;
            this.searchField.ShortcutsEnabled = true;
            this.searchField.Size = new System.Drawing.Size(217, 29);
            this.searchField.TabIndex = 53;
            this.searchField.UseSelectable = true;
            this.searchField.WaterMark = "Search Text(Expense Name)...";
            this.searchField.WaterMarkColor = System.Drawing.Color.Silver;
            this.searchField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchField.TextChanged += new System.EventHandler(this.onTextChange);
            // 
            // ManageExpenseCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 489);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.categoryDataGridView);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.expenseBindingNavigator);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ManageExpenseCategoryForm";
            this.Text = "Manage Expense Categories";
            this.Load += new System.EventHandler(this.onLoad);
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.DataGridView categoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private MetroFramework.Controls.MetroLabel searchLabel;
        private MetroFramework.Controls.MetroTextBox searchField;
    }
}
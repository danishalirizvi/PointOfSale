
namespace PointOfSale.UI.Views
{
    partial class ManagePaymentMethodForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePaymentMethodForm));
            this.paymentTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.grdHeadingLabel1 = new MetroFramework.Controls.MetroLabel();
            this.expenseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.methodLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).BeginInit();
            this.expenseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentTypeDataGridView
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.paymentTypeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.paymentTypeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paymentTypeDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.paymentTypeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTypeDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentTypeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.paymentTypeDataGridView.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paymentTypeDataGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.paymentTypeDataGridView.GridColor = System.Drawing.Color.Maroon;
            this.paymentTypeDataGridView.Location = new System.Drawing.Point(31, 178);
            this.paymentTypeDataGridView.Name = "paymentTypeDataGridView";
            this.paymentTypeDataGridView.ReadOnly = true;
            this.paymentTypeDataGridView.RowHeadersVisible = false;
            this.paymentTypeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paymentTypeDataGridView.Size = new System.Drawing.Size(415, 248);
            this.paymentTypeDataGridView.TabIndex = 1;
            this.paymentTypeDataGridView.SelectionChanged += new System.EventHandler(this.onSelectionChange);
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(28, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(379, 15);
            this.subHeadingLabel.TabIndex = 15;
            this.subHeadingLabel.Text = "NOTE :  Manage payment type from the section below if necessary!";
            this.subHeadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // grdHeadingLabel1
            // 
            this.grdHeadingLabel1.AutoSize = true;
            this.grdHeadingLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grdHeadingLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.grdHeadingLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.grdHeadingLabel1.Location = new System.Drawing.Point(28, 99);
            this.grdHeadingLabel1.Name = "grdHeadingLabel1";
            this.grdHeadingLabel1.Size = new System.Drawing.Size(156, 25);
            this.grdHeadingLabel1.TabIndex = 16;
            this.grdHeadingLabel1.Text = "Payment Methods";
            this.grdHeadingLabel1.UseCustomBackColor = true;
            // 
            // expenseBindingNavigator
            // 
            this.expenseBindingNavigator.AddNewItem = null;
            this.expenseBindingNavigator.CountItem = null;
            this.expenseBindingNavigator.DeleteItem = null;
            this.expenseBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.expenseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorDeleteItem});
            this.expenseBindingNavigator.Location = new System.Drawing.Point(28, 138);
            this.expenseBindingNavigator.MoveFirstItem = null;
            this.expenseBindingNavigator.MoveLastItem = null;
            this.expenseBindingNavigator.MoveNextItem = null;
            this.expenseBindingNavigator.MovePreviousItem = null;
            this.expenseBindingNavigator.Name = "expenseBindingNavigator";
            this.expenseBindingNavigator.PositionItem = null;
            this.expenseBindingNavigator.Size = new System.Drawing.Size(116, 37);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.methodLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.methodLabel.Location = new System.Drawing.Point(297, 150);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(146, 25);
            this.methodLabel.TabIndex = 39;
            this.methodLabel.Text = "Selected Method";
            // 
            // ManagePaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 449);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.expenseBindingNavigator);
            this.Controls.Add(this.grdHeadingLabel1);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.paymentTypeDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagePaymentMethodForm";
            this.Text = "Manage Payment Type";
            this.Load += new System.EventHandler(this.onFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingNavigator)).EndInit();
            this.expenseBindingNavigator.ResumeLayout(false);
            this.expenseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView paymentTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private MetroFramework.Controls.MetroLabel grdHeadingLabel1;
        private System.Windows.Forms.BindingNavigator expenseBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private MetroFramework.Controls.MetroLabel methodLabel;
    }
}
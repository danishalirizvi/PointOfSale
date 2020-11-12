namespace PointOfSale.UI.Reports.Sales.All
{
    partial class SalesByCustomerReportForm
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
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.customerPicker = new System.Windows.Forms.ComboBox();
            this.customerLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.toDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fromDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.generateReportButton = new MetroFramework.Controls.MetroButton();
            this.htmlPanel2 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.htmlPanel1.SuspendLayout();
            this.htmlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(1214, 0);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.customerPicker);
            this.htmlPanel1.Controls.Add(this.customerLabel);
            this.htmlPanel1.Controls.Add(this.metroLabel2);
            this.htmlPanel1.Controls.Add(this.toDatePicker);
            this.htmlPanel1.Controls.Add(this.metroLabel1);
            this.htmlPanel1.Controls.Add(this.fromDatePicker);
            this.htmlPanel1.Controls.Add(this.generateReportButton);
            this.htmlPanel1.Location = new System.Drawing.Point(5, 47);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(1214, 82);
            this.htmlPanel1.TabIndex = 0;
            // 
            // customerPicker
            // 
            this.customerPicker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.customerPicker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.customerPicker.FormattingEnabled = true;
            this.customerPicker.Location = new System.Drawing.Point(871, 60);
            this.customerPicker.Name = "customerPicker";
            this.customerPicker.Size = new System.Drawing.Size(191, 21);
            this.customerPicker.TabIndex = 7;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.customerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.customerLabel.Location = new System.Drawing.Point(776, 57);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(89, 25);
            this.customerLabel.TabIndex = 6;
            this.customerLabel.Text = "Customer";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(368, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 25);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "To Date";
            // 
            // toDatePicker
            // 
            this.toDatePicker.Location = new System.Drawing.Point(446, 52);
            this.toDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.toDatePicker.Name = "toDatePicker";
            this.toDatePicker.Size = new System.Drawing.Size(224, 29);
            this.toDatePicker.TabIndex = 3;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(22, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(96, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "From Date";
            // 
            // fromDatePicker
            // 
            this.fromDatePicker.Location = new System.Drawing.Point(124, 52);
            this.fromDatePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.fromDatePicker.Name = "fromDatePicker";
            this.fromDatePicker.Size = new System.Drawing.Size(224, 29);
            this.fromDatePicker.TabIndex = 1;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(1102, 52);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(109, 29);
            this.generateReportButton.TabIndex = 0;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseSelectable = true;
            this.generateReportButton.Click += new System.EventHandler(this.onClick);
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.AutoScroll = true;
            this.htmlPanel2.AutoScrollMinSize = new System.Drawing.Size(1214, 0);
            this.htmlPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel2.Controls.Add(this.reportViewer);
            this.htmlPanel2.Location = new System.Drawing.Point(5, 135);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(1214, 419);
            this.htmlPanel2.TabIndex = 1;
            // 
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.DisplayStatusBar = false;
            this.reportViewer.DisplayToolbar = false;
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(1214, 419);
            this.reportViewer.TabIndex = 1;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // SalesByCustomerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 577);
            this.Controls.Add(this.htmlPanel2);
            this.Controls.Add(this.htmlPanel1);
            this.Name = "SalesByCustomerReportForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.onFormLoad);
            this.htmlPanel1.ResumeLayout(false);
            this.htmlPanel1.PerformLayout();
            this.htmlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime toDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime fromDatePicker;
        private MetroFramework.Controls.MetroButton generateReportButton;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
        private System.Windows.Forms.ComboBox customerPicker;
        private MetroFramework.Controls.MetroLabel customerLabel;
    }
}
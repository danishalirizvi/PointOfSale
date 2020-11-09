namespace PointOfSale.UI.Reports.Sales.All
{
    partial class SalesByPercentDiscountReportForm
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
            this.ItemLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.toDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.fromDatePicker = new MetroFramework.Controls.MetroDateTime();
            this.generateReportButton = new MetroFramework.Controls.MetroButton();
            this.htmlPanel2 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtDiscountPercentage = new MetroFramework.Controls.MetroTextBox();
            this.htmlPanel1.SuspendLayout();
            this.htmlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(1214, 0);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.txtDiscountPercentage);
            this.htmlPanel1.Controls.Add(this.ItemLabel);
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
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ItemLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ItemLabel.Location = new System.Drawing.Point(726, 57);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(173, 25);
            this.ItemLabel.TabIndex = 6;
            this.ItemLabel.Text = "Discount Percentage";
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
            this.toDatePicker.Size = new System.Drawing.Size(228, 29);
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
            this.fromDatePicker.Size = new System.Drawing.Size(228, 29);
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
            // txtDiscountPercentage
            // 
            // 
            // 
            // 
            this.txtDiscountPercentage.CustomButton.Image = null;
            this.txtDiscountPercentage.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtDiscountPercentage.CustomButton.Name = "";
            this.txtDiscountPercentage.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiscountPercentage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscountPercentage.CustomButton.TabIndex = 1;
            this.txtDiscountPercentage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscountPercentage.CustomButton.UseSelectable = true;
            this.txtDiscountPercentage.CustomButton.Visible = false;
            this.txtDiscountPercentage.Lines = new string[0];
            this.txtDiscountPercentage.Location = new System.Drawing.Point(905, 58);
            this.txtDiscountPercentage.MaxLength = 32767;
            this.txtDiscountPercentage.Name = "txtDiscountPercentage";
            this.txtDiscountPercentage.PasswordChar = '\0';
            this.txtDiscountPercentage.PromptText = "Discount Percantage...";
            this.txtDiscountPercentage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscountPercentage.SelectedText = "";
            this.txtDiscountPercentage.SelectionLength = 0;
            this.txtDiscountPercentage.SelectionStart = 0;
            this.txtDiscountPercentage.ShortcutsEnabled = true;
            this.txtDiscountPercentage.Size = new System.Drawing.Size(191, 23);
            this.txtDiscountPercentage.TabIndex = 7;
            this.txtDiscountPercentage.UseSelectable = true;
            this.txtDiscountPercentage.WaterMark = "Discount Percantage...";
            this.txtDiscountPercentage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscountPercentage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SalesByPercentDiscountReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 577);
            this.Controls.Add(this.htmlPanel2);
            this.Controls.Add(this.htmlPanel1);
            this.Name = "SalesByPercentDiscountReportForm";
            this.Text = "Sales Report By Discount Percentage";
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
        private MetroFramework.Controls.MetroLabel ItemLabel;
        private MetroFramework.Controls.MetroTextBox txtDiscountPercentage;
    }
}
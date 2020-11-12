namespace PointOfSale.UI.Reports.Sales.All
{
    partial class ReOrderReportForm
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
            this.htmlPanel2 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.htmlPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.AutoScroll = true;
            this.htmlPanel2.AutoScrollMinSize = new System.Drawing.Size(1214, 0);
            this.htmlPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel2.Controls.Add(this.reportViewer);
            this.htmlPanel2.Location = new System.Drawing.Point(5, 53);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(1214, 501);
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
            this.reportViewer.Size = new System.Drawing.Size(1214, 501);
            this.reportViewer.TabIndex = 1;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ReOrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 577);
            this.Controls.Add(this.htmlPanel2);
            this.Name = "ReOrderReportForm";
            this.Text = "Profit Report";
            this.Load += new System.EventHandler(this.ReOrderReportForm_Load);
            this.htmlPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
    }
}
namespace PointOfSale.UI.Views
{
    partial class AddPaymentMethodForm
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
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.addPaymentMethodButton = new MetroFramework.Controls.MetroButton();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionField = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameField
            // 
            // 
            // 
            // 
            this.nameField.CustomButton.Image = null;
            this.nameField.CustomButton.Location = new System.Drawing.Point(222, 2);
            this.nameField.CustomButton.Name = "";
            this.nameField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.nameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameField.CustomButton.TabIndex = 1;
            this.nameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameField.CustomButton.UseSelectable = true;
            this.nameField.CustomButton.Visible = false;
            this.nameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameField.Lines = new string[0];
            this.nameField.Location = new System.Drawing.Point(105, 275);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.PromptText = "Payment Method e.g. CASH / DUE...";
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.SelectionLength = 0;
            this.nameField.SelectionStart = 0;
            this.nameField.ShortcutsEnabled = true;
            this.nameField.Size = new System.Drawing.Size(250, 30);
            this.nameField.TabIndex = 0;
            this.nameField.UseSelectable = true;
            this.nameField.WaterMark = "Payment Method e.g. CASH / DUE...";
            this.nameField.WaterMarkColor = System.Drawing.Color.Silver;
            this.nameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // addPaymentMethodButton
            // 
            this.addPaymentMethodButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addPaymentMethodButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPaymentMethodButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addPaymentMethodButton.Location = new System.Drawing.Point(205, 394);
            this.addPaymentMethodButton.Name = "addPaymentMethodButton";
            this.addPaymentMethodButton.Size = new System.Drawing.Size(150, 50);
            this.addPaymentMethodButton.TabIndex = 1;
            this.addPaymentMethodButton.Text = "ADD";
            this.addPaymentMethodButton.UseCustomBackColor = true;
            this.addPaymentMethodButton.UseCustomForeColor = true;
            this.addPaymentMethodButton.UseSelectable = true;
            this.addPaymentMethodButton.Click += new System.EventHandler(this.addPaymentMethodButtonClick);
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(332, 15);
            this.subHeadingLabel.TabIndex = 16;
            this.subHeadingLabel.Text = "NOTE : Add your payment method from the section below.";
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PointOfSale.UI.Properties.Resources.ds_1;
            this.pictureBox.Location = new System.Drawing.Point(18, 78);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(337, 190);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // descriptionField
            // 
            // 
            // 
            // 
            this.descriptionField.CustomButton.Image = null;
            this.descriptionField.CustomButton.Location = new System.Drawing.Point(156, 2);
            this.descriptionField.CustomButton.Name = "";
            this.descriptionField.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.descriptionField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionField.CustomButton.TabIndex = 1;
            this.descriptionField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionField.CustomButton.UseSelectable = true;
            this.descriptionField.CustomButton.Visible = false;
            this.descriptionField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.descriptionField.Lines = new string[0];
            this.descriptionField.Location = new System.Drawing.Point(105, 311);
            this.descriptionField.MaxLength = 32767;
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.PasswordChar = '\0';
            this.descriptionField.PromptText = "Description...";
            this.descriptionField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionField.SelectedText = "";
            this.descriptionField.SelectionLength = 0;
            this.descriptionField.SelectionStart = 0;
            this.descriptionField.ShortcutsEnabled = true;
            this.descriptionField.Size = new System.Drawing.Size(250, 77);
            this.descriptionField.TabIndex = 17;
            this.descriptionField.UseSelectable = true;
            this.descriptionField.WaterMark = "Description...";
            this.descriptionField.WaterMarkColor = System.Drawing.Color.Silver;
            this.descriptionField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(47, 286);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 19);
            this.nameLabel.TabIndex = 19;
            this.nameLabel.Text = "Name :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(18, 322);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(81, 19);
            this.descriptionLabel.TabIndex = 20;
            this.descriptionLabel.Text = "Description :";
            // 
            // AddPaymentMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 456);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.addPaymentMethodButton);
            this.Controls.Add(this.nameField);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPaymentMethodForm";
            this.Text = "Add Payment Method";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox nameField;
        private MetroFramework.Controls.MetroButton addPaymentMethodButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private MetroFramework.Controls.MetroTextBox descriptionField;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
    }
}
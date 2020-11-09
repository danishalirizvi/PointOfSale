namespace PointOfSale.UI.Views
{
    partial class AddEmploymentStatusForm
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
            this.addStatusButton = new MetroFramework.Controls.MetroButton();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.descriptionField = new MetroFramework.Controls.MetroTextBox();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addStatusButton
            // 
            this.addStatusButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addStatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addStatusButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addStatusButton.Location = new System.Drawing.Point(111, 257);
            this.addStatusButton.Name = "addStatusButton";
            this.addStatusButton.Size = new System.Drawing.Size(150, 50);
            this.addStatusButton.TabIndex = 1;
            this.addStatusButton.Text = "ADD";
            this.addStatusButton.UseCustomBackColor = true;
            this.addStatusButton.UseCustomForeColor = true;
            this.addStatusButton.UseSelectable = true;
            this.addStatusButton.Click += new System.EventHandler(this.addEmploymentRoleButtonClick);
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(316, 15);
            this.subHeadingLabel.TabIndex = 16;
            this.subHeadingLabel.Text = "NOTE : Add Employment Status from the section below.";
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(117, 25);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Status Name :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.descriptionLabel.Location = new System.Drawing.Point(11, 40);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(106, 25);
            this.descriptionLabel.TabIndex = 22;
            this.descriptionLabel.Text = "Description :";
            // 
            // nameField
            // 
            // 
            // 
            // 
            this.nameField.CustomButton.Image = null;
            this.nameField.CustomButton.Location = new System.Drawing.Point(180, 1);
            this.nameField.CustomButton.Name = "";
            this.nameField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameField.CustomButton.TabIndex = 1;
            this.nameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameField.CustomButton.UseSelectable = true;
            this.nameField.CustomButton.Visible = false;
            this.nameField.Lines = new string[0];
            this.nameField.Location = new System.Drawing.Point(123, 11);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.PromptText = "Status Name...";
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.SelectionLength = 0;
            this.nameField.SelectionStart = 0;
            this.nameField.ShortcutsEnabled = true;
            this.nameField.Size = new System.Drawing.Size(202, 23);
            this.nameField.TabIndex = 23;
            this.nameField.UseSelectable = true;
            this.nameField.WaterMark = "Status Name...";
            this.nameField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionField
            // 
            // 
            // 
            // 
            this.descriptionField.CustomButton.Image = null;
            this.descriptionField.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.descriptionField.CustomButton.Name = "";
            this.descriptionField.CustomButton.Size = new System.Drawing.Size(107, 107);
            this.descriptionField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionField.CustomButton.TabIndex = 1;
            this.descriptionField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionField.CustomButton.UseSelectable = true;
            this.descriptionField.CustomButton.Visible = false;
            this.descriptionField.Lines = new string[0];
            this.descriptionField.Location = new System.Drawing.Point(123, 40);
            this.descriptionField.MaxLength = 32767;
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.PasswordChar = '\0';
            this.descriptionField.PromptText = "Role Description and Jobs...";
            this.descriptionField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionField.SelectedText = "";
            this.descriptionField.SelectionLength = 0;
            this.descriptionField.SelectionStart = 0;
            this.descriptionField.ShortcutsEnabled = true;
            this.descriptionField.Size = new System.Drawing.Size(202, 112);
            this.descriptionField.TabIndex = 25;
            this.descriptionField.UseSelectable = true;
            this.descriptionField.WaterMark = "Role Description and Jobs...";
            this.descriptionField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.descriptionField);
            this.InputPanel.Controls.Add(this.nameField);
            this.InputPanel.Controls.Add(this.descriptionLabel);
            this.InputPanel.Controls.Add(this.nameLabel);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(23, 90);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(334, 161);
            this.InputPanel.TabIndex = 26;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // AddEmploymentStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 323);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.addStatusButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEmploymentStatusForm";
            this.Text = "Add Employment Status";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton addStatusButton;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroTextBox nameField;
        private MetroFramework.Controls.MetroTextBox descriptionField;
        private MetroFramework.Controls.MetroPanel InputPanel;
    }
}
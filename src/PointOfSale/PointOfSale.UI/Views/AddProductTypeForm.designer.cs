namespace PointOfSale.UI.Views
{
    partial class AddProductTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductTypeForm));
            this.AddTypeButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            this.DateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.ItemNameField = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionField = new MetroFramework.Controls.MetroTextBox();
            this.DescriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.TypeNameLabel = new MetroFramework.Controls.MetroLabel();
            this.DateLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddTypeButton
            // 
            this.AddTypeButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.AddTypeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTypeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.AddTypeButton.Location = new System.Drawing.Point(531, 303);
            this.AddTypeButton.Name = "AddTypeButton";
            this.AddTypeButton.Size = new System.Drawing.Size(150, 50);
            this.AddTypeButton.TabIndex = 6;
            this.AddTypeButton.Text = "Add Product Type";
            this.AddTypeButton.UseCustomBackColor = true;
            this.AddTypeButton.UseCustomForeColor = true;
            this.AddTypeButton.UseSelectable = true;
            this.AddTypeButton.Click += new System.EventHandler(this.addTypeButtonClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.ForestGreen;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(311, 15);
            this.metroLabel1.TabIndex = 37;
            this.metroLabel1.Text = "NOTE :  Add new product type from the section below!";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // InputPanel
            // 
            this.InputPanel.Controls.Add(this.DateTimePicker);
            this.InputPanel.Controls.Add(this.ItemNameField);
            this.InputPanel.Controls.Add(this.DescriptionField);
            this.InputPanel.Controls.Add(this.DescriptionLabel);
            this.InputPanel.Controls.Add(this.TypeNameLabel);
            this.InputPanel.Controls.Add(this.DateLabel);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(221, 104);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(470, 193);
            this.InputPanel.TabIndex = 39;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Checked = false;
            this.DateTimePicker.Location = new System.Drawing.Point(121, 7);
            this.DateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(339, 29);
            this.DateTimePicker.TabIndex = 24;
            // 
            // ItemNameField
            // 
            // 
            // 
            // 
            this.ItemNameField.CustomButton.Image = null;
            this.ItemNameField.CustomButton.Location = new System.Drawing.Point(311, 2);
            this.ItemNameField.CustomButton.Name = "";
            this.ItemNameField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.ItemNameField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ItemNameField.CustomButton.TabIndex = 1;
            this.ItemNameField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ItemNameField.CustomButton.UseSelectable = true;
            this.ItemNameField.CustomButton.Visible = false;
            this.ItemNameField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.ItemNameField.Lines = new string[0];
            this.ItemNameField.Location = new System.Drawing.Point(121, 42);
            this.ItemNameField.MaxLength = 32767;
            this.ItemNameField.Name = "ItemNameField";
            this.ItemNameField.PasswordChar = '\0';
            this.ItemNameField.PromptText = "Type Product Name Here...";
            this.ItemNameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ItemNameField.SelectedText = "";
            this.ItemNameField.SelectionLength = 0;
            this.ItemNameField.SelectionStart = 0;
            this.ItemNameField.ShortcutsEnabled = true;
            this.ItemNameField.Size = new System.Drawing.Size(339, 30);
            this.ItemNameField.TabIndex = 20;
            this.ItemNameField.UseSelectable = true;
            this.ItemNameField.WaterMark = "Type Product Name Here...";
            this.ItemNameField.WaterMarkColor = System.Drawing.Color.Silver;
            this.ItemNameField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DescriptionField
            // 
            // 
            // 
            // 
            this.DescriptionField.CustomButton.Image = null;
            this.DescriptionField.CustomButton.Location = new System.Drawing.Point(233, 2);
            this.DescriptionField.CustomButton.Name = "";
            this.DescriptionField.CustomButton.Size = new System.Drawing.Size(103, 103);
            this.DescriptionField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescriptionField.CustomButton.TabIndex = 1;
            this.DescriptionField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescriptionField.CustomButton.UseSelectable = true;
            this.DescriptionField.CustomButton.Visible = false;
            this.DescriptionField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.DescriptionField.Lines = new string[0];
            this.DescriptionField.Location = new System.Drawing.Point(121, 78);
            this.DescriptionField.MaxLength = 32767;
            this.DescriptionField.Multiline = true;
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.PasswordChar = '\0';
            this.DescriptionField.PromptText = "Type Product Description Here...";
            this.DescriptionField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescriptionField.SelectedText = "";
            this.DescriptionField.SelectionLength = 0;
            this.DescriptionField.SelectionStart = 0;
            this.DescriptionField.ShortcutsEnabled = true;
            this.DescriptionField.Size = new System.Drawing.Size(339, 108);
            this.DescriptionField.TabIndex = 21;
            this.DescriptionField.UseSelectable = true;
            this.DescriptionField.WaterMark = "Type Product Description Here...";
            this.DescriptionField.WaterMarkColor = System.Drawing.Color.Silver;
            this.DescriptionField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DescriptionLabel.Location = new System.Drawing.Point(10, 78);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(106, 25);
            this.DescriptionLabel.TabIndex = 22;
            this.DescriptionLabel.Text = "Description :";
            // 
            // TypeNameLabel
            // 
            this.TypeNameLabel.AutoSize = true;
            this.TypeNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.TypeNameLabel.Location = new System.Drawing.Point(11, 45);
            this.TypeNameLabel.Name = "TypeNameLabel";
            this.TypeNameLabel.Size = new System.Drawing.Size(106, 25);
            this.TypeNameLabel.TabIndex = 23;
            this.TypeNameLabel.Text = "Type Name :";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DateLabel.Location = new System.Drawing.Point(59, 11);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(56, 25);
            this.DateLabel.TabIndex = 25;
            this.DateLabel.Text = "Date :";
            // 
            // AddProductTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 375);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.AddTypeButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProductTypeForm";
            this.Text = "Add Product Type";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton AddTypeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel InputPanel;
        private MetroFramework.Controls.MetroDateTime DateTimePicker;
        private MetroFramework.Controls.MetroTextBox DescriptionField;
        private MetroFramework.Controls.MetroTextBox ItemNameField;
        private MetroFramework.Controls.MetroLabel DescriptionLabel;
        private MetroFramework.Controls.MetroLabel TypeNameLabel;
        private MetroFramework.Controls.MetroLabel DateLabel;
    }
}
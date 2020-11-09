namespace PointOfSale.UI.Views
{
    partial class AddExpenseCatagoryForm
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
            this.expenseField = new MetroFramework.Controls.MetroTextBox();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.expenseLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionField = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // expenseField
            // 
            // 
            // 
            // 
            this.expenseField.CustomButton.Image = null;
            this.expenseField.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.expenseField.CustomButton.Name = "";
            this.expenseField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.expenseField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.expenseField.CustomButton.TabIndex = 1;
            this.expenseField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.expenseField.CustomButton.UseSelectable = true;
            this.expenseField.CustomButton.Visible = false;
            this.expenseField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.expenseField.Lines = new string[0];
            this.expenseField.Location = new System.Drawing.Point(186, 88);
            this.expenseField.MaxLength = 32767;
            this.expenseField.Name = "expenseField";
            this.expenseField.PasswordChar = '\0';
            this.expenseField.PromptText = "Expense Category Name...";
            this.expenseField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.expenseField.SelectedText = "";
            this.expenseField.SelectionLength = 0;
            this.expenseField.SelectionStart = 0;
            this.expenseField.ShortcutsEnabled = true;
            this.expenseField.Size = new System.Drawing.Size(202, 30);
            this.expenseField.TabIndex = 0;
            this.expenseField.UseSelectable = true;
            this.expenseField.WaterMark = "Expense Category Name...";
            this.expenseField.WaterMarkColor = System.Drawing.Color.Silver;
            this.expenseField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Save.Location = new System.Drawing.Point(211, 276);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(150, 50);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "ADD";
            this.btn_Save.UseCustomBackColor = true;
            this.btn_Save.UseCustomForeColor = true;
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.addExpenseCategoryButtonClick);
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(282, 15);
            this.subHeadingLabel.TabIndex = 34;
            this.subHeadingLabel.Text = "Note : Add expense category from section below.";
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.expenseLabel.Location = new System.Drawing.Point(23, 93);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(157, 25);
            this.expenseLabel.TabIndex = 35;
            this.expenseLabel.Text = "Expense Category :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.descriptionLabel.Location = new System.Drawing.Point(74, 129);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(106, 25);
            this.descriptionLabel.TabIndex = 37;
            this.descriptionLabel.Text = "Description :";
            // 
            // descriptionField
            // 
            // 
            // 
            // 
            this.descriptionField.CustomButton.Image = null;
            this.descriptionField.CustomButton.Location = new System.Drawing.Point(70, 2);
            this.descriptionField.CustomButton.Name = "";
            this.descriptionField.CustomButton.Size = new System.Drawing.Size(129, 129);
            this.descriptionField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionField.CustomButton.TabIndex = 1;
            this.descriptionField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionField.CustomButton.UseSelectable = true;
            this.descriptionField.CustomButton.Visible = false;
            this.descriptionField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.descriptionField.Lines = new string[0];
            this.descriptionField.Location = new System.Drawing.Point(186, 129);
            this.descriptionField.MaxLength = 32767;
            this.descriptionField.Multiline = true;
            this.descriptionField.Name = "descriptionField";
            this.descriptionField.PasswordChar = '\0';
            this.descriptionField.PromptText = "Category Description...";
            this.descriptionField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionField.SelectedText = "";
            this.descriptionField.SelectionLength = 0;
            this.descriptionField.SelectionStart = 0;
            this.descriptionField.ShortcutsEnabled = true;
            this.descriptionField.Size = new System.Drawing.Size(202, 134);
            this.descriptionField.TabIndex = 36;
            this.descriptionField.UseSelectable = true;
            this.descriptionField.WaterMark = "Category Description...";
            this.descriptionField.WaterMarkColor = System.Drawing.Color.Silver;
            this.descriptionField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PointOfSale.UI.Properties.Resources.ds_10;
            this.pictureBox1.Location = new System.Drawing.Point(23, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ExpCatagoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 337);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionField);
            this.Controls.Add(this.expenseLabel);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.expenseField);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ExpCatagoryForm";
            this.Text = "Add Expense Category";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox expenseField;
        private MetroFramework.Controls.MetroButton btn_Save;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private MetroFramework.Controls.MetroLabel expenseLabel;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroTextBox descriptionField;
    }
}
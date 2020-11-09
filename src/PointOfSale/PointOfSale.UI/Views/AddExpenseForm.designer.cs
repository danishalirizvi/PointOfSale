

namespace PointOfSale.UI.Views
{
    partial class AddExpenseForm
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
            this.dateTimePicker = new MetroFramework.Controls.MetroDateTime();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.amountField = new MetroFramework.Controls.MetroTextBox();
            this.commentField = new MetroFramework.Controls.MetroTextBox();
            this.expenseLabel = new MetroFramework.Controls.MetroLabel();
            this.commentLabel = new MetroFramework.Controls.MetroLabel();
            this.amountLabel = new MetroFramework.Controls.MetroLabel();
            this.dateLabel = new MetroFramework.Controls.MetroLabel();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.expensePicker = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(168, 140);
            this.dateTimePicker.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Save.Location = new System.Drawing.Point(168, 283);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(150, 50);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "ADD EXPENSE";
            this.btn_Save.UseCustomBackColor = true;
            this.btn_Save.UseCustomForeColor = true;
            this.btn_Save.UseSelectable = true;
            this.btn_Save.Click += new System.EventHandler(this.addNewExpenseButtonClick);
            // 
            // amountField
            // 
            // 
            // 
            // 
            this.amountField.CustomButton.Image = null;
            this.amountField.CustomButton.Location = new System.Drawing.Point(172, 2);
            this.amountField.CustomButton.Name = "";
            this.amountField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.amountField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.amountField.CustomButton.TabIndex = 1;
            this.amountField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.amountField.CustomButton.UseSelectable = true;
            this.amountField.CustomButton.Visible = false;
            this.amountField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.amountField.Lines = new string[0];
            this.amountField.Location = new System.Drawing.Point(168, 211);
            this.amountField.MaxLength = 32767;
            this.amountField.Name = "amountField";
            this.amountField.PasswordChar = '\0';
            this.amountField.PromptText = "Expense amount...";
            this.amountField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.amountField.SelectedText = "";
            this.amountField.SelectionLength = 0;
            this.amountField.SelectionStart = 0;
            this.amountField.ShortcutsEnabled = true;
            this.amountField.Size = new System.Drawing.Size(200, 30);
            this.amountField.TabIndex = 2;
            this.amountField.UseSelectable = true;
            this.amountField.WaterMark = "Expense amount...";
            this.amountField.WaterMarkColor = System.Drawing.Color.Silver;
            this.amountField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // commentField
            // 
            // 
            // 
            // 
            this.commentField.CustomButton.Image = null;
            this.commentField.CustomButton.Location = new System.Drawing.Point(278, 2);
            this.commentField.CustomButton.Name = "";
            this.commentField.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.commentField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.commentField.CustomButton.TabIndex = 1;
            this.commentField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.commentField.CustomButton.UseSelectable = true;
            this.commentField.CustomButton.Visible = false;
            this.commentField.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.commentField.Lines = new string[0];
            this.commentField.Location = new System.Drawing.Point(168, 247);
            this.commentField.MaxLength = 32767;
            this.commentField.Name = "commentField";
            this.commentField.PasswordChar = '\0';
            this.commentField.PromptText = "Expense note / comments / hints...";
            this.commentField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.commentField.SelectedText = "";
            this.commentField.SelectionLength = 0;
            this.commentField.SelectionStart = 0;
            this.commentField.ShortcutsEnabled = true;
            this.commentField.Size = new System.Drawing.Size(306, 30);
            this.commentField.TabIndex = 3;
            this.commentField.UseSelectable = true;
            this.commentField.WaterMark = "Expense note / comments / hints...";
            this.commentField.WaterMarkColor = System.Drawing.Color.Silver;
            this.commentField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.expenseLabel.Location = new System.Drawing.Point(5, 180);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(157, 25);
            this.expenseLabel.TabIndex = 8;
            this.expenseLabel.Text = "Expense Category :";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.commentLabel.Location = new System.Drawing.Point(66, 252);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(96, 25);
            this.commentLabel.TabIndex = 6;
            this.commentLabel.Text = "Comment :";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.amountLabel.Location = new System.Drawing.Point(14, 216);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(149, 25);
            this.amountLabel.TabIndex = 7;
            this.amountLabel.Text = "Expense Amount :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.dateLabel.Location = new System.Drawing.Point(39, 144);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(123, 25);
            this.dateLabel.TabIndex = 8;
            this.dateLabel.Text = "Expense Date :";
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(402, 30);
            this.subHeadingLabel.TabIndex = 16;
            this.subHeadingLabel.Text = "NOTE: Add Expense from the section below.\r\nSelect the expense date and then add y" +
    "our details for accurate reports.";
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::PointOfSale.UI.Properties.Resources.ds_3;
            this.pictureBox.Location = new System.Drawing.Point(374, 107);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(99, 137);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 17;
            this.pictureBox.TabStop = false;
            // 
            // expensePicker
            // 
            this.expensePicker.FormattingEnabled = true;
            this.expensePicker.ItemHeight = 23;
            this.expensePicker.Location = new System.Drawing.Point(168, 176);
            this.expensePicker.Name = "expensePicker";
            this.expensePicker.Size = new System.Drawing.Size(200, 29);
            this.expensePicker.TabIndex = 18;
            this.expensePicker.UseSelectable = true;
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 355);
            this.Controls.Add(this.expensePicker);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.expenseLabel);
            this.Controls.Add(this.commentField);
            this.Controls.Add(this.amountField);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dateTimePicker);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "AddExpenseForm";
            this.Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroDateTime dateTimePicker;
        private MetroFramework.Controls.MetroButton btn_Save;
        private MetroFramework.Controls.MetroTextBox amountField;
        private MetroFramework.Controls.MetroTextBox commentField;
        private MetroFramework.Controls.MetroLabel expenseLabel;
        private MetroFramework.Controls.MetroLabel commentLabel;
        private MetroFramework.Controls.MetroLabel amountLabel;
        private MetroFramework.Controls.MetroLabel dateLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private MetroFramework.Controls.MetroComboBox expensePicker;
    }
}
namespace PointOfSale.UI.Views
{
    partial class AddWorkShiftForm
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
            this.addWorkShiftButton = new MetroFramework.Controls.MetroButton();
            this.subHeadingLabel = new MetroFramework.Controls.MetroLabel();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.nameField = new MetroFramework.Controls.MetroTextBox();
            this.descriptionField = new MetroFramework.Controls.MetroTextBox();
            this.InputPanel = new MetroFramework.Controls.MetroPanel();
            this.endTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.startTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.InputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWorkShiftButton
            // 
            this.addWorkShiftButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addWorkShiftButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addWorkShiftButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addWorkShiftButton.Location = new System.Drawing.Point(126, 343);
            this.addWorkShiftButton.Name = "addWorkShiftButton";
            this.addWorkShiftButton.Size = new System.Drawing.Size(150, 50);
            this.addWorkShiftButton.TabIndex = 1;
            this.addWorkShiftButton.Text = "ADD";
            this.addWorkShiftButton.UseCustomBackColor = true;
            this.addWorkShiftButton.UseCustomForeColor = true;
            this.addWorkShiftButton.UseSelectable = true;
            this.addWorkShiftButton.Click += new System.EventHandler(this.addWorkShiftButtonClick);
            // 
            // subHeadingLabel
            // 
            this.subHeadingLabel.AutoSize = true;
            this.subHeadingLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.subHeadingLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subHeadingLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.subHeadingLabel.Location = new System.Drawing.Point(23, 60);
            this.subHeadingLabel.Name = "subHeadingLabel";
            this.subHeadingLabel.Size = new System.Drawing.Size(269, 15);
            this.subHeadingLabel.TabIndex = 16;
            this.subHeadingLabel.Text = "NOTE : Add Work Shift from the section below.";
            this.subHeadingLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.nameLabel.Location = new System.Drawing.Point(34, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(105, 25);
            this.nameLabel.TabIndex = 20;
            this.nameLabel.Text = "Shift Name :";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.descriptionLabel.Location = new System.Drawing.Point(33, 101);
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
            this.nameField.Location = new System.Drawing.Point(145, 11);
            this.nameField.MaxLength = 32767;
            this.nameField.Name = "nameField";
            this.nameField.PasswordChar = '\0';
            this.nameField.PromptText = "Shift Name...";
            this.nameField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameField.SelectedText = "";
            this.nameField.SelectionLength = 0;
            this.nameField.SelectionStart = 0;
            this.nameField.ShortcutsEnabled = true;
            this.nameField.Size = new System.Drawing.Size(202, 23);
            this.nameField.TabIndex = 23;
            this.nameField.UseSelectable = true;
            this.nameField.WaterMark = "Shift Name...";
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
            this.descriptionField.Location = new System.Drawing.Point(145, 101);
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
            this.InputPanel.Controls.Add(this.endTimePicker);
            this.InputPanel.Controls.Add(this.startTimePicker);
            this.InputPanel.Controls.Add(this.endTimeLabel);
            this.InputPanel.Controls.Add(this.startTimeLabel);
            this.InputPanel.Controls.Add(this.descriptionField);
            this.InputPanel.Controls.Add(this.nameField);
            this.InputPanel.Controls.Add(this.descriptionLabel);
            this.InputPanel.Controls.Add(this.nameLabel);
            this.InputPanel.HorizontalScrollbarBarColor = true;
            this.InputPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.InputPanel.HorizontalScrollbarSize = 10;
            this.InputPanel.Location = new System.Drawing.Point(23, 90);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(357, 247);
            this.InputPanel.TabIndex = 26;
            this.InputPanel.VerticalScrollbarBarColor = true;
            this.InputPanel.VerticalScrollbarHighlightOnWheel = false;
            this.InputPanel.VerticalScrollbarSize = 10;
            // 
            // endTimeLabel
            // 
            this.endTimeLabel.AutoSize = true;
            this.endTimeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.endTimeLabel.Location = new System.Drawing.Point(9, 70);
            this.endTimeLabel.Name = "endTimeLabel";
            this.endTimeLabel.Size = new System.Drawing.Size(130, 25);
            this.endTimeLabel.TabIndex = 29;
            this.endTimeLabel.Text = "Shift End Time :";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.startTimeLabel.Location = new System.Drawing.Point(3, 35);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(136, 25);
            this.startTimeLabel.TabIndex = 28;
            this.startTimeLabel.Text = "Shift Start Time :";
            // 
            // startTimePicker
            // 
            this.startTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.startTimePicker.Location = new System.Drawing.Point(145, 40);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.ShowUpDown = true;
            this.startTimePicker.Size = new System.Drawing.Size(202, 20);
            this.startTimePicker.TabIndex = 27;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.endTimePicker.Location = new System.Drawing.Point(145, 75);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.ShowUpDown = true;
            this.endTimePicker.Size = new System.Drawing.Size(202, 20);
            this.endTimePicker.TabIndex = 30;
            // 
            // AddWorkShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 416);
            this.Controls.Add(this.InputPanel);
            this.Controls.Add(this.subHeadingLabel);
            this.Controls.Add(this.addWorkShiftButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddWorkShiftForm";
            this.Text = "Add Work Shift";
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton addWorkShiftButton;
        private MetroFramework.Controls.MetroLabel subHeadingLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroTextBox nameField;
        private MetroFramework.Controls.MetroTextBox descriptionField;
        private MetroFramework.Controls.MetroPanel InputPanel;
        private MetroFramework.Controls.MetroLabel endTimeLabel;
        private MetroFramework.Controls.MetroLabel startTimeLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
    }
}
namespace PointOfSale.UI.Views
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.usernameField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.loginButton = new MetroFramework.Controls.MetroButton();
            this.resetButton = new MetroFramework.Controls.MetroButton();
            this.subheadLabel = new MetroFramework.Controls.MetroLabel();
            this.headLabel = new System.Windows.Forms.Label();
            this.closeButtom = new MetroFramework.Controls.MetroButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameField
            // 
            this.usernameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameField.Location = new System.Drawing.Point(400, 154);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(306, 29);
            this.usernameField.TabIndex = 0;
            // 
            // passwordField
            // 
            this.passwordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordField.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordField.Location = new System.Drawing.Point(400, 196);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(306, 29);
            this.passwordField.TabIndex = 1;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usernameLabel.Location = new System.Drawing.Point(296, 154);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(98, 25);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username :";
            this.usernameLabel.UseCustomForeColor = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.passwordLabel.Location = new System.Drawing.Point(302, 196);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password :";
            this.passwordLabel.UseCustomForeColor = true;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.Color.LawnGreen;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.loginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginButton.Location = new System.Drawing.Point(400, 238);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(150, 50);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseCustomBackColor = true;
            this.loginButton.UseCustomForeColor = true;
            this.loginButton.UseSelectable = true;
            this.loginButton.Click += new System.EventHandler(this.loginButtonClick);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.White;
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.resetButton.Location = new System.Drawing.Point(556, 238);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(150, 50);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "RESET";
            this.resetButton.UseCustomBackColor = true;
            this.resetButton.UseCustomForeColor = true;
            this.resetButton.UseSelectable = true;
            this.resetButton.Click += new System.EventHandler(this.resetButtonClick);
            // 
            // subheadLabel
            // 
            this.subheadLabel.AutoSize = true;
            this.subheadLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.subheadLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.subheadLabel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.subheadLabel.Location = new System.Drawing.Point(10, 39);
            this.subheadLabel.Name = "subheadLabel";
            this.subheadLabel.Size = new System.Drawing.Size(309, 25);
            this.subheadLabel.TabIndex = 6;
            this.subheadLabel.Text = "EASY OFFLINE SYSTEM, VERSION 3";
            this.subheadLabel.UseCustomForeColor = true;
            // 
            // headLabel
            // 
            this.headLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headLabel.AutoSize = true;
            this.headLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.headLabel.Location = new System.Drawing.Point(8, 7);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(612, 31);
            this.headLabel.TabIndex = 11;
            this.headLabel.Text = "BILLING LIGHT APPLICATION ( SHOP ERP )";
            // 
            // closeButtom
            // 
            this.closeButtom.BackColor = System.Drawing.Color.Salmon;
            this.closeButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButtom.Location = new System.Drawing.Point(733, 5);
            this.closeButtom.Name = "closeButtom";
            this.closeButtom.Size = new System.Drawing.Size(67, 27);
            this.closeButtom.TabIndex = 10;
            this.closeButtom.Text = "Close";
            this.closeButtom.UseCustomBackColor = true;
            this.closeButtom.UseCustomForeColor = true;
            this.closeButtom.UseSelectable = true;
            this.closeButtom.Click += new System.EventHandler(this.closeButtonClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.Image = global::PointOfSale.UI.Properties.Resources.login;
            this.pictureBox.Location = new System.Drawing.Point(44, 139);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(228, 166);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.closeButtom);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.subheadLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.TextBox passwordField;
        private MetroFramework.Controls.MetroLabel usernameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroButton loginButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private MetroFramework.Controls.MetroButton resetButton;
        private MetroFramework.Controls.MetroLabel subheadLabel;
        private System.Windows.Forms.Label headLabel;
        private MetroFramework.Controls.MetroButton closeButtom;
    }
}
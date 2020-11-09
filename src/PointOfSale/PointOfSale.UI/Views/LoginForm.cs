using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Params;

namespace PointOfSale.UI.Views
{

    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            if (usernameField.Text.Trim() == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, " Username is Requred", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernameField.Focus();
                return;
            }
            else if (passwordField.Text.Trim() == string.Empty)
            {

                MetroFramework.MetroMessageBox.Show(this, " Password is Requred", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordField.Focus();
                return;
            }
            else {
                LoginManager loginManager = new LoginManager();

                LoginParam param = new LoginParam(usernameField.Text, passwordField.Text);

                bool status = loginManager.LoginValidation(param);

                if (status)
                {
                    this.Hide();
                    //MetroFramework.MetroMessageBox.Show(this, "Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HomePage logon = new HomePage();
                    logon.Show();
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "Username and Password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameField.Clear();
                    passwordField.Clear();
                    usernameField.Focus();
                }
            }

            //if (count == 1)
            //{
            //    //MetroFramework.MetroMessageBox.Show(this, "Username and Password is correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);                
           
            //    this.Hide();
            //    HomePage logon = new HomePage();

            //    if (logon.ShowDialog() != DialogResult.OK)
            //    {
            //        //Handle authentication failures as necessary, for example:
            //        Application.Exit();
            //    }
            //    else
            //    {
            //        this.Show();
            //    }

            //}

            //else
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Username and Password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    usernameField.Clear();
            //    passwordField.Clear();
            //    usernameField.Focus();
            //}

        }

        private void resetButtonClick(object sender, EventArgs e)
        {
            usernameField.Clear();
            passwordField.Clear();
            usernameField.Focus();
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}

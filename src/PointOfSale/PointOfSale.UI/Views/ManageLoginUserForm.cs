using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using MetroFramework;

namespace PointOfSale.UI.Views
{
    public partial class ManageLoginUserForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public ManageLoginUserForm()
        {
            InitializeComponent();
            //expenseManager.LoadCombos(expensePicker);
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            employeeManager.LoadLoginUsersGrid(loginUserDataGridView);
        }

        private void addButtonClick(object sender, EventArgs e)
        {
            if (usernameField.Text == "" || passwordField.Text == "" || confirmField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Username, Password and Confirm Password Fields are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (passwordField.Text != confirmField.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Passwords do not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LoginUser user = new LoginUser()
                    {
                        Username = usernameField.Text,
                        Password = passwordField.Text,
                        IsActive = 1,
                        IsBlocked = 0
                    };

                    if (adminCheck.CheckState == CheckState.Checked)
                    {
                        user.IsAdmin = 1;
                    }
                    else
                    {
                        user.IsAdmin = 0;
                    }

                    bool status = employeeManager.AddLoginUser(user);
                    if (status)
                    {
                        usernameField.Clear();
                        passwordField.Clear();
                        confirmField.Clear();
                        adminCheck.Checked = false;
                        employeeManager.LoadLoginUsersGrid(loginUserDataGridView);
                        MetroFramework.MetroMessageBox.Show(this, "Login User Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Username already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void clearButtonClick(object sender, EventArgs e)
        {
            usernameField.Clear();
            passwordField.Clear();
            confirmField.Clear();
            adminCheck.Checked = false;
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            
            usernameField.Text = loginUserDataGridView.CurrentRow.Cells["Username"]?.Value.ToString();
            passwordField.Text = loginUserDataGridView.CurrentRow.Cells["Password"]?.Value.ToString();
            confirmField.Text = loginUserDataGridView.CurrentRow.Cells["Password"]?.Value.ToString();
            if (loginUserDataGridView.CurrentRow.Cells["IsAdmin"]?.Value.ToString() == "1")
            {
                adminCheck.Checked = true;
            }
            else
            {
                adminCheck.Checked = false;
            }

        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            if (loginUserDataGridView.Rows.Count == 1) return;

            if (loginUserDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (loginUserDataGridView.CurrentRow == null) return;

                int userID = Convert.ToInt32(loginUserDataGridView.CurrentRow.Cells["LoginUserID"]?.Value.ToString());

                employeeManager.DeleteLoginUser(userID);

                employeeManager.LoadLoginUsersGrid(loginUserDataGridView);

                emptyGridCheck();
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emptyGridCheck()
        {
            if (loginUserDataGridView.RowCount == 0)
            {
                usernameField.Clear();
                passwordField.Clear();
                confirmField.Clear();
                adminCheck.Checked = false;
            }
        }

        private void updateButtonClicked(object sender, EventArgs e)
        {
            if (loginUserDataGridView.Rows.Count == 1) return;
            if (loginUserDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (usernameField.Text == "" || passwordField.Text == "" || confirmField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Username, Password and Confirm Password Fields are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (passwordField.Text != confirmField.Text)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Passwords do not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LoginUser user = new LoginUser()
                    {
                        LoginUserID = Convert.ToInt32(loginUserDataGridView.CurrentRow.Cells["LoginUserID"]?.Value.ToString()),
                        Username = usernameField.Text,
                        Password = passwordField.Text,
                        IsActive = 1,
                        IsBlocked = 0
                    };

                    if (adminCheck.CheckState == CheckState.Checked)
                    {
                        user.IsAdmin = 1;
                    }
                    else
                    {
                        user.IsAdmin = 0;
                    }

                    bool status = employeeManager.UpdateLoginUser(user);
                    if (status)
                    {
                        
                        employeeManager.LoadLoginUsersGrid(loginUserDataGridView);

                        usernameField.Clear();
                        passwordField.Clear();
                        confirmField.Clear();
                        adminCheck.Checked = false;

                        MetroFramework.MetroMessageBox.Show(this, "Login User Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Username already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            employeeManager.LoadLoginUsersGrid(loginUserDataGridView,searchField.Text);
            emptyGridCheck();
        }
    }
}

